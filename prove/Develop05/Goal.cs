public abstract class Goal 
{
    private string _shortName;
    private string _description;
    private string _points;
    private string _my_file;
    


    public  Goal()
    {
    }
    public  Goal(string name, string description, string point)
    {
    }

    public abstract void RecordEvent(Goal otro);
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation(Goal otro);
    
    public abstract string GetDetailsString(Goal otro);
    public void SetName(string name)
    {
        _shortName = name;
    }
    public string GetName()
    {
        return _shortName;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDescription()
    {
        return _description;
    }
    public void SetPoints(string points)
    {
        _points = points;
    }
    public string GetPoints()
    {
        return _points;
    }
    public virtual int GetBonus()
    {
        return -1;
    }
    public virtual void SetBonus(int bonus)
    {

    }
    public virtual int GetAmountCompleted()
    {
        return -1;
    }
    public virtual void SetAmountCompleted(int amountCompleted)
    {

    }
    public virtual int GetTarget()
    {
        return -1;
    }
    public virtual void SetTarget(int target)
    {

    }

    public void SetMyFile(string FileName)
    {
        _my_file = FileName;
    }
    public string GetMyFile()
    {
        return _my_file;
    }

}