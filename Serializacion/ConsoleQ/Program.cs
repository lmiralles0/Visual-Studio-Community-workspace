using System;
using System.Collections.Generic;
using System.Text.Json;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============== CLASE PERSONA ==================");
            var archivo = new Archivo("personas.json");
            var personas = new List<Persona>();

            var persona = new Persona("Maria", 333);

            personas.Add(persona);
            personas.Add(new Persona("Julia", 444));
            personas.Add(new Persona("Julieta", 555));
            personas.Add(new Persona("Julo", 666));

            var opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            var personaJson = JsonSerializer.Serialize(personas, opciones);

            Console.WriteLine(personaJson);



            if (archivo.Escribir(personaJson))
            {
                Console.WriteLine("Exito");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            var lectura = archivo.LeerTodoElArchivo();

            var personaDeserializada = JsonSerializer.Deserialize<List<Persona>>(lectura);


            foreach (var item in personaDeserializada)
            {
                Console.WriteLine(item);
            }
        }
    }
}
