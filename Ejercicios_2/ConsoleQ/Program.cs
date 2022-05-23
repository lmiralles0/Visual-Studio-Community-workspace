using System;
using Bibliotecas_Ejercicios;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 1";
            
            double acumulador = 0;
            double numMax = int.MinValue;
            double numMin = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese un Nº entre 100 y -100: ");
                int numero = int.Parse((string)Console.ReadLine());
                if (Validador.Validar(numero, -100, 100))
                {
                    acumulador += numero;
                    if (numero > numMax)
                    {
                        numMax = numero;
                    }
                    else if (numero < numMin)
                    {
                        numMin = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Error al ingresar Nº: ");
                    i--;  
                }
            }
            Console.WriteLine("El menor Nº es {0}, el mayor Nº es {1}, el promedio es {2}", numMin, numMax, acumulador / 10);
            Console.ReadKey();
            
        }
    }
}
