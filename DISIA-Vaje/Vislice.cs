using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Vislice
    {

        public static void Igraj() 
        {
            Console.WriteLine("************************");
            Console.WriteLine("*                      *");
            Console.WriteLine("*     IGRA VISLICE     *");
            Console.WriteLine("*                      *");
            Console.WriteLine("************************");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Vnesi (1) za novo igro.");
                Console.WriteLine("Vnesi (2) za novo solo igro.");
                Console.WriteLine("Vnesi (0) za izhod.");

                int izbira = int.Parse(Console.ReadLine());

                switch (izbira)
                {
                    case 1:
                        NovaIgra();
                        break;
                    case 2:
                        NovaIgra2();
                        break;
                    case 0:
                        return; // zaključi metodo
                    default:
                        Console.WriteLine("Napačna izbira! Poskusite ponovno.");
                        break;
                }
            }
        }

        public static void NovaIgra2()
        {
            List<string> seznamBesed = new List<string>();
            seznamBesed.Add("JAGUAR");
            // trim odreže presledke na začetku in koncu
            string beseda = seznamBesed[0];

            bool[] skritiZnaki = new bool[beseda.Length];

            // za primer ko je prva in vse enake črke razkrite
            /*
            skritiZnaki[0] = true;
            for (int i = 0; i < beseda.Length; i++)
            {
                if (beseda[i] == beseda[0])
                {
                    skritiZnaki[i] = true;
                }
            }
            */

            int steviloNapacnihUgibanj = 0;
            while (true)
            {
                Console.WriteLine();
                IzpisiBesedo(beseda, skritiZnaki);

                Console.WriteLine();
                Console.WriteLine("Vnesi črko:");
                char crka = Console.ReadLine().Trim()[0];

                if (!RazkrijBesedo(beseda, skritiZnaki, crka))
                {
                    steviloNapacnihUgibanj++;
                }

                if (steviloNapacnihUgibanj == 5)
                {
                    Console.WriteLine("Izgubili ste!");
                    break;
                }

                if (SoVseRazkrite(skritiZnaki))
                {
                    Console.WriteLine("Zmagali ste!");
                    break;
                }
            }

        }

        public static void NovaIgra() 
        {
            Console.WriteLine("Vnesi besedo za ugibanje:");
            // trim odreže presledke na začetku in koncu
            string beseda = Console.ReadLine().Trim();

            bool[] skritiZnaki = new bool[beseda.Length];

            // za primer ko je prva in vse enake črke razkrite
            /*
            skritiZnaki[0] = true;
            for (int i = 0; i < beseda.Length; i++)
            {
                if (beseda[i] == beseda[0])
                {
                    skritiZnaki[i] = true;
                }
            }
            */

            int steviloNapacnihUgibanj = 0;
            while (true) 
            {
                Console.WriteLine();
                IzpisiBesedo(beseda, skritiZnaki);

                Console.WriteLine();
                Console.WriteLine("Vnesi črko:");
                char crka = Console.ReadLine().Trim()[0];

                if (!RazkrijBesedo(beseda, skritiZnaki, crka)) 
                {
                    steviloNapacnihUgibanj++;
                }

                if (steviloNapacnihUgibanj == 5) 
                {
                    Console.WriteLine("Izgubili ste!");
                    break;
                }

                if (SoVseRazkrite(skritiZnaki)) 
                {
                    Console.WriteLine("Zmagali ste!");
                    break;
                }
            }

        }

        public static bool SoVseRazkrite(bool[] tabela) 
        {
            for (int i = 0; i < tabela.Length; i++) 
            {
                if (!tabela[i]) // obstaja mesto v tabeli z vrednostjo false
                {
                    return false;
                }
            }
            return true;
        }


        public static bool RazkrijBesedo(string beseda, bool[] tabela, char znak) 
        {
            bool sprememba = false;
            for (int i = 0; i < beseda.Length; i++) 
            {
                if (beseda[i] == znak && tabela[i]) // črka je že razkrita
                {
                    return false;
                }
                else if (beseda[i] == znak) // razkrijemo črko 
                {
                    tabela[i] = true;
                    sprememba = true;
                }
            }
            return sprememba;
        }

        public static void IzpisiBesedo(string beseda, bool[] tabela) 
        {
            for (int i = 0; i < beseda.Length; i++) 
            {
                if (tabela[i])
                {
                    Console.Write(beseda[i] + " ");
                }
                else 
                {
                    Console.Write("_ ");
                }
            }
            Console.WriteLine();
        }

    }
}
