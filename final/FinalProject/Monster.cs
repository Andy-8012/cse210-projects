public abstract class Monster {

    protected int _health;
    protected int _damage;
    protected string _name;
    protected string _specialAttackName;

    public Monster(string name){
        _name = name;
    }

    public virtual void BasicAttack(Adventurer adventurer){
        Console.WriteLine($"The {_name} attacked you for {_damage} damage.");
        int currentHealth = adventurer.GetHealth();
        int afterAttackHealth = currentHealth - _damage;
        adventurer.SetHealth(afterAttackHealth);
        Console.WriteLine($"You have {adventurer.GetHealth()} health left.");
    }

    public abstract void SpecialAttack(Adventurer adventurer);

    public virtual void DisplayMonster(){
        Console.WriteLine($"You have encountered a {_name}. It has {_health} health and does {_damage} damage per basic attack.");
        Console.WriteLine($"Watch out for it's special attack {_specialAttackName}");
    }

    public int GetHealth(){
        return _health;
    }

    public void SetHealth(int health){
        _health = health;
    }

    public string GetName(){
        return _name;
    }

}