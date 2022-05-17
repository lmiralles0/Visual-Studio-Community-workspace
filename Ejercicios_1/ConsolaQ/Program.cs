using System;

namespace ConsolaQ
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            Console.Title = "Ejercicio N° 1";
            int[] IntArray = new int[5];
            string aux;
            Console.WriteLine("Ingrese un N°: ");
            for (int i = 0; i < IntArray.Length; i++)
            {
                aux = Console.ReadLine();
                IntArray[i] = int.Parse(aux);
            }
            int maximo = 0;
            int minimo = 0;
            int contador = 0;
            for (int i = 0; i < IntArray.Length; i++)
            {
                if(i == 0)
                {
                    maximo = IntArray[i];
                    minimo = IntArray[i]; 
                }
                else if(IntArray[i] > maximo)
                {
                    maximo = IntArray[i];
                }
                else if(IntArray[i] < minimo)
                {
                    minimo = IntArray[i];
                }
                contador += IntArray[i]; 
            }

          
            Console.WriteLine("El numero mayor es {0}, el numero menor es {1} y el promedio es {2:#.0}", maximo, minimo, (double)contador/IntArray.Length);
            Console.ReadKey(false);  
            Console.Clear();
            /////
            ///
            Console.Title = "Ejercicio N° 2";

            Console.WriteLine("Ingrese un N° para calcular su cubo: ");
            int num = int.Parse(Console.ReadLine());
            if (num <= 0)
                Console.WriteLine("ERROR.¡Reingresar numero!");
            else
            {
                num = (int)Math.Pow(num, 3);
                Console.WriteLine("{0:}",num);  
            }

            Console.ReadKey(false);
            Console.Clear();
            //////  
            ///

            Console.Title = "Ejercicio N° 3";

            string exit = "";
            int numero;
            string aux_1;
            int cont;
            int flag = 0;
            do
            {
                aux_1 = exit;
                if (flag == 0)
                {
                    Console.WriteLine("Ingrese un N° mayor a uno: ");
                    aux_1 = Console.ReadLine();
                }
                bool resultado = Int32.TryParse(aux_1, out numero);

                if (resultado && numero > 1)
                {
                    for (int i = 2; i <= numero; i++)
                    {
                        cont = 0;
                        for (int y = 1; y <= i; y++)
                        {
                            if (i % y == 0)
                            {
                                cont += 1; 
                            }
                            if (cont == 2 && y == i)
                            {
                                Console.WriteLine(i);
                            }      
                        }
                    }
                }
                else
                {
                    Console.Write("Error ingrese un N° o escriba salida: ");
                    exit = Console.ReadLine();
                    if(exit != "salida")
                        flag = 1;
                        continue;
                }
               
                Console.Write("Escriba \'salida\' para salir: ");
                exit = Console.ReadLine();
            } while (exit != "salida");


            Console.ReadKey(false);
            Console.Clear();
            //////  
            ///

            Console.Title = "Ejercicio N° 4";
            Console.WriteLine("N° perfectos");
            int seguir = 1;
            int numAcumulador = 1;
            int perfecto = 0;
            while (seguir <= 4)
            {
                for (int y = 1; y < numAcumulador; y++)
                {

                    if (numAcumulador % y == 0)
                    {
                        perfecto += y;

                    }
                }
                if (numAcumulador == perfecto)
                {
                    Console.WriteLine(numAcumulador);
                    seguir++;
                }
                numAcumulador++;
                perfecto = 0;


            }
            Console.ReadKey(false);
            Console.Clear();

            Console.Title = "Ejercicio N° 5";
            double numeros,
                    sumaAtras,
                    sumaAdelante,
                    aumento = 1;


            Console.Write("Ingrese un numero  ");
            numeros = double.Parse(Console.ReadLine());

            // Comienzo del programa
            while (aumento < numeros)
            {
                aumento++;
                sumaAtras = 0;
                sumaAdelante = 0;

                // Calculo para atras
                for (double i = 1; i < aumento; i++)
                {
                    sumaAtras = sumaAtras + i;
                }
                //calculo para adelante
                for (double j = aumento + 1; j <= sumaAtras; j++)
                {
                    if ((sumaAdelante == sumaAtras) || (sumaAdelante > sumaAtras))
                        break;
                    sumaAdelante = sumaAdelante + j;
                }

                // Mostrando en pantalla
                if (sumaAtras == sumaAdelante)
                    Console.WriteLine("Es centro numerico: {0}", aumento);
            }
            Console.ReadKey(false);
            Console.Clear();

            Console.Title = "Ejercicio N° 6";

            Console.Write("Escriba el año a verificar si es biciesto: ");
            double año = double.Parse((string)Console.ReadLine());

            if (año % 4 == 0 && año % 100 != 0)
            {
                Console.WriteLine("El año {0} es biciesto.", año);
            }
            else if (año % 4 == 0 && año % 100 == 0 && año % 400 == 0)
            {
                Console.WriteLine("El año {0} es biciesto.", año);
            }
            else
            {
                Console.WriteLine("El año {0} no es biciesto", año);
            }
             
            ///
            ///
            
            Console.ReadKey(false);
            Console.Clear();
            */

            Console.Title = "Ejercicio N° 7";
            char continuar = 's';
            string nombre;
            string aux_Nombre = string.Empty;
            string hora_Aux;
            string antiguedad_Aux;
            string totalXTrabajadorBruto_Aux;
            string totalXTrabajadorNeto_Aux;

            do
            {
                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese el valor de de trabajo por hora: ");
                int hora = int.Parse((string)Console.ReadLine());
                Console.Write("Ingrese la antiguedad: ");
                int antiguedad = int.Parse((string)Console.ReadLine());
                Console.Write("Ingrese la cantidad de horas trabajadas: ");
                int cantidadDeHoras = int.Parse((string)Console.ReadLine());
                double totalXTrabajdorBruto = (hora * cantidadDeHoras) + (antiguedad * 150);
                double totalXTrabajdorNeto = totalXTrabajdorBruto - (totalXTrabajdorBruto * 0.13);
                hora_Aux = Convert.ToString(hora);
                antiguedad_Aux = Convert.ToString(antiguedad);
                totalXTrabajadorBruto_Aux = Convert.ToString(totalXTrabajdorBruto);
                totalXTrabajadorNeto_Aux = Convert.ToString(totalXTrabajdorNeto);

                if (hora > 0 && antiguedad > 0 && cantidadDeHoras > 0 )
                {
                    aux_Nombre += nombre + '|';
                    hora_Aux += hora_Aux + '|';
                    antiguedad_Aux += antiguedad_Aux + '|';
                    totalXTrabajadorBruto_Aux += totalXTrabajadorBruto_Aux + '|';
                    totalXTrabajadorNeto_Aux += totalXTrabajadorNeto_Aux + '|';
                }
                else
                    break;

                Console.Write("Desea continuar? Pulse \'s' o pulse \'n' para salir: ");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 's');
           
            nombre = string.Empty;
            string h;
            string h1;
            string h2;
            string h3;
            string h4;
                       
            for (int letra = 0; letra != aux_Nombre.Length; letra++)
            {
                if (aux_Nombre[letra] == '|')
                {
                    Console.Write("Empleado : {0}", nombre);
                    nombre = "";
                    continue;
                }
                nombre += Convert.ToString(aux_Nombre[letra]);   
            }
            


        }
    }
}
