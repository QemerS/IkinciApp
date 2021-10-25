using System;

namespace IkinciApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 - dən 100 - ə qədər tək ədədləri console-da çap edin;
            for (short x = 1; x <= 100; x++)
            {
                if (x % 2 != 0)
                {
                    Console.WriteLine(x);
                }

            }
        }
    }
}
