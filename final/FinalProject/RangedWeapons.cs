class RangedWeapons : Weapons
{
    private int _minimalRange;
    private int _optimalRange;
    private int _maxRange;
    private int _ammunitionAmmount;
    private string _ammunitionType;

    public RangedWeapons()
    {

    }
    
    public override string GetWeaponInfo(string weapon)
    {

        return weapon;
    }
    public override string GetWeapon (string weapon)
    {

        return weapon;
    }
        public override  string GetArmor(string armor)
    {
        return armor;
    }
        private void SetAmmunitionType()
    {

    }
}