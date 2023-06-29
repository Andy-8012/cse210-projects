class BreathingActivity : Activity {

    public BreathingActivity(string name, string description) : base(name,description){

    }

    public void Run(){
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        _currentTime = DateTime.Now;
        _endTime = _currentTime.AddSeconds(_duration);

        while (_currentTime < _endTime){
            Console.WriteLine();
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            Console.WriteLine();
            Console.Write("Breathe out... ");
            ShowCountDown(6);
            Console.WriteLine();
            _currentTime = DateTime.Now;
        }

        DisplayEndingMessgae();
    }

}