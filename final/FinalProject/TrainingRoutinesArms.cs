public class TrainingRoutinesArms: TrainingRoutines
{
    private string _difficulty;
    public TrainingRoutinesArms(string difficulty, int duration) : base( difficulty, duration)
    {
        _difficulty = difficulty;
    }

    public override void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the This Arms exercises. \n");
        Console.WriteLine($"We will start by Chest exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectChestExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(5);
        Console.WriteLine($"Now continue with Shoulders exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectChestExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(5);
        Console.WriteLine($"\n And we will finish with  Triceps exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectChestExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(5);
    }

    public void SelectChestExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Diamond Push-ups", "1. Start in a plank position with your hands close together, forming a diamond shape.\n2. Lower your body, keeping your elbows close to your sides, then push back up."},
            {"Chest Squeeze (Pec Fly) with Resistance Band", "1. Secure a resistance band at chest height.\n2. Hold the band handles with each hand and extend your arms forward.\n3. Open your arms wide to the sides, then bring them back to the front."},
            {"Banded Chest Press", "1. Attach a resistance band to a fixed point.\n2. Hold the band handles at shoulder height, push your hands forward, then bring them back towards your chest."},

            {"Jumping Push-ups", "1. Perform a regular push-up, then explosively push off the ground so your hands leave the floor.\n2. Land softly and immediately go into the next push-up."},
            {"Knee-to-Chest Push-ups", "1. Start in a plank position.\n2. Lower your body into a push-up, and as you push back up, bring one knee towards your chest.\n3. Alternate legs with each repetition."},

            {"Push-ups", "1. Start in a plank position with your hands placed shoulder-width apart.\n2. Lower your body towards the ground by bending your elbows, then push back up to the starting position."},
            {"Dips", "1. Use parallel bars or sturdy furniture.\n2. Lower your body by bending your arms, then push back up to the starting position."},
            {"Plank with Shoulder Taps", "1. Begin in a plank position on your hands.\n2. Lift one hand and tap the opposite shoulder, then switch sides while keeping your body stable and straight."},
            {"Side Plank", "1. Lie on your side with your elbow directly beneath your shoulder and legs stacked.\n2. Lift your hips, keeping your body in a straight line. Hold for a few seconds and then switch sides."},
            {"Close-Grip Push-ups", "1. Assume a plank position with your hands close together, forming a triangle shape.\n2. Lower your body, keeping your elbows close to your sides, then push back up."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Push-ups", "Dips", "Plank with Shoulder Taps", "Side Plank", "Close-Grip Push-ups" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Diamond Push-ups", "Chest Squeeze (Pec Fly) with Resistance Band", "Banded Chest Press" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Jumping Push-ups", "Knee-to-Chest Push-ups" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }
        DisplayRandomExercise(selectedExercises,exercises );
    }

    public void SelectShouldersExercise(string Dificultad)
    {
         Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Lateral Raises (with Household Items)", "1. Hold a household item in each hand, standing with your feet shoulder-width apart.\n2. Keep a slight bend in your elbows and lift the items out to your sides until they reach shoulder level.\n3. Lower them back down to your thighs."},
            {"Reverse Snow Angels (on the Floor)", "1. Lie face down on the floor with your arms extended in front of you.\n2. Lift your arms and legs off the ground, then move your arms in a semicircular motion (as if making a snow angel in the air).\n3. Lower your arms back down and repeat the motion."},

            {"Pike Push-Ups", "1. Start in a push-up position with your hands slightly wider than shoulder-width apart and your hips lifted toward the ceiling (forming an upside-down V shape).\n2. Lower your head toward the ground, then push back up to the starting position. This exercise targets the shoulders and upper arms."},
            {"Handstand Push-Ups (Against a Wall)", "1. Kick up into a handstand position against a wall, with your hands placed shoulder-width apart.\n2. Lower your head toward the ground, then push back up to the starting position. Use the wall for balance and support."},
            {"Pike Shoulder Press (with Household Items)", "1. Hold a household item in each hand, such as water bottles or bags of rice.\n2. Sit on the floor with your legs extended straight out, forming a V shape with your body.\n3. Lift the items overhead, then lower them back down toward your shoulders, keeping your arms straight."},

            {"Shoulder Taps", "1. Start in a plank position with your hands directly under your shoulders.\n2. Lift your right hand and tap your left shoulder, then return to the plank position.\n3. Repeat on the other side, alternating arms."},
            {"Front Raises (with Household Items)", "1. Hold a household item in each hand, such as water bottles or bags of rice.\n2. Stand with your feet shoulder-width apart.\n3. Lift the items forward until they reach shoulder level, then lower them back down."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Shoulder Taps", "Front Raises (with Household Items)" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Lateral Raises (with Household Items)", "Reverse Snow Angels (on the Floor)" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Pike Push-Ups", "Handstand Push-Ups (Against a Wall)", "Pike Shoulder Press (with Household Items)" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }

        DisplayRandomExercise(selectedExercises,exercises );
    }
    public void SelectTricepsExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Lateral Raises (with Household Items)", "1. Hold a household item in each hand, standing with your feet shoulder-width apart.\n2. Keep a slight bend in your elbows and lift the items out to your sides until they reach shoulder level.\n3. Lower them back down to your thighs."},
            {"Reverse Snow Angels (on the Floor)", "1. Lie face down on the floor with your arms extended in front of you.\n2. Lift your arms and legs off the ground, then move your arms in a semicircular motion (as if making a snow angel in the air).\n3. Lower your arms back down and repeat the motion."},

            {"Pike Push-Ups", "1. Start in a push-up position with your hands slightly wider than shoulder-width apart and your hips lifted toward the ceiling (forming an upside-down V shape).\n2. Lower your head toward the ground, then push back up to the starting position. This exercise targets the shoulders and upper arms."},
            {"Handstand Push-Ups (Against a Wall)", "1. Kick up into a handstand position against a wall, with your hands placed shoulder-width apart.\n2. Lower your head toward the ground, then push back up to the starting position. Use the wall for balance and support."},
            {"Pike Shoulder Press (with Household Items)", "1. Hold a household item in each hand, such as water bottles or bags of rice.\n2. Sit on the floor with your legs extended straight out, forming a V shape with your body.\n3. Lift the items overhead, then lower them back down toward your shoulders, keeping your arms straight."},

            {"Shoulder Taps", "1. Start in a plank position with your hands directly under your shoulders.\n2. Lift your right hand and tap your left shoulder, then return to the plank position.\n3. Repeat on the other side, alternating arms."},
            {"Front Raises (with Household Items)", "1. Hold a household item in each hand, such as water bottles or bags of rice.\n2. Stand with your feet shoulder-width apart.\n3. Lift the items forward until they reach shoulder level, then lower them back down."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Shoulder Taps", "Front Raises (with Household Items)" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Lateral Raises (with Household Items)", "Reverse Snow Angels (on the Floor)" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Pike Push-Ups", "Handstand Push-Ups (Against a Wall)", "Pike Shoulder Press (with Household Items)" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }
        DisplayRandomExercise(selectedExercises,exercises );
    }
}