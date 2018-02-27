using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors");
        Console.WriteLine("Enter hand 1:");
        string hand1 = Console.ReadLine().ToLower();
        Console.WriteLine("Enter hand 2:");
        string hand2 = Console.ReadLine().ToLower();
        compareHands(hand1, hand2);

        Console.ReadLine();
    }

    private static void compareHands(string hand1, string hand2)
    {

        {
            if (hand1 == hand2)
            {
                Console.WriteLine("It's a tie!");
                Console.ReadLine();
            }

            else if (hand1 == "rock" && hand2 == "scissors")
            {
                Console.WriteLine("Rock wins! Way to go hand 1");
                Console.ReadLine();
            }
            else if (hand1 == "rock" && hand2 == "paper")
            {
                Console.WriteLine("Paper Wins! Way to go hand 2");
                Console.ReadLine();

            }



            else if (hand1 == "scissors" && hand2 == "rock")
            {
                Console.WriteLine("Rock wins! Way to go hand 2");
                Console.ReadLine();
            }
            else if (hand1 == "scissors" && hand2 == "paper")
            {
                Console.WriteLine("Scissors Wins! Way to go hand 1");
                Console.ReadLine();
            }


            else if (hand1 == "paper" && hand2 == "rock")
            {
                Console.WriteLine("Paper wins! Way to go hand 1");
                Console.ReadLine();
            }
            else if (hand1 == "paper" && hand2 == "scissors")
            {
                Console.WriteLine("Scissors Wins! Way to go hand 2");
                Console.ReadLine();
            }
        }
        //play again?Rockcd
        Console.WriteLine("Would you like to play again? Enter 1 for yes and 2 for no");
        string playerChoice = Console.ReadLine();

        if (playerChoice == "1")
        {
            //calling method to start game
            Main();
            //calling method to display results of game
            compareHands(hand1, hand2);
        }

        else if (playerChoice == "2")
        {
            Console.WriteLine("Thanks for playing");
            Console.ReadLine();
        }



    }
}
