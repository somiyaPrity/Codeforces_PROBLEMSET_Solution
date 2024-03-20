using System;

namespace Team
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                int count = 0;
                string p1 = Console.ReadLine();
                foreach (var ch in p1)
                {
                    if (ch == '1')
                        count++;
                }
                if (count >= 2)
                {
                    result = result + 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}
