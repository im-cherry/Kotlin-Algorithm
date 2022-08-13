using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            int T = Convert.ToInt32(Console.ReadLine());
            string[] input;
            
            for (int t = 0; t < T; t++)
            {
                input = Console.ReadLine().Split();
                int A = Convert.ToInt32(input[0]);
                int B = Convert.ToInt32(input[1]);

                answer.Append($"{A + B}\n");
            }

            Console.WriteLine(answer);
        }
    }
}