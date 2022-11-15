using Delegados.Clases;
using System.Collections.Generic;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Delegados
{
    internal class Program
    {
        static void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}");
        }

        static int Sumar(int numeroUno, int numeroDos)
        {
            return numeroUno + numeroDos;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            //Delegado._delegadoSaludar = new DSaludar(Saludar);
            // O
            //Delegado._delegadoSaludar = Saludar;

            Delegado._delegadoSaludar = nombre => Console.WriteLine(nombre);

            Delegado.Saludar(Saludar);
            Delegado.Saludar();

            //Delegado.Sumar(Sumar);
            Delegado.Sumar(
               (n1, n2) => n1 + n2
            );

            List<Persona> personas = new List<Persona>
            {
                new Persona("Zulema", 321),
                new Persona("Juan", 121),
                new Persona("Ana", 221),
                new Persona("Javier", 821),
            };

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==========LEGJO DESC=============");
            //personas.Sort(OrdenarDesc);
            personas.Sort(
                (p1, p2) => p2.Legajo - p1.Legajo
            );

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========NOMBRE DESC============");
            //personas.Sort(OrdenarPorNombreDesc);
            personas.Sort(
                (p1, p2) => p2.Nombre.CompareTo(p1.Nombre)
            );

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===========NOMBRE ASC============");
            //personas.Sort(OrdenarPorNombreAsc);

            personas.Sort(
                (p1, p2) => p1.Nombre.CompareTo(p2.Nombre)
            );

            foreach (var item in personas)
            {
                Console.WriteLine(item);
            }
        }

        static int OrdenarDesc(Persona p1, Persona p2)
        {
            var order = p2.Legajo - p1.Legajo;

            return order;
        }

        static int OrdenarPorNombreDesc(Persona p1, Persona p2)
        {
            var order = p2.Nombre.CompareTo(p1.Nombre);

            return order;
        }

        static int OrdenarPorNombreAsc(Persona p1, Persona p2)
        {
            var order = p1.Nombre.CompareTo(p2.Nombre);

            return order;
        }
    }
}