using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welcome to Rock, Paper, Scissors");
        Console.WriteLine("Enter hand 1:");
        string hand1 = Console.ReadLine().ToLower();
        Console.Clear();
        Console.WriteLine("Welcome to Rock, Paper, Scissors");
        Console.WriteLine("Enter hand 2:");
        string hand2 = Console.ReadLine().ToLower();
        string returnedResult = compareHands(hand1, hand2);
        Console.WriteLine(returnedResult);
        Console.ReadLine();
        playerChoice();
    }

    private static string compareHands(string hand1, string hand2)
    {
        {
            if (hand1 == hand2)
            {
                return "It's a tie!";
            }

            else if (hand1 == "rock" && hand2 == "scissors")
            {
                return "Rock wins! Way to go hand 1";
            }
            else if (hand1 == "rock" && hand2 == "paper")
            {
                return "Paper Wins! Way to go hand 2";
            }

            else if (hand1 == "scissors" && hand2 == "rock")
            {
                return "Rock wins! Way to go hand 2";
            }
            else if (hand1 == "scissors" && hand2 == "paper")
            {
                return "Scissors Wins! Way to go hand 1";
            }

            else if (hand1 == "paper" && hand2 == "rock")
            {
                return "Paper wins! Way to go hand 1";
            }
            else if (hand1 == "paper" && hand2 == "scissors")
            {
                return "Scissors Wins! Way to go hand 2";
            }

            return "";
        }
    }

    private static void playerChoice()
    {
        //play again?Rockcd
        Console.WriteLine("Would you like to play again? Enter 1 for yes and 2 for no");
        string playerChoice = Console.ReadLine();

        if (playerChoice == "1")
        {
            //calling method to start game
            Main();
        }

        else if (playerChoice == "2")
        {
            Console.WriteLine("Thanks for playing");
            Console.ReadLine();
        }
    }
}
