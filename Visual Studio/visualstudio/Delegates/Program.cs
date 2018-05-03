using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void Func();

        static void PrintMy()
        {
            Console.WriteLine("My");
        }
        static void PrintName()
        {
            Console.WriteLine("name");
        }
        static void PrintIs()
        {
            Console.WriteLine("is");
        }
        static void PrintManny()
        {
            Console.WriteLine("Manny");
        }

        static void Main(string[] args)
        {
            Func myFunction = new Func(PrintMy);

            myFunction += PrintName;
            myFunction += PrintIs;
            myFunction += PrintManny;

            myFunction.Invoke();

            Console.ReadLine();
        }
    }
}
