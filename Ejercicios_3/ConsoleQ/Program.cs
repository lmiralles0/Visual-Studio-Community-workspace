using System;
using Objects;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.Title = "Ejercicios N° 1";


            Cuentas a = new Cuentas("Luciano Miralles", 5000);

            Console.WriteLine(a.Mostrar(a));
            Console.ReadKey();

            Estudiante a = new Estudiante("Luciano", "Miralles", "110669");

            a.SetNotaPrimerParcial(7);
            a.SetNotaSegundoParcial(6);

            Console.WriteLine(a.Mostrar());*/


            int aux;
            Random num = new Random();


            int contador = 5;
            while (contador > 0)
            {
                aux = num.Next(5, 11);
                Console.WriteLine(aux);
                contador--;

            }

            


            Console.ReadKey();
            
            
        }
    }
}
