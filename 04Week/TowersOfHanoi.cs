using System;
using System.Collections.Generic;

public class Program
{
    int movingBlock;
    //Fields - usually set to private
    private static Dictionary<string, List<int>> stacks = new Dictionary<string, List<int>>()
    {
        { "a", new List<int>() {4,3,2,1} },
        { "b", new List<int>() {} },
        { "c", new List<int>() {} }
    };




    public static void Main()
    {
        // Your code here

        while (!GameOver())
        {
            //Console.Clear();
            PrintStacks();
            Console.WriteLine("Pick Start");
            string start = Console.ReadLine();
            Console.WriteLine("Pick End");
            string finish = Console.ReadLine();
            if (IsLegal(start, finish))
            {
                //movePiece(start, finish);
                Console.WriteLine("It works");
                MovePiece(start, finish);
            }
            else
            {
                Console.WriteLine("Illegal Move");
            }
        }
        PrintStacks();
        GameOver();
        Console.WriteLine("You won!");
        Console.ReadLine();
    }

    public static bool GameOver()
    {
        if (stacks["c"].Count == 4 || stacks["b"].Count == 4)
        {
            return true;
        }
        return false;
    }

    public static void MovePiece(string start, string finish)
    {
        // Your code here
        List<int> startStack = stacks[start];
        int movingBlock = startStack[startStack.Count - 1];
        List<int> finishStack = stacks[finish];
        //int placedBlock = finishStack[finishStack.Count - 1];
        stacks[start].Remove(movingBlock);
        stacks[finish].Add(movingBlock);

    }

    public static bool IsLegal(string start, string finish)
    {
        // is finished stack empty?
        if (stacks[finish].Count == 0)
        {
            return true;
        }
        else
        {
            List<int> startStack = stacks[start];
            int movingBlock = startStack[startStack.Count - 1];
            List<int> finishStack = stacks[finish];
            int placedBlock = finishStack[finishStack.Count - 1];
            if (movingBlock < placedBlock)
            {
                return true;
            }
        }
        return false;
    }

    public static void PrintStacks()
    {
        string[] letters = new string[] { "a", "b", "c" };
        for (var i = 0; i < letters.Length; i++)
        {
            List<string> blocks = new List<string>();
            for (var j = 0; j < stacks[letters[i]].Count; j++)
            {
                blocks.Add(stacks[letters[i]][j].ToString());
            }
            Console.WriteLine(letters[i] + ": " + String.Join("|", blocks));
        }
    }
}
