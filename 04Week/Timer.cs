using System;
using System.Collections.Generic;

public class Program
{
    //fields
    private static Stopwatch _stopWatch;
    private static string _command;


    //Properties




    static Program()
    {
        _stopWatch = new Stopwatch();
    }

    //Methods
    public static void Main()
    {
        bool started = false;
        bool stopped = false;
        bool reset = false;


        Console.Clear();
        Console.WriteLine("STOPWATCH");

        while (_command != "exit")
        {
            Console.WriteLine("Type command (start, stop, reset or exit): ");
            _command = Console.ReadLine().ToLower();

            Console.Clear();
            Console.WriteLine("STOPWATCH");


            if (_command == "start")
            {

                started = _stopWatch.Start();


            }
            else if (_command == "stop")
            {
                stopped = _stopWatch.Stop();


            }
            else if (_command == "reset")
            {
                reset = _stopWatch.Reset();


                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Stopwatch has been reset!");
                    Console.ResetColor();
                }
            }


            else if (_command == "exit")
            {

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You Exited the Stopwatch application, Goodbye!");
                Console.ReadLine();
                Console.ResetColor();
            }

        }
    }


    class Stopwatch
    {
        //fields
        private DateTime _startDateTime;
        private DateTime _endDateTime;
        private TimeSpan _elapsedTime;

        //properties

        //constructors



        //Methods

        public bool Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Stopwatch has started!");
            _startDateTime = DateTime.Now;

            Console.ResetColor();


            //_command = Console.ReadLine().ToLower();
            return true;

        }
        public bool Stop()
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Stopwatch has stopped!");
            _endDateTime = DateTime.Now;

            _elapsedTime = _endDateTime.Subtract(_startDateTime);



            Console.WriteLine(_elapsedTime.ToString(@"hh\:mm\:ss"));
            Console.ResetColor();
            return true;
        }
        public bool Reset()
        {
            if (_startDateTime != DateTime.Now)
                return false;

            _startDateTime = new DateTime();
            _endDateTime = new DateTime();

            return true;
        }


    }
    public bool Exit()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You exited the Stopwatch application, Goodbye!");
        Console.ReadLine();

        Console.ResetColor();


        //_command = Console.ReadLine().ToLower();
        return true;




    }
}
