using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the truth!");
            bool input = bool.Parse(Console.ReadLine());
            Console.WriteLine("You gave " + input);
        }
    }
}
