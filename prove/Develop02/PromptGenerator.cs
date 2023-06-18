public class PromptGenerator
    {
        List<string> prompts;

        public PromptGenerator()
        {
            prompts = new List<string>
            {
                "What was the best thing that happened to you today?",
                "Was there anything that made you smile today or made you laugh?",
                "What could you have done better today that you could do tomorrow?",
                "If I could do this day over again, what would you have changed?",
                "How did you see the hand of the Lord in your life today?"
         

            };
        }

        public string GetRandomPrompt()
        {
            string randomPrompt = "";
            int randomIndex = new Random().Next(prompts.Count);

            randomPrompt = prompts[randomIndex];

            return randomPrompt;

        }

    }