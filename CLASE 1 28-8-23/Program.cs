namespace CLASE_1_28_8_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorIngresado;
            string buffer;
            bool estado;
            int contador = 0;
            int acumuladorIngreso = 0;
            float promedio;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;

            do
            {
                Console.WriteLine("Ingrese numero");
                buffer = Console.ReadLine();
                estado = int.TryParse(buffer, out valorIngresado);
                
                while(!estado)
                {
                    Console.WriteLine("Error ingrese un numero...");
                    buffer = Console.ReadLine();
                    estado = int.TryParse(buffer, out valorIngresado);

                }

                acumuladorIngreso += valorIngresado;
                
                
                if(valorIngresado > maximo)
                {
                    maximo = valorIngresado;
                }
                if (valorIngresado < minimo)
                {
                    minimo = valorIngresado;
                }

                contador++;

            } while(contador < 5);

            if (contador !=  0) 
            {
                promedio = (float)acumuladorIngreso / contador;
                Console.WriteLine("El promedio es {0} ", promedio.ToString());
            }

            Console.WriteLine("MAXIMO: {0} \nMINIMO: {1}", maximo.ToString(), minimo.ToString());
            Console.ReadKey();


        }
    }
}