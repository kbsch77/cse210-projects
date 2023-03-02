using System;
// This program has a more intricate animation of a spinning ('o') face.
// Additionally, the prompts and questions for the Reflections Activity each are used at least one time before cycling through again.
// The same is true with the prompt questions in the Listing Activity. 
class Program
{
    static void Main(string[] args)
    {
        string userEntry;
        int userChoice = 0;

        Breathing breathingActivity = new Breathing();
        Reflection reflectionActivity = new Reflection();
        Listing listActivity = new Listing();

        do{
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the Menu: ");
            userEntry = Console.ReadLine();
            userChoice = int.Parse(userEntry);

            if(userChoice == 1){
                breathingActivity.DisplayBreathing();
            }
            else if(userChoice == 2){
                reflectionActivity.DisplayReflection();
            }
            else if(userChoice == 3){
                listActivity.DisplayListing();
            }
            else if(userChoice == 4){
                Console.WriteLine("Very well, have a good day.");
            }
            else{
                Console.WriteLine("You are a silly billy. Enter a number 1-4 to select from the Menu.");
            }
        }while(userChoice != 4);
    }
}