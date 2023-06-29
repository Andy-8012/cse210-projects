class ListingActivity : Activity {

    private int _count;
    private List<string> _prompts = new List<string>();
    private Random randomGenerator = new Random();

    public ListingActivity(string name, string description) : base(name,description){
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run(){
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        _count = GetListFromUser().Count();
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessgae();

    }

    public string GetRandomPrompt(){
        string prompt = "";
        int randomPrompt = randomGenerator.Next(0,4);
        prompt = _prompts[randomPrompt];
        return prompt;
    }

    public List<string> GetListFromUser(){
        List<string> userList = new List<string>();
        _currentTime = DateTime.Now;
        _endTime = _currentTime.AddSeconds(_duration);

        while (_currentTime < _endTime){
            Console.Write("> ");
            string userInput = Console.ReadLine();
            userList.Add(userInput);
            _currentTime = DateTime.Now;
        }
        return userList;
    }

}