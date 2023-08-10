using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_paskaita_Uzduotys
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toliau = true;

            while (toliau)
            {
                Console.WriteLine("Pasirinkite funkciją.");
                Console.WriteLine("1. Vardu sarasas");
                Console.WriteLine("2. Laimingas kelias");
                Console.WriteLine("3. Pacman");
                Console.WriteLine("x - baigti programą.");
                Console.WriteLine();
                Console.WriteLine("Įveskite tik skaičių arba x.");

                string funNr = Console.ReadLine(); //Funckijos pasirinkimui

                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();

                if (funNr == "1")
                {
                    VarduSarasas();
                }
                else if (funNr == "2")
                {
                    LaimingasKelias();
                }
                else if (funNr == "3")
                {
                    Pacman();
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

        public static void VarduSarasas()
        {
            int index = 0;            
            List<string> vardai = new List<string>{"Ona", "Barbora", "Algis", "Mantas", "Vygintas"};
            bool toliau = true;
            string komanda = "";

            while (toliau)
            {
                Console.Clear();
                Console.WriteLine("---- #1 ----");
                Console.WriteLine();
                Console.WriteLine("Galimos komandos:");
                Console.WriteLine("  N: Naujas elementas (New)");
                Console.WriteLine("  R: Pasalinti dabar matoma elementa (Remove)");
                Console.WriteLine("  >: Sekantis elementas (Rodykle desinen)");
                Console.WriteLine("  <: Praeitas elementas (Rodykle kairen");
                Console.WriteLine("  x: Baigti programa.");
                Console.WriteLine();
                Console.WriteLine("Dabartinis vardas: {0}, jo indeksas: {1}", vardai[index], index);
                Console.WriteLine();
                Console.WriteLine("Iveskite komanda:");

                komanda = Console.ReadLine();
                Console.WriteLine();

                switch (komanda)
                {
                    case "N":
                        vardai = NaujasVardas(vardai);
                        index = vardai.Count - 1;
                        break;
                    case "R":
                        vardai.RemoveAt(index);
                        index = 0;
                        break;
                    case ">":
                        index = Sekantis(vardai.Count, index);
                        break;
                    case "<":
                        index = Praeitas(vardai.Count, index);
                        break;
                    case "x":
                        toliau = false;
                        break;
                    default:                        
                        Console.WriteLine("Nesupratau");
                        Console.ReadLine();
                        break;
                }
            }            
        }

        public static List<string> NaujasVardas(List<string> vardai)
        {
            Console.WriteLine("Iveskite nauja varda:");
            string input = Console.ReadLine();
            vardai.Add(input);
            return vardai;
        }

        public static int Praeitas(int ilgis, int index)
        {
            if (index == 0)
            {
                return ilgis - 1;
            }
            else
            {
                return index - 1;
            }
        }

        public static int Sekantis(int ilgis, int index)
        {
            if (index == ilgis - 1)
            {
                return 0;
            }
            else
            {
                return index + 1;
            }
        }

        public static void LaimingasKelias()
        {
            string[] zaidimoLaukas;
            int zaidejas, saldainiaiKairej, saldainiaiDesinej;
            Random rnd = new Random();
            string puse;
            int laimejimai = 0;
            int zaidimuSkaicius = 0;
            bool toliau = true;

            while (toliau)
            {
                Console.Clear();
                Console.WriteLine("---- #2 ----");
                Console.WriteLine();

                zaidimoLaukas = LaukoUzpildymas();
                zaidejas = rnd.Next(0, 29);

                zaidimoLaukas[zaidejas] = "X";

                Console.WriteLine("I kuria puse renkates eiti? Kairen ( < ) ar desinen ( > )?");
                puse = Console.ReadLine();
                Console.WriteLine();

                saldainiaiDesinej = KiekDesinej(zaidimoLaukas, zaidejas);
                saldainiaiKairej = KiekKairej(zaidimoLaukas, zaidejas);

                LaukoSpausdinimas(zaidimoLaukas);
                Console.WriteLine();
                Console.WriteLine("Kaireje buvo {0} saldainiu, o desineje - {1}.", saldainiaiKairej, saldainiaiDesinej);

                if ((puse == "<" && saldainiaiKairej > saldainiaiDesinej) || (puse == ">" && saldainiaiDesinej > saldainiaiKairej))
                {
                    Console.WriteLine("Sveikinu, laimejote!");
                    laimejimai++;
                    zaidimuSkaicius++;
                }
                else
                {
                    Console.WriteLine("Deja, nelaimejote.!");
                    zaidimuSkaicius++;
                }

                Console.WriteLine("Is viso laimejote {0} kartu. Suzaidete {1} zaidimu.", laimejimai, zaidimuSkaicius);
                Console.WriteLine();

                bool toliau2 = true;

                while (toliau2)
                {
                    Console.WriteLine("Ar zaisite dar? Y/N");
                    string arZais = Console.ReadLine();

                    if (arZais == "Y")
                    {
                        toliau2 = false;
                    }
                    else if (arZais == "N")
                    {
                        toliau2 = false;
                        toliau = false;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nesupratau.");
                        Console.WriteLine();
                    }
                }                
            }
        }

        public static string[] LaukoUzpildymas()
        {
            string[] zaidimoLaukas = new string[30];
            Random rnd = new Random();
            string[] options = {"_", "o"};

            for (int i = 0; i < 30; i++)
            {
                zaidimoLaukas[i] = options[rnd.Next(0, 2)];
            }

            return zaidimoLaukas;
        }

        public static int KiekDesinej(string[] zaidimoLaukas, int zaidejas)
        {
            int kiek = 0;

            for (int i = zaidejas + 1; i < 30; i++)
            {
                if (zaidimoLaukas[i] == "o")
                {
                    kiek++;
                }
            }

            return kiek;
        }

        public static int KiekKairej(string[] zaidimoLaukas, int zaidejas)
        {
            int kiek = 0;

            for (int i = zaidejas - 1; i >= 0; i--)
            {
                if (zaidimoLaukas[i] == "o")
                {
                    kiek++;
                }
            }

            return kiek;
        }

        public static void LaukoSpausdinimas(string[] zaidimoLaukas)
        {
            for (int i = 0; i < 30; i++)
            {
                if (zaidimoLaukas[i] == "_")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (zaidimoLaukas[i] == "o")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

                Console.Write(zaidimoLaukas[i]);
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public static void Pacman()
        {
            string[,] pacmanLaukas;
            int[] pacman = new int[2] { 0, 0 };
            Random rnd = new Random();
            bool toliau = true;
            ConsoleKeyInfo keyPressed;
            int kiekSaldainiu, surinktiTaskai = 0;
            int rows = 10, col = 15;
            int[] priesas = new int[2];

            pacmanLaukas = LaukoSukurimas(rows, col);

            pacmanLaukas[0, 0] = "X";

            priesas[0] = rnd.Next(1, rows);
            priesas[1] = rnd.Next(1, col);

            pacmanLaukas[priesas[0], priesas[1]] = "#";

            kiekSaldainiu = SaldainiaiLauke(pacmanLaukas, rows, col);

            while (toliau)
            {
                Console.Clear();
                Console.WriteLine("---- #3 ----");
                Console.WriteLine();

                LaukoSpausdinimas(pacmanLaukas, rows, col, kiekSaldainiu, surinktiTaskai);

                keyPressed = Console.ReadKey(false);

                pacmanLaukas[pacman[0], pacman[1]] = " "; //Pacman pasišalina iš senosios vietos;

                pacman = Move(pacman, keyPressed.Key, rows, col); //randama naujoji pacman vieta

                pacmanLaukas[priesas[0], priesas[1]] = " "; //priesas pasišalina iš senosios vietos;

                priesas = priesasMove(priesas, pacman, rows, col);

                if (pacman[0] == priesas[0] && pacman[1] == priesas[1])
                {
                    surinktiTaskai = 0;
                    kiekSaldainiu = -1;
                }
                else
                {
                    if (pacmanLaukas[pacman[0], pacman[1]] == "o") //skaiciuojama, kiek surinkta tasku ir kiek dar liko saldainiu
                    {
                        surinktiTaskai++;
                        kiekSaldainiu--;
                    }

                    if (pacmanLaukas[priesas[0], priesas[1]] == "o") //tikrinama, ar priesas nesuvalge saldainio
                    {
                        kiekSaldainiu--;
                    }

                    pacmanLaukas[pacman[0], pacman[1]] = "X"; //Pacman padedamas i naujaja vieta
                }

                pacmanLaukas[priesas[0], priesas[1]] = "#"; //priesas padedamas i naujaja vieta

                if (kiekSaldainiu <= 0)
                {
                    toliau = false;
                }
            }

            Console.Clear();
            Console.WriteLine("---- #3 ----");
            Console.WriteLine();
            LaukoSpausdinimas(pacmanLaukas, rows, col, kiekSaldainiu, surinktiTaskai);
        }

        public static string[,] LaukoSukurimas(int rows, int col)
        {
            string[,] zaidimoLaukas = new string[rows,col];
            Random rnd = new Random();
            string[] options = { " ", "o" };

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col - 2; j+=3)
                {
                    zaidimoLaukas[i,j] = " ";
                    zaidimoLaukas[i,j+1] = options[rnd.Next(0, 2)];
                    zaidimoLaukas[i, j + 2] = " ";
                }                
            }

            return zaidimoLaukas;
        }

        public static void LaukoSpausdinimas(string[,] laukas, int rows, int col, int saldainiai, int taskai)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (laukas[i,j] == "o")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    else if (laukas[i,j] == "X")
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }

                    Console.Write(laukas[i,j]);
                }

                Console.Write("\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

            if (saldainiai == 0)
            {
                Console.WriteLine("Sveikinu! Jus laimejote. Surinkote {0} tasku.", taskai);
                Console.WriteLine();
            }
            else if (saldainiai == -1)
            {
                Console.WriteLine("Pralaimejote. Jus suvalge priesas!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Surinkti taskai: {0}, dar liko {1} saldainiu.", taskai, saldainiai);
                Console.WriteLine();
            }
        }

        public static int[] Move(int[] figura, ConsoleKey keyPressed, int rows, int col)
        {
            if (keyPressed == ConsoleKey.LeftArrow)
            {
                if (figura[1] == 0)
                {
                    figura[1] = col - 1;
                }
                else
                {
                    figura[1]--;
                }
            }
            else if (keyPressed == ConsoleKey.RightArrow)
            {
                if (figura[1] == col - 1)
                {
                    figura[1] = 0;
                }
                else
                {
                    figura[1]++;
                }
            }
            else if (keyPressed == ConsoleKey.UpArrow)
            {
                if (figura[0] == 0)
                {
                    figura[0] = rows - 1;
                }
                else
                {
                    figura[0]--;
                }
            }
            else if (keyPressed == ConsoleKey.DownArrow)
            {
                if (figura[0] == rows -  1)
                {
                    figura[0] = 0;
                }
                else
                {
                    figura[0]++;
                }
            }

                return figura;
        }

        public static int[] priesasMove(int[] priesas, int[] pacman, int rows, int col)
        {
            int pacRow = pacman[0];
            int pacCol = pacman[1];
            int priesasRow = priesas[0];
            int priesasCol = priesas[1];

            int ikiPacmanKairen, ikiPacmanDesinen, ikiPacmanZemyn, ikiPacmanAukstyn;

            ikiPacmanAukstyn = IkiPacmanAukstyn(priesasRow,pacRow, rows);
            ikiPacmanDesinen = IkiPacmanDesinen(priesasCol, pacCol, col);
            ikiPacmanKairen = IkiPacmanKairen(priesasCol, pacCol, col);
            ikiPacmanZemyn = IkiPacmanZemyn(priesasRow, pacRow, rows);

            List<int> kaipToli = new List<int>();

            kaipToli.Add(ikiPacmanAukstyn);
            kaipToli.Add(ikiPacmanDesinen);
            kaipToli.Add(ikiPacmanKairen);
            kaipToli.Add(ikiPacmanZemyn);

            kaipToli.RemoveAll(i => i == 0);

            int arciausiaKryptis = kaipToli.Min();

            if (ikiPacmanAukstyn == arciausiaKryptis)
            {
                priesas = Move(priesas, ConsoleKey.UpArrow, rows, col);
            }
            else if (ikiPacmanDesinen == arciausiaKryptis)
            {
                priesas = Move(priesas, ConsoleKey.RightArrow, rows, col);
            }
            else if (ikiPacmanKairen == arciausiaKryptis)
            {
                priesas = Move(priesas, ConsoleKey.LeftArrow, rows, col);
            }
            else if (ikiPacmanZemyn == arciausiaKryptis)
            {
                priesas = Move(priesas, ConsoleKey.DownArrow, rows, col);
            }

            return priesas;
        }

        public static int IkiPacmanAukstyn(int priesas, int pacman, int rows)
        {
            if ( pacman < priesas)
            {
                return priesas - pacman;
            }
            else
            {
                return priesas + (rows - pacman);
            }
        }

        public static int IkiPacmanDesinen(int priesas, int pacman, int col)
        {
            if (pacman > priesas)
            {
                return pacman - priesas;
            }
            else
            {
                return pacman + (col - priesas);
            }
        }

        public static int IkiPacmanKairen(int priesas, int pacman, int col)
        {
            if (pacman < priesas)
            {
                return priesas - pacman;
            }
            else
            {
                return priesas + (col - pacman);
            }
        }

        public static int IkiPacmanZemyn(int priesas, int pacman, int rows)
        {
            if (pacman > priesas)
            {
                return pacman - priesas;
            }
            else
            {
                return pacman + (rows - priesas);
            }
        }

        public static int SaldainiaiLauke(string[,] pacmanLaukas, int rows, int col)
        {
            int kiek = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (pacmanLaukas[i,j] == "o")
                    {
                        kiek++;
                    }
                }
            }
            return kiek;
        }
    }
}
