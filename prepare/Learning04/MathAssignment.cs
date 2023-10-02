// 6._Create this class and make sure to specify that it inherits from the base Assignment class.
public class MathAssignment : Assignments 
{
    private string _textbookSection;
    private string _problems;

//7._Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
    public MathAssignment(string studentName, string topic, string textbookSection, string problems ) : base (studentName, topic)
    {
        _problems = problems;
        _textbookSection = textbookSection;
    }
//8._Add the GetHomeworkList() method.
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems} ";
    }

}