public class PromptGeneration
{
    List<string> _different_Prompts = new List<string>() 
    {"Who was the most interesting person I interacted with today?",
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?", 
    "If I had one thing I could do over today, what would it be?", 
    "if you could say something to someone before you die what would it be", 
    "what would you like to accomplish today"};
    
    public string GetRandomPrompt()
    {
        Random random_selector = new Random();
        int random_number = random_selector.Next(_different_Prompts.Count);
        string random_prompt = _different_Prompts[random_number];
        return random_prompt;
    }
}