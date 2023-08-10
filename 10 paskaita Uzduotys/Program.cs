using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_paskaita_Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toliau = true;

            while (toliau)
            {
                Console.WriteLine("Pasirinkite funkciją.");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Spausdink 3");
                Console.WriteLine("3. Klausimas");
                Console.WriteLine("4. RaidesA");
                Console.WriteLine("5. Zodziai");
                Console.WriteLine("6. Graza");
                Console.WriteLine("7. Masyvas");
                Console.WriteLine("x - baigti programą.");
                Console.WriteLine();
                Console.WriteLine("Įveskite tik skaičių arba x.");

                string funNr = Console.ReadLine(); //Funckijos pasirinkimui

                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();

                if (funNr == "1")
                {
                    Suma();
                }
                else if (funNr == "2")
                {
                    Spausdink3();
                }
                else if (funNr == "3")
                {
                    Klausimas();
                }
                else if (funNr == "4")
                {
                    RaidesA();
                }
                else if (funNr == "5")
                {
                    Zodziai();
                }
                else if (funNr == "6")
                {
                    Graza();
                }
                else if (funNr == "7")
                {
                    Masyvas();
                }
                else if (funNr == "x")
                {
                    toliau = false;
                }
                else
                {
                    Console.WriteLine("Neteisinga funkcija.");
                }

                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine("Noredami testi paspauskite ENTER");
                Console.ReadLine();
                Console.Clear();
            }
        }

        public static void Suma()
        {
            Console.Clear();
            Console.WriteLine("---- #1 ----");
            Console.WriteLine();

            Console.WriteLine("Iveskite kiek norite sveiku skaiciu. Skaicius atskirkite tarpais:");
            string input = Console.ReadLine().Trim();

            string[] skaiciai = input.Split(' ');

            int suma = 0, sk;

            foreach (string skaicius in skaiciai)
            {
                sk = int.Parse(skaicius);

                if (sk % 2 == 0)
                {
                    suma += sk;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Ivestu lyginiu skaiciu suma: " + suma);
        }

        public static void Spausdink3()
        {
            int sk1, sk2;

            Console.Clear();
            Console.WriteLine("---- #2 ----");
            Console.WriteLine();

            Console.WriteLine("Iveskite dvizenkli skaiciu:");
            sk1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite kita dvizenkli skaiciu, kuris butu didesnis uz pirma:");
            sk2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            if (sk1 > 99 || sk1 < 10 || sk2 > 99 || sk2 < 10)
            {
                Console.WriteLine("Pabaiga.");
            }
            else
            {
                for (int i = sk1; i <= sk2; i++)
                {
                    if (i > sk1)
                    {
                        Console.Write(", ");
                    }

                    Console.Write(i);

                    if (i % 3 == 0)
                    {
                        i++;
                    }
                }

                Console.Write("\n");
            }
        }

        public static void Klausimas()
        {
            string tekstas;
            bool tekstasTeisingas = false;
            
            while (!tekstasTeisingas)
            {
                Console.Clear();
                Console.WriteLine("---- #3 ----");
                Console.WriteLine();

                Console.WriteLine("Iveskite teksta, kuris prasidetu zodziu \"Labas\", o pasibaigtu klaustuku (?)");
                tekstas = Console.ReadLine();

                Console.WriteLine();

                if((tekstas.Substring(0, 5) == "Labas") && (tekstas.Substring(tekstas.Length - 1) == "?"))
                {
                    Console.WriteLine("Aciu!");
                    tekstasTeisingas = true;
                }
                else
                {
                    Console.WriteLine("Neteisingai...");
                }

                Console.ReadLine();
            }           

        }

        public static void RaidesA()
        {
            string tekstas;
            bool tekstasTeisingas = false;
            int kiekA;

            while (!tekstasTeisingas)
            {
                Console.Clear();
                Console.WriteLine("---- #4 ----");
                Console.WriteLine();

                kiekA = 0;

                Console.WriteLine("Iveskite teksta, kuriame butu BENT 3 raides a");
                tekstas = Console.ReadLine();

                Console.WriteLine();

                foreach (char x in tekstas.ToLower())
                {
                    if (x == 'a')
                    {
                        kiekA++;
                    }
                }

                if (kiekA >= 3)
                {
                    Console.WriteLine("Aciu!");
                    tekstasTeisingas = true;
                }
                else
                {
                    Console.WriteLine("Neteisingai...");
                }

                Console.ReadLine();
            }
        }

        public static void Zodziai()
        {
            int kiek, vidutinisIlgis;
            List<string> zodziai = new List<string>();
            int ilgiuSuma = 0;

            Console.Clear();
            Console.WriteLine("---- #5 ----");
            Console.WriteLine();

            Console.WriteLine("Iveskite, kiek zodziu pildysite:");
            kiek = int.Parse(Console.ReadLine());
            Console.WriteLine("Po viena iveskite visus zodzius:");
            
            for (int i = 0; i < kiek; i++)
            {
                zodziai.Add(Console.ReadLine());
                ilgiuSuma += zodziai[i].Length;
            }       

            vidutinisIlgis = ilgiuSuma / kiek;

            Console.WriteLine();
            Console.WriteLine("Vidutinis zodziu ilgis: " +  vidutinisIlgis);

            foreach (string z in zodziai)
            {
                if (z.Length > vidutinisIlgis)
                {
                    Console.WriteLine(z + " - Ilgas");
                }
                else if (z.Length < vidutinisIlgis)
                {
                    Console.WriteLine(z + " - Trumpas");
                }
                else
                {
                    Console.WriteLine(z + " - Vidutinis");
                }
            }
        }

        public static void Graza()
        {
            Random rnd = new Random();
            int kiekPinigu = rnd.Next(10, 51);
            int idetaPinigu = 0;

            while (idetaPinigu < kiekPinigu)
            {
                Console.Clear();
                Console.WriteLine("---- #6 ----");
                Console.WriteLine();
                Console.WriteLine("Prasome ideti {0}EUR. Galite dėti dalimis.", kiekPinigu);
                Console.WriteLine("Truksta {0}EUR. Prasome ideti pinigu.", kiekPinigu - idetaPinigu);

                idetaPinigu += int.Parse(Console.ReadLine());
            }

            if (idetaPinigu == kiekPinigu)
            {
                Console.WriteLine();
                Console.WriteLine("Aciu!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Jusu graza: " + (idetaPinigu - kiekPinigu));
            }
        }

        public static void Masyvas()
        {
            Console.Clear();
            Console.WriteLine("---- #7 ----");
            Console.WriteLine();

            List<int> options = new List<int>();
            Random rnd = new Random();
            int j;

            for (int i = 1; i < 26; i++)
            {
                options.Add(i);
            }

            int[] masyvas = new int[20];

            Console.WriteLine("Masyvas:");

            for (int i = 0; i < masyvas.Length; i++)
            {
                j = rnd.Next(options.Count);
                masyvas[i] = options[j];
                options.Remove(options[j]);

                Console.WriteLine(masyvas[i]);
            }
        }
    }
}

 