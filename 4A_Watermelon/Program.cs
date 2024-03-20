using System;

namespace _4A_Watermelon
{
    class Program
    {
        static void Main(string[] args)
        {
            int melon = Int32.Parse(Console.ReadLine());

            if (melon % 2 == 0 && melon > 2)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
