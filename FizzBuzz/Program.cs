using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Run();

        }

        private void Run()
        {
            var list = Enumerable.Range(1, 100);

            foreach (var num in list)
            {
                if (IsMod(num, i => i % 3 == 0 && i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (IsMod(num, i => i % 3 == 0))
                {
                    Console.WriteLine("Fizz");
                }
                else if (IsMod(num, i => i % 5 == 0))
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(num);
                }
            }

            Console.ReadLine();

        }

        private bool IsMod(int i, Func<int, bool> predicate)
        {
            return predicate(i);
        }


    }
}
