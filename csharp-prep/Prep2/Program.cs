using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please type your grade percentage: ");
        String response = Console.ReadLine();
        int grade = int.Parse(response);

        int lastNum = grade % 10;
        String sign = "";
        String letter = "";

        if (lastNum >= 7 && grade > 59 && grade < 97)
        {
            sign = "+";
        }
        else if (lastNum < 3 && grade > 59 && grade < 97)
        {
            sign = "-";
        }

        if (grade >= 90 )
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
         else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final letter grade is {letter}{sign}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you didn't pass the course.");
        }
    }
}