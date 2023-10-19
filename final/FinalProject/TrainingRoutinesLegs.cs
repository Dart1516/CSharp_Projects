public class TrainingRoutinesLegs: TrainingRoutines
{
    private string _difficulty;
    public TrainingRoutinesLegs(string difficulty, int duration) : base( difficulty, duration)
    {
    _difficulty = difficulty;
    }

    public override void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the This Body exercises. \n");
        Console.WriteLine($"We will start by Calves exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectCalvesExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
        Console.WriteLine($"Now continue with Femoral exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectFemoralExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
        Console.WriteLine($"Now continue with Quads exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectQuadsExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
        Console.WriteLine($"\nAnd we will finish with  Hamstrings exercise. \n");
        Console.WriteLine($"Get ready..." );
        ShowCountDown(5);
        SelectHamstringsExercise(_difficulty);
        ExerciseRepetition();
        ShowSpinner(3);
    }
    public void SelectCalvesExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Calf Raises on an Elevated Surface", "1. Stand on an elevated surface such as a step or a block, with your heels hanging off the edge.\n2. Lift your heels as high as you can, then lower them below the step level to get a full range of motion.\n3. Use a wall or rail for balance if needed."},
            {"Calf Raises with Towel", "1. Stand with your feet hip-width apart and place a small towel under the balls of both feet.\n2. Use your toes to scrunch the towel as you raise your heels, then lower them back down.\n3. This exercise helps work the muscles along the front of the shins (anterior tibialis) as well."},
            
            {"Single-Leg Calf Raises", "1. Stand on one leg near a wall or something stable for support.\n2. Lift the heel of your supporting foot as high as possible, then lower it back down.\n3. Perform all the repetitions on one leg before switching to the other."},
            {"Calf Raises with Jump", "1. Start in a standing position with your feet hip-width apart.\n2. Perform a regular calf raise, but as you lift your heels, explode into a jump, reaching upward.\n3. Land softly on the balls of your feet, then immediately go into the next repetition."},
            {"Calf Raises with Resistance Band", "1. Sit on the ground with your legs extended straight out and loop a resistance band around the balls of your feet.\n2. Hold the ends of the band in your hands and create tension.\n3. Point your toes and flex your feet against the resistance band, working your calf muscles."},

            {"Standing Calf Raises", "1. Stand with your feet hip-width apart near a wall or something stable for support.\n2. Lift your heels off the ground as high as you can, then lower them back down.\n3. Repeat the motion, focusing on contracting your calf muscles."},
            {"Seated Calf Raises", "1. Sit on a chair or bench with your feet flat on the ground.\n2. Lift your heels off the ground, flexing your calf muscles, then lower them back down.\n3. You can place a weight on your thighs for added resistance."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Standing Calf Raises", "Seated Calf Raises" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Calf Raises on an Elevated Surface", "Calf Raises with Towel" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Single-Leg Calf Raises", "Calf Raises with Jump", "Calf Raises with Resistance Band" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }
        DisplayRandomExercise(selectedExercises,exercises );
    }

    public void SelectFemoralExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Walking Lunges", "1. Step forward with your right foot into a lunge, then bring your left foot to meet your right foot.\n2. Repeat the lunge motion, walking forward with each step."},
            {"Step-Ups", "1. Use a sturdy bench or elevated surface.\n2. Step up onto the bench with your right foot, then bring your left foot to meet it.\n3. Step back down and repeat, alternating legs."},
            {"Reverse Lunges", "1. Step backward with your right foot into a lunge, bending both knees at 90-degree angles.\n2. Push off the back foot to return to the standing position, then alternate legs."},

            {"Pistol Squats", "1. Stand on your left leg with your right leg extended forward.\n2. Lower your body into a squat on the left leg while keeping your right leg straight and parallel to the ground.\n3. Push back up to the starting position and repeat, then switch legs."},
            {"Bulgarian Split Squats", "1. Stand a few feet away from a bench or elevated surface.\n2. Extend your right leg behind you and place the top of your foot on the bench.\n3. Lower your body into a lunge, then push back up to the starting position. Repeat on the other leg."},
            {"Single-Leg Glute Bridges", "1. Lie on your back with your knees bent and feet flat on the floor.\n2. Lift one foot off the ground and perform a glute bridge using the other leg, then switch legs."},

            {"Bodyweight Squats", "1. Stand with your feet shoulder-width apart.\n2. Lower your body as if you were going to sit in a chair, keeping your chest up and your knees aligned with your toes.\n3. Push through your heels to return to the starting position."},
            {"Lunges", "1. Step forward with your right foot into a lunge, bending both knees at 90-degree angles.\n2. Push off the front foot to return to the standing position, then alternate legs."},
            {"Glute Bridges", "1. Lie on your back with your knees bent and feet flat on the floor.\n2. Lift your hips toward the ceiling, squeezing your glutes at the top of the movement.\n3. Lower your hips back down without touching the ground and repeat."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Bodyweight Squats", "Lunges", "Glute Bridges" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Walking Lunges", "Step-Ups", "Reverse Lunges" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Pistol Squats", "Bulgarian Split Squats", "Single-Leg Glute Bridges" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }

        DisplayRandomExercise(selectedExercises,exercises );
    }
    public void SelectHamstringsExercise(string Dificultad)
    {
        // Dictionary of exercises and their steps
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Single-Leg Romanian Deadlifts", "1. Stand on one leg with a slight bend in your knee.\n2. Hinge at your hips and lower your upper body toward the ground while extending your free leg straight behind you for balance.\n3. Return to the starting position and repeat, then switch legs."},
            {"Walking Lunges (with Forward Reach)", "1. Step forward with your right foot into a lunge while reaching both arms forward.\n2. Push off the front foot and bring your left foot to meet your right foot while swinging your arms back.\n3. Repeat the lunge motion, walking forward with each step and alternating arms."},
            
            {"Nordic Hamstring Curl (Partner Assisted)", "1. Kneel on the ground with your feet secured under a heavy object or have a partner hold your ankles.\n2. Lower your upper body toward the ground, keeping your back straight, then push back up to the starting position using your hamstrings."},
            {"Slider Hamstring Curls", "1. Lie on your back with your heels on sliders (or a smooth surface like a hardwood floor).\n2. Lift your hips toward the ceiling, then slide your feet toward your glutes, engaging your hamstrings.\n3. Extend your legs back out and repeat the sliding motion."},
            {"Bear Crawls", "1. Start on your hands and knees with your hips lifted toward the ceiling.\n2. Crawl forward by moving your opposite hand and foot, keeping your knees close to the ground.\n3. Focus on engaging your hamstrings to control the movement."},

            {"Bodyweight Leg Curls", "1. Lie on your stomach with your legs straight.\n2. Bend your knees and bring your heels toward your glutes as far as you can, then straighten your legs back out."},
            {"Glute Bridges (Single-Leg Variation)", "1. Lie on your back with your knees bent and feet flat on the floor.\n2. Lift one foot off the ground and perform a glute bridge using the other leg, then switch legs."},
            {"Seated Leg Raises", "1. Sit on the edge of a sturdy chair or bench with your legs extended straight out in front of you.\n2. Lift your legs off the ground as high as you can, then lower them back down without letting them touch the floor."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Bodyweight Leg Curls", "Glute Bridges (Single-Leg Variation)", "Seated Leg Raises" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Single-Leg Romanian Deadlifts", "Walking Lunges (with Forward Reach)" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Nordic Hamstring Curl (Partner Assisted)", "Slider Hamstring Curls", "Bear Crawls" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }
        DisplayRandomExercise(selectedExercises,exercises );
    }
     public void SelectQuadsExercise(string Dificultad)
    {
        Dictionary<string, string> exercises = new Dictionary<string, string>
        {
            {"Bulgarian Split Squats", "1. Stand a few feet away from a bench or elevated surface.\n2. Extend your right leg behind you and place the top of your foot on the bench.\n3. Lower your body into a lunge, then push back up to the starting position. Repeat on the other leg."},
            {"Step-Ups", "1. Use a sturdy bench or elevated surface.\n2. Step up onto the bench with your right foot, then bring your left foot to meet it.\n3. Step back down and repeat, alternating legs."},

            {"Pistol Squats", "1. Stand on your left leg with your right leg extended forward.\n2. Lower your body into a squat on the left leg while keeping your right leg straight and parallel to the ground.\n3. Push back up to the starting position and repeat, then switch legs."},
            {"Jumping Lunges", "1. Start in a lunge position with your right foot forward.\n2. Jump explosively into the air, switching your legs mid-air and landing in a lunge position with your left foot forward.\n3. Continue alternating legs with each jump."},
            {"Sissy Squats", "1. Stand with your feet close together and your hands on your hips.\n2. Lower your body backward, bending your knees and keeping your heels on the ground.\n3. Continue lowering yourself as far as your flexibility allows, then return to the starting position."},

            {"Bodyweight Squats", "1. Stand with your feet shoulder-width apart.\n2. Lower your body as if you were going to sit in a chair, keeping your chest up and your knees aligned with your toes.\n3. Push through your heels to return to the starting position."},
            {"Lunges", "1. Step forward with your right foot into a lunge, bending both knees at 90-degree angles.\n2. Push off the front foot to return to the standing position, then alternate legs."},
            {"Wall Sits", "1. Lean your back against a wall and lower your body into a sitting position, as if you were sitting in an invisible chair.\n2. Hold this position, keeping your thighs parallel to the ground."}
        };
        List<string> selectedExercises = new List<string>();
        switch (Dificultad)
        {
            case "beginner":
                selectedExercises.AddRange(new string[] { "Bodyweight Squats", "Lunges", "Wall Sits" });
                break;
            case "intermediate":
                selectedExercises.AddRange(new string[] { "Bulgarian Split Squats", "Step-Ups" });
                break;
            case "advanced":
                selectedExercises.AddRange(new string[] { "Pistol Squats", "Jumping Lunges", "Sissy Squats" });
                break;
            default:
                Console.WriteLine("Invalid difficulty level.");
                return;
        }
        DisplayRandomExercise(selectedExercises,exercises );
    }
}