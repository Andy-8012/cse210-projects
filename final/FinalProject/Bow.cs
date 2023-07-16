public class Bow : Weapon {
    
    private int _range;

    public Bow(int damage, string element) : base(damage,element){
        _damage = damage;
        _element = element;
        _range = 5;
    }

    public int GetRange(){
        return _range;
    }

}