
class ListingActivity : Activity
{
    private int _count;
    protected List<string> _prompts;
    


    public ListingActivity()
    {
        this.SetActivityName("Listing Activity");
        this.SetDescription("This activity will help you reflect on the good things" +
         "in your life by having you list as many as you can in a certian area.");
        
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
     //   _count = new int count     

    }
   
    public string GetListingActivity()
    {

        return"";
    }

    public string GetRandomPrompt()
    {
         string randomPrompt = "";
            int randomIndex = new Random().Next(_prompts.Count);

            randomPrompt = _prompts[randomIndex];

            return randomPrompt;
    
    }
    public string GetListFromUser()
    {
        return "";


    }
    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration();
        

        Console.WriteLine();
        Console.Write("How long in seconds, would you like for your session?");

        Console.Clear();

        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();
                    string date = DateTime.Now.Date.ToString("MMM dd, yyyy");

        //            Entry entry = new Entry(date, prompt, response);
         //           journal.AddEntry(entry);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        Thread.Sleep(3000);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
            {
                 Console.WriteLine();
            }
        Console.Clear();
        
        
        
        Console.Write($"You responded {_count} times");

        


        DisplayEndingMessage();
        
    }

    


}