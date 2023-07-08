public abstract class Goal {

    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points){
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString(){
        string detailString;
        if (IsComplete()){
            detailString = $"[X] {_shortName} ({_description})";
        }
        else{
            detailString = $"[ ] {_shortName} ({_description})";
        }
        return detailString;
    }

    public string getShortName(){
        return _shortName;
    }

    public int getPoints(){
        int points = int.Parse(_points);
        return points;
    }

}