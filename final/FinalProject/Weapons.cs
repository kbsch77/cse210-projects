abstract class Weapons : Gear
{
    private string _damageType;
    private string _damageDice;
    private string _modifyerAttribute;
    private string _weaponName;
    private List<string> _attributes;

    public abstract string GetWeaponInfo();

    public void SetDamageType()
    {
        
    }
    public string GetDamageType()
    {
        return _damageType;
    }
    public void SetDamageDice()
    {
        
    }
    public string GetDamageDice()
    {
        return _damageDice;
    }
    public void SetModifyerAttribute()
    {
        
    }
    public string GetModifyerAttribute()
    {
        return _modifyerAttribute;
    }
    public void SetWeaponName()
    {
        
    }
    public string GetWeaponName()
    {
        return _weaponName;
    }
    public void SetAttributes()
    {
        
    }
    public List<string> GetAttributes()
    {
        return _attributes;
    }
}