
class Scripture
{
    Reference reference;

     private List<Word> words;

    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();

        List<string> allWords = _text.Split(' ').ToList();
        foreach(string wordString in allWords)
        {
            Word newWord = new Word(wordString);
            words.Add(newWord);
        }

    }

    public void HideRandomWords()
    {
        Random random = new Random();

            bool hide = true;
            while (hide)
            {
                int randomWord = random.Next(words.Count);

                //Word eachWord = new Word(words[randomWord]); 
                //if (eachWord.GetIsHidden(words[randomWord]) != true)
                {
                 //   string replace = wordString.Hide();
                 //   words[randomWord] = replace;
                    hide = false;


                }

            }
        
        

    }

    public string GetDisplayText()
    {
        string scriptureText = "";
        
        foreach (Word word in words)
        {
            if (word.GetIsHidden() == false)
            {
                scriptureText += word.GetDisplayText() + " ";
            }
            else
            {
                scriptureText += new string('_', word.GetDisplayText().Length) + " ";

            }
            
        }
        return ($"{reference.GetDisplayText()} {scriptureText}" );

    }

    public bool IsCompletelyHidden()
    {
        return true;

    }

}