class RangedCombat : Combat
{
    public override void Attack (int attackRoll)
    {

    }
    public int UseAmmunition (int ammount)
    {
        return ammount --;
    }
}