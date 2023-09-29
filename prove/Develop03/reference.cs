public class Reference {
    private string _book = "";
    private int _chapter; 
    private int _verse;
    private int _endVerse;
    
    public Reference(string referencia)
    {   
        string[] parts = referencia.Split(' ');
        string book = parts[0];
        string[] chapterAndVerse = parts[1].Split(':');        
        int chapter = Int32.Parse(chapterAndVerse[0]);
        //string[] verses = parts[1].Split(':'); 
        //int firstVerse = Int32.Parse(verses[0]); 
        //int endVerse = Int32.Parse(verses[1]);
        //setFirstVerse(firstVerse);
        //setEndVerse(endVerse);
        setBook(book);
        setChapter(chapter);
    }
    public string getBook()
    {
        return _book;
    }
    public void setBook(string newText)
    {
        _book = newText;
    }
    public int getChapter()
    {
        return _chapter;
    }
    public void setChapter(int chapter)
    {
    _chapter = chapter;
    }
    public int getFirstVerse()
    {
        return _verse;
    }
    public void setFirstVerse(int firstVerse)
    {
    _verse = firstVerse;
    }
    public int getEndVerse()
    {
        return _endVerse;
    }
    public void setEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetDisplayTex1Verse() 
    {
        string reference = $"{_book} { _chapter}: {_verse}  ";
        return reference;
    }
    public string GetDisplayTex2Verse() 
    {
        string reference = $"{_book} { _chapter}: {_verse} - {_endVerse} ";
        return reference;
    }

    // Possible getters and setters

    public void SetDisplayText( string displayText) 
    {
        
    }
    
}