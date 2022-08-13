using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            string[] input;
            int result;
            
            while(true)
            {
                input = Console.ReadLine().Split();
                result = Convert.ToInt32(input[0]) + Convert.ToInt32(input[1]);
                
                if(result == 0)
                    break;
                
                answer.Append($"{result}\n");
            }
            Console.WriteLine(answer);
        }
    }
}