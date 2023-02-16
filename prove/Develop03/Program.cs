using System;
// To exceed the requirements, I have given the user a choice in either a multi-verse scripture or a single verse scripture.
// I have also made a list of seven single-verse scriptures that are chosen at random for the single verse option.
class Program
{
    static void Main(string[] args)
    {   
        //local variables
        bool runProgram = true;
        string userChoice;

        Console.WriteLine("Press Enter to draw a random single verse scripture or type 'multi' for a multiple verse scripture.");
        userChoice = Console.ReadLine();

        //multi-Verse Scripture Option
        if(userChoice == "multi"){

            //constructors
            Referance scriptReferance = new Referance();
            Text scriptText = new Text();
            Scripture memoryMultiScripture = new Scripture(scriptReferance.GetMultiReferance(), scriptText.GetMultiVerseText(0), scriptText.GetMultiVerseText(1));
            
            memoryMultiScripture.Display();

            // program memorization loop
            while(runProgram){ 
                Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
                userChoice = Console.ReadLine();

                //quits program
                if(userChoice == "quit"){
                    runProgram = false;
                }

                //removes words
                else{
                    memoryMultiScripture.HideWords();
                    memoryMultiScripture.Display();
                    runProgram = memoryMultiScripture.EndMemorization();
                }
            } 
        }

        //the random single-verse scripture option
        else{
            Scripture memoryScripture = new Scripture();
            memoryScripture.Display();

            // program memorization loop
            while(runProgram){ 
                Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
                userChoice = Console.ReadLine();

                //quits program
                if(userChoice == "quit"){
                    runProgram = false;
                }

                //removes words
                else{
                    memoryScripture.HideWords();
                    memoryScripture.Display();
                    runProgram = memoryScripture.EndMemorization();
                }
            } 
        }
    }
}