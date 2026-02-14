using System;
using System.Collections.Generic;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;
    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            DisplayPlayerInfo();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Event");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Quit");
            Console.Write("Choose: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: CreateGoal(); break;
                case 2: ListGoalDetails(); break;
                case 3: RecordEvent(); break;
                case 4: SaveGoals(); break;
                case 5: LoadGoals(); break;
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nScore: {_score}");
        Console.WriteLine($"Level: {GetLevel()}");
        Console.WriteLine($"Title: {GetTitle()}");
        Console.WriteLine("----------------------");
    }
    private int GetLevel()
    {
        return _score / 500 + 1;
    }
    private string GetTitle()
    {
        return GetLevel() switch
        {
            >= 10 => "Eternal Champion",
            >= 7 => "Disciplined Disciple",
            >= 5 => "Faithful Seeker",
            >= 3 => "Consistent Beginner",
            _ => "New Adventurer"
        };
    }
    public void CreateGoal()
    {
        Console.WriteLine("1. Simple  2. Eternal  3. Checklist");
        int type = int.Parse(Console.ReadLine());
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string desc = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());
        if (type == 1)
            _goals.Add(new SimpleGoal(name, desc, points));
        else if (type == 2)
            _goals.Add(new EternalGoal(name, desc, points));
        else
        {
            Console.Write("Target: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Bonus: ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        _score += _goals[index].RecordEvent();
    }
    public void SaveGoals()
    {
        using StreamWriter sw = new("goals.txt");
        sw.WriteLine(_score);
        foreach (Goal g in _goals)
            sw.WriteLine(g.GetStringRepresentation());
    }
    public void LoadGoals()
    {
        string[] lines = File.ReadAllLines("goals.txt");
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split("|");
            if (parts[0] == "SimpleGoal")
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            else if (parts[0] == "EternalGoal")
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            else
                _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]),
                    int.Parse(parts[5]), int.Parse(parts[6])));
        }
    }
}
