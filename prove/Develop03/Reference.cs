class Reference
{
    string book;
    int chapter, verse, endVerse;

    public Reference (string _book, int _chapter, int _verse)
    {
        book    = _book;
        chapter =  _chapter;
        verse   = _verse;

    }

    public Reference(string _book, int _chapter, int _verseStart, int _verseEnd)
    {
        book     = _book;
        chapter  = _chapter;
        verse    = _verseStart;
        endVerse = _verseEnd;

    }

    public string GetDisplayText()
    {
        string refernceDisplay = "";
        if (endVerse != 0)
        {
            refernceDisplay = $"{book} {chapter} {verse}-{endVerse}";

        }
        else
        {
              refernceDisplay = $"{book} {chapter} {verse}";

        }
        return refernceDisplay;

        
    }
}