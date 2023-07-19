
public class MainMenu
{
    private string _userName;
    private List<Goal> _goals;
    private int _totalPoints;
    public MainMenu(string name)
    {
        _userName = name;
        _goals = new List<Goal>();
    }
    public void CreateNewGoal()
    {
        Console.Clear();
        int menuinput = 0;
        List <string> Menu = new List<string>
            {
            "The types of Goals are: ",
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal",
            " Which type of goal would you like to create?"
            };

        while (menuinput != 4)
        {
            Console.Clear();
            foreach (string menuItem in Menu)
            {
            Console.WriteLine(menuItem);
            }
        
            Console.WriteLine("Select a choice from the menu: Press 4 to return to main menu");
            menuinput = int.Parse(Console.ReadLine());
            Console.Clear();

            
            switch (menuinput)
            {
                case 1:
                Console.WriteLine("Name of Goal: ");
                string goalName =Console.ReadLine();
                Console.Write("Give a short description: ");
                string goalDescription = Console.ReadLine();
                Console.WriteLine("How many points to assign when accomplished?: ");
                int goalPoints = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints, false );
                _goals.Add(simpleGoal);
                break;

                case 2:
                Console.WriteLine("Name of Goal: ");
                goalName =Console.ReadLine();
                Console.Write("Give a short description: ");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points to assign when accomplished?: ");
                goalPoints = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal= new EternalGoal(goalName, goalDescription, 0, goalPoints );
                _goals.Add(eternalGoal);
                break;

                case 3:
                Console.WriteLine("name of Goal: ");
                goalName =Console.ReadLine();
                Console.Write("Give a short description: ");
                goalDescription = Console.ReadLine();
                Console.WriteLine("How many points to assign when accomplished?: ");
                goalPoints = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal have to be accomplished before you get a bonus?");
                int timesTillBonus = int.Parse(Console.ReadLine());
                Console.Write("What is the bonus for accomplishing it that amount?");
                int bonusPoints = int.Parse(Console.ReadLine());
                ChecklistGoal checkListGoal = new ChecklistGoal(goalName, goalDescription, goalPoints, bonusPoints, timesTillBonus, 0, false );
                _goals.Add(checkListGoal);
                break; 

                
            }     

        }
    
    }
    public void Save()
    {
        Console.Clear();
        Console.Write("What is the file name?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"00|{_userName}|{_totalPoints}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRep());

            }
        }

    }
    public void DisplayGoals()
    {
        int i = 1;
        foreach(Goal goal in _goals)
        {
            Console.Write(i + ". ");
            goal.DisplayGoals(0);
            i++;
        }
        Console.WriteLine();

    }
    public void Load()
    {
        Console.Clear();
        Console.Write("What is the file name?: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _goals.Clear();
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            if (int.Parse(parts[0])== 00)
            {
                _userName = parts[1];
                if (int.Parse(parts[2])== 0 )
                {
                    _totalPoints = 0;
                }
                continue;
            }
            if (int.Parse(parts[0]) == 1)
            {
                bool isFinished;
                if(parts[4].ToLower().Equals("true"))
                {
                    isFinished = true;

                }
                else
                {
                    isFinished = false;

                }
                SimpleGoal loadedGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),isFinished);
                _goals.Add(loadedGoal);
            }
            else if (int.Parse(parts[0])==2)
            {
                EternalGoal loadedGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]), int.Parse(parts[4]));
                _goals.Add(loadedGoal);
            }
            else if (int.Parse(parts[0])==3)
            {
                bool done;
                if (parts[7].ToLower().Equals("true"))
                {
                    done = true;
                }
                else
                {
                    done = false;

                }
                ChecklistGoal loadedGoal = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]),done);
                _goals.Add(loadedGoal);

            }
        }
        Console.WriteLine("Hello");
    }
    public void RecordEvent()
    {
        int i = 1;
        List<Goal> alt = new List<Goal>();
        foreach (Goal goal in _goals)
        {
            if(!goal.GetIsComplete())
            {
                alt.Add(goal);
                Console.Write(i + ". ");
                goal.DisplayGoals(1);
                i++;
            }
        }
        if(i > 1)
        {
            Console.WriteLine("What goal did you complete?");
            int index = int.Parse(Console.ReadLine()) -1;
            alt[index].SetIsCompleted();
            _totalPoints += alt[index].GetPoints();
        }
        else
        {
            Console.WriteLine("Sorry, no goals to see here!");
        }
    }
    public int GetTotalPoints()
    {
        return _totalPoints;
    }

}