public class Spider : Monster {

    public Spider(string name) : base(name){
        _damage = 4;
        _health = 20;
        _specialAttackName = "Widow's Bite";
    }

    public override void SpecialAttack(Adventurer adventurer){
        Console.WriteLine($"Watch out!! The {_name} uses their special attack {_specialAttackName}");
        int specialAttackDamage = _damage * 3;
        Console.WriteLine($"This hits you for {specialAttackDamage} damage");
        int currentHealth = adventurer.GetHealth();
        int afterAttackHealth = currentHealth - specialAttackDamage;
        adventurer.SetHealth(afterAttackHealth);
        Console.WriteLine($"You have {adventurer.GetHealth()} health left.");
    }

}