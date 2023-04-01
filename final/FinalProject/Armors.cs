class Armors : Gear
{
    private string _armorName;
    private string _armorType;
    private int _armorClassBonus;
    private int _streangthRequirement;
    private bool _stealthDisadvantage;

    public Armors()
    {

    }

    public string GetArmorInfo ()
    {
        string armorInfo = (_armorName + ", " + _armorType + ", AC +" + _armorClassBonus + ", " + "Strength of " + _streangthRequirement + " required");
        
        if(_stealthDisadvantage)
        {
            armorInfo = armorInfo + (", Stealth Disadvantage");
        }

        return armorInfo;
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