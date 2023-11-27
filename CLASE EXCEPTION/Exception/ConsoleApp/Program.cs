namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
         
            

            try
            {
                int num1 = 0;
                int num = 5 / num1;
                Console.WriteLine(num.ToString());
            }
            catch(Exception)
            {
                Console.WriteLine("No se puede dividir por 0 capo");
            }

            Console.ReadKey();
        }
    }
}
