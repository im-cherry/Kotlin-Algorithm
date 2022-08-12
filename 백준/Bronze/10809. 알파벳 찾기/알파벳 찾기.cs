using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            int alpha = 97;
            for (int i = 0; i < 26; i++)
            {
                Console.Write($"{word.IndexOf((char)(alpha + i))} ");
            }
        }
    }
}