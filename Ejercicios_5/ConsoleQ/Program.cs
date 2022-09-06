using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Prueba";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Blue;


            StringBuilder aux = new StringBuilder();

            List<string> nombres = new List<string>()
            {
                "R",
                "L",
                "M",
            };

            Dictionary<short, string> map = new Dictionary<short, string>();
            map.Add(3, "idolo");
            Console.WriteLine(map[3]);

            foreach (string nomb in nombres)
            {
                aux.Append(nomb);
                Console.WriteLine(nomb);
            }
            Console.WriteLine(aux.ToString());
            
            Stack numeros = new Stack();

            numeros.Push(5);
            numeros.Push(6);  
            numeros.Push(7);
            numeros.Push(8);


            int largo = numeros.Count;
            int palabra = 0;

            for (int i = 0; i < largo; i++)
            {
                palabra = (int)numeros.Pop();
                Console.WriteLine(palabra);
            }

            int divisor = 0;
            try 
            {
                int numero = 5 / divisor;
            }
            catch(FieldAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(DivideByZeroException example)
            {
                Console.WriteLine(example.Message);
            }
            finally
            {
                Console.ReadKey();
            }


            Heladera p = new Heladera("SIAM", DateTime.Now, 2);

            Console.WriteLine(p.ToString());
            Console.ReadKey();

        }
        public class Producto
        {
            private string marca;

            public Producto(string marca)
            {
                this.marca = marca;
            }

            public new string ToString()
            {
                return marca;
            }
        }

        public class Heladera : Producto
        {
            
            private double cantidadDePuertas;
            private DateTime fecha;


            public Heladera(string marca,DateTime fecha, double cantidadDePuertas) : base(marca)
            {
                this.fecha = fecha;
                this.cantidadDePuertas = cantidadDePuertas;
            }

            public new string ToString()
            {
                return $"{base.ToString()} -  {this.cantidadDePuertas} puertas";
            }
        }
    }
}
