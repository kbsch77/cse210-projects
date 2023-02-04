using System;

class Program
{
    static void Main(string[] args)
    {
        // Classes called
        Prompts myPrompts = new Prompts();
        RecordKeeper myRecords = new RecordKeeper();

        // local variables
        String fileName = "";
        int userChoice;
        List<JournalEntry> entries = new List<JournalEntry>();

        
        // Runs the Program in a loop untill quit option is selected
        do{
            // Gives and gets user choices
            userChoice = myPrompts.GiveUserOptions();

            if(userChoice == 1){ //Write
                JournalEntry myEntry = new JournalEntry();
                myEntry.WriteEntry();
                entries.Add(myEntry);
            }
            else if(userChoice == 2){ //Display
                myRecords.DisplayJournal(entries);
            }
            else if(userChoice == 3){ //Load
                myRecords.LoadJournal();
            }
            else if(userChoice == 4){ //Save
               fileName =  myRecords.SaveJournal(fileName, entries);
            }
            else if(userChoice == 5){ //Quit
                Console.WriteLine("Goodbye");
            }
            else{
                Console.WriteLine("Please enter a number of 1 through 5.");
            }
        } while (userChoice != 5);
    }
}