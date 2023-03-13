class GameFunctions
{
    private int _totalScore = 0;
    private List<Goal> _loadedGoals = new List<Goal>();

    public void Save(string fileName, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalScore);

            foreach(Goal goal in goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void Load(string fileName)
    {
        Goal goal;
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            //Local Variables
            string[] parts = line.Split(",");
            
            string name;
            string description;
            int points;
            string goalType = parts[0];

            //Creates and adds a Simple Goal to a list
            if(goalType == "SimpleGoal")
            {
                goal = new SimpleGoal();
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                bool complete = bool.Parse(parts[4]);

                goal.CreateGoal(name, description, points, complete);
                _loadedGoals.Add(goal);
            }

            //Creates and adds an Eternal Goal to a list
            else if(goalType == "EternalGoal")
            {
                goal = new EternalGoal();
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);

                goal.CreateGoal(name, description, points);
                _loadedGoals.Add(goal);
            }

            //Creates and adds a Checklist Goal to a list
            else if(goalType == "ChecklistGoal")
            {
                goal = new ChecklistGoal();
                name = parts[1];
                description = parts[2];
                points = int.Parse(parts[3]);
                int completionNumber = int.Parse(parts[4]);
                int currentNumber = int.Parse(parts[5]);
                int bonusPoints = int.Parse(parts[6]);

                goal.CreateGoal(name, description, points, false, completionNumber, currentNumber, bonusPoints);
                _loadedGoals.Add(goal);
            }

            //Sets the first line in the file as the player's score
            else
                _totalScore = int.Parse(parts[0]);
        }
    }

    public void AddPoints(int points)
    {
        _totalScore += points;
    }

    public void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_totalScore} points.");
        Console.WriteLine();
    }

    public List<Goal> GetLoadedGoals()
    {
        return _loadedGoals;
    }
}