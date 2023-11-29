namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
            string path = $"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            path += @"\Directorio\";

            Console.WriteLine(path);
            Console.WriteLine(Directory.Exists(path));

            if(!Directory.Exists(path) ) 
            {
                Directory.CreateDirectory(path);
            }
            Console.ReadKey();
            
        }
    }
}
