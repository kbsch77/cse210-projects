class Armors : Gear
{
    private string _armorType;
    private int _armorClassBonus;
    private int _streangthRequirement;
    private bool _stealthDisadvantage;

    public Armors()
    {

    }

    public string GetArmorInfo (string armor)
    {

        return armor;
    }
    public override  string GetArmor(string armor)
    {

        return armor;
    }
    public override string GetWeapon (string weapon)
    {
        return weapon;
    }
}