public class SimpleGoal : Goal {

    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name,description,points){

    }
    public SimpleGoal(string name, string description, string points, string isComplete) : base(name,description,points){
        if (isComplete == "True"){
            _isComplete = true;
        }
    }

    public override void RecordEvent(){
        Console.WriteLine($"Congratulation! You have earned {_points} points!");
        _isComplete = true;
    }

    public override bool IsComplete(){
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName},{_description},{_points},{_isComplete}";
    }

}