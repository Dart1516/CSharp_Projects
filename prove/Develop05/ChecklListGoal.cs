public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public CheckListGoal()
    {
    }
    public CheckListGoal(string name, string description, string points,int bonus ,int target ): base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(Goal linea)
    {
        Console.WriteLine($"You earn: {linea.GetPoints()}");
    }
    public override bool IsComplete()
    {
        return true;
    }
    public override string GetDetailsString(Goal linea)
    {
        return $"[ ] {linea.GetName()} ({linea.GetDescription()}) Currently Completed: {linea.GetAmountCompleted()}/{linea.GetTarget()}";
    }
    public override string GetStringRepresentation(Goal linea)
    {
        return $"{linea}:{linea.GetName()},{linea.GetDescription()},{linea.GetPoints()},{linea.GetBonus()},{linea.GetTarget()},{linea.GetAmountCompleted()}"; 
    }
    public override int GetTarget()
    {
        return _target;
    }
    public override void SetTarget(int target)
    {
        _target = target;
    }
    public override int GetAmountCompleted()
    {
        return _amountCompleted;
    }
    public override void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }
    public override int GetBonus()
    {
        return _bonus;
    }
    public override void SetBonus(int bonus)
    {
        _bonus = bonus;
    }   
}