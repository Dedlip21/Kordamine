using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kordamine
{
    class startClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast! ");
            string eesnimi = Console.ReadLine();

            if (eesnimi.ToLower() == "juku")
            {
                Console.WriteLine("Tule minu juurde külla, " + eesnimi + ".");
                Console.WriteLine("What ticked do you need to buy, " + eesnimi + "?");
                int aasta = int.Parse(Console.ReadLine());
                if (aasta < 6)
                {
                    Console.WriteLine("Tasuta");
                }
                else if (aasta <=14 && aasta >= 6)
                {
                    Console.WriteLine("Lastepilet");
                }
                else if (aasta <=64 && aasta >= 15)
                {
                    Console.WriteLine("Täispilet");
                }
                else if (aasta >= 65 && aasta <= 100)
                {
                    Console.WriteLine("Sooduspilet");
                }
                else if (aasta <= 0 && aasta > 100)
                {
                    Console.WriteLine("Viga andmetada!");
                }
            }
            else
            {
                Console.WriteLine("Täna mind kodus pole, " + eesnimi + "!");

                int arv1 = int.Parse(Console.ReadLine());
                int arv2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Arvude {0} ja {1} korrutis võrdub {2}", arv1, arv2, arv1 * arv2);
            }

            //temperatur
            Console.WriteLine("Aga mis on temperatuur. Kui see on 18 ja eespol, sest ma lähen jalutama. Aga et aalpool, sest ma ei lähe.");
            int temp = int.Parse(Console.ReadLine());
            if (temp >= 18)
            {
                Console.WriteLine("Jah, ma lähen kindlasti!");
            }
            else
            {
                Console.WriteLine("Halb, pean jääma.");
            }

            //----------------------------------------------------------------

            //pikkus
            Console.WriteLine("Muide, kui pikk sa oled?");
            int pikkus = int.Parse(Console.ReadLine());
            if (pikkus >= 0 && pikkus <130)
            {
                Console.WriteLine("Ära valeta, sa pole nii väiklane!");
            }
            else if (pikkus >= 130 && pikkus <=150)
            {
                Console.WriteLine("Noh, sa oled natuke väike.");
            }
            else if (pikkus >= 160 && pikkus <= 180)
            {
                Console.WriteLine("Siis oled keskmine pikkusega.");
            }
            else if (pikkus >= 180 && pikkus <= 220)
            {
                Console.WriteLine("Vau, sa oled pikk!");
            }
            else if (pikkus > 220)
            {
                Console.WriteLine("Kas sa teed nalja? Sa pole kindlasti nii pikk!");
            }


            //kahe pinginaabrid
            Console.WriteLine("Tere, kas sa oled saamas klassis? Mis su nimi on.");
            string nimi1 = Console.ReadLine();
            string nimi2 = Console.ReadLine();

            Console.WriteLine("Tähendab " + nimi1 + " ja " + nimi2);
            Console.WriteLine(nimi1 + ", kas sa istud sama laua taga?");
            if (nimi2 == "Nikita" && nimi2 == "Oleg")
            {
                Console.WriteLine("Tähendab ta istud " + nimi2);
            }
            else if (nimi2 != "Nikita" && nimi2 != "Oleg")
            {
                Console.WriteLine("Nii et ta ei kuulu sellesse klassi!");
            }


            Console.WriteLine("Write cm1 of first wall");
            decimal cm1 = Math.Abs(decimal.Parse(Console.ReadLine()));
            Console.WriteLine("Write cm2 of the second wall");
            decimal cm2 = Math.Abs(decimal.Parse(Console.ReadLine()));

            Console.WriteLine("Write cm1 of first wall");


            Console.ReadLine();
        }
    }
}
