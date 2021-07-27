using System;

namespace Perfect NumberExamaple
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 496;
            int i = 1;
            int total = 0;

            for (i = 1; i < num; i++)
            {
                if (num % i == 0)
                    total += i;
            }
            if (total == num)
                Console.Write("{0} is a perfect number", num);
            else
                Console.Write("{0} is not a perfect number", num);
        }
    }
}