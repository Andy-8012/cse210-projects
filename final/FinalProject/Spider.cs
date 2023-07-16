public class Spider : Monster {

    public Spider(string name) : base(name){
        _damage = 4;
        _health = 20;
    }

    public override int SpecialAttack(int playerHealth){
        return playerHealth;
    }

    public override void DisplayMonster()
    {
        base.DisplayMonster();
    }

}