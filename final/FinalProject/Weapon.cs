public abstract class Weapon {

    protected int _damage;
    protected string _element;

    public Weapon(int damage, string element){
        _damage = damage;
        _element = element;
    }

    public int GetDamage(){
        return _damage;
    }

    public string GetElement(){
        return _element;
    }

}