using System;

namespace _2AA_Bit__
{
    class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            int n = Int32.Parse(Console.ReadLine());

            for(int i = 0;i<n;i++){
                string statement = Console.ReadLine();

                if (statement == "++X")
                {
                    ++X;
                }
                else if (statement == "X++")
                {
                    X++;
                }
                else if (statement == "--X")
                {
                    --X;
                }
                else if (statement == "X--")
                {
                    X--;
                }
            }

            Console.WriteLine(X);
        }
    }
}
