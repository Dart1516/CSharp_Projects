using System.Net.Http.Headers;

public class SimpleGoal: Goal
{
    private bool _isComplete;

    public SimpleGoal()
    {
    }
    public SimpleGoal(string name, string description, string points): base(name, description, points)
    {

    }
    public override void RecordEvent(Goal linea)
    {
        Console.WriteLine($"You earn: {linea.GetPoints()}");
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetDetailsString(Goal linea)
    {
        return $"[ ] {linea.GetName()} ({linea.GetDescription()})";
    }

    public override string GetStringRepresentation(Goal linea)
    {
        return $"{linea}:{linea.GetName()},{linea.GetDescription()},{linea.GetPoints()},{linea.IsComplete()}"; 
    }

}