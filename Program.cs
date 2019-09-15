using System;

namespace 구구단
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("구구단");
            int i, j;
            for(i=1;i<=9;i++)
            {
                for(j=1;j<=9;j++)
                {
                    Console.WriteLine("{0}*{1}={2}", i, j, i * j);
                }
                Console.WriteLine();
            }
        }
    }
}
