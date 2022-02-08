using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double hind = 15;
            string p_tuup = "tais";

            Console.WriteLine("Hello World! Mis on sinu nimi on");
            Console.Title="Pealkiri";
            string nimi = Console.ReadLine();
            char[] tahed = nimi.ToCharArray();//juku-['j','u','k','u']
            int i = 0;
            nimi = "";
            foreach (var t in tahed)
            {
                if (i==0)
                {
                    nimi += t.ToString().ToUpper();

                }
                else
                {
                    nimi += t.ToString().ToLower();
                }
                i++;
            }
            Console.WriteLine("Tere {0}!", nimi);
            if (nimi.ToUpper()=="JUKU"|| nimi.ToLower()=="sasha")
            {

                Console.WriteLine($"Tule kulla!{nimi} kas tahad kinna");
                string vastus = Console.ReadLine();
                if (vastus.ToLower()=="jah"|| vastus.ToLower()=="yes" || vastus.ToLower()=="да")
                {
                    int vanus = int.Parse(Console.ReadLine());
                    if (vanus<=0 || vanus>109)
                    {
                        Console.WriteLine("Viga");
                        p_tuup = "viga andmetega";
                    }
                    else
                    {
                        if (vanus > 0 && vanus < 6)
                        {
                            hind -= hind;
                            p_tuup = "Tasuta";
                        }
                        else if (vanus > 6 && vanus < 12)
                        {
                            hind -= hind * 0.5;
                            p_tuup = "lastepilet";
                        }
                        else if (vanus > 15 && vanus < 65)
                        {
                            hind -= hind * 0.25;
                            p_tuup = "täispilet";
                        }
                        else if (vanus > 65 && vanus < 108)
                        {
                            hind -= hind * 0.1;
                            p_tuup = "sooduspilet";

                        }
                        else if (vanus > 65)
                        {
                            hind -= hind * 0.5;
                            p_tuup = "Tasuta";
                        }
                        Console.WriteLine("{0}, sul {2} pilet vaja maksta{1}", nimi,hind,p_tuup);
                    }
                    





                }
                else 
                {
                    Console.WriteLine("Ei taha :(");
                }
            }
            else
            {
                Console.WriteLine("Tana ma olen hoivatud:(");
            }
            */


            /*
            Console.WriteLine("Tere! Palun sisestage teie nimed");
            Console.WriteLine();
            string n1 = Console.ReadLine();
            string n2 = Console.ReadLine();
            if ((((n1=="Mihail" && n1=="Marko")||(n2 == "Mihail" && n1 == "Marko")) || ((n1 == "Edgar" && n1 == "Marko") || (n2 == "Edgar" && n1 == "Marko")))|| ((n1 == "Aleksandr A" && n1 == "Aleksandr K") || ((n1 == "Aleksandr A" && n1 == "Daniil") || (n2 == "Daniil" && n1 == "Aleksandr A")) || ((n1 == "Elena" && n1 == "Alina") || (n2 == "Alina" && n1 == "Elena")) || ((n1 == "Vlademir" && n1 == "Ervin") || (n2 == "Ervin" && n1 == "Vlademir"))))
            {
                Console.WriteLine("Sa oled Pinginaabrid");
            }
            else
            {
                Console.WriteLine("Sa ei oled Pinginaabrid");
            }

            */

            /*
            Console.WriteLine("Sisestage põranda pindala!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((a != 0 && b != 0) || (a < 0 && b < 0))
            {
                int S = a * b;
                Console.WriteLine(S + "m2");
                Console.WriteLine();
                Console.WriteLine("Kas sa tahad remondi teha?");
                string c = Console.ReadLine();
                if (c.ToUpper() == "JAH" || c.ToLower() == "jah")
                {
                    Console.WriteLine("Kui palju maksab 1 m2?");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine("Kui palju maksab põranda vahetus?");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Sul on vaja maksta :" + d + e + " euro");
                }
                else
                {
                    Console.WriteLine(":(");
                }
            }
            else
            {
                Console.WriteLine("Viga");
            }
            */
            /*
            Console.WriteLine("Kui pikk sa oled?");
            int pikk = int.Parse(Console.ReadLine());
            if (pikk <= 60 || pikk > 300)
            {
                Console.WriteLine("Viga");
            }
            else
            {
                if (pikk > 80 && pikk < 140)
                {
                    Console.WriteLine("Luhike");
                }
                else if (pikk > 140 && pikk < 165)
                {
                    Console.WriteLine("Keskmine");
                }
                else if (pikk > 165 && pikk < 230)
                {
                    Console.WriteLine("Korge");
                }
            }
            */
            /*
            Console.WriteLine("Kui pikk sa oled?");
            Console.WriteLine("Mis on sinu sugu?");
            int pikk = int.Parse(Console.ReadLine());
            string sugu = Console.ReadLine();
            if (sugu=="Mees" && sugu=="MEES");
            {

            }
            if (pikk <= 60 || pikk > 300)
            {
                Console.WriteLine("Viga");
            }
            else
            {
                if (pikk > 80 && pikk < 150)
                {
                    Console.WriteLine("Luhike");
                }
                else if (pikk > 150 && pikk < 165)
                {
                    Console.WriteLine("Keskmine");
                }
                else if (pikk > 165 && pikk < 230)
                {
                    Console.WriteLine("Korge");
                }
                if (sugu == "Naine" && sugu == "NAINE") ;
                {

                }
                if (pikk <= 60 || pikk > 300)
                {
                    Console.WriteLine("Viga");
                }
                else
                {
                    if (pikk > 80 && pikk < 130)
                    {
                        Console.WriteLine("Luhike");
                    }
                    else if (pikk > 130 && pikk < 160)
                    {
                        Console.WriteLine("Keskmine");
                    }
                    else if (pikk > 160 && pikk < 190)
                    {
                        Console.WriteLine("Korge");
                    }

                }
                }

            */
            int piim = 2;
            int saia = 1;
            int leib = 1;




                    Console.ReadKey();
        }
    }    
}
