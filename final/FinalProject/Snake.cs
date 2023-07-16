public class Snake : Monster {

    public Snake(string name) : base(name){
        _damage = 8;
        _health = 10;
    }

    public override int SpecialAttack(int playerHealth){
        return playerHealth;
    }

    public override void DisplayMonster()
    {
        base.DisplayMonster();
    }

}