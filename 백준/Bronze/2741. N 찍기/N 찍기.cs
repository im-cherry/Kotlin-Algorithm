using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            StringBuilder result = new StringBuilder();
            
            for(int n = 1; n <= N; n++)
            {
                result.Append($"{n}\n");
            }
            
            Console.WriteLine(result.ToString());
        }
	}
}