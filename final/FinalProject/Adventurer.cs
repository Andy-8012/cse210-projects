public class Adventurer {

    private int _health;
    private int _damage;
    private string _name;

    public Adventurer(string name){
        _name = name;
        _health = 100;
        _damage = 5;
    }

    public int BasicAttack(int monsterHealth){
        return monsterHealth;
    }

    public int SpecialAttack(int monsterHealth){
        return monsterHealth;
    }

    public bool Run(){
        bool success = true;
        return success;
    }

    public bool RollBack(){
        bool success = true;
        return success;
    }

}