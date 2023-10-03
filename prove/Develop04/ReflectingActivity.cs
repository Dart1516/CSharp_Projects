public class ReflectingActivity : Activity
{
    private List<string> _prompts= new List<string>() 
    {
        "Think about a challenging situation in your life?",
        "Recall a time when you faced fear head-on and emerged stronger on the other side", 
        "Think about a moment when you felt overwhelmed ", 
        "Think about a situation where you faced criticism or judgment.", 
        "Recall a time when you had to juggle multiple responsibilities and pressures.", 
        "Reflect on a setback or failure that you turned into a learning opportunity.", 
        "Think about a situation where you stood up for yourself or someone else", 
        "Consider a moment when you had to make a difficult decision.?", 
        "Think about a goal or dream you pursued despite obstacles.", 
        "Describe a time when you supported a friend or family member through a tough period.?"
    };
    private List<string> _question = new List<string>() 
    {
        "where you summon strength to overcome it?",
        "What did you learn from that experience?", 
        "What motivated you to persist?", 
        "How did you handle it, and what did you learn about your resilience in that moment?", 
        "How did you manage your time and energy effectively?", 
        "How did you bounce back, and what skills did you develop in the process?", 
        "Which factors influenced your choices, and how did you navigate the challenges that followed?", 
        "What sacrifices did you make, and how did your determination help you achieve or progress toward that goal?", 
        "How did your strength positively impact the others life, and what did you learn about your own resilience?"
    };
    
    public ReflectingActivity(string ActivityName, string PersonalizedWelcomeMessage): base(ActivityName,PersonalizedWelcomeMessage)
    {
        
    }
    public void Run()
    {        
        Console.WriteLine($"Get ready..." );
        ShowSpinner(3);
        Console.WriteLine($"Consider the following prompt: \n" );
        DisplayPrompt();
        Console.WriteLine($"When you have something in mind, press enter to continue." );
        Console.ReadLine();
        Console.WriteLine($"Now ponder on each of the following question as they related to this experience.");
        Console.WriteLine($"You may begin in:");
        ShowCountDown(3);
        DateTime startTime2 = DateTime.Now;
        DateTime endTime2 = startTime2.AddSeconds(_duration);
        while (DateTime.Now < endTime2)   
        {
            DisplayQuestion();
            ShowSpinner(10);
        }
    }
    public string GetRandomPrompt()
    {
        Random random_selector = new Random();
        int random_number = random_selector.Next(_prompts.Count);
        string random_prompt = _prompts[random_number];
        _prompts.RemoveAt(random_number); // To delete the selected number
        return random_prompt;
    }
    public string GetRandomQuestion()
    {
        Random random_selector = new Random();
        int random_number = random_selector.Next(_question.Count);
        string random_question = _question[random_number];
        _question.RemoveAt(random_number); // To delete the selected number
        return random_question;
    }
    public void DisplayPrompt()
    {   
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n" ); 
    }
    public void DisplayQuestion()
    {
        Console.WriteLine($"-> {GetRandomQuestion()}\n" ); 
    }

}