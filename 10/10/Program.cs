using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will tell a story, but I need some information.");
            Console.WriteLine("Give me a name for main character below:");
            string TheName = Console.ReadLine();
            Console.WriteLine("Give the character a profession:");
            string profession = Console.ReadLine();

            Console.WriteLine("Here is the story:");
            Console.WriteLine("Once upon a time there was a " + profession + " called " + TheName);
            Console.WriteLine("On their way to work, " + TheName + " often wondered what being a " + profession + " meant to them.");
            Console.WriteLine("When you work as a " + profession + " you meet interesting people.");
            Console.WriteLine(TheName + " enjoys their work as " + profession + ". THE END");


        }
    }
}
