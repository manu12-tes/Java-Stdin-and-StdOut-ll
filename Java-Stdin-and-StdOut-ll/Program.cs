using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Stdin_and_StdOut_ll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escribe una entero, un double y una cademna");
            int stInt = Int32.Parse(Console.ReadLine());
            double myDouble = double.Parse(Console.ReadLine());
            String cadena = Console.ReadLine();

            Console.WriteLine("String:" + cadena);
            Console.WriteLine("Double:" + myDouble);
            Console.WriteLine("int:" + stInt);
        }
    }
}
