using System;

class Program
{
    static void Main(string[] args)
    {

// STEP 2 Start the Project
// Open the class project in VS Code.
// Navigate to the Learning02 project in the prepare folder. Find the Program.cs file, which will be your entry point for the program.
// Verify that you can run the project and see the beginning "Hello World" output.

//Console.WriteLine("Aca salen los primeros trabajos");
    Job job1 = new Job();
    job1._CompanyName = "Microsoft";
    job1._JobTitle = "Software Engineer";
    job1._StartYear = 2019;
    job1._EndYear = 2022;
//    job1.DisplaysJobInformation();

    Job job2 = new Job();
    job2._CompanyName = "Apple";
    job2._JobTitle = "Software Engineer";
    job2._StartYear = 2022;
    job2._EndYear = 2023;
    job2.DisplaysJobInformation();
    Console.WriteLine("");
    Console.WriteLine("------------------");
    Console.WriteLine("");
 //   Console.WriteLine("Aca sale el resumen");


    Resume resume1 = new Resume ();
    resume1._PersonName = "David Puche";
    resume1._ListJobs.Add(job1);
    resume1._ListJobs.Add(job2);

    resume1.DisplaysResume();

    }
}


/// STEP 1
/// You program should contain two classes one for a Job and one for the Resume itself, as follows:
///Class: Job
    //Responsibilities:
//Keeps track of the company, job title, start year, and end year.
//Behaviors:
//Displays the job information in the format "Job Title (Company) StartYear-EndYear", for example: "Software Engineer (Microsoft) 2019-2022".
/// </summary>
/// 

public class Job
{

    public int _StartYear ;
    public int _EndYear;
    public string _CompanyName= "";
    public string _JobTitle = "";

    public void DisplaysJobInformation()
    {
        Console.WriteLine($"{_JobTitle}, ({_CompanyName}) {_StartYear}-{_EndYear}");
    }
   

}
class Resume
{
    /// Class: Resume
    ///Responsibilities:
        ///Keeps track of the person's name and a list of their jobs.
    ///Behaviors:
        ///Displays the resume, which shows the name first, followed by displaying each one of the jobs.///
    ///Add a Display method to the Resume class
    //Return to your Resume class and add a method to display its details.
    //This method should not have any parameters and should not return anything.
    //In the method body, you should display the person's name and then iterate through each Job instance in the list of jobs and display them.
    //Hint: remember that you can call each job's Display method that you created earlier.
    //Return to your main function, remove any code that is displaying information, and instead, add a call at the end to the Display method from your Resume class to display the name and all the jobs in one line.
    
    
    public string _PersonName = "";
    public List<Job> _ListJobs = new List<Job>();

    public void DisplaysResume()
    {
        Console.WriteLine($"Name: {_PersonName}");
        Console.WriteLine("Jobs:");
        
        foreach (Job job in _ListJobs)
        {
            job.DisplaysJobInformation();
        }
    }
}

