using System;

namespace Bibliotecas_Ejercicios
{
    public class Validador
    {
        public static bool Validar (int valor, int min, int max)
        {
            if(valor >= min && valor <= max && max > min)
                return true;
            else
                return false;
        }

        public static bool ValidarRespuesta(string respuesta)
        {
            if (respuesta == "S" || respuesta == "s")
                return true;
            if (respuesta == "N" || respuesta == "n")
                return false;
            else
                respuesta = Console.ReadLine();
                return Validador.ValidarRespuesta(respuesta);
        }
    }

    public class Conversor
    {
        public static string ConvertidorDecimelABinario (int numeroEntero)
        {
            string binario = string.Empty;
            int aux = 0;
            for (int i = numeroEntero; i >= 0 ; i--)
            {
                aux = i % 2;
                binario += aux.ToString();
            }
            return binario;
        }
    }
}
