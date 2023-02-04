class JournalEntry{
    private Prompts journalPrompts = new Prompts();

    public string _dateText;
    public string _prompt;
    public string _userEntry;

    public void WriteEntry(){
        // Gets the current date and time
        DateTime theCurrentTime = DateTime.Now;
        _dateText = theCurrentTime.ToShortDateString();

        // Entry prompt
        _prompt = journalPrompts.GiveJournalPrompt();
        Console.WriteLine($"{_prompt}");

        // User's Journal Entry
        Console.Write(">"); // Shows '>' or entry starting point, but dosen't save it to the entry.
        _userEntry = Console.ReadLine();
        Console.WriteLine(); // Blank for spacing
    }
}