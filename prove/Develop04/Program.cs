using System;

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;

        List<string> menu =new List<string>
        {
            "Menu Options: ",
            " 1. Start Breathing Activity",
            " 2. Start Reflecting Activity",
            " 3. Start Listening Activity",
            " 4. Quit",
            " 5. Get text from listing Activity"
        };

        while (userMenuInput != 4)
        {
            Console.Clear();
            foreach (string menuItem in menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (userMenuInput)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
               

            }
        }

    }
}