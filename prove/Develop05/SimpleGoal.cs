public class SimpleGoal : Goal
{
    private string _GoalTypes;
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, string goal) : base(name, description, points)
    {
        _GoalTypes = goal;
    }

    public override void RecordEvent()
    {
        if (IsComplete())
        {
            AddSetPointToCurrentPoint();
            SetCheckMark();
        }
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override void SetIsCompleteToTrue()
    {
        _isComplete = true;
    }

    public override string GetStringRepresentation()
    {
        return $"{_GoalTypes}: {_shortName} | {_description} | {_setPoints} | {IsComplete()}";
    }
}