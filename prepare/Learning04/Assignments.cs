//1._Begin by creating a new file and a class for your base Assignment class.
public class Assignments
{
    // 2._Add the attributes as private member variables
    protected string _studentName;
    private string _topic;

    public Assignments () // Esta fue creada para que pueda pasar  
    {
        _studentName = "Anonymous";
        _topic = "Unknown";
    }
    // 3._Create a constructor for this class that receives a student name and topic and sets the member variables
    public Assignments(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // 4._Add the method for GetSummary() to return the student's name and the topic.

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}