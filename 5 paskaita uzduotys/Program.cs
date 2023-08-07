using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Pasirinkimas();
            }
            Console.ReadLine();
        }
        public static void Pasirinkimas()
        {
            //Cia aprasykite kintamuosius
            int a = 3, b = 6, c = 19;
            string vardas = "Kamile";
            float kaina = 0f, vidurkis = 8.4f;

            Console.WriteLine("Pasirinkite užduotį (1 - 10)");
            string input = Console.ReadLine();
            Console.WriteLine("--------------");
            Console.WriteLine();

            if (input == "1")
            {
                Pirma();
            }
            else if (input == "2")
            {
                Antra();
            }
            else if (input == "3")
            {
                Trecia();
            }
            else if (input == "4")
            {
                Ketvirta();
            }
            else if (input == "5")
            {
                Penkta(vardas);
            }
            else if (input == "6")
            {
                Sesta();
            }
            else if (input == "7")
            {
                Septinta(b, c);
            }
            else if (input == "8")
            {
                Astunta();
            }
            else if (input == "9")
            {
                Devinta();
            }
            else if (input == "10")
            {
                Desimta(b);
            }
            else if (input == "11")
            {
                Vienuolikta();
            }
            else
            {
                Console.WriteLine("Neteisingas užduoties numeris. Prašome pakartoti pasirinkimą.");
            }

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine("Noredami testi paspauskite ENTER");
            Console.ReadLine();
            Console.Clear();
        }

        public static void Pirma()
        {
            Console.WriteLine("---- #1 ----");
            Console.WriteLine();
            Console.WriteLine("Įveskite skaičių.");

            float sk = float.Parse(Console.ReadLine());

            Console.WriteLine();

            if (sk == 0)
            {
                Console.WriteLine("Skaičius netinkamas.");
            }
            else
            {
                PakeltiKvadratu(sk);
            }
        }

        public static void PakeltiKvadratu(float sk)
        {
            Console.WriteLine("{0}² = {1}", sk, sk * sk);
        }

        public static void Antra()
        {
            Console.WriteLine("---- #2 ----");
            Console.WriteLine();
            Console.WriteLine("Įveskite sveiką skaičių.");

            int sk = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Įveskite sakinį.");

            string sakinys = Console.ReadLine();

            Console.WriteLine();

            PildykLenta(sk, sakinys);
        }

        public static void PildykLenta(int kiek, string sakinys)
        {
            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine(sakinys);
            }
        }

        public static void Trecia()
        {
            string ats1, ats2;

            Console.WriteLine("---- #3 ----");
            Console.WriteLine();
            Console.WriteLine("Ar padarei namų darbus?");

            ats1 = Console.ReadLine();

            Console.WriteLine();

            if (ats1 == "Taip")
            {
                Console.WriteLine("Šaunuolis(-ė)!, imk sausainį!");
            }
            else if (ats1 == "Nesigavo")
            {
                Console.WriteLine("Ateik, paaiškinsiu...");
            }
            else if (ats1 == "Ne")
            {
                Console.WriteLine("Kodėl?");

                ats2 = Console.ReadLine();

                Console.WriteLine();

                if (ats2 == "Pamirsau")
                {
                    Console.WriteLine("Kitą kartą nepamiršk!");
                }
                else if (ats2 == "Tingejau")
                {
                    Console.WriteLine("Sėsk 2!");
                }
            }
            else
            {
                Console.WriteLine("Nesuprantu, ką čia murmi??");
            }

        }
        public static void Ketvirta()
        {
            int sk, sk1, sk2, sk3, sk4;

            Console.WriteLine("---- #4 ----");
            Console.WriteLine();
            Console.WriteLine("Įveskite keturženkį skaičių.");

            sk = int.Parse(Console.ReadLine());

            Console.WriteLine();

            sk4 = sk % 10;
            sk3 = sk / 10 % 10;
            sk2 = sk / 100 % 10;
            sk1 = sk / 1000;

            Console.WriteLine("sk1 = {0}, sk2 = {1}, sk3 = {2}, sk4 = {3}", sk1, sk2, sk3, sk4);
        }
        public static void Penkta(string vardas)
        {
            int i = 0;
            string ivestasVardas;

            Console.WriteLine("---- #5 ----");

            while (i < 2)
            {
                Console.WriteLine();

                if (i == 0)
                {
                    Console.WriteLine("1. Koks tavo vardas?");
                }
                else if (i == 1)
                {
                    Console.WriteLine("2. Koks tavo vardas?");
                }

                ivestasVardas = Console.ReadLine();

                if (ivestasVardas == vardas)
                {
                    i++;
                }
                else
                {
                    i = 0;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Sveika, " + vardas);
        }
        public static void Sesta()
        {
            Console.WriteLine("---- #6 ----");
            Console.WriteLine();

            for (int i = 5; i <= 15; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void Septinta(int b, int c)
        {
            Console.WriteLine("---- #7 ----");
            Console.WriteLine();
            Console.WriteLine("Šie skaičiai nuo {0} iki {1} dalijasi iš 3:", b, c);

            for (int i = b; i <= c; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public static void Astunta()
        {
            Console.WriteLine("---- #8 ----");
            Console.WriteLine();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(i);
                }

                Console.WriteLine(i);
            }
        }
        public static void Devinta()
        {
            Console.WriteLine("---- #9 ----");
            Console.WriteLine();

            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write(j);
                }

                Console.WriteLine(i);
            }
        }
        public static void Desimta(int b)
        {
            Console.WriteLine("---- #10 ----");
            Console.WriteLine();

            for (int i = b; i <= 30; i++)
            {
                Console.Write(i + " dalinasi iš:");

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        Console.Write(" " + j);
                    }
                }

                Console.Write("\n");
            }
        }
        public static void Vienuolikta()
        {
            Console.WriteLine("---- #11 ----");
            Console.WriteLine();

            bool pirminis;

            Console.Write("1");

            for (int i = 1; i <= 9999; i++)
            {
                pirminis = false;

                for (int j = 2; j <= i; j++)
                {
                    if (j == i)
                    {
                        pirminis = true;
                    }
                    else
                    {
                        if (i % j == 0)
                        {
                            j = i;
                        }
                    }
                }

                if (pirminis)
                {
                    Console.Write(", ");
                    Console.Write(i);
                }
            }
        }
    }
}