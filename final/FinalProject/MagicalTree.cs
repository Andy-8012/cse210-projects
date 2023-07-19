public class MagicalTree : Monster {

    public MagicalTree(string name) : base(name){
        _damage = 2;
        _health = 30;
        _specialAttackName = "Magical Leaves";
    }

    public override void SpecialAttack(Adventurer adventurer){
        Console.WriteLine($"Watch out!! The {_name} uses their special attack {_specialAttackName}");
        int specialAttackDamage = _damage * 4;
        Console.WriteLine($"This hits you for {specialAttackDamage} damage");
        int currentHealth = adventurer.GetHealth();
        int afterAttackHealth = currentHealth - specialAttackDamage;
        adventurer.SetHealth(afterAttackHealth);
        Console.WriteLine($"You have {adventurer.GetHealth()} health left.");
    }

}