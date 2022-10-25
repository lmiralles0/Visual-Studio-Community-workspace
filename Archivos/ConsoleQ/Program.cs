using System;
using System.IO;
using System.Text;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var win = OperatingSystem.IsWindows();
            var linux = OperatingSystem.IsLinux();

            Console.WriteLine($"Is win {win}");

            Console.WriteLine($"Is Linux {linux}");

            var so = Environment.OSVersion;
            var plataform = Environment.OSVersion.Platform;
            var version = Environment.OSVersion.Version;
            var o = Environment.NewLine;

            Console.WriteLine($"SO {so}");
            Console.WriteLine($"Plat {plataform}");
            Console.WriteLine($"new line {Environment.NewLine} sdss");
            Console.WriteLine($"Version {version}");



            Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, -26} | {4, -26} |",
            "Nombre", "Tipo", "Formato", "Tamaño", "Espacio libre");

            foreach (DriveInfo unidad in DriveInfo.GetDrives())
            {
                if (unidad.IsReady)
                {
                    Console.WriteLine("{0, -10} | {1, -10} | {2, -7} | {3, 20:N0} bytes | {4, 20:N0} bytes |",
                    unidad.Name, unidad.DriveType, unidad.DriveFormat, unidad.TotalSize,
                    unidad.AvailableFreeSpace);
                }
                else
                {
                    Console.WriteLine("{0, -10} | {1, -10}", unidad.Name, unidad.DriveType);
                }
            }


            Console.WriteLine("DirectorySeparatorChar {0}", Path.DirectorySeparatorChar);
            Console.WriteLine("DirectorySeparatorChar {0}", Path.GetRandomFileName());

            var path = Path.Combine("mario", "utn");

            Console.WriteLine("Path combine {0}", path);

            Console.WriteLine("{0}", Directory.GetCurrentDirectory());

            try
            {

                var sb = new StringBuilder();

                sb.AppendLine("Texto linea 1");
                sb.AppendLine("Texto linea 2");

                File.WriteAllText("archivo.txt", sb.ToString());


                // NO liberar recursos aca
            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                // Liberar recursos
            }


            StreamWriter sw = null!; // = new StreamWriter("archivoSW.txt");

            try
            {
                sw = new StreamWriter("archivoSW.txt", true);

                sw.WriteLine("Linea 1");
                sw.WriteLine("Linea 2");
                sw.Write("Linea 2");
                sw.WriteLine("Linea 3");
                sw.WriteLine("Linea 5");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sw is not null)
                {
                    sw.Close();
                    sw.Dispose();
                }
            }



            // LEER ARCHIVO
            var path2 = "archivoSW.txt";

            var lecturaAll = File.ReadAllText(path2);

            Console.WriteLine("=============== ALL ==================");
            Console.WriteLine(lecturaAll);

            var lecturaLine = File.ReadAllLines(path2);

            foreach (var item in lecturaLine)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=============== STREAM READER ==================");
            var sr = File.OpenText(path2);

            Console.WriteLine(sr.ReadToEnd());

            sr.Close();
            sr.Dispose();
            Console.ReadKey();
        }
    }
}
