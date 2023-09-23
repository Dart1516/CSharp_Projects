public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText ="" ; 

    public List <string> _list_to_store_temporarily_my_entries = new List<string>();
    public void DisplayEntry()
    { 
        _list_to_store_temporarily_my_entries.Add($"{_date} - {_promptText}");
        _list_to_store_temporarily_my_entries.Add(_entryText);
        _list_to_store_temporarily_my_entries.Add("----------------------------------------");
        _list_to_store_temporarily_my_entries.Add("");
    }

    
}