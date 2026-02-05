using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new()
    {
        "Who are people that you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity()
        : base(
            "Listing",
            "This activity will help you reflect on the good things in your life by listing as many things as you can."
        )
    { }

    public override void Run()
    {
        Start();

        Random rand = new();
        Console.WriteLine($"\n--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        Countdown(5);

        Console.WriteLine("\nStart listing items (press Enter after each one):");

        List<string> items = new();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            items.Add(Console.ReadLine());
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");
        End();
    }
}
