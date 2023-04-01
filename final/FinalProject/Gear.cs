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
    public void SetWeight(string weight)
    {
        _weight = weight;
    }
    public string GetWeight()
    {
        return _weight;
    }
    public void SetCost(string cost)
    {
        _cost = cost;
    }
    public string GetCost()
    {
        return _cost;
    }
}