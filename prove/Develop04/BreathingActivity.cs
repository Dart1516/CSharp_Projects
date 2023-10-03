public class BreathingActivity : Activity
{

    public BreathingActivity(string ActivityName, string PersonalizedWelcomeMessage): base(ActivityName,PersonalizedWelcomeMessage)
    {
        
    }
    public void Run()
    {   
        Console.WriteLine($"Get ready..." );
        ShowSpinner(5);
        DateTime startTime1 = DateTime.Now; //Declaramos la hora en que comenzará 
        DateTime endTime1 = startTime1.AddSeconds(_duration); // declaramos el tiempo final que será 10 segundos luego de comenzar
        while (DateTime.Now < endTime1)   
        {
        Console.WriteLine($"Breathe in..." ); 
        ShowCountDown(5);
        Console.WriteLine($"Now, Breathe out..." ); 
        ShowCountDown(5);
        }
     
    }
}