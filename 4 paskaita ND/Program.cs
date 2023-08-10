using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_paskaita_ND
{
    class Program
    {
        static void Main(string[] args)
        {
            bool toliau = true;

            while (toliau)
            {
                Console.WriteLine("Pasirinkite funkciją.");
                Console.WriteLine("1. Skaičiuotuvas");
                Console.WriteLine("2. Spėliojimo žaidimas");
                Console.WriteLine("3. Kauliukas");
                Console.WriteLine("4. Kavos aparatas");
                Console.WriteLine("x - baigti programą.");
                Console.WriteLine();
                Console.WriteLine("Įveskite tik skaičių arba x.");

                string funNr = Console.ReadLine(); //FUnckijos pasirinkimui

                Console.WriteLine();

                if (funNr == "1")
                {
                    Skaiciuotuvas();
                }
                else if (funNr == "2")
                {
                    SpeliojimoZaidimas();
                }
                else if (funNr == "3")
                {
                    Kauliukas();
                }
                else if (funNr == "4")
                {
                    KavosAparatas();
                }
                else if (funNr == "x")
                {
                    toliau = false;
                }
                else
                {
                    Console.WriteLine("Neteisinga funkcija.");
                    Console.WriteLine();
                }
            }

        }

        //Funkcija įvykdo pasirinką aritmetinį veiksmą.
        public static void Skaiciuotuvas()
        {
            bool toliau = true;

            while (toliau)
            {
                Console.WriteLine("Pasirinkite veiksmą: + - / *");
                string veiksmas = Console.ReadLine();

                if (veiksmas != "+" && veiksmas != "-" && veiksmas != "/" && veiksmas != "*")
                {
                    Console.WriteLine("Neteisingas veiksmas.");
                }
                else
                {
                    Console.WriteLine("Vieną po kito įveskite du skaičius.");
                    int sk1 = int.Parse(Console.ReadLine());
                    int sk2 = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (veiksmas == "+")
                    {
                        Console.WriteLine("{0} + {1} = {2}", sk1, sk2, sk1 + sk2);
                    }
                    else if (veiksmas == "-")
                    {
                        Console.WriteLine("{0} - {1} = {2}", sk1, sk2, sk1 - sk2);
                    }
                    else if (veiksmas == "/")
                    {
                        Console.WriteLine("{0} / {1} = {2}", sk1, sk2, (float)sk1 / sk2);
                    }
                    else if (veiksmas == "*")
                    {
                        Console.WriteLine("{0} * {1} = {2}", sk1, sk2, sk1 * sk2);
                    }
                }

                Console.WriteLine();

                bool toliau2 = true;
                while (toliau2)
                {
                    Console.WriteLine("Ar nori skaičiuoti vėl? (Y/N)");
                    string dar = Console.ReadLine();

                    if (dar == "Y")
                    {
                        Console.WriteLine();
                        toliau2 = false;
                    }
                    else if (dar == "N")
                    {
                        Console.WriteLine();
                        toliau2 = false;
                        toliau = false;
                    }
                    else
                    {
                        Console.WriteLine("Nesupratau.");
                        Console.WriteLine();
                    }
                }


            }

            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();

        }

        //Skaičiaus spėliojimo žaidimas. Vykdomas iki kol skaičius atspėjamas 5 kartus.
        public static void SpeliojimoZaidimas()
        {
            int laimejimai = 0;
            Random rnd = new Random();
            int sk, spejimas;

            while (laimejimai != 5)
            {
                sk = rnd.Next(1, 11);
                spejimas = 0;

                Console.WriteLine("Aš sugalvojau skaičių nuo 1 iki 10.");
                Console.WriteLine("Spėkite skaičių!");

                while (sk != spejimas)
                {
                    spejimas = int.Parse(Console.ReadLine());

                    if (sk != spejimas)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nepataikėte. Bandykite dar kartą.");
                    }
                }

                laimejimai++;
                Console.WriteLine();
                Console.WriteLine("Teisingai! Jau turite {0} teisingus spėjimus", laimejimai);
                Console.WriteLine();
            }

            Console.WriteLine("Užteks žaisti.");
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
        }

        //Funkcija išridena
        public static void Kauliukas()
        {
            Random rnd = new Random();
            int suma = 0;

            Console.WriteLine("Kokį kauliuką naudosite? (Su kiek daugiausiai taškų?)");
            int maxTasku = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Kiek kauliukų mesite?");
            int kiek = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Kauliukai ridenami...");
            Console.WriteLine();

            for (int i = 0; i < kiek; i++)
            {
                suma += rnd.Next(1, maxTasku + 1);
            }
            Console.WriteLine("Išridenti {0} taškai.", suma);
            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
        }

        //Kavos aparatas funkcija gali pasakyti aparato uždarbį arba parduoti kavos. Aparatas atiduoda grąžą.
        public static void KavosAparatas()
        {
            float kava = 3f;
            float vanduo = 5f;
            int uzdarbis = 0;
            bool toliau = true;
            string funkcija;

            //kavos aparatas dirba tol, kol nepasakoma, kad nebenorima daugiau funkcijų
            while (toliau)
            {
                float idetaPinigu = 0f;
                int kaina = 0;
                float kiekKavos = 0f;
                float kiekVandens = 0f;
                string dydis = "";

                Console.WriteLine("Pasirinkite kavos aparato funkciją.");
                Console.WriteLine("Jei norite kavos, rašykite - Kava");
                Console.WriteLine("Jei norite sužinote, kiek aparatas yra uždirbęs pinigų, rašykite - Pinigai");

                funkcija = Console.ReadLine();

                //Kavos tiekimas
                if (funkcija == "Kava")
                {
                    Console.WriteLine();
                    Console.WriteLine("Kokio kavos puodelio norėtumėte? S, M ar L?");
                    dydis = Console.ReadLine();

                    switch (dydis)
                    {
                        case "S":
                            kaina = 1;
                            kiekKavos = 0.5f;
                            kiekVandens = 0.25f;
                            break;
                        case "M":
                            kaina = 3;
                            kiekKavos = 0.75f;
                            kiekVandens = 0.5f;
                            break;
                        case "L":
                            kaina = 5;
                            kiekKavos = 1f;
                            kiekVandens = 0.75f;
                            break;
                        default:
                            Console.WriteLine("Tokio dydžio nėra.");
                            Console.WriteLine();
                            break;
                    }

                    if (kaina != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Jūsų kava kainuoja {0}EUR. Galite dėti dalimis.", kaina);

                        //Pinigų skaičiavimas pasirinktam puodeliui
                        while (idetaPinigu < kaina)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nepakankamas balansas. Trūksta {0}EUR. Prašome įdėti pinigų.", kaina - idetaPinigu);
                            idetaPinigu += float.Parse(Console.ReadLine());
                        }

                        //Grąža duodama tik jei yra ką duoti.
                        if (idetaPinigu > kaina)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Jums liko {0}EUR. Pasiimkite grąžą.", idetaPinigu - kaina);
                        }

                        kava -= kiekKavos;
                        vanduo -= kiekVandens;
                        uzdarbis += kaina;

                        Console.WriteLine();
                        Console.WriteLine(dydis + " kava paruošta!");

                        //Tikrinama, ar užtenka vandens ir kavos aparate
                        while (kava < 1 || vanduo < 0.75)
                        {
                            string papildymas = null;
                            string kasBaiges = null;

                            if (kava < 1 && vanduo < 0.75)
                            {
                                kasBaiges = "kava ir vanduo.";
                            }
                            else if (kava < 1)
                            {
                                kasBaiges = "kava";
                            }
                            else
                            {
                                kasBaiges = "vanduo";
                            }

                            Console.WriteLine();
                            Console.WriteLine("Pasibaigė {0}. Prašome papildyti.", kasBaiges);
                            Console.WriteLine("Norint papildyti kavos, rašykite - Kava");
                            Console.WriteLine("Norint papildyti vandens, rašykite - Vanduo");

                            papildymas = Console.ReadLine();

                            if (papildymas == "Kava")
                            {
                                kava = 3f;
                                Console.WriteLine();
                                Console.WriteLine("Ačiū. Kavos vėl yra.");
                            }
                            else if (papildymas == "Vanduo")
                            {
                                Console.WriteLine();
                                Console.WriteLine("Ačiū. Vandens vėl yra.");
                                vanduo = 5f;
                            }
                            else
                            {
                                Console.WriteLine();
                                Console.WriteLine("Nesupratau");
                            }
                        }
                    }
                }
                //Pasakoma, kiek pinigų uždirbta per programos veikimo laiką.
                else if (funkcija == "Pinigai")
                {
                    Console.WriteLine();
                    Console.WriteLine("Kavos aparatas uždirbo {0}EUR.", uzdarbis);
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Neteisinga funkcija.");
                }

                bool toliau2 = true;
                while (toliau2)
                {
                    Console.WriteLine();
                    Console.WriteLine("Ar norite atlikti kitą funkciją? Y/N?");

                    string dar = Console.ReadLine();

                    if (dar == "Y")
                    {
                        Console.WriteLine();
                        toliau2 = false;
                    }
                    else if (dar == "N")
                    {
                        Console.WriteLine();
                        toliau2 = false;
                        toliau = false;
                    }
                    else
                    {
                        Console.WriteLine("Nesupratau.");
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------");
            Console.WriteLine();
        }
    }
}