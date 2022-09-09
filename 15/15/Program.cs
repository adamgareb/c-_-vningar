using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a string:");
            string StringInput = Console.ReadLine();

            Console.WriteLine("Give an interger:");
            int IntInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Give a double:");
            double DoubleInput = double.Parse(Console.ReadLine());

            Console.WriteLine("Give a boolean:");
            bool BooleanInput = bool.Parse(Console.ReadLine());

            Console.WriteLine("Your string: " + StringInput);
            Console.WriteLine("Your interger: " + IntInput);
            Console.WriteLine("Your double: " + DoubleInput);
            Console.WriteLine("Your boolean: " + BooleanInput);
        }
    }
}
