using Biblioteca;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float temperaturaCelsius = 9;
            temperaturaCelsius = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);

            Console.WriteLine("{0}", temperaturaCelsius.ToString());
            double buffer;

            //Potencia 
            buffer = Math.Pow(2, 5); // 2 elevado a 5
            Console.WriteLine($"POTENCIA: {buffer}");

            //Raiz Cuadrada
            buffer = Math.Sqrt(25);
            Console.WriteLine($"RAIZ CUADRADA: {buffer}");

            //REDONDEO
            buffer = Math.Round(3.1416, 2); //Rodendeo de 2
            Console.WriteLine($"REDONDEO: {buffer}");

            //SENO
            buffer = Math.Sin(Math.PI / 2); //SENO DE 90
            Console.WriteLine($"SENO: {buffer}");

            //COSENO
            buffer = Math.Cos(Math.PI); //COSENO DE 180
            Console.WriteLine($"COSENO: {buffer}");

            Console.ReadKey();
            DateTime dateTime = new DateTime();
        }
    }
}