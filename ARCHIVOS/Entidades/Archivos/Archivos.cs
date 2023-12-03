

using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Archivos
{
    public static class Archivos<T>
    {
        public static string Leer_TXT(string path)
        {
            string retorno = string.Empty;
            try
            {
                using(StreamReader sr = new StreamReader(path))
                {
                    string linea;
                    while ((linea = sr.ReadLine()) != null)
                    {
                        retorno += linea;
                    }
                }
                return retorno;
            }
            catch(Exception e) 
            {
                retorno += e.Message;
                return retorno;
            }
        }


        public static T Leer_JSON<T>(string path)
        {
            string jsonString = File.ReadAllText(path);

            T miObject = JsonSerializer.Deserialize<T>(jsonString);

            return miObject;
        }


        public static T Leer_XML<T>(string path)
        {
            using(StreamReader sw = new StreamReader(path)) 
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                return (T)xmlSerializer.Deserialize(sw);
            }
        }


        public static bool Escribir_TXT(string path, string stream)
        {   
            bool retorno = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine(stream);
                    retorno = true;
                }
                
                return retorno;
            }
            catch (Exception e) 
            {
                retorno = false;
                return retorno;
            }   
        }


        public static void Escribir_JSON<T>(string path, T miObject)
        {
            JsonSerializerOptions opciones = new JsonSerializerOptions();
            opciones.WriteIndented = true;

            string jsonString = JsonSerializer.Serialize(miObject, opciones);

            File.WriteAllText(path, jsonString);
        }


        public static void Escribir_XML<T>(string path, T miObject)
        {
            using(StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(sw, miObject);
            }
        }
    }
}
