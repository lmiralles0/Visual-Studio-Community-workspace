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
        public static string ConvertirDecimelABinario (int numeroEntero)
        {
            string binario = string.Empty;
            int aux;
            string binario_aux = string.Empty;
          
            while (numeroEntero > 0)
            {
                aux = numeroEntero % 2;
                numeroEntero /= 2;
                binario_aux += aux.ToString();  
            }
            for (int i = binario_aux.Length - 1; i >= 0; i--)
            {
                binario += binario_aux[i];

            }
            return binario;
        }

        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numero = numeroEntero.ToString();
            int decimall = 0;
            int contador = -1;
            
            for (int i = numero.Length - 1; i >= 0; i--)
            {
                contador++; 
                if (numero[i] == '1')
                {
                    decimall += (int)Math.Pow(2, contador);
                }   
            }
            return decimall;
        }

       
    }

    public class Calculadora
    {
        public static double Calcular (double operando1, double operando2, char operacion)
        {
            double resultado = 0;
            switch (operacion)
            {
                case '+':
                    resultado = operando1 + operando2;
                    break;
                case '-':
                    resultado = operando1 - operando2;
                    break;
                case '*':
                    resultado = operando1 * operando2;
                    break;
                case '/':
                    if (Validar(operando2))
                        resultado = operando1 / operando2;
                    else
                        Console.WriteLine("Error no se puede dividir por 0");
                    break;
            }
            return resultado;
        }

        private static bool Validar (double operando2)
        {
            if (operando2 < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
