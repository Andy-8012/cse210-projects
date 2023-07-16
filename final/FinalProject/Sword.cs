public class Sword : Weapon {
    
    private int _sharpness;

    public Sword(int damage, string element) : base(damage,element){
        _damage = damage;
        _element = element;
        _sharpness = 3;
    }


    public int GetRange(){
        return _sharpness;
    }

}