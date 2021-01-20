using System;

namespace KMA.ProgrammingInCSharp2021.Budgets
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello{((args.Length > 0)? $", {args[0]}" : "")}!");
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
