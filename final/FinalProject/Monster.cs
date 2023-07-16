public abstract class Monster {

    protected int _health;
    protected int _damage;
    protected string _name;

    public Monster(string name){
        _name = name;
    }

    public virtual int BasicAttack(int playerHealth){
        return playerHealth;
    }

    public abstract int SpecialAttack(int playerHealth);

    public virtual void DisplayMonster(){

    }

}