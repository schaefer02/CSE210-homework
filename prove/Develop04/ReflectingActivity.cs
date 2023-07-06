
class ReflectionActivity :Activity
{
    protected List<string> _prompts;
    protected List<string> _question;
    private int _duration;

    public ReflectionActivity()
    {
        this.SetActivityName("Reflection Activity");
        this.SetDescription("This activity will help you reflect on times in your life when you have" +
        " shown strength and resilience. This will help you recognize the power you have and how you" +
        " can use it in other aspects of your life.");

        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."


        };
        _question = new List<string>
        {
           "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"

        };

        

        
    }
     public string GetRandomPrompt()
        {
            string randomPrompt = "";
            int randomIndex = new Random().Next(_prompts.Count);

            randomPrompt = _prompts[randomIndex];

            return randomPrompt;

        }
     public string GetRandomQuestion()
        {
            string randomQuestion = "";
            int randomIndex = new Random().Next(_question.Count);

            randomQuestion = _question[randomIndex];

            return randomQuestion;

        }


    public void Run()
    {
        DisplayStartingMessage();
        int interval = GetDuration();
        for (int i = 0; i <= 2;)
        
        {
            Console.WriteLine();
            Console.WriteLine("Consider the following prompt:");
            Console.WriteLine(GetRandomPrompt());
            Console.WriteLine();
            Console.WriteLine("When you have something in mind, press Enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experiance.");
            Console.Write("You may begin in:"); 
            ShowCountDown(_duration);
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(interval);
            Console.WriteLine();
            
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(interval);
            Console.WriteLine();
            Console.Clear();
            break;

        }


        
        
        GetRandomQuestion();




        DisplayEndingMessage();

    }


}