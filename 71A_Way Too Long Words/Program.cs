using System;

namespace _71A_Way_Too_Long_Words
{
    class Program
    {

        static void Main()

        {

            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)

            {

                string s = Console.ReadLine();

                int l = s.Length;

                if (l <= 10)

                {
                    Console.WriteLine(s);
                }

                else

                {

                    Console.Write(s[0]);
                    Console.Write((l - 2));
                    Console.WriteLine(s[l - 1]);
                }

            }

        }
    }
}
