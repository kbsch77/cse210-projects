class Prompts{
    public List<string> _prompts = new List<string>(){
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string GiveJournalPrompt(){
        // random number of 0 through 4
        int randomInt = new Random().Next(0, 4);

        // retrieves and returns a random prompt from the prompt list
        string prompt = _prompts[randomInt];
        return prompt;
    }

    public int GiveUserOptions(){
        Console.WriteLine("Plese Select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        string userEntry = Console.ReadLine();
        int userChoice = int.Parse(userEntry);
        return userChoice;
    }
}