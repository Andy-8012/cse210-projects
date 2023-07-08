public class ChecklistGoal : Goal {

    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base(name,description,points){
        _target = target;
        _bonus = bonus;
    }
    public ChecklistGoal(string name, string description, string points, int target, int bonus,int amountCompleted) : base(name,description,points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override void RecordEvent(){
        int pointsEarned;
        _amountCompleted += 1;
        if (_amountCompleted == _target){
            pointsEarned = _bonus + int.Parse(_points);
        }
        else{
            pointsEarned = int.Parse(_points);
        }

        Console.WriteLine($"Congratulation! You have earned {pointsEarned} points!");

    }

    public override bool IsComplete(){
        if (_amountCompleted >= _target){
            return true;
        }
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{_target}";
    }

}