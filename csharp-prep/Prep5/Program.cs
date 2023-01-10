using System;

class Program
{
    static void Main(string[] args)
    {
        WelcomeMessage();
        string name = PromptUserName();
        int user_number = PromptUserNumber();
        DisplayResult(name, SquareNumber(user_number));
    }

    static void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string user_name = Console.ReadLine();
        return user_name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string e_num = Console.ReadLine();
        int user_number = int.Parse(e_num);
        return user_number;
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string user_name, int squared_number)
    {
        Console.WriteLine($"{user_name}, the square of your number is {squared_number}");
    }
}