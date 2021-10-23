using System;

namespace Generics_PS1
{
    class Program
    {
        static void Main(string[] args)
        {
            StackDoubles();
            StackStrings();
            Console.ReadLine();
        }
        
        private static void StackStrings()
        {
            var stack = new SimpleStack<string>();
            stack.Push("Wired Brain Coffee");
            stack.Push("Strings pushed");
            while (stack.Count > 0)
            {
                object item = stack.Pop();
                Console.WriteLine($"Item:{item}");
            }
        }

        private static void StackDoubles()
        {
            var stack = new SimpleStack<double>();
            stack.Push(1.2);
            stack.Push(2.8);
            stack.Push(3.0);

            double sum = 0.0;
            while (stack.Count > 0)
            {
                double item = stack.Pop();
                Console.WriteLine($"Item:{item}");
                sum += item;
            }
            Console.WriteLine($"Sum:{sum}");
        }
    }
}
