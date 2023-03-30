class Character{
    private int _strength;
    private int _dexterity;
    private int _constitution;
    private int _intelligence;
    private int _wisdom;
    private int _charisma;
    private int _proficiencyBonus = 1;
    private string _name;
    private int _level =1;

    public Character (string name)
    {
        _name = name;
        RollStats();
    }
    public Character (string name, int strength=1, int dexterity=1, int constitution=1, int intelligence=1, int wisdom=1, int charisma=1)
    {
        _name = name;
        _strength = strength;
        _dexterity = dexterity;
        _constitution = constitution;
        _intelligence = intelligence;
        _wisdom = wisdom;
        _charisma = charisma;
    }
    public void RollStats ()
    {

    }

    //Getters & Setters
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetLevel(int level = 1)
    {
        _level = level;
    }
    public int GetLevel()
    {
        return _level;
    }
}