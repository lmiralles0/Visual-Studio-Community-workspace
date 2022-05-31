using System;
using Objects;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuentas a = new Cuentas("Lu1ciano Miralles", 5000);

            Console.WriteLine(a.titular);
            Console.ReadKey();


            
        }
    }
}
