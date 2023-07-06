class Response 
{
    public class Entry
{

    protected string promptText, entryText;

    public Entry (string _prompText, string _entryText)
    {
        
        promptText  = _prompText;
        entryText   = _entryText; 

    }


    public void Run()
    {
        Console.WriteLine($"Prompt {promptText}");
        Console.WriteLine(entryText);


    }

}




}

