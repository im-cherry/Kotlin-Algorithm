using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            int A = Convert.ToInt32(input[0]);
            int B = Convert.ToInt32(input[1]);
            int result = A - B;
            
            Console.WriteLine(result);
        }
    }
}