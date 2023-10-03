public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "When have you felt the Holy Ghost this month?",
        "What have you done this month to strengthen your faith?",
        "How did you show love to your family this month?",
        "What steps have you taken this week to take care of your health?",
        "What will be your goals for today?",
    };

    public ListingActivity(string ActivityName, string PersonalizedWelcomeMessage) : base(ActivityName, PersonalizedWelcomeMessage)
    {

    }
    public void Run()
    {
        Console.WriteLine("Get Ready");
        ShowSpinner(2);
        Console.WriteLine("");
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        GetRandomPrompt();
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        List<string> listaTemporal = new List<string>();
        DateTime startTime3 = DateTime.Now;
        DateTime endTime3 = startTime3.AddSeconds(_duration);
        while (DateTime.Now < endTime3)
        {
            Console.Write("-> ");
            string itemOnList = Console.ReadLine()!;
            listaTemporal.Add($"{itemOnList}");
        }
        Console.WriteLine($"You listed {GetListFromUser(listaTemporal)} items ");
    }
    public string GetRandomPrompt()
    {
        Random random_selector = new Random();
        int random_number = random_selector.Next(_prompts.Count);
        string random_prompt = _prompts[random_number];
        return random_prompt;
    }
    public int GetListFromUser(List<string> temporalList)
    {
        _count = temporalList.Count;
        return _count;
    }
}