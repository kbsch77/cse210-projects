using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();
        int entered_number;
        do{
            Console.Write("Enter number: ");
            string e_num = Console.ReadLine();
            entered_number = int.Parse(e_num);
            if (entered_number != 0){
                numbers.Add(entered_number);
            }
        }while(entered_number != 0);

        double sum = 0;
        double average;
        double largest_number = 0;
        double small_pos_num = 99999999999999999999999999999999999999999999999999999999999999999.9;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if(numbers[i] > largest_number){
                largest_number = numbers[i];
            }
            if(numbers[i] < small_pos_num && numbers[i] > 0){
                small_pos_num = numbers[i];
            }
        }
        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest_number}");
        Console.WriteLine($"The smallest positive number is: {small_pos_num}");
    }
}