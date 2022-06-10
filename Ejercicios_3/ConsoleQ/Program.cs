using System;
using Objects;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicios N° 1";


            Cuentas a = new Cuentas("Luciano Miralles", 5000);

            Console.WriteLine(a.Mostrar(a));
            Console.ReadKey();
            
        }
    }
}
