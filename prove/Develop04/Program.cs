string input = "0";
    Console.WriteLine("Welcome to this Mindfulness Activity program");
        void Menu()
        {   
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity.");
            Console.WriteLine(" 2. Start reflecting activity.");
            Console.WriteLine(" 3. Start listing activity.");
            Console.WriteLine(" 4. Quit.");
            Console.WriteLine("Select a choice from the menu: ");
            input = Console.ReadLine()!;
        }

        Activity a1 = new Activity(); // To Showing Creativity and Exceeding Requirements I made validate all the entries.
        
        while(input != "4")
        {
            Menu();

            switch (input) {
                case "1":
                    Console.Clear();
                    BreathingActivity b1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on you breathing");
                    b1.DisplayStartingMessage();
                    b1.Run();
                    b1.DisplayEndingMessage();
                    break;
                
                case "2":
                    Console.Clear();
                    ReflectingActivity r1 = new ReflectingActivity("Reflection Activity", "This activity will help ypu reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");
                    r1.DisplayStartingMessage(); // and Make sure no random prompts/questions are selected until they have all been used at least once in that session
                    r1.Run();
                    r1.DisplayEndingMessage();
                    break;
                
                case "3":
                    Console.Clear();
                    ListingActivity l1 = new ListingActivity("Listing Activity", "This activity will help ypu reflect on the good things in your life by having a list as many things as you can in a certain area");
                    l1.DisplayStartingMessage();
                    l1.Run();
                    l1.DisplayEndingMessage();
                    break;
                default:
                    Console.WriteLine("that is not a valid number, Please enter a number between 1 and 4.");
                break;
            }
        }
