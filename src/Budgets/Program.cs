using System;

namespace KMA.ProgrammingInCSharp2021.Budgets
{
    class Program
    {
        static void Main(string[] args)
        {
            double x=34.1;

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else
            {
                Console.WriteLine($"Hello!");
            }
        }
    }
}
