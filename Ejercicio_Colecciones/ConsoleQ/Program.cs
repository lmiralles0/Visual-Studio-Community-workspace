<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackPositivo = new Stack<int>();
            Stack<int> stackNegativo= new Stack<int>();
            Queue<int> queuePositvo = new Queue<int>();
            Queue<int> queueNegativo= new Queue<int>();
            List<int> lista = new List<int>();
            Random random = new Random();
            int aux = 0;

            for (int i = 0; i < 20; i++)
            {
                aux = random.Next(-100, 100);
                if(aux != 0)
                {
                    lista.Add(aux);
                }
            }
            foreach(int num in lista)
            {
                Console.Write($"{num} ");
            }
            
            Console.WriteLine("");
            lista.Sort();
            lista.Reverse();
            
            foreach(int num in lista)
            {
                if(num > 0)
                {
                    Console.Write($"{num} ");
                    stackPositivo.Push(num);
                    queuePositvo.Enqueue(num);
                }
            }

            Console.WriteLine("");


            lista.Reverse();

            foreach (int num in lista)
            {
                if(num < 0)
                {
                    Console.Write($"{num} ");
                    stackNegativo.Push(num);
                    queueNegativo.Enqueue(num);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Queue");
            foreach (int num in queueNegativo)
            {
                Console.WriteLine(num);
            }



            Console.WriteLine("Stack");
            foreach(int num in stackNegativo)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
=======
﻿using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace ConsoleQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackPositivo = new Stack<int>();
            Stack<int> stackNegativo= new Stack<int>();
            Queue<int> queuePositvo = new Queue<int>();
            Queue<int> queueNegativo= new Queue<int>();
            List<int> lista = new List<int>();
            Random random = new Random();
            int aux = 0;

            for (int i = 0; i < 20; i++)
            {
                aux = random.Next(-100, 100);
                if(aux != 0)
                {
                    lista.Add(aux);
                }
            }
            foreach(int num in lista)
            {
                Console.Write($"{num} ");
            }
            
            Console.WriteLine("");
            lista.Sort();
            lista.Reverse();
            
            foreach(int num in lista)
            {
                if(num > 0)
                {
                    Console.Write($"{num} ");
                    stackPositivo.Push(num);
                    queuePositvo.Enqueue(num);
                }
            }

            Console.WriteLine("");


            lista.Reverse();

            foreach (int num in lista)
            {
                if(num < 0)
                {
                    Console.Write($"{num} ");
                    stackNegativo.Push(num);
                    queueNegativo.Enqueue(num);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Queue");
            foreach (int num in queueNegativo)
            {
                Console.WriteLine(num);
            }



            Console.WriteLine("Stack");
            foreach(int num in stackNegativo)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
>>>>>>> 5b63a2e02c465abaafd091827697c2e99c3842c4
