using System;
using System.Collections.Generic;

public class Word
{
    private string _modifiedText;
    private List<string> _wordsList;

    public Word(string originalText)
    {
        _modifiedText = originalText;
        _wordsList = new List<string>(_modifiedText.Split(' '));
    }
    public string getModifiedText()
    {
        return _modifiedText;
    }

    public List<string> getWordsList()
    {
        return _wordsList;
    }



}