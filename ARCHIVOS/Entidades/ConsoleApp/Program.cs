using Archivos;
using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona();
            pers.Name = "Luciano";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
            Archivos<Persona>.Escribir_XML(path,pers);
            Console.WriteLine(path);    
            Console.ReadKey();
        }
        
    }
}
