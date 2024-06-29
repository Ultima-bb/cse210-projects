abstract class Goal
{
    public string Name { get; protected set; }
    public int Points { get; protected set; }
    public bool IsCompleted { get; protected set; }

    public virtual void CompleteGoal()
    {
        IsCompleted = true;
    }

    public abstract string DisplayGoal();
}