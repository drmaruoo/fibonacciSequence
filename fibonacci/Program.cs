using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            bool enabled = true;
            bool recursion = true;
            List<BigInteger> numbers = new List<BigInteger>();
            int n = 0;
            Console.WriteLine("Press [r] to use recursive algorithm or press [a] to use alternative one");
            if (Console.ReadKey().KeyChar == 'a')
            {
                Console.Clear();
                recursion = false;
                Console.WriteLine("Using alternative algorithm");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Using recursive algorithm");
            }

            Console.WriteLine("Press [ENTER] to generate next number, write anything and press [ENTER] to exit");
            Console.WriteLine("Hold [ENTER] to generate numbers quickly");
            long initial = GC.GetTotalMemory(true);
            while (enabled)
            {
                stopWatch.Reset();
                if (Console.ReadLine() != "")
                {
                    enabled = false;
                }
                else
                {
                    stopWatch.Start();
                    if (recursion) Console.Write(generate(n++));
                    else
                    {
                        BigInteger temp = generateAlternative(n++, numbers);
                        numbers.Add(temp);
                        Console.Write(temp);
                    }
                    stopWatch.Stop();
                    long size = (GC.GetTotalMemory(true) - initial);
                    Console.Write(" | it took " + stopWatch.ElapsedMilliseconds + "ms | " + size + "B of memory used");
                }
            }
        }
        static BigInteger generate(int n)
        {
            if (n < 2)
            {
                return (BigInteger)n;
            }
            else
            {
                return generate(n - 2) + generate(n - 1);
            }
        }
        static BigInteger generateAlternative(int n, List<BigInteger> array)
        {
            if (n < 2)
            {
                return (BigInteger)n;
            }
            else
            {
                return array[n - 2] + array[n - 1];
            }
        }

    }
}
