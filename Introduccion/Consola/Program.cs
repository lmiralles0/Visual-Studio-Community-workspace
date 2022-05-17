using System;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Variales
            /// Fraccionarias
            /*double ;
            float ;
            decimal ;*/

            Console.WriteLine();
            /// Enteras
            short numChico = 32000; //ushort
            long numGrande = 900000L; //ulong
            int numeroEntero = 5; //uint

            Console.WriteLine("short {0}, long {1}, int {2}",numChico, numGrande, numeroEntero);
            /// Literales
            string texto = "Hello World";
            char letra = 'd';

            Console.WriteLine("{0} {1}",letra.ToString(),texto.ToString());
            ///Booleanos
            bool verdadero = true;
            bool falso = false;

            Console.WriteLine("bool {0} {1}", verdadero, falso);
            ///Object && Dynamic && Inferencias

            dynamic nombre_1 = "Salazar";
            int longitud_2 = nombre_1.Length;
            object nombre = "Esteban";
            var promedio = 5.55;
            int longitud = ((string)nombre).Length;

            Console.Write("El promedio del alumno {0} es {1} y se almaceno en {2}", nombre, promedio, promedio.GetType().Name);
            Console.Write(". El {0} tiene {1} letras\n", nameof(nombre), longitud);
            Console.WriteLine("{0}", longitud_2);
            ///Valores por defecto (default) && tamaños ($, max, min)
            
            Console.WriteLine("Tamaño por defecto de {0} {1}",longitud.GetType().Name, default(int));
            Console.WriteLine("Tamaño del int en bit: {0}, minimo valor {1}, maximo valor {2}", sizeof(int), int.MinValue, int.MaxValue);
            ////Bucle foreach
            foreach (char letras in texto)
            {
                Console.WriteLine(letras.ToString());
            }

            ///OUTPUT && INPUT
            ///Console

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            string placaDeVideo = "Nvidia RTX 3080";
            decimal precioPlacaVideo = 344663.36M;
            string procesador = "Ryzen 7 5800x";
            decimal precioProcesador = 63595M;

            Console.WriteLine("{0,-20} {1,10}", "Producto", "Precio");
            Console.WriteLine("{0,-20} {1,10:N2}", placaDeVideo, precioPlacaVideo);
            Console.WriteLine("{0,-20} {1,10:N2}", procesador, precioProcesador);
            
            string fruta = Console.ReadLine();
            Console.WriteLine("Mandale {0}",fruta);

            fruta = Console.ReadLine();
            double precio = float.Parse(fruta);
            double precioMasIva = precio + (precio * 0.21);

            Console.WriteLine("El precio es {0:$#.00}, con IVA {1:$#.00}", precio, precioMasIva);

            Console.WriteLine("Presione una tecla o combinación de teclas:");

            Console.Clear();
            ConsoleKeyInfo teclaPresionada = Console.ReadKey(true);

            ConsoleKey tecla = teclaPresionada.Key;
            char caracter = teclaPresionada.KeyChar;
            ConsoleModifiers modificadores = teclaPresionada.Modifiers;
            Console.Beep(); // Sonido por defecto.

            Console.WriteLine("Tecla: {0}. Caracter: {1}. Modificadores: {2}", tecla, caracter, modificadores);
            Console.Title = "Mi primer programa en C#";
            Environment.Exit(0);    
        }
    }
}
