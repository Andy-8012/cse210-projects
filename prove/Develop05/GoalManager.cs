public class GoalManager{

    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager(){

    }

    public void Start(){
        Console.Clear();
        int menuChoice = -1;

        while (menuChoice != 6){
        DisplayPlayerInfo();
        Console.WriteLine();
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
        menuChoice = int.Parse(Console.ReadLine());

        switch (menuChoice){
            case 1:
                Console.Clear();
                CreateGoal();
                break;

            case 2:
                Console.Clear();
                ListGoalDetails();
                break;

            case 3:
                Console.Clear();
                SaveGoals();
                break;

            case 4:
                Console.Clear();
                LoadGoals();
                break;

            case 5:
                Console.Clear();
                RecordEvent();
                break;

            case 6:
                Console.Clear();
                Console.WriteLine("Goodbye");
                break;

            default:
                Console.Clear();
                Console.WriteLine("Please choose a valid menu option");
                Console.WriteLine();
                break;

        }


        }
    }

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames(){
        Console.WriteLine("The goals are:");
            for (int i = 0; i < _goals.Count(); i++){
                int listNumber = i + 1;
                Console.WriteLine($"  {listNumber}. {_goals[i].getShortName()}");
        }
    }

    public void ListGoalDetails(){
        for (int i = 0; i < _goals.Count(); i++){
            int listNumber = i + 1;
            Console.WriteLine($"{listNumber}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal(){
        Console.WriteLine();
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which goal would you like to create: ");

        int goalChoice = int.Parse(Console.ReadLine());
        string goalName;
        string description;
        string points;
        int target;
        int bonus;

        switch (goalChoice){
            case 1:
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("How many points is this goal worth? ");
                points = Console.ReadLine();

                SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
                _goals.Add(simpleGoal);

                Console.Clear();

                break;

            case 2:
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("How many points is this goal worth? ");
                points = Console.ReadLine();

                EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
                _goals.Add(eternalGoal);

                Console.Clear();

                break;

            case 3:
                Console.Write("What is the name of your goal? ");
                goalName = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                description = Console.ReadLine();

                Console.Write("How many points is this goal worth? ");
                points = Console.ReadLine();

                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                target = int.Parse(Console.ReadLine());

                Console.Write($"What is the bonus for accomplishing it {target} times? ");
                bonus = int.Parse(Console.ReadLine());

                ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus);
                _goals.Add(checklistGoal);

                Console.Clear();

                break;

            default:
                Console.Clear();
                Console.WriteLine("Please enter a valid option");
                CreateGoal();
                break;
        }

    }

    public void RecordEvent(){
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int completedGoal = int.Parse(Console.ReadLine());
        
        if (completedGoal > _goals.Count()){
            Console.WriteLine("Please enter a valid option ");
            RecordEvent();
        }
        else{
            completedGoal -= 1;
            _goals[completedGoal].RecordEvent();
        }
        string[] goalInformation = _goals[completedGoal].GetStringRepresentation().Split(",");

        if(goalInformation.Count() > 4){
            if ( _goals[completedGoal].IsComplete()){
                int bonus = int.Parse(goalInformation[3]);
                _score += bonus;
            }
        }

        _score += _goals[completedGoal].getPoints();

        Console.WriteLine($"You now have {_score} points");
        Console.WriteLine();
        
    }

    public void SaveGoals(){
        string filename;

        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename)){
            outputFile.WriteLine(_score);

            foreach (Goal goal in _goals){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals(){
        string filename;

        Console.Write("What is the filename for the goal file? ");
        filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);

        foreach (string line in lines){
            string[] parts = line.Split(":");
            int partsLength = parts.Count();

            if (partsLength == 2){
                string goalType = parts[0];
                string[] goalInformation = parts[1].Split(",");

                if (goalType == "SimpleGoal"){
                    SimpleGoal simpleGoal = new SimpleGoal(goalInformation[0],goalInformation[1],goalInformation[2],goalInformation[3]);
                    _goals.Add(simpleGoal);
                }

                else if (goalType == "EternalGoal"){
                    EternalGoal eternalGoal = new EternalGoal(goalInformation[0],goalInformation[1],goalInformation[2]);
                    _goals.Add(eternalGoal);
                }
                else if (goalType == "ChecklistGoal"){
                    ChecklistGoal checklistGoal = new ChecklistGoal(goalInformation[0],goalInformation[1],goalInformation[2],int.Parse(goalInformation[4]),int.Parse(goalInformation[3]),int.Parse(goalInformation[5]));
                    _goals.Add(checklistGoal);
                }
            }

        }

    }

}