class ReflectingActivity : Activity{

    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();
    private Random randomGenerator = new Random();


    public ReflectingActivity(string name, string description) : base(name,description){
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }


    public void Run(){
        DisplayStartingMessage();

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);

        DisplayPrompt();

        Console.WriteLine();

        DisplayQuestions();

        DisplayEndingMessgae();
    }

    private string GetRandomPrompt(){
        string prompt = "";
        int randomPrompt = randomGenerator.Next(0,3);
        prompt = _prompts[randomPrompt];
        return prompt;
    }

    private string GetRandomQuestion(){
        string question = "";
        int randomQuestion = randomGenerator.Next(0,8);
        question = _questions[randomQuestion];
        return question;
        }

    public void DisplayPrompt(){
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($" --- {GetRandomPrompt()} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.Read();
    }

    public void DisplayQuestions(){
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You will begin in: ");
        ShowCountDown(5);
        Console.Clear();

        _currentTime = DateTime.Now;
        _endTime = _currentTime.AddSeconds(_duration);

        while (_currentTime < _endTime){
            Console.Write($"> {GetRandomQuestion()} ");
            ShowSpinner(10);
            Console.WriteLine();
            _currentTime = DateTime.Now;
        }
    }

}