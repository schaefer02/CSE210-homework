using System;

class Program
{
    static void Main(string[] args)
    {
        bool play = true;
        Console.WriteLine("Whats your name?");
        MainMenu user = new MainMenu(Console.ReadLine());

        Console.WriteLine($"Points: {user.GetTotalPoints()}");
        int menuinput = 0;

        List <string> Menu  = new List<string>
            {
            "Menu Options:",
            "1. Create new Goal",
            "2. List Goals" ,
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Goals",
            "6. Quit"
            };
            while (menuinput != 6)
            {
                 Console.Clear();
            foreach (string menuItem in Menu)
            {
                Console.WriteLine(menuItem);
            }
            Console.WriteLine("Select a choice from the menu: ");
            menuinput = int.Parse(Console.ReadLine());
            Console.Clear();


                Console.WriteLine(Menu);
                
                switch (menuinput)
                {
                    case 1:
                    user.CreateNewGoal();
                    break;

                    case 2:
                    user.DisplayGoals();
                    break;

                    case 3:
                    user.Save();
                    break;

                    case 4:
                    user.Load();
                    break;

                    case 5:
                    user.RecordEvent();
                    break;

                    case 6:
                    play = false;
                    
                    break;

                    default:
                    Console.WriteLine("Sorry we can not process that.");
                    break;
                }




    
    
        }

    } 

}