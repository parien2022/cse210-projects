using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numList = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        while (number != 0) {
            
            Console.Write("Enter number: ");
            String response = Console.ReadLine();
            number = int.Parse(response);

            numList.Add(number);
            
        }

        numList.RemoveAt(numList.Count - 1);

        int sum = numList.Sum();

        double average = numList.Average();
        int max = numList.Max();
 
        int minNum = max;
        foreach (int i in numList){
            if (i > 0 && i < minNum){
                minNum = i;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {minNum}");
        Console.WriteLine("The sorted list is:");
        numList.Sort();
        foreach (int item in numList){
            Console.WriteLine(item);
        }
    }
}