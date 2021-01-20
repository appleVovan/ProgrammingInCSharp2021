using System;

namespace KMA.ProgrammingInCSharp2021.Budgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((args.Length > 0) ? $"Hello, {args[0]}!" : "Hello!");
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
