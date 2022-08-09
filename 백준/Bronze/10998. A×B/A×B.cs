using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int answer = Convert.ToInt32(input[0]) * Convert.ToInt32(input[1]);
            
            Console.WriteLine(answer);
        }
    }
}