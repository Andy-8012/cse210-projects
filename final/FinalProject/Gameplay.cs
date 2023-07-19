public class Gameplay {

    protected int _score;
    protected Adventurer adventurer;
    Random randomGenerator = new Random();

    public Gameplay(){
    }

    public int GetScenario(){
        int randomInt = randomGenerator.Next(0,3);
        return randomInt;
    }

    public void Start(){
        Console.WriteLine("Welcome to the world of Tazmania!");
        Console.WriteLine("Who might you be?");
        string name = Console.ReadLine();
        adventurer = new Adventurer(name);
        Console.Clear();

        Console.WriteLine($"It is good to have you here {adventurer.GetName()}");

        string userInput = "";

        while (userInput != "y"){
            Console.WriteLine("We have been looking for a hero to save us from these monsters! Are you our hero? (y/n)");
            userInput = Console.ReadLine().ToLower();

            if (userInput == "y"){
                Console.Clear();
                Console.WriteLine("Awesome thank you so much!! We are so glad you are here!");
            }
            else {
                Console.WriteLine("Nope wrong answer. You are whether you like it or not. Try again.");
            }
        }

        Console.WriteLine("And so your adventure starts. Good luck!");
        Console.WriteLine("You will encounter many monsters on your journey try not to die!");
        Console.WriteLine();

        adventurer.CreateWeapon();

        AdventureBegins();

    }

    public void AdventureBegins(){
        while (adventurer.GetHealth() > 0){
            int scenario = GetScenario();

            switch(scenario){
                case 0:
                    Spider spider = new Spider("Spider");
                    spider.DisplayMonster();
                    
                    while (adventurer.GetHealth() > 0 & spider.GetHealth() > 0){
                        AdventurerMenu(spider);
                        int randomInt = randomGenerator.Next(0,10);
                        if (randomInt == 5) {
                            spider.SpecialAttack(adventurer);
                        }
                        else{
                            spider.BasicAttack(adventurer);
                        }
                    }

                    _score += 1;

                break;

                case 1:
                    Snake snake = new Snake("Snake");
                    snake.DisplayMonster();
                    while (adventurer.GetHealth() > 0 & snake.GetHealth() > 0){
                        AdventurerMenu(snake);
                        int randomInt = randomGenerator.Next(0,10);
                        if (randomInt == 5) {
                            snake.SpecialAttack(adventurer);
                        }
                        else{
                            snake.BasicAttack(adventurer);
                        }
                    }

                    _score += 1;

                break;

                case 2:
                    MagicalTree magicalTree = new MagicalTree("Magical Tree");
                    magicalTree.DisplayMonster();
                    while (adventurer.GetHealth() > 0 & magicalTree.GetHealth() > 0){
                        AdventurerMenu(magicalTree);
                        int randomInt = randomGenerator.Next(0,10);
                        if (randomInt == 5) {
                            magicalTree.SpecialAttack(adventurer);
                        }
                        else{
                            magicalTree.BasicAttack(adventurer);
                        }
                    }

                    _score += 1;

                break;
            }
        }
    }

    public void AdventurerMenu(Monster monster){
        Console.WriteLine("Please choose one of the following options: ");
        Console.WriteLine("   1. Attack");
        Console.WriteLine("   2. Run");
        Console.WriteLine("   3. Give up");

        string userInput = Console.ReadLine();

        if (userInput == "1"){
            int randomInt = randomGenerator.Next(0,10);
            if (randomInt == 5) {
                Console.Clear();
                adventurer.SpecialAttack(monster);
            }
            else{
                Console.Clear();
                adventurer.BasicAttack(monster);
            }
        }
        else if (userInput == "2"){
            int randomInt = randomGenerator.Next(0,4);
            if (randomInt == 2) {
                Console.Clear();
                adventurer.Run(monster);
            }
            else{
                Console.Clear();
                Console.WriteLine("You were not successful at running away.");
            }
        }
        else if (userInput == "3"){
            Console.WriteLine("You die. Thanks for playing");
            adventurer.SetHealth(0);
        }
        else{
            AdventurerMenu(monster);
        }
    }

    public int GetScore(){
        return _score;
    }

}