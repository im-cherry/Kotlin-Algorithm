using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            double A = Convert.ToDouble(input[0]);
            double B = Convert.ToDouble(input[1]);
            double result = A / B;
            
            Console.WriteLine(result);
        }
    }
}