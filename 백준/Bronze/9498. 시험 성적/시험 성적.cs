using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = Convert.ToInt32(Console.ReadLine());
            
            switch (score / 10)
            {
                case 10:
                case 9:
                    Console.WriteLine("A");
                    break;
                case 8:
                    Console.WriteLine("B");
                    break;
                case 7:
                    Console.WriteLine("C");
                    break;
                case 6:
                    Console.WriteLine("D");
                    break;
                default:
                    Console.WriteLine("F");
                    break;
            }
        }
	}
}