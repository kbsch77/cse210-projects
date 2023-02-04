class Prompts{
    //Journal Entry Prompts
    public List<string> _prompts = new List<string>()
    {
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
        //Menu prompts
        Console.WriteLine("Plese Select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");

        //meathod variables
        bool validity = false;
        string userEntry = "6";

        //Loop to ensure validity of menu prompt choice
        while(validity == false){
            userEntry = Console.ReadLine();

            //Only allows users to enter in a number between 1-5
            if (userEntry == "1" || userEntry == "2"|| userEntry == "3"|| userEntry == "4"|| userEntry == "5"){
                validity = true;
            }
            else Console.WriteLine("Please enter a number of 1 through 5.");
        }
        int userChoice = int.Parse(userEntry);
        return userChoice;
    }
}