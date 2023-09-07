using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laikrodis
{
    class Program
    {
        const int maxMinutes = 60;
        const int maxValandos = 12;

        static void Main(string[] args)
        {
            int valandos, minutes;
            string valandosText, minutesText;
            float kampas;

            Console.WriteLine("Paeiliui iveskite, kiek valandu ir minuciu rodo laikrodis (sveikaisias skaiciais):");
            valandosText = Console.ReadLine();
            minutesText = Console.ReadLine();

            Console.WriteLine();

            if (int.TryParse(valandosText, out valandos) == false || int.TryParse(minutesText, out minutes) == false)
            {
                Console.WriteLine("Valandos ir minutes gali buti tik sveikieji skaiciai. Jusu ivesti duomenys neteisingi.");
            }
            else if (valandos > maxValandos * 2)
            {
                Console.WriteLine("Ivestas valandu skaicius yra per didelis. Paroje yra tik 24 valandos.");
            }
            else if (minutes > maxMinutes)
            {
                Console.WriteLine("Ivestas minuciu skaicius yra per didelis. Valanda sudaro 60 minuciu.");
            }
            else
            {
                if (valandos == maxValandos || valandos == maxValandos * 2) { valandos = 0; }
                if (valandos > maxValandos) { valandos = valandos % maxValandos; }
                if (minutes == maxMinutes) { minutes = 0; }

                kampas = SkaiciuokKampa(valandos, minutes);

                Console.WriteLine("Mažesnysis kampas tarp laikrodzio rodykliku yra {0} laipsniu.", kampas);
                Console.ReadLine();
            }        
                        
        }

        public static float SkaiciuokKampa(int valandos, int minutes)
        {
            float kampas;

            float valandosMinutemis = (valandos * 5) + (5 * (float)minutes / maxMinutes);

            float atstumasMinutemis = valandosMinutemis - minutes;

            if (atstumasMinutemis < 0) { atstumasMinutemis = atstumasMinutemis * (-1); }

            if (atstumasMinutemis > maxMinutes / 2) { atstumasMinutemis = maxMinutes - atstumasMinutemis; }

            kampas = atstumasMinutemis / maxMinutes * 360;

            return kampas;
        }
    }
}
