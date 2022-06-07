using System;
using Objects;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuentas a = new Cuentas("Luciano Miralles", 5000);
            
            Console.WriteLine(a.GetTitular());
            Console.ReadKey();
            
        }
    }
}
