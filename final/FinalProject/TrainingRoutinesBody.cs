public class TrainingRoutinesBody: TrainingRoutines
{
    private string _difficulty;
    public TrainingRoutinesBody(string difficulty, int duration) : base( difficulty, duration)
    {
        _difficulty = difficulty;
    }

    public override void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the This Body exercises. \n");
        Console.WriteLine($"We will start by Abs exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectAbsExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
        Console.WriteLine($"Now continue with Back exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectBackExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
        Console.WriteLine($"\nAnd we will finish with  Biceps exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectBicepsExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
    }
    public void SelectAbsExercise(string Dificultad)
    {
        // Dictionary of exercises and their steps
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Hollow Body Hold", "1. Lie on your back with your arms extended overhead and your legs straight.\n2. Lift your arms, head, shoulders, and legs a few inches off the ground, creating a slight U-shape with your body. Hold this position."},
            {"Dragon Flags", "1. Lie on a bench or a stable surface with your upper body hanging off the edge and your hands gripping the bench behind your head.\n2. Lift your legs and lower your body toward the ground in a controlled manner, then push back up to the starting position."},
            {"V-Ups", "1. Lie on your back with your arms extended overhead and your legs straight.\n2. Simultaneously lift your upper body and legs, reaching your hands toward your feet to form a V shape.\n3. Lower your body back down without letting your hands or feet touch the ground."},

            {"Crunches", "1. Lie on your back with your knees bent and feet flat on the floor.\n2. Place your hands behind your head or cross them over your chest.\n3. Curl your upper body off the floor, exhaling as you lift, and inhale as you lower back down."},
            {"Leg Raises", "1. Lie on your back with your legs straight.\n2. Lift your legs upward toward the ceiling without bending your knees, then lower them back down without letting them touch the floor."},
            {"Plank", "1. Start in a push-up position with your arms straight.\n2. Lower your forearms to the floor, elbows directly beneath your shoulders.\n3. Keep your body in a straight line from head to heels, engaging your core muscles. Hold this position."},
            {"Bicycle Crunches", "1. Lie on your back with your hands behind your head.\n2. Lift your shoulder blades off the ground and bring your right elbow toward your left knee while straightening your right leg.\n3. Switch sides in a pedaling motion, bringing your left elbow toward your right knee."},

            {"Mountain Climbers", "1. Start in a push-up position with your arms straight.\n2. Alternate bringing your knees in toward your chest, as if you're climbing a mountain, while keeping your back flat."},
            {"Flutter Kicks", "1. Lie on your back with your hands under your glutes or resting at your sides.\n2. Lift your legs off the ground a few inches.\n3. Alternately kick your legs up and down in a fluttering motion, engaging your lower abdominal muscles."},
            {"Reverse Crunches", "1. Lie on your back with your hands by your sides or under your glutes for support.\n2. Lift your legs toward the ceiling, then curl your hips off the ground, bringing your knees toward your chest."}
        };
        // List of exercises based on the selected difficulty
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "Neginner":
                selectedExercises.AddRange(new string[] { "Crunches", "Leg Raises", "Plank", "Bicycle Crunches" });
                break;
            case "Intermediate":
                selectedExercises.AddRange(new string[] { "Mountain Climbers", "Flutter Kicks", "Reverse Crunches" });
                break;
            case "Advanced":
                selectedExercises.AddRange(new string[] { "Hollow Body Hold", "Dragon Flags", "V-Ups" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }
        DisplayRandomExercise(selectedExercises,exercises );
    }

    public void SelectBackExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Bent Over Dumbbell Rows", "1. Stand with your feet shoulder-width apart, holding a dumbbell in each hand.\n2. Bend your knees slightly and hinge at your hips, keeping your back straight.\n3. Pull the dumbbells to your hips, then lower them back down."},
            {"Single-Arm Dumbbell Rows (Supported)", "1. Place one knee and one hand on a bench and hold a dumbbell in the opposite hand.\n2. Pull the dumbbell to your hip by bending your elbow, then lower it back down."},
            {"Towel Pull-Ups", "1. Hang a towel over a pull-up bar and grab each end with your hands.\n2. Perform pull-ups, using the towel for grip, by pulling your body up until your chin passes the bar, then lower yourself back down."},

            {"Pull-Ups (Wide Grip)", "1. Grab a pull-up bar with an overhand grip, hands wider than shoulder-width apart.\n2. Pull your body up until your chin passes the bar, then lower yourself back down."},
            {"Chin-Ups (Underhand Grip)", "1. Grab a pull-up bar with an underhand grip, hands shoulder-width apart.\n2. Pull your body up until your chin passes the bar, then lower yourself back down."},
            {"Barbell Deadlifts", "1. Stand with your feet shoulder-width apart and a barbell on the ground in front of you.\n2. Bend your knees, lower your body, and grasp the bar with an overhand grip.\n3. Lift the bar by straightening your hips and knees, keeping your back straight, then lower it back down."},

            {"Bodyweight Rows", "1. Use a sturdy horizontal bar or a Smith machine at waist height.\n2. Grab the bar with an overhand grip and walk your feet forward, leaning back slightly.\n3. Pull your chest toward the bar, then lower yourself back down."},
            {"Dumbbell Rows", "1. Stand with a dumbbell in each hand, palms facing your thighs.\n2. Bend your knees slightly and bend forward at the waist.\n3. Pull the dumbbells to your hips by bending your elbows, then lower them back down."},
            {"Lat Pulldowns", "1. Use a cable machine with a wide bar attachment.\n2. Sit down and grab the bar with an overhand grip, hands wider than shoulder-width apart.\n3. Pull the bar down to your chest, then slowly release it back up."},
            {"Face Pulls", "1. Attach a rope attachment to a high pulley at the gym.\n2. Grab the rope with both hands and pull it toward your face, keeping your upper arms parallel to the ground.\n3. Release the rope back to the starting position."},
            {"Superman Exercise", "1. Lie face down on the floor with your arms extended in front of you.\n2. Lift your arms, chest, and legs off the ground, squeezing your back muscles at the top.\n3. Lower back down and repeat."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Bodyweight Rows", "Dumbbell Rows", "Lat Pulldowns", "Face Pulls", "Superman Exercise" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Bent Over Dumbbell Rows", "Single-Arm Dumbbell Rows (Supported)", "Towel Pull-Ups" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Pull-Ups (Wide Grip)", "Chin-Ups (Underhand Grip)", "Barbell Deadlifts" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }

        DisplayRandomExercise(selectedExercises,exercises );
    }
    public void SelectBicepsExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Concentration Curls", "1. Sit on a chair or bench, holding a household item in one hand.\n2. Rest your elbow against your inner thigh and curl the item toward your shoulder, then lower it back down."},
            {"Bicep Curl with Static Hold", "1. Hold a household item in each hand and curl one arm up to your shoulder.\n2. Hold the curl position with one arm while you continue to curl with the other arm, alternating sides."},
            {"Zottman Curls", "1. Hold a household item in each hand with palms facing upward.\n2. Curl the items toward your shoulders, then rotate your palms downward at the top of the movement before lowering them back down."},

            {"Chin-Ups (Underhand Grip)", "1. Find a sturdy bar at a height where you can hang freely.\n2. Grab the bar with your palms facing toward you and your hands shoulder-width apart.\n3. Pull your body up until your chin passes the bar, then lower yourself back down."},
            {"Towel Pull-Ups", "1. Hang a towel over a bar and grab each end with your hands.\n2. Perform pull-ups by pulling your body up until your chin passes the bar, then lower yourself back down."},
            {"Bodyweight Bicep Curls", "1. Stand facing a wall at arm's length.\n2. Place your hands on the wall at shoulder height.\n3. Lean your body weight into your hands, then push back, engaging your biceps in a curling motion."},

            {"Bicep Curls with Household Items", "1. Hold a household item in each hand (such as water bottles, canned goods, or bags of rice).\n2. Stand with your feet shoulder-width apart and your arms fully extended.\n3. Curl the items toward your shoulders by bending your elbows, then lower them back down."},
            {"Hammer Curls", "1. Hold a household item in each hand with your palms facing your thighs.\n2. Curl the items toward your shoulders while keeping your palms facing inward, then lower them back down."},
            {"Isometric Bicep Holds", "1. Stand with your arms extended at your sides, holding household items in each hand.\n2. Curl your arms to 90-degree angles and hold the position, engaging your biceps for a set duration (e.g., 30 seconds)."},
            {"Reverse Bicep Curls", "1. Hold a household item in each hand with your palms facing downward.\n2. Curl the items toward your shoulders, focusing on the back of your arms, then lower them back down."},
            {"Towel Bicep Curls", "1. Hold a towel with both hands, gripping it shoulder-width apart.\n2. Step on the middle of the towel with one foot.\n3. Curl the towel toward your shoulders by bending your elbows, then lower it back down."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Bicep Curls with Household Items", "Hammer Curls", "Isometric Bicep Holds", "Reverse Bicep Curls", "Towel Bicep Curls" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Concentration Curls", "Bicep Curl with Static Hold", "Zottman Curls" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Chin-Ups (Underhand Grip)", "Towel Pull-Ups", "Bodyweight Bicep Curls" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }

        DisplayRandomExercise(selectedExercises,exercises );
    }
}