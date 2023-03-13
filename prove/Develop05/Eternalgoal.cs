class EternalGoal : Goal{
    //All attributes are handled in the parent class of Goal.
    public override void CreateGoal(string name, string description, int points, bool complete = false, int completionNumber = 0, int currentNumber = 0, int bonusPoints = 0){
        SetGoalType("EternalGoal");
        SetName(name);
        SetDescription(description);
        SetPoints(points);
    }
}