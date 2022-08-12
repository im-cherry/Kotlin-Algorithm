using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            
            int num1 = Convert.ToInt32(input[0]);
            int num2 = Convert.ToInt32(input[1]);
            int num3 = Convert.ToInt32(input[2]);
            int num4 = Convert.ToInt32(input[3]);
            int num5 = Convert.ToInt32(input[4]);
            int num6 = ( (num1*num1) + (num2*num2) + (num3*num3) + (num4*num4) + (num5*num5) ) % 10;

            Console.WriteLine(num6);
        }
	}
}