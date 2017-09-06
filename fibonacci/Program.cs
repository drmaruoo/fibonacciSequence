using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            bool enabled = true;
            int n = 0;
            Console.WriteLine("Press [ENTER] to generate next number, write anything and press [ENTER] to close");
            while (enabled)
            {
                if (Console.ReadLine() != "")
                {
                    enabled = false;
                }
                else
                {
                    Console.Write(generate(n++));
                }
            }
        }
        static int generate(int n)
        {
            if (n < 2)
            {
                return n;
            }
            else
            {
                return generate(n - 2) + generate(n - 1);
            }
        }
    }
}
