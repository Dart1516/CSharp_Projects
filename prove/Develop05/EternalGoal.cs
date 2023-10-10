public class EternalGoal :Goal
{

    public EternalGoal() 
    {
    }    
    public EternalGoal(string name, string description, string points): base(name, description, points) 
    {

    }

    public override void RecordEvent(Goal linea)
    {
        Console.WriteLine($"You earn: {linea.GetPoints()}");
    }
    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }
    public override string GetDetailsString(Goal linea)
    {
        return $"[ ] {linea.GetName()} ({linea.GetDescription()})";
    }
    public override string GetStringRepresentation(Goal linea)
    {
        return $"{linea}:{linea.GetName()},{linea.GetDescription()},{linea.GetPoints()}"; 
    }

}