using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment testAssignmet = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(testAssignmet.GetSummary());
        Console.WriteLine();

        MathAssignment testMath = new MathAssignment("Mary Waters", "European History", "7.3", "8-19");
        Console.WriteLine(testMath.GetSummary());
        Console.WriteLine(testMath.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment testWriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(testWriting.GetSummary());
        Console.WriteLine(testWriting.GetWritingInformation());
    }
}