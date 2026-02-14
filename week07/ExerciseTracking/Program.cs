using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2026, 02, 13), 30, 4.8));
        activities.Add(new Cycling(new DateTime(2026, 02, 13), 45, 20.0));
        activities.Add(new Swimming(new DateTime(2026, 02, 13), 40, 30));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}