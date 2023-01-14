using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        String name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);
    }

    static void DisplayWelcome(){
            Console.WriteLine("Welcome to the Program!");
        }

    static String PromptUserName(){
        Console.Write("Please enter your name: ");
        String name = Console.ReadLine();

        return name;
    } 

    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        String answer = Console.ReadLine();
        int number = int.Parse(answer);

        return number;
    } 

    static int SquareNumber(int favoriteNum) {
        int squareNumber = favoriteNum * favoriteNum;

        return squareNumber;
    }

    static void DisplayResult(String name, int number){
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}