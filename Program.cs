using System;
using System.Collections.Generic;

namespace ExampleInstructionYield
{
    class Program
    {
        static IEnumerable<int> Range(int from, int to)
        {
            for (int i = from; i < to; i++)
            {
                yield return i;
            }
            yield break;
        }

        static void Main(string[] args)
        {
            foreach (int x in Range(-10, 10))
            {
                Console.WriteLine(x);
            }
        }
    }
}
