class Program
{
    static void Main()
    {
        Assignment simpleAssignment = new Assignment("Swuamy Santos", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment math = new MathAssignment(
            "Jhefferson Parrag",
            "Fractions",
            "7.3",
            "8-19"
        );
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment(
            "Alessandra Lima",
            "Brasilians History",
            "The Way of Colonizations"
        );
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}
