abstract class Gear
{
    private List<string> _weapons;
    private List<string> _armors;
    private string _weight;
    private string _cost;

    public abstract string GetWeapon (string weapon);
    public abstract string GetArmor(string armor);

    public void SetWeapons()
    {
        
    }
    public List<string> GetWeapons()
    {
        return _weapons;
    }
    public void SetArmors()
    {

    }
    public List<string> GetArmors()
    {
        return _armors;
    }
}