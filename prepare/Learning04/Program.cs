namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        //5._Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.

        Assignments A1 = new Assignments("Samuel Bennett ", "Multiplication");
        Console.WriteLine($"{A1.GetSummary()}");
        //9._Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods
        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine($"{m1.GetSummary()}");
        Console.WriteLine($"{m1.GetHomeworkList()}");
        //13._Return to Main and test your new class.
        WritingAssignment w1 = new WritingAssignment("Mary Waters","European History","The Causes of World War II ");
        Console.WriteLine($"{w1.GetSummary()}");
        Console.WriteLine($"{w1.GetWritingINformation()}");


    }
}