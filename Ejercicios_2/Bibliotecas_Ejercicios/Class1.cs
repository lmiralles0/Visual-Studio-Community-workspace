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
    }
}
