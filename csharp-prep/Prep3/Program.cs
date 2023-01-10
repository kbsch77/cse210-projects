using System;

class Program
{
    static void Main(string[] args)
    {
        string play_again;
        do{
            Random randomGenerator = new Random();
            int magic_number = randomGenerator.Next(1, 101);

            Boolean end_round = false;
            int try_count = 0;
            while(end_round == false){
                Console.Write("What is your guess? ");
                string g_num = Console.ReadLine();
                int guess_number = int.Parse(g_num);
                try_count ++;

                if (guess_number == magic_number){
                    Console.WriteLine("You guessed it!");
                    end_round = true;
                }
                else if(guess_number > magic_number){
                    Console.WriteLine("Lower");
                }
                else if(guess_number < magic_number){
                    Console.WriteLine("Higher");
                }
            }
            Console.WriteLine($"You got the number in {try_count} guesses.");

            Console.Write("Do you want to play again (yes/no)? ");
            play_again = Console.ReadLine();
            Console.WriteLine("");
        }while(play_again.ToLower() == "yes");
    }
}