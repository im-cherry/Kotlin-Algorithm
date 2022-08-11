using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            
            if(year % 4 == 0)
            {
                if(year % 100 != 0 || year % 400 == 0)
                {
                    result = 1;
                }
            }
            
            Console.WriteLine(result);
        }
	}
}