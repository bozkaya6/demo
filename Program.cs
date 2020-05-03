using System;

namespace Demo2
{

    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 10;

            x = x + y;
            y = x - y;
            x = x - y;

            Console.WriteLine("After swapping: x = "
                         + x + ", y = " + y);

        }
    }
}
