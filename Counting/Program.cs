using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine("Program.Main()");
                Console.WriteLine("test change 1");
                Console.ReadKey();
            }
        }
    }
}
