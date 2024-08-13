using System;

namespace _158A_Next_Round
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] first_line = Console.ReadLine().Split(' '); //split by space
            int n = int.Parse(first_line[0]);
            int k = int.Parse(first_line[1]);
            string[] data = Console.ReadLine().Split(' ');


            int[] scores = new int[n];
            int i = 0;

            foreach (var number in data)
            {
                scores[i] = int.Parse(number);
                i++;
            }
            int finisher = scores[k-1];
            int result = 0;
            for (int j = 0; j < scores.Length; j++)
            {
                if (scores[j] >= finisher && scores[j]>0)
                {
                    result++;

                }
            }

            Console.WriteLine(result);


        }
    }
}
