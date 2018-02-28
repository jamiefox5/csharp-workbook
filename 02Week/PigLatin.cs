using System;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Whats the Word?");
        string word = Console.ReadLine();
        Console.WriteLine(Translator.Translate(word));
        Console.ReadLine();
    }
}
