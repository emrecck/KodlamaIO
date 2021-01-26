using System;

namespace RefAndOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            int ref_A = 5;
            int out_A;

            RefIncrease(ref ref_A);
            Console.WriteLine("If you will use ref keyword,you have to declare value of field");
            Console.WriteLine(ref_A);

            OutIncrease(out out_A);
            Console.WriteLine("If you will use out keyword,you shouldn't have declare value of field");
            Console.WriteLine(out_A);
        }

        static void RefIncrease(ref int say)
        {
            say++;
        }
        static void OutIncrease(out int say)
        {
            say = 5;
            say++;
        }
    }
}
