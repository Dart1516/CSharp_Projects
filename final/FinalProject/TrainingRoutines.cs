public abstract class  TrainingRoutines
{
    
    protected int _duration;
    private string _difficulty;

    public TrainingRoutines(string difficulty, int duration)
    {
        _duration= duration;
        _difficulty = difficulty;
    }
    
    public virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the This XXXXXX exercises. \n");
        Console.WriteLine($"We will start by XXXXXXX exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowSpinner(5);
        ShowSpinner(3);
        Console.WriteLine($"Now continue with XXXXXXXXX exercise. \n");
        ShowSpinner(3);
        Console.WriteLine($"\n And we will finish with  XXXXXXXXX  exercise. \n");
        ShowSpinner(3);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Well Done");
        Console.WriteLine($"");
        Console.WriteLine($"you have complete another {_duration} of exercise.");
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

    protected void DisplayRandomExercise(List<string> selectedExercises, Dictionary<string, string> exercises)
    {
        // Select a random exercise from the list
        Random random = new Random();
        string selectedExercise = selectedExercises[random.Next(selectedExercises.Count)];

        // Display the name of the selected exercise
        Console.WriteLine($"Selected Exercise: {selectedExercise}");

        // Display the steps of the selected exercise
        Console.WriteLine("\nExercise Steps:");
        Console.WriteLine(exercises[selectedExercise]);
    }

    protected void ExerciseRepetition()
    {

        Console.WriteLine("Press enter when you are ready:");
        Console.ReadLine();
        DateTime startTime1 = DateTime.Now; //Declaramos la hora en que comenzará 
        DateTime endTime1 = startTime1.AddSeconds(_duration/3); // declaramos el tiempo final que será 10 segundos luego de comenzar
        while (DateTime.Now < endTime1)   
        {
        Console.WriteLine($"One More Time." ); 
        ShowCountDown(05);
        }
        Console.WriteLine($"Perfect. \n");
        ShowSpinner(5);
    }
}