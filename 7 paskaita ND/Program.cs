using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_paskaita_ND
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toliau = true;

            while (toliau)
            {
                Console.WriteLine("Pasirinkite funkciją.");
                Console.WriteLine("1. String");
                Console.WriteLine("2. List");
                Console.WriteLine("x - baigti programą.");
                Console.WriteLine();
                Console.WriteLine("Įveskite tik skaičių arba x.");

                string funNr = Console.ReadLine(); //Funckijos pasirinkimui

                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();

                if (funNr == "1")
                {
                    StringTask();
                }
                else if (funNr == "2")
                {
                    ListTask();
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

        public static void StringTask()
        {
            string tekstas;
            int pradzia, ilgis, kiek;

            Console.WriteLine("---- #1 ----");
            Console.WriteLine();

            Console.WriteLine("Iveskite teksta:");
            
            tekstas = Console.ReadLine().Trim();

            kiek = KiekSimboliu(tekstas);

            Console.WriteLine();
            Console.WriteLine("Teksto ilgis: " + kiek);
            Console.WriteLine();

            Console.WriteLine("Kirpsime eilute. Nuo kokio indekso noresite kirpti?");
            pradzia = int.Parse(Console.ReadLine());

            Console.WriteLine("Kiek simboliu kirpti?");
            ilgis = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Rezultatas: " + KerpamEilute(tekstas, pradzia, ilgis, kiek));
        }

        public static int KiekSimboliu(string tekstas)
        {
            int kiek = 0;

            foreach(char c in tekstas)
            {
                kiek++;
            }

            return kiek;
        }

        public static string KerpamEilute(string tekstas, int pradzia, int ilgis, int kiek)
        {
            string naujasTekstas = "";
            int paskutinisSimbolis = pradzia + ilgis;

            if (paskutinisSimbolis > kiek)
            {
                paskutinisSimbolis = kiek;
            }

            for(int i = pradzia; i < paskutinisSimbolis; i++)
            {
                naujasTekstas += tekstas[i];
            }
            
            return naujasTekstas;
        }

        public static void ListTask()
        {
            List<string> vardai = new List<string>();
            string ilgiausiasVardas;

            Console.WriteLine("---- #2 ----");
            Console.WriteLine();

            Console.WriteLine("Iveskite keleta vardu atskirtu tarpais.");
            vardai.AddRange(Console.ReadLine().Trim().Split(' '));

            ilgiausiasVardas = IlgiausiasVardas(vardai);

            Console.WriteLine();
            Console.WriteLine("Ilgiausias vardas: " + ilgiausiasVardas);
            Console.WriteLine();

            RasykVardus(vardai);

        }

        public static string IlgiausiasVardas(List<string> vardai)
        {
            int max = 0, ilgis;
            string ilgiausias = "";

            foreach (string vardas in vardai)
            {
                ilgis = KiekSimboliu(vardas);

                if (ilgis > max)
                {
                    max = ilgis;
                    ilgiausias = vardas;
                }
            }
            return ilgiausias;
        }

        public static void RasykVardus(List<string> vardai)
        {
            int ilgis;

            foreach (string vardas in vardai)
            {
                ilgis = KiekSimboliu(vardas);

                if (ilgis < 5)
                {
                    Console.WriteLine(vardas + " - trumpas");
                }
                else if (ilgis > 7)
                {
                    Console.WriteLine(vardas + " - ilgas");
                }
                else
                {
                    Console.WriteLine(vardas + " - vidutinis");
                }
            }
        }
    }
}
