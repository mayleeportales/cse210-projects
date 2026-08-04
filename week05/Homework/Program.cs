using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignments writingAssignments = new WritingAssignments("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine("====================================================");

        Console.WriteLine(writingAssignments.GetSummary());
        Console.WriteLine(writingAssignments.GetWritingInformation());

        
    }
}