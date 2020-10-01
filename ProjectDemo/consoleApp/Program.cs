using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From C#");
            Console.WriteLine("Press any key to quit");
            int s = 0;
            for(int i = 1; i <= 7; i++)
            {
                s += i;
            }
            Console.WriteLine($"sum of 1 to 7 = {s}");
            increase(ref s);
            Console.WriteLine($"value of s after increase = {s}");
            Console.ReadKey();
            // Delegate is a pointer to a function
        }

        static void increase(ref int s)
        {
            s++;
        }
    }
}
