public class Adventurer {

    private int _health;
    private int _damage;
    private string _name;
    private Weapon weapon;

    public Adventurer(string name){
        _name = name;
        _health = 100;
        _damage = 5;
    }

    public void BasicAttack(Monster monster){
        Console.WriteLine($"You attacked the {monster.GetName()} for {_damage} damage.");
        int currentHealth = monster.GetHealth();
        int afterAttackHealth = currentHealth - _damage;
        monster.SetHealth(afterAttackHealth);
        Console.WriteLine($"The {monster.GetName()} has {monster.GetHealth()} health left.");
    }

    public void SpecialAttack(Monster monster){
        int totalDamage = _damage + weapon.GetDamage() * 2;
        Console.WriteLine($"You attacked the {monster.GetName()} for {totalDamage} damage. That was a {weapon.GetElement()} hit!");
        int currentHealth = monster.GetHealth();
        int afterAttackHealth = currentHealth - totalDamage;
        monster.SetHealth(afterAttackHealth);
        Console.WriteLine($"The {monster.GetName()} has {monster.GetHealth()} health left.");
    }

    public void Run(Monster monster){
        Console.WriteLine("Congradulations you ran away! However the monster still attacked you once.");
        monster.SetHealth(0);
    }

    public string GetName(){
        return _name;
    }

    public int GetHealth(){
        return _health;
    }

    public void SetHealth(int health){
        _health = health;
    }

    public void CreateWeapon(){
        Console.WriteLine("Which weapon would you like to use:");
        Console.WriteLine("   1. Bow");
        Console.WriteLine("   2. Sword");

        string userInput = Console.ReadLine();
        if (userInput == "1"){
            weapon = new Bow(3,"fire");
            Console.Clear();
            Console.WriteLine("You received a bow with the fire element.");
            Console.WriteLine();
        }
        else if (userInput == "2"){
            Console.Clear();
            weapon = new Sword(2, "poison");
            Console.WriteLine("You received a sword with the poison element.");
            Console.WriteLine();
        }
        else {
            Console.Clear();
            Console.WriteLine("Please enter a valid option.");
            CreateWeapon();
        }
    }
}