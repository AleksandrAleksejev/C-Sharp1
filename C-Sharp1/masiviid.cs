using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1
{
    class masiviid
    {
        static void Main(string[] args)
        {/*/
            Random rnd = new Random();
            int[] arvud = new int[10];
            for (int i = 0; i < arvud.Length; i++)
            {
                arvud[i] = rnd.Next(1, 100);
            }
            foreach (int arv in arvud)
            {
                Console.Write($"{arv,4}"); 
            }
            Console.WriteLine();
            string[] nimed = new string[5] { "Anna", "Olga", "Daniil", "Aleksandr", "Mark" };
           
            int a=0;
            do
            {
                Console.Write("Jrkordne number(tavaline inimene)1-5: ");//1,2,3,4,5,
                try
                {
                    a = int.Parse(Console.ReadLine());
                }
                catch (Exception error)
                {

                    Console.WriteLine(error);
                }
               
            } while (a<1 || a>5);
            Console.WriteLine(nimed[a-1]);

            */
            /*
            Random rnd = new Random();
            int N = rnd.Next(1, 100);
            int M = rnd.Next(1, 100);
            Console.WriteLine($"N={N}");
            Console.WriteLine($"M={M}");

            if (N>M)
            {
                int abi = N;
                N = M;
                N = abi;
            }
            int[] NM = new int[M-N+1];
            for (int j = N; j < M+1; j++)
            {
                NM[j-N] = j;
                Console.WriteLine(j*j);
            }
            */
            /*
            Console.WriteLine("Напишите 5 чисел: ");
            int[] arvud0 = new int[5];
            for (int i = 0; i < arvud0.Length; i++)
            {
                arvud0[i] = int.Parse(Console.ReadLine());
            }
            int summa = 0;
            int korrutis = 1;
            /*foreach (int arv in arvud0)
            {
                summa += arv;
                korrutis *= arv;
            }*/
            /*
            for (int i = 0; i < arvud0.Length; i++)
            {
                summa += arvud0[i];
                korrutis *= arvud0[i];

            }
            Console.WriteLine($"Summa = {summa}");
            Console.WriteLine($"Korrutis = {korrutis}");
            Console.WriteLine($"Keskmine = {korrutis / arvud0.Length,4}");
            */
            /*
           

            
            /*
            //elevant
            string a = "";
            while (a.ToLower() != "слон")
            {
                Console.WriteLine("Купи слона!");
                a = Console.ReadLine();
            }
            Console.WriteLine("Конец");
            */
            
            /*
            //Math tabl
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j).ToString() + "\t");
                }
                Console.WriteLine();
            }
            */










            Console.ReadLine();
        }
    }
}
