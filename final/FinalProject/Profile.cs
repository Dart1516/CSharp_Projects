public class Profile : MenuManager
{
    private double _weight;
    private double _height;
    private int _age;

public Profile()
{

}

public void CreatedNewProfile(string profileName)
{
    ImcCalculator();
    MinutesPerDay();
    FitnessGoal();

    using (StreamWriter outputFile = new StreamWriter(profileName+".txt"))
    {
        outputFile.WriteLine($"-------------------- User Info --------------------");
        outputFile.WriteLine($"Name: {profileName}");
        outputFile.WriteLine($"Age: {_age}");
        outputFile.WriteLine($"Weight: {_weight}");
        outputFile.WriteLine($"Height: {_height}");
        outputFile.WriteLine($"IBM: {Convert.ToString(GetBMI())}");
        outputFile.WriteLine($"IBM Status: {Convert.ToString(WeightStatus(GetBMI()))}");
        outputFile.WriteLine($"Fitness Goal: {GetFitnessGoal()}");
        outputFile.WriteLine($"Minutes of exercises per day: {GetExerciseDurationSeconds()*60}");
        outputFile.WriteLine($"Minutes of exercises per day: {GetExerciseDurationSeconds()*60}");
    }
}

public void ImcCalculator()
{
    double weight = ValidWeight("Enter your weight in kilograms:");
    SetWeight(weight);
    double height = ValidHeight("Enter your height in centimeters:");
    SetHeight(height);
    int age = ValidAge("Please, tell us your age:");
    SetAge(age);
    double bmi = weight / (height * height);
    Console.WriteLine($"Your Body Mass Index (BMI) is: {bmi}");
    Console.WriteLine($"Weight Status: {WeightStatus(bmi)}");
    SetBMI(bmi);
}
    
static string WeightStatus(double bmi)
{
    if (bmi < 18.5)
    {
        return "Underweight";
    }
    else if (bmi >= 18.5 && bmi < 24.9)
    {
        return "Normal Weight";
    }
    else if (bmi >= 25 && bmi < 29.9)
    {
        return "Overweight";
    }
    else if (bmi >= 30 && bmi < 34.9)
    {
        return "Obesity (Grade 1)";
    }
    else if (bmi >= 35 && bmi < 39.9)
    {
        return "Obesity (Grade 2)";
    }
    else
    {
        return "Severe Obesity (Grade 3)";
    }
}
public double ValidHeight(string prompt)
{
    double value;
    while (true)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine()!;
        if (double.TryParse(input, out value))
        {
            if (value <65)
            {
                Console.WriteLine("Seems to be that you are smaller than a baby. Please verify and enter a number between 65 and 272 ");
                continue;
            }
            if (value >272)
            {
                Console.WriteLine("Seems to be that you are  the tallest person ever. Please verify  enter a number between 65.24 and 272.9 ");
                continue;
            }
            if (value >65 || value <272)
            {
            return value/100;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for example: 170 ");
        }
    }
}
public double ValidWeight(string prompt)
    {
        double value;
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine()!;
            if (double.TryParse(input, out value))
            {
                if (value <7.3)
                {
                    Console.WriteLine("Seems to be that your weight is lower than a baby, something must be wrong, please visit a doctor if is correct or enter a number between 7.3 and 594.8 ");
                    continue;
                }if (value >594.8)
                {
                    Console.WriteLine("Seems to be that your weight is unusual. Please verify and enter a number between 7.3 and 594.8 ");
                    continue;
                }else                
                {
                return value;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number, for example: 80.7");
            }
        }
    }
public int ValidAge(string prompt)
{
    int value;
    while (true)
    {
        Console.WriteLine(prompt);
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out value))
        {
            if (value <1)
            {
                Console.WriteLine("Seems to be that you're not older enough to use this app, please try another age.  ");
                continue;
            }
            if (value >117)
            {
                Console.WriteLine("Wow it Seems to be that you are older enough to stop worry about your weight. Please verify  enter a number between 65.24 and 272.9 ");
                continue;
            }
            if (value >1 || value <117)
            {
            return value;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number");
        }
    }
}
public int MinutesPerDay()
{
    int minutes;
    while (true)
    {
        Console.WriteLine("How many minutes per day can you exercise?");
        string input = Console.ReadLine()!;

        if (int.TryParse(input, out minutes))
        {
            int exerciseDurationSeconds = minutes*60;
            SetExerciseDurationSeconds(exerciseDurationSeconds);
            return exerciseDurationSeconds;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a whole number.");
        }
    }
}

public string FitnessGoal()
    {
        while (true)
        {
            Console.WriteLine("What is your fitness goal?");
            Console.WriteLine("1. Gain Weight/Muscle Mass");
            Console.WriteLine("2. Lose Weight/Burn Fat");
            string userInput = Console.ReadLine()!.ToLower();

            if (userInput == "1" || userInput == "gain weight" || userInput == "muscle mass" || userInput == "Gain Weight/Muscle Mass")
            {   
                SetFitnessGoal("Gain Weight/Muscle Mass");
                return "Gain Weight/Muscle Mass";
            }
            else if (userInput == "2" || userInput == "lose weight" || userInput == "burn fat" || userInput == "Weight/Burn Fat")
            {
                SetFitnessGoal("Lose Weight/Burn Fat");
                return "Lose Weight/Burn Fat";
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select either '1' for Gain Weight/Muscle Mass or '2' for Lose Weight/Burn Fat.");
            }
        }
    }


public void SetWeight(double weight)
{
    _weight = weight;
}

public double GetWeight()
{
    return _weight;
}
public void SetHeight(double height)
{
    _height = height;
}

public double GetHeight()
{
    return _height;
}
public void SetAge(int age)
{
    _age = age;
}

public double GetAge()
{
    return _age;
}
}