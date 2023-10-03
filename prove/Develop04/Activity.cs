using System.ComponentModel.DataAnnotations;

public class Activity{
    private string _activityName;
    private string _description;
    protected int _duration;
    
    public Activity()
    {
        _activityName= "Sin nombre aún";
        _description = "Sin descripción aún";
        _duration = 0;
        
    }
    public Activity(string name, string PersonalizedWelcomeMessage )
    {
        _activityName = name;
        _description = PersonalizedWelcomeMessage;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_activityName}. \n");
        Console.WriteLine($"{_description}.\n");
        string númeroCorrecto= "no";
        do
        {
            Console.Write($"How long in seconds, would you like for your session: ");
            string input = Console.ReadLine()!;
            try
            {
                _duration = Int32.Parse(input);
                númeroCorrecto = "yes";
                
            }catch (FormatException)
            {
                Console.WriteLine("This is not a number, Please enter a number.\n");
                
            }    
            
        }while (númeroCorrecto == "no");
        
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done");
        Console.WriteLine($"");
        Console.WriteLine($"you have complete another {_duration} seconds of the {_activityName}.");
        ShowSpinner(4);
        Console.WriteLine($"");
        Console.WriteLine($"Would you like to do something else?");
    }
    public void ShowSpinner(int WaitingSeconds)
    {   

        List<string> vueltaAnimada = new List<string>();
        vueltaAnimada.Add("|");
        vueltaAnimada.Add("/");
        vueltaAnimada.Add("-");
        vueltaAnimada.Add("\\");
        vueltaAnimada.Add("|");
        vueltaAnimada.Add("/");
        vueltaAnimada.Add("-");
        vueltaAnimada.Add("\\");
        vueltaAnimada.Add("|");
        vueltaAnimada.Add("/");
        vueltaAnimada.Add("-");
        vueltaAnimada.Add("\\");
        vueltaAnimada.Add("|");
        vueltaAnimada.Add("/");
        vueltaAnimada.Add("-");
        vueltaAnimada.Add("\\");
        DateTime startTime2 = DateTime.Now; //Declaramos la hora en que comenzará 
        DateTime endTime2 = startTime2.AddSeconds(WaitingSeconds); // declaramos el tiempo final que será 10 segundos luego de comenzar
        while (DateTime.Now < endTime2)
        {   
            string forma = vueltaAnimada[WaitingSeconds];
            Console.Write(forma);
            Thread.Sleep(0250);
            Console.Write($"\b \b");
            WaitingSeconds++;
            if (WaitingSeconds >= vueltaAnimada.Count) // SIN ESTO DARÁ ERROR
            {WaitingSeconds = 0;} // ESTO ES SUPER IMPORTANTE
        }

    }
    public void ShowCountDown(int contador)
    {
        for ( int duration= contador; duration >0; duration--)
        {
            Console.Write($"{duration}");
            Thread.Sleep(1000);
            Console.Write($"\b\b  \b\b");
        }

    }


}