namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
            string path = $"{ Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}";
            path += @"\Directorio\";
            //or path += "\\Directorio\\";

            Console.WriteLine(path);
            Console.WriteLine(Directory.Exists(path));

            
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                
            }
            string pathArchivo = path + "ArchivoPrueba.txt";
            
            if(Directory.Exists(path)) 
            {
                using(StreamWriter sw = new StreamWriter(pathArchivo)) 
                {
                    sw.WriteLine("LINEA 1");
                }

            }

            if(Directory.Exists(path)) 
            {
                using(StreamWriter sw = new StreamWriter(pathArchivo, true))
                {
                    sw.Write("LINEA 2");
                }
            }

            string pathArchivo2 = string.Empty;

            if (Directory.Exists(path))
            { 
                string[] archivosEnDirectorio = Directory.GetFiles(path);
                foreach (string pathA in archivosEnDirectorio)
                {
                    Console.WriteLine($"{pathA}");
                     if (pathA.Contains("ArchivoPrueba.txt"))
                     {
                        pathArchivo2 = pathA;
                        break;
                     }  
                }
            }

            if(pathArchivo2 != string.Empty)
            {
                using (StreamReader sr = new StreamReader(pathArchivo2))
                {
                    string linea;
                    while((linea = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(linea);
                    }
                }
            }

            Console.ReadKey();
            
        }
    }
}
