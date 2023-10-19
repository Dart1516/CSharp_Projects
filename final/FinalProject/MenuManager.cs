public class MenuManager 
{
    public string _profileName;
    private int _exerciseDurationSeconds;
    private double _BMI;
    private string _goal;
    private string _difficulty;


public MenuManager()
{
    _profileName = "";
    _goal="";
    _difficulty="";

}

    public void introduction()
    {   
        Console.WriteLine("");
        Console.WriteLine("Please Enter your name: ");
        _profileName = Console.ReadLine()!;
        SetProfileName(_profileName);
        string profileFile = _profileName+".txt";
        if (File.Exists(profileFile))
        {   
            start();    
        } 
        else //if does not exist we are going to create
        {
            Profile p1 = new Profile();

            Console.WriteLine($"There is not exist {_profileName}'s profile. \n Let's create one: ");
            p1.CreatedNewProfile(_profileName);
            start();
        }
    }

    public void start()
    {
        bool quit = false;
        while(!quit)

        {
            Console.WriteLine($"Welcome Home {GetProfileName()} ");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start Exercise Routine.");
            Console.WriteLine(" 2. See My Profile.");
            Console.WriteLine(" 3. Update Profile.");
            Console.WriteLine(" 4. Load Goals.");
            Console.WriteLine(" 5. Tips to remember.");
            Console.WriteLine(" 6. Quit.");
            Console.WriteLine("Select a choice from the menu: ");
            string input = Console.ReadLine()!.ToLower();

            switch (input) {
                case "1":
                Console.WriteLine("How many minutes would you like to exercise today");
                int seconds = Convert.ToInt32(Console.ReadLine());
                SetExerciseDurationSeconds(seconds*60);
                    SelectDifficulty();
                    break;
                case "2":
                    DisplayProfile();
                    break;
                case "3":
                    UpdateProfile();
                    break;
                case "4":
                    introduction();
                    break;
                case "5":
                    string profileFile = _profileName+".txt";
                    string rutaArchivo = profileFile;
                    string[] lineas = File.ReadAllLines(rutaArchivo);
                    string fitnessGoal = lineas[7].Split(':')[1].Trim();
                    PromptTips p1 = new PromptTips();
                    p1.DisplayPrompt(fitnessGoal);
                    break;
                case "6":
                    Console.WriteLine("wish you the best of luck. See you.");
                    quit = true;
                    break;
                default:
                    Console.WriteLine("that is not a valid number, Please enter a number between 1 and 7.");
                break;
            }
        }
    }

    public void SetProfileName(string ProfileName)
    {
        _profileName = ProfileName;
    }

    public string GetProfileName()
    {
        return _profileName;
    }

    public void DisplayProfile()
    {   
        string profileFile = _profileName+".txt";
        string rutaArchivo = profileFile;

        // Leer todas las líneas del archivo
        string[] lineas = File.ReadAllLines(rutaArchivo);

        // Obtener los valores usando Split y Trim
        string UserName = lineas[1].Split(':')[1].Trim();
        SetProfileName(UserName);
        string Age = lineas[2].Split(':')[1].Trim();
        string Weight = lineas[3].Split(':')[1].Trim();
        string Height = lineas[4].Split(':')[1].Trim();
        string ibm = lineas[5].Split(':')[1].Trim();
        string ibmState = lineas[6].Split(':')[1].Trim();
        string fitnessGoal = lineas[7].Split(':')[1].Trim();
        string exerciseSeconds = lineas[8].Split(':')[1].Trim();
        int minutesOfExercises = Convert.ToInt32(exerciseSeconds)/60;

        // Mostrar los valores extraídos
        Console.WriteLine("User Name: " + UserName);
        Console.WriteLine("Age: " + Age);
        Console.WriteLine("Weight: " + Weight);
        Console.WriteLine("Height: " + Height);
        Console.WriteLine("IBM: " + ibm);
        Console.WriteLine("IBM Status: " + ibmState);
        Console.WriteLine("Fitness Goal: " + fitnessGoal);
        Console.WriteLine("Minutes of exercises per day: " + minutesOfExercises);
    }

    public void UpdateProfile()
    {   
        string content = File.ReadAllText(_profileName+".txt");
        Console.WriteLine("Enter the number of the info you want to update:");
        Console.WriteLine("1. Age");
        Console.WriteLine("2. Weight");
        Console.WriteLine("3. Height");
        Console.WriteLine("4. IBM");
        Console.WriteLine("5. IBM Status");
        Console.WriteLine("6. Fitness Goal");
        Console.WriteLine("7. Minutes of exercises per day");

        int choice = int.Parse(Console.ReadLine()!);
        Profile p1 = new Profile();
        string newValue = "";
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter your new age:");
                newValue = Console.ReadLine()!;
                content = ReplaceValue(content, "Age: ", newValue);
                break;
            case 2:
                Console.WriteLine("Enter your new Weight:");
                newValue = Console.ReadLine()!;
                content = ReplaceValue(content, "Weight: ", newValue);
                break;
            case 3:
                Console.WriteLine("Enter your new Height:");
                newValue = Console.ReadLine()!;
                content = ReplaceValue(content, "Height: ", newValue);
                break;
            case 4:
                Console.WriteLine("Enter your new IBM:");
                newValue = Console.ReadLine()!;
                content = ReplaceValue(content, "IBM: ", newValue);
                break;
            case 5:
                Console.WriteLine("Enter your IBM Status:");
                newValue = Console.ReadLine()!;
                content = ReplaceValue(content, "IBM Status: ", newValue);
                break;
            case 6:
                Console.WriteLine("Enter the new value for goal:");
                
                newValue = p1.FitnessGoal();
                content = ReplaceValue(content, "Fitness Goal: ", newValue);
                break;
            case 7:
                Console.WriteLine("Enter the new value for exercise minutes:");
                newValue = Console.ReadLine()!;
                content = ReplaceValue(content, "Minutes of exercises per day: ", newValue);
                break;
            default:
                Console.WriteLine("Invalid option.");
                return;
        }
        File.WriteAllText(_profileName+".txt", content);
        Console.WriteLine("Your info has been Updated:");
    }
    
    private string ReplaceValue(string content, string prefix, string newValue) // el código más hermoso que encontré para remplazar datos
    {
        int startIndex = content.IndexOf(prefix);
            if (startIndex != -1)
            {
                int endIndex = content.IndexOf("\n", startIndex);
                if (endIndex != -1)
                {
                    content = content.Remove(startIndex + prefix.Length, endIndex - startIndex - prefix.Length);
                    content = content.Insert(startIndex + prefix.Length, newValue);
                }
            }
            return content;
    }

    public void SelectDifficulty()
    {   
        bool quit = false;
        while(!quit)
        {
            Console.WriteLine($"Select difficulty");
            Console.WriteLine(" 1. Beginner.");
            Console.WriteLine(" 2. Intermediate.");
            Console.WriteLine(" 3. Advanced.");
            Console.WriteLine(" 4. Back.");
            string input = Console.ReadLine()!.ToLower();
            string _difficulty;

            switch (input) 
            {
                case "1":
                    _difficulty ="Beginner";
                    SetDifficulty(_difficulty);
                    SelectExercise();
                    break;
                case "2":
                    _difficulty ="Intermediate";
                    SetDifficulty(_difficulty);
                    SelectExercise();
                    break;
                case "3":
                    _difficulty ="Advanced";
                    SetDifficulty(_difficulty);
                    SelectExercise();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("that is not a valid number, Please enter a number between 1 and 4.");
                break;
            }
        }
    }
    public void SelectExercise()
    {   
        bool quit = false;
        while(!quit)
        {
            Console.WriteLine($"What focus you will have in your exercise today");
            Console.WriteLine(" 1. Arms.");
            Console.WriteLine(" 2. Body.");
            Console.WriteLine(" 3. Legs.");
            Console.WriteLine(" 4. Back.");
            string input = Console.ReadLine()!.ToLower();
            switch (input) 
            {
                case "1":
                    TrainingRoutinesArms t1 = new TrainingRoutinesArms(_difficulty, _exerciseDurationSeconds);
                    t1.DisplayStartingMessage();
                    t1.DisplayEndingMessage();
                    break;
                case "2":
                    TrainingRoutinesBody t2 = new TrainingRoutinesBody(_difficulty, _exerciseDurationSeconds);
                    t2.DisplayStartingMessage();
                    t2.DisplayEndingMessage();
                    break;
                case "3":
                    TrainingRoutinesLegs t3 = new TrainingRoutinesLegs(_difficulty, _exerciseDurationSeconds);
                    t3.DisplayStartingMessage();
                    t3.DisplayEndingMessage();
                    break;
                case "4":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("that is not a valid number, Please enter a number between 1 and 4.");
                break;
            }
        }
    }

    public void SetBMI(double bmi)
    {
        _BMI = bmi;
    }
    public double GetBMI()
    {
        return _BMI;
    }

    public void SetExerciseDurationSeconds(int exerciseDurationSeconds)
    {
        _exerciseDurationSeconds = exerciseDurationSeconds;
    }
    public int GetExerciseDurationSeconds()
    {
        return _exerciseDurationSeconds;
    }
    public void SetFitnessGoal(string goal)
    {
        _goal = goal;
    }
    public string GetFitnessGoal()
    {
        return _goal;
    }
    public void SetDifficulty(string difficulty)
    {
        _difficulty = difficulty;
    }
}