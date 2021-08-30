using System;

namespace EnumDemo
{
    class Program
    {
        enum MeetingDemo
        {
            Trivial,
            Regular,
            Critical,
        }
        static void Main(string[] args)
        {
            MeetingDemo meet = MeetingDemo.Critical;
            int value = (int)MeetingDemo.Critical;

            if (meet == MeetingDemo.Critical)
            {
                Console.WriteLine("Critical " + value);
            }
            else if (meet == MeetingDemo.Trivial)
            {
                Console.WriteLine("Trivial " + value);
            }

            else if (meet == MeetingDemo.Regular)
            {
                Console.WriteLine("Regular " + value);
                Console.ReadKey();
            }
        }
    }
}