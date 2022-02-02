using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string UserNamer;
            UserNamer = Console.ReadLine();
            Console.WriteLine("Hello, " + UserNamer);
            Console.Read();
        }
    }
}
