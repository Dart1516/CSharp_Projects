using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Tracing;
using System.Text.Json;


public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _extractedNumber;
    public string? _myFile;

    public GoalManager()
    { 
    }

    public void start( )
    {

    string input = "";
        while(input != "6   ")
        {
            Console.WriteLine($"You Have {_score} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal.");
            Console.WriteLine(" 2. List Goals.");
            Console.WriteLine(" 3. Save Goals.");
            Console.WriteLine(" 4. Load Goals.");
            Console.WriteLine(" 5. Record Event.");
            Console.WriteLine(" 6. Quit.");
            Console.WriteLine("Select a choice from the menu: ");
            input = Console.ReadLine()!;

            switch (input) {
                case "1":
                    CreateGoal();
                    break;
                
                case "2":
                    DisplayPlayerInfo();
                    break;
                
                case "3":
                    SaveGoal();
                    
                    break;
                case "4":
                    LoadGoals();
                    break;

                case "5":
                    Console.WriteLine($"Which Goal do you accomplished? ");
                    Console.WriteLine($"Select a choice from the menu ");
                    ListGoalNames();
                    string strMyChoice = Console.ReadLine()!;
                    int myChoice= Convert.ToInt32(strMyChoice);
                    RecordEvent(myChoice);
                    
                    break;
                    
                default:
                    Console.WriteLine("that is not a valid number, Please enter a number between 1 and 6.");
                break;
            }
        }
    }
    
    public void DisplayPlayerInfo()
    {
        Console.WriteLine("The goals are: ");
        foreach (Goal linea in _goals)
        {
            Console.WriteLine(linea.GetDetailsString(linea));
        }
    }

    public void ListGoalNames()
    {
        int count=1;
        foreach(Goal linea in _goals)
            {
                Console.WriteLine($"{count}._ {linea.GetName()}");
                count++;
            }
    }
    public void ListGoalDetails()
    {
        
    }
    public void CreateGoal()
    {
        string shortName;
        string description;
        string points;
        string strTarget;
        int target;
        string strBonus;
        int bonus;
        string my_choice = "";
        while(my_choice != "4")
        {   

            Console.WriteLine("");
            Console.WriteLine("The types of goals are:");
            Console.WriteLine("1._ Simple Goal");
            Console.WriteLine("2._ Eternal Goal");
            Console.WriteLine("3._ checklist Goal");
            Console.WriteLine("4._ Go Back to main menu");
            Console.WriteLine("Which type of goal would you like to create?");
            
            my_choice = Console.ReadLine()!;
        
        
        switch (my_choice) {
                case "1":
                    Console.WriteLine("What is the name of your goal?:");
                    shortName = Console.ReadLine()!;
                    Console.WriteLine("What is a short description of it?:");
                    description = Console.ReadLine()!;
                    Console.WriteLine("What is the amount of point associated?:");
                    points = Console.ReadLine()!;
                    Console.WriteLine("Goal registered");
                    Goal simpleGoal= new SimpleGoal(shortName, description, points);
                    simpleGoal.SetName(shortName);
                    simpleGoal.SetDescription(description);
                    simpleGoal.SetPoints(points);
                    _goals.Add(simpleGoal);
                    Console.WriteLine("Entry registered");
                    break;
                case "2":
                    Console.WriteLine("What is the name of your goal?:");
                    shortName = Console.ReadLine()!;
                    Console.WriteLine("What is a short description of it?:");
                    description = Console.ReadLine()!;
                    Console.WriteLine("What is the amount of point associated?:");
                    points = Console.ReadLine()!;
                    Console.WriteLine("Goal registered");
                    Goal eternalGoal= new EternalGoal(shortName, description, points);
                    eternalGoal.SetName(shortName);
                    eternalGoal.SetDescription(description);
                    eternalGoal.SetPoints(points);
                    _goals.Add(eternalGoal);
                    Console.WriteLine("Entry registered");
                    break;
                case "3":
                    Console.WriteLine("What is the name of your goal?: ");
                    shortName = Console.ReadLine()!;
                    Console.WriteLine("What is a short description of it?: ");
                    description = Console.ReadLine()!;
                    Console.WriteLine("What is the amount of point associated?: ");
                    points = Console.ReadLine()!;
                    Console.WriteLine("What is the bonus for accomplishing that goal: ");
                    strBonus = Console.ReadLine()!;
                    bonus = Convert.ToInt32(strBonus);
                    Console.WriteLine("How many times does this goal need to be accomplisher for the bonus?: ");
                    strTarget = Console.ReadLine()!;
                    target = Convert.ToInt32(strTarget);
                    Goal checkListGoal= new CheckListGoal(shortName, description, points, bonus, target);
                    checkListGoal.SetName(shortName);
                    checkListGoal.SetDescription(description);
                    checkListGoal.SetPoints(points);
                    checkListGoal.SetBonus(bonus);
                    checkListGoal.SetTarget(target);
                    _goals.Add(checkListGoal);
                    Console.WriteLine("Entry registered");
                    break;
                default:
                    Console.WriteLine("that is not a valid number, Please enter a number between 1 and 4.");
                    Console.WriteLine("Would you like to create another goal?.");
                    break;
            }
        }
    }

    public void RecordEvent(int MyChoice)
    {
        string[] lines = System.IO.File.ReadAllLines(_myFile);
        if (MyChoice >= 1 && MyChoice <= lines.Length)
            {
                string chosenLine = lines[MyChoice ];
                string[] values = chosenLine.Split(',');

                Console.WriteLine($"La línea número {MyChoice} es: {chosenLine}");
                if (values.Length >= MyChoice)
                    {
                        int extractedNumber1= Convert.ToInt32(values[2]);
                        Console.WriteLine($"El número en la posición después de la segunda coma en la línea {chosenLine} es: {extractedNumber1}");
                        SetExtractedNumber(extractedNumber1);
                    }
            }
        Console.WriteLine($"Congratulations you earn {_extractedNumber} point");
        _score = _score + _extractedNumber;
        
        
    }

    public void SaveGoal()
    {
        Console.WriteLine("");
        Console.WriteLine("Enter the name of the person and the extension of the file to save the goals. ");
        string fileName = Console.ReadLine()!;

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}"); 
            foreach(Goal linea in _goals)
            {
                outputFile.WriteLine($"{linea.GetStringRepresentation(linea)}");     
            }
        }
        Console.WriteLine($"{fileName} has been saved.");
        Console.WriteLine("");
    }
    public void LoadGoals()
    {   
        Goal simpleGoal= new SimpleGoal();
        Goal eternalGoal= new EternalGoal();
        Goal checkListGoal= new CheckListGoal();
        Console.WriteLine("");
        Console.WriteLine("What is te filename for the goal file?: ");
        _myFile = Console.ReadLine()!;
        if (File.Exists(_myFile))
        {
            _goals.Clear();
            string[] lines = System.IO.File.ReadAllLines(_myFile);
            if (int.TryParse(lines[0], out _score))
            {   
                for (int i = 1; i < lines.Length; i++)// review the lines starting the second line
                {
                    string[] parts = lines[i].Split(':'); // divide the next line in parts ":"
                    string typeOfTheObject = parts[0]; // the first words is the type
                    if (typeOfTheObject == "SimpleGoal")
                    {
                        string[] detailsOfTheObject = parts[1].Split(",");
                        simpleGoal.SetName(detailsOfTheObject[0]);
                        simpleGoal.SetDescription(detailsOfTheObject[1]);
                        simpleGoal.SetPoints(detailsOfTheObject[2]);
                        _goals.Add(simpleGoal);
                    }
                    if (typeOfTheObject == "EternalGoal")
                    {   
                        string[] detailsOfTheObject = parts[1].Split(",");
                        eternalGoal.SetName(detailsOfTheObject[0]);
                        eternalGoal.SetDescription(detailsOfTheObject[1]);
                        eternalGoal.SetPoints(detailsOfTheObject[2]);
                        _goals.Add(eternalGoal);
                    }
                    if (typeOfTheObject == "CheckListGoal")
                    {   
                        
                        string[] detailsOfTheObject = parts[1].Split(",");
                        checkListGoal.SetName(detailsOfTheObject[0]);
                        checkListGoal.SetDescription(detailsOfTheObject[1]);
                        checkListGoal.SetPoints(detailsOfTheObject[2]);
                        Console.WriteLine(detailsOfTheObject[3]);
                        int bonus;
                        if (Int32.TryParse(detailsOfTheObject[3], out bonus))
                        {checkListGoal.SetBonus(bonus);
                        }
                        int target;
                        if (Int32.TryParse(detailsOfTheObject[4], out target))
                        {checkListGoal.SetTarget(target);
                        }
                        int amountCompleted= Convert.ToInt32(detailsOfTheObject[5]);
                        checkListGoal.SetAmountCompleted(amountCompleted);
                        _goals.Add(checkListGoal);
                    }
                }
            }
            Console.WriteLine($"{_myFile} has been loaded.");
        }
        else
        {
            Console.WriteLine($"File '{_myFile}' not found.");
        }
        Console.WriteLine("");
    }
    public void SetExtractedNumber(int extractedN)
    {
        _extractedNumber = extractedN;
    }

}