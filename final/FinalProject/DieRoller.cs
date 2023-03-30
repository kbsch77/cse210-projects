class DieRoller{
    public int RollDice(int diceType)
    {
        Random rand = new Random();
        int roll = rand.Next(1, (diceType + 1));
        return roll;
    }
}