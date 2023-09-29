using System.Text.RegularExpressions;

public class Scripture
{
    private string _allText  = ""; // will have the scripture and reference
    private string _scripture = ""; // will only have the text without reference
    private string _textoModificado = "";
    private string _reference = ""; // will store only the reference without the text
    private string _IsCompletelyHidden ="";
    private string[] _wordsList;
    private List<int> availableIndex;
    Random random = new Random();
    
    
    public Scripture()
    {
        string filePath = "100_Scripture_Mastery_Passages.txt";// this will read the file with the scripture
        List<string> lines = new List<string>(); // I will real all the lines and jump the blank ones
        try
        {
            foreach (string line in File.ReadLines(filePath))
            {
                if (!string.IsNullOrWhiteSpace(line))
                {
                    lines.Add(line);
                }
            }
        }
        catch (IOException e)
        {
            string errorMessage = "Error while trying to read the file" + e.Message; // just in case.
            return;
        }

        Random randomNumber = new Random(); // This will help me to select a random line 
        int randomIndex = randomNumber.Next(0, lines.Count);

        string selectedScripture = lines[randomIndex]; // this is the scripture That I'm going to use, and store in a variable, for I'm going tu use it,
        setAllText(lines[randomIndex]);

        int searchTheLastNumber = selectedScripture.LastIndexOfAny("0123456789".ToCharArray()); //This is for separating the Reference from the Scripture

        if (searchTheLastNumber != -1)
        {
            string textBeforeNumbers = selectedScripture.Substring(0, searchTheLastNumber + 1).Trim();
            setReference(textBeforeNumbers);
            string textAfterNumber = selectedScripture.Substring(searchTheLastNumber + 1).Trim();
            setScriptureText(textAfterNumber);
        }
        _wordsList = _scripture.Split(' ');
        availableIndex = new List<int>();
        for (int i = 0; i < _wordsList.Length; i++)
        {
            availableIndex.Add(i);
        }
         setCompletelyHidden("no");
        
    }
    public void setPalabras(string[] p)
    {
        _wordsList = p;
    }
    public void setIndiceDisponible(List<int> indice)
    {
        availableIndex = indice;
    }

    public string getAllText()
    {
        return _allText;
    }
    public void setAllText(string AllText)
    {
        _allText = AllText;
    }
    public string getScriptureText()
    {
        return _scripture;
    }
    public void setScriptureText(string ScriptureText)
    {
        _scripture = ScriptureText;
    }
    public string getReference()
    {
        return _reference;
    }
    public void setReference(string ReferenciaDeEscritura)
    {
        _reference = ReferenciaDeEscritura;
    }
    public void HideRandomWords2()
    {
       //This is the code for not repeating words
            if (availableIndex.Count > 0)
            {   
                for (int wordHide = 0; wordHide < 10; wordHide++)
                {
                     if (availableIndex.Count == 0)
                    {_IsCompletelyHidden = "yes";
                    setCompletelyHidden("yes");
                        break;
                    
                    }
                int selectedWord = random.Next(0, availableIndex.Count);
                int numberOfWordToChange = availableIndex[selectedWord];
                availableIndex.RemoveAt(selectedWord);
                _wordsList[numberOfWordToChange] = new string('_', _wordsList[numberOfWordToChange].Length);
                }
            _textoModificado = string.Join(" ", _wordsList);  
            }
            else
            {
                Console.WriteLine("All the words are hide.");
                _IsCompletelyHidden = "yes";
                Environment.Exit(0);
                setCompletelyHidden("yes");
                
            }
    }

    public string GetDisplayText()
    {
        Console.WriteLine($"{_reference} - \n{_textoModificado}");
        return "GetDisplayText";
    }

    public string getIsCompletelyHidden()
    {   
        return _IsCompletelyHidden;
    }
        public void setCompletelyHidden(string text)
    {
        _IsCompletelyHidden = text;
    }
}