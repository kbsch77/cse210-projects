using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your letter percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter;

        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;

        if (percentage >= a){
            letter = "A";
        }
        else if (percentage >= b){
            letter = "B";
        }
        else if (percentage >= c){
            letter = "C";
        }
        else if (percentage >= d){
            letter = "D";
        }
        else{
            letter = "F";
        }
        Console.WriteLine($"Your grade is an {letter}.");

        if (percentage >= 70){
            Console.WriteLine("Congragulations! you passed the class!");
        }
        else{
            Console.WriteLine("You have failed the class, but I'm sure that you will pass next time!");
        }
    }
}