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

            Directory.CreateDirectory(path);
            path += "ArchivoPrueba.txt";
            
            if(Directory.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("LINEA 1");
                    sw.Close();
                }
            }

            if (Directory.Exists(path)) 
            {
                using(StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.Write("LINEA 2");
                    sw.Close();   
                }
            }
            //Console.ReadKey();
            
        }
    }
}
