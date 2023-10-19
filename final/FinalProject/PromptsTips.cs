public class PromptTips
{
    private List<string> _weightLossTips;
    private List<string> _maintenanceWeightTips;
    public PromptTips()
    {
        _weightLossTips = new List<string>
        {
            "Control portion sizes to reduce calorie intake.",
            "Incorporate cardiovascular and strength exercises into your routine.",
            "Maintain a balanced diet rich in fruits, vegetables, lean proteins, and whole grains.",
            "Stay hydrated by drinking enough water throughout the day to support your metabolism.",
            "Practice mindful eating, savor each bite, and avoid distractions like TV or phones.",
            "Limit processed foods high in sugars, salt, and unhealthy fats.",
            "Get enough sleep; aim for 7-9 hours per night, as lack of sleep can affect weight loss efforts.",
            "Manage stress through activities like yoga, meditation, or hobbies to avoid emotional eating.",
            "Regularly track your progress, celebrate achievements, and adjust your plan if needed.",
            "Seek support; consider joining a weight loss group, working with a nutritionist, or having a workout buddy for motivation and accountability."
        };

        _maintenanceWeightTips = new List<string>
        {
            "Continue regular physical activity to maintain your fitness level.",
            "Maintain healthy eating habits, focusing on natural foods and avoiding processed snacks.",
            "Keep practicing mindful food consumption, avoiding unnecessary bingeing or overeating.",
            "Prioritize adequate sleep, as it plays a crucial role in weight maintenance and overall health.",
            "Stay active; incorporate movement into your daily routine, such as walking or using stairs.",
            "Continue drinking an adequate amount of water daily to support your metabolism.",
            "Schedule regular medical check-ups and monitor your weight to address any changes promptly.",
            "Manage stress continually to prevent emotional eating and maintain a healthy mindset.",
            "Celebrate your achievements, both big and small, to stay motivated.",
            "Understand that maintaining a healthy weight is a lifelong commitment to your well-being."
        };
    }

    public  string GetRandomTip(string fitnessGoal)
    {   
        Random random_selector = new Random();    
        if (fitnessGoal == "Lose Weight/Burn Fat")
        {        
            int random_number = random_selector.Next(_weightLossTips.Count);
            string random_prompt = _weightLossTips[random_number];
            _weightLossTips.RemoveAt(random_number);
            return random_prompt;
        }if(fitnessGoal == "Gain Weight/Muscle Mass")
        {
            int random_number = random_selector.Next(_maintenanceWeightTips.Count);
            string random_prompt = _maintenanceWeightTips[random_number];
            _maintenanceWeightTips.RemoveAt(random_number); 
            return random_prompt;
        }else
        {
            return "there is not Goal Set for a tip";
        }
    }
        public void DisplayPrompt(string fitnessGoal)
    {   
        Console.WriteLine($"--- {GetRandomTip(fitnessGoal)} ---\n" ); 
    }
}