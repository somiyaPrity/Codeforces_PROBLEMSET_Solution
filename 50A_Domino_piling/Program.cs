using System;

namespace _50A_Domino_piling
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first_line = Console.ReadLine().Split(' '); //split by space
            int M = int.Parse(first_line[0]);
            int N = int.Parse(first_line[1]);
            int result = (M * N) / 2;
            Console.WriteLine(result);
        }
    }
}
