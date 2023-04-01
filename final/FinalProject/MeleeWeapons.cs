class MeleeWeapons : Weapons
{
    public MeleeWeapons()
    {

    }

    public override string GetWeaponInfo ()
    {
        string weaponInfo = (GetWeaponName() + ", " + GetDamageDice() + " " + GetDamageType());

        List<string> attributes = GetAttributes();
        foreach(string attribute in attributes)
        {
            if(attribute != "n/a")
            {
                weaponInfo = weaponInfo + (", " + attribute);
            }
        }

        return weaponInfo;
    }
    public override string GetWeapon (string weapon)
    {

        return weapon;
    }
        public override  string GetArmor(string armor)
    {
        return armor;
    }
}