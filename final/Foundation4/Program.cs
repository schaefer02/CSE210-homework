using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        activities.Add(new Running("01/01/2010", 5.5, 30));
        activities.Add(new Cycling("02/02/2012", 10.2, 45));
        activities.Add(new Swimming("03/03/2013", 35, 90));

        int index = 1;
        foreach (Activity activity in activities)
        {
            Console.WriteLine($"Activity: {index} :\n {activity.GetSummary()}");
            index++;
        }
        Console.WriteLine();
    }
}