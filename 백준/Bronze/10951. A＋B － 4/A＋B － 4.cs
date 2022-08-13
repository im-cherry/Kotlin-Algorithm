using System;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            string input;
            string[] inputArr;
            
            while (true)
            {
                input = Console.ReadLine();
                if(input == null)
                    break;
                
                inputArr = input.Split();
                answer.Append($"{Convert.ToInt32(inputArr[0]) + Convert.ToInt32(inputArr[1])}\n");
            }

            Console.WriteLine(answer);
        }
    }
}