using System;

namespace Sample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("The result is:");

            add(1, 2);
        }

        static void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
