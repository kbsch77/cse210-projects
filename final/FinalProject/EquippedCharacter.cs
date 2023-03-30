class EquippedCharacter : Character
{
    private string _meleeWeapon;
    private string _rangedWeapon;
    private string _armor;
    private bool _sheild;
    private bool _proficiency;

    public EquippedCharacter (string name, string meleeWeapon = "n/a", string rangedWeapon = "n/a", string armor = "n/a", bool sheild = false) 
    : base (name)
    {
        SetName(name);
        RollStats();
        _meleeWeapon = meleeWeapon;
        _rangedWeapon = rangedWeapon;
        _armor = armor;
        _sheild = sheild;
    }
    public EquippedCharacter 
    (string name, int strength=1, int dexterity=1, int constitution=1, int intelligence=1, int wisdom=1, int charisma=1, 
        string meleeWeapon = "n/a", string rangedWeapon = "n/a", string armor = "n/a", bool sheild = false) 
    : base (name, strength, dexterity, constitution, intelligence, wisdom, charisma)
    {
        SetName(name);

        _meleeWeapon = meleeWeapon;
        _rangedWeapon = rangedWeapon;
        _armor = armor;
        _sheild = sheild;
    }

    public void ApplyWeaponProficiency()
    {

    }
    public void EquipArmor()
    {

    }
    public void EquipMeleeWeapon()
    {

    }
    public void EquipRangedWeapon()
    {

    }

}