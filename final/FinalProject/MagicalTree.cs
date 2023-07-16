public class MagicalTree : Monster {

    public MagicalTree(string name) : base(name){
        _damage = 2;
        _health = 30;
    }

    public override int SpecialAttack(int playerHealth){
        return playerHealth;
    }

    public override void DisplayMonster()
    {
        base.DisplayMonster();
    }

}