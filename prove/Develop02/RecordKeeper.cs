using System.IO; 

class RecordKeeper{
    private string[] _loadedLines;
    public string SaveJournal(string fileName, List<JournalEntry> entries){
        Console.Write("Enter the name of your journal: ");
        fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in entries){// Entry date
            outputFile.Write($"Date: {entry._dateText} - ");

            // Entry prompt
            outputFile.WriteLine($"Prompt: {entry._prompt}");

            // User's Journal Entry
            outputFile.WriteLine($"{entry._userEntry}");
            outputFile.WriteLine(); // Blank for spacing
            } 
        }
        return fileName;
    }

    public void LoadJournal(){
        Console.Write("Enter the name of your journal you want to load: ");
        string fileName = Console.ReadLine();

        _loadedLines = System.IO.File.ReadAllLines(fileName);
    }

    public void DisplayJournal(List<JournalEntry> entries){
        if(_loadedLines != null){
            foreach (string line in _loadedLines)
            {
                Console.WriteLine($"{line}");
            }
        }
        foreach (JournalEntry entry in entries){// Entry date
        Console.Write($"Date: {entry._dateText} - ");

        // Entry prompt
        Console.WriteLine($"Prompt: {entry._prompt}");

        // User's Journal Entry
        Console.WriteLine($"{entry._userEntry}");
        Console.WriteLine(); // Blank for spacing
            
        }
    }
}