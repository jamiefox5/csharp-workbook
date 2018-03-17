using System;

public class Program
{
    public static string _command;

    public static void Main()
    {
        var newPost = new BlogPost
        {
            Title = "New Post",
            Description = "New Post Description."
        };
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("-------------------------");
        Console.WriteLine(newPost.Title);
        Console.WriteLine(newPost.Description);
        Console.WriteLine(newPost.CreationDateTime);
        Console.WriteLine("-------------------------");

        do
        {
            //Console.WriteLine("Number of votes: " + newPost.DisplayVotes());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Do you like my Blog?");
            Console.WriteLine("Please let me know by typing: yes or no");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Type exit to leave the Blog");
            _command = Console.ReadLine().ToLower();


            switch (_command)
            {
                case "yes":
                    newPost.UpVote();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You have " + newPost.DisplayVotes() + " votes");
                    break;

                case "no":
                    newPost.DownVote();
                    Console.ForegroundColor = ConsoleColor.Magenta
                    ;
                    Console.WriteLine("You have " + newPost.DisplayVotes() + " votes");
                    break;

                default:
                    Console.WriteLine("Please enter a valid command");
                    break;

            }
        } while (_command != "exit");


    }
}

class BlogPost
{
    public string Title { get; set; }
    public string Description { get; set; }
    public readonly DateTime CreationDateTime = DateTime.Now;
    private int _votes = 0;

    public int DisplayVotes()
    {
        return _votes;
    }

    public void UpVote()
    {
        _votes++;
    }

    public void DownVote()
    {
        _votes--;
    }
}
