class Activity {

    protected string _name;
    protected string _description;
    protected int _duration;
    protected DateTime _currentTime;
    protected DateTime _futureTime;
    protected DateTime _endTime;
    private bool _hideCountDown;

    public Activity(string name, string description){
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Would you like to hide the countdown in the Activites? y/n");
        if (Console.ReadLine().ToLower() == "y"){
            _hideCountDown = true;
        }
        else{
            _hideCountDown = false;
        }
    }

    public void DisplayEndingMessgae(){
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds){
        _currentTime = DateTime.Now;
        _futureTime = _currentTime.AddSeconds(seconds);

        while (_currentTime < _futureTime){
            Console.Write("|");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(300);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(300);
            Console.Write("\b \b");
            _currentTime = DateTime.Now;
        }
    }

    public void ShowCountDown(int seconds){
        if (_hideCountDown){
            while (seconds > 0){
            Thread.Sleep(1000);
            seconds -= 1;
        }
        }
        else{
            while (seconds > 0){
                Console.Write(seconds);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                seconds -= 1;
            }
        }

    }

}