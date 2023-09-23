public class Journal 
{
    public string? _my_file;
    // public List<string>? _entries;
    public string _written_entry = "";

    public  void AddEntry (Entry newEntry)
    {

    }
        public void DisplayAll()
    {
        foreach (string line in System.IO.File.ReadLines(_my_file!))
        {  
            System.Console.WriteLine(line);  
        } 
    }

    public void SaveToFile(string random_phrase, string dataText)
    {
        using (StreamWriter archivo = File.AppendText(_my_file!))
        {
            archivo.WriteLine($"{_written_entry}");
        }
    }

    public void LoadFromFile (string file)
    {
        
    }
    public void creating_a_file()
    {
        using (StreamWriter outputFile = new StreamWriter(_my_file!))
        {
            outputFile.WriteLine($"--------------------{_my_file}--------------------");
        }
    }



}