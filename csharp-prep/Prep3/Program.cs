using System;

class Program
{
    static void Main(string[] args)
    {


        Random generateRandom = new Random();
        int random = generateRandom.Next(1, 101);

        int guess = 0;
        int times = 0;
        String answer = "";
        

        while(guess != random || answer == "yes"){
            Console.Write("What is your guess? ");
            String response = Console.ReadLine();
            guess = int.Parse(response);

            times = times + 1;

            if (guess > random){
                Console.WriteLine("Lower");
            }
            else if (guess < random) {
                Console.WriteLine("Higher");
            }
            else{
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {times} times");
                Console.Write("Do you want to play again (yes/no) ");
                answer = Console.ReadLine();
                if (answer == "yes"){
                    times = 0;
                    random = generateRandom.Next(1, 101);   
                }
                else{
                    Console.WriteLine("Goodbye");
                }
                
            }
        }
    }
}