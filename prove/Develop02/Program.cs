using System;


Console.WriteLine("");
Console.WriteLine("");

Journal to_write = new Journal();
Journal to_show_last_entries = new Journal();

PromptGeneration random_prompts = new PromptGeneration();

DateTime theCurrentTime = DateTime.Now;
Entry newEntry = new Entry();
newEntry._date = theCurrentTime.ToShortDateString();

//Entry listaPrueba = new Entry();
List<string> list_to_store_temporarily_my_entries = new List<string>();

string validation_answers;
string validation_loop_on_going;

Console.WriteLine("Welcome to the Journal Program!");
Console.WriteLine("Please write a number from 1 to 6 to select one of the following options: ");

string app_on = "yes";
do
{
    Console.WriteLine("1._ Write a new entry");
    Console.WriteLine("2._ Display currents entries");
    Console.WriteLine("3._ Delete currents entries");
    Console.WriteLine("4._ Load an display older Entries");
    Console.WriteLine("5._ Save entries in a journal");
    Console.WriteLine("6._ Quit");
    Console.WriteLine("");
    Console.WriteLine("What we are doing today?:");
    Console.WriteLine("");

    string my_choice = Console.ReadLine()!;
    string generate_random_prompts = random_prompts.GetRandomPrompt();
    newEntry._promptText = generate_random_prompts;


    if (my_choice == "1")
    {
        Console.WriteLine($"{newEntry._promptText} (Press enter to finish): ");
        newEntry._entryText = Console.ReadLine()!;
        //newEntry.DisplayEntry();
        list_to_store_temporarily_my_entries.Add($"{newEntry._date} - {generate_random_prompts}");
        list_to_store_temporarily_my_entries.Add(newEntry._entryText);
        list_to_store_temporarily_my_entries.Add("----------------------------------------");
        list_to_store_temporarily_my_entries.Add("");
        Console.WriteLine("Entry registered");
        Console.WriteLine("");


    }

    else if (my_choice == "2")
    {
        if (list_to_store_temporarily_my_entries.Count < 1)
        {
            Console.WriteLine("I'm sorry, you don't have any entry yet.");
            Console.WriteLine("Do you want to do something else?: ");

        }
        else
        {
            Console.WriteLine("The entries you have write so fare are: ");
            foreach (string each_entry in list_to_store_temporarily_my_entries)
            {
                Console.WriteLine(each_entry);
            }
        }
        Console.WriteLine("");
    }

    else if (my_choice == "3")
    {
        Console.WriteLine("");
        if (list_to_store_temporarily_my_entries.Count < 1)
        {
            Console.WriteLine("I'm sorry, you don't have any entry to delete yet.");
            Console.WriteLine("");
            Console.WriteLine("Do you want to do something else?: ");
        }
        else
        {
            Console.WriteLine("");
            validation_loop_on_going = "yes";
            do
            {
                Console.WriteLine("Do you want to delete all your current entries? (y/n): ");
                validation_answers = Console.ReadLine()!;
                if (validation_answers == "y")
                {//https://www.techiedelight.com/es/delete-all-items-from-a-list-in-csharp/#:~:text=Una%20soluci%C3%B3n%20simple%20y%20directa,Clear()%20m%C3%A9todo.
                    list_to_store_temporarily_my_entries.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("All current not saved entries were deleted.");
                    validation_loop_on_going = "no";

                }
                else
                {

                    validation_loop_on_going = validation_method(validation_loop_on_going, validation_answers);
                }
            } while (validation_loop_on_going == "yes");
        }
    }
    else if (my_choice == "4")
    {
        Console.WriteLine("");
        Console.WriteLine("Please enter the name of the journal you would like to open: ");
        string journal_name = Console.ReadLine()!;

        if (File.Exists(journal_name))
        {
            to_show_last_entries._my_file = journal_name;
            to_write._my_file = journal_name;
            to_show_last_entries.DisplayAll();
            Console.WriteLine("");
            Console.WriteLine($"Journal {journal_name} loaded");
            list_to_store_temporarily_my_entries.Clear();
            Console.WriteLine("Do you want to do something else?: ");
            Console.WriteLine("");
        }
        else //if does not exist we are going to create
        {
            Console.WriteLine($"There is not exist a {journal_name} file.");
            validation_loop_on_going = "yes";
            do
            {
                Console.WriteLine($"Would you like to create a journal called {journal_name} (y/n): ");
                validation_answers = Console.ReadLine()!;
                if (validation_answers == "y")
                {
                    to_write._my_file = journal_name;
                    to_write.creating_a_file();
                    list_to_store_temporarily_my_entries.Clear();
                    Console.WriteLine($"The {journal_name} has been created.");
                    Console.WriteLine("");
                    validation_loop_on_going = "no";
                }
                else
                {

                    validation_loop_on_going = validation_method(validation_loop_on_going, validation_answers);
                }
            } while (validation_loop_on_going == "yes");
        }
    }
    else if (my_choice == "5")
    {
        Console.WriteLine("");
        Console.WriteLine("Enter the name of the journal to save the entries. ");
        to_write._my_file = Console.ReadLine()!;
        if (File.Exists(to_write._my_file))
        {
            validation_loop_on_going = "yes";
            do
            {
                Console.WriteLine($"Already exist a {to_write._my_file} Are you sure you wish overwrite it?: (y/n) ");
                validation_answers = Console.ReadLine()!;
                if (validation_answers == "y")
                {
                    validation_loop_on_going = "no";
                    foreach (string a_entry in list_to_store_temporarily_my_entries)
                    {
                        to_write._written_entry = a_entry;
                        to_write.SaveToFile(generate_random_prompts, newEntry._date);
                    }
                }
                else
                {

                    validation_loop_on_going = validation_method(validation_loop_on_going, validation_answers);
                }

            } while (validation_loop_on_going == "yes");

        }
        else //if does not exist we are going to create
        {
            Console.WriteLine($"There is not exist a {to_write._my_file} Journal");
            validation_loop_on_going = "yes";
            do
            {
                Console.WriteLine($"Would you like to create a journal called {to_write._my_file}: (y/n)");
                validation_answers = Console.ReadLine()!;
                if (validation_answers == "y")
                {
                    to_write.creating_a_file();
                    if (list_to_store_temporarily_my_entries.Count > 0)
                        foreach (string a_entry in list_to_store_temporarily_my_entries)
                        {
                            to_write._written_entry = a_entry;
                            to_write.SaveToFile(generate_random_prompts, newEntry._date);
                        }
                    validation_loop_on_going = "no";
                }
                else
                {

                    validation_loop_on_going = validation_method(validation_loop_on_going, validation_answers);
                }

            } while (validation_loop_on_going == "yes");

        }
        Console.WriteLine($"{to_write._my_file} has been saved.");
        Console.WriteLine("");
    }
    else if (my_choice == "6")
    {
        Console.WriteLine("");
        app_on = "no";
        Console.WriteLine("See you next time.");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("This is not a valid answer, please digit a number between 1 to 6.");
        Console.WriteLine("");
    }

} while (app_on == "yes");
string validation_method(string loop, string answer)
{
    if (answer == "n")
    {
        Console.WriteLine("Do you want to do something else?: ");
        loop = "no";
        return loop;
    }
    else
    {
        Console.WriteLine("Invalid input, please answer with the letter (y) or (n) to continue.");
        Console.WriteLine("");
        return loop;
    }



}
