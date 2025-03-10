using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Vaje1
    {
        public static void vaje1()
        {
            /*
               // Naloga 1.0.0.2 in 1.0.0.3
               bool logicneVrednosti = false;

               char znak = 'a';

               string niz = "To je niz!";

               byte bajt = 0;
               int celoStevilo = 0; // za cela stevila
               long celoStevilo2 = 0;

               float decimalnoStevilo = 0.5F;
               double decimalnoStevilo2 = 0.2; // za decimalna stevila
               decimal decimalnoStevilo3 = 0.6M;
               */
            /* To je
             * večvrstični
             * komentar.
             */
            /*
            // Naloga 1.0.0.4
            string znamkaAvtomobila = "Audi";
            int steviloVrat = 4;
            double hitrost = 100.5;
            string merskeEnote = "km/h";
            bool jeNov = false;

            Console.WriteLine("Podatki o avtomobilu:");
            Console.WriteLine("Znamka: " + znamkaAvtomobila);
            Console.WriteLine("Stevilo vrat: " + steviloVrat);
            Console.WriteLine("Hitrost: " + hitrost + " " + merskeEnote);

            // Naloga 1.0.0.6
            char unicodeZnak = '\u0041';
            Console.WriteLine("Znak A: " + unicodeZnak);
            Console.WriteLine("Znak A: \u0041");

            // Naloga 1.0.0.7 in 1.0.0.8
            Console.WriteLine("Ime in priimek");
            Console.WriteLine("Ulica in hisna stevilka");
            Console.WriteLine("Posta in postna stevilka");

            string imeInPriimek = "Ime priimek";
            string ulica = "Ulica in hisna stevilka";
            string posta = "Posta in postna stevilka";

            Console.WriteLine(imeInPriimek + "\n" + ulica + "\n" + posta);

            Console.WriteLine("Ime priimek\nUlica in hisna stevilka\nPosta in postna stevilka");


            // Naloga 1.0.0.9 in 1.0.0.10
            int a = 125;
            int b = 20;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b); // ostanek pri deljenju

            Console.WriteLine("Vsota: " + (a + b));
            Console.WriteLine("Vsota: " + (a - b));

            Console.WriteLine(a + b + " je vsota.");
            Console.WriteLine(a - b + " je razlika.");


            // Naloga 1.0.0.11
            int stevilo = 5;
            stevilo = stevilo + 2;
            stevilo += 2;
            Console.WriteLine(stevilo);
            stevilo = stevilo - 2;
            stevilo -= 2;
            Console.WriteLine(stevilo);
            stevilo *= 2;
            Console.WriteLine(stevilo);
            stevilo /= 2;
            Console.WriteLine(stevilo);
            stevilo %= 2;
            Console.WriteLine(stevilo);

            // posebnost
            stevilo++; // poveča za 1
            stevilo--; // zmanjša za 1

            // Naloga 1.0.0.13
            int trimestnoStevilo = 123;

            int enice = trimestnoStevilo % 10; // enice
            Console.WriteLine(enice);

            int desetice = trimestnoStevilo / 10; // odreže enice
            desetice %= 10;
            int desetice2 = trimestnoStevilo / 10 % 10;
            Console.WriteLine(desetice);
            Console.WriteLine(desetice2);

            int stotice = trimestnoStevilo / 10 / 10;

            int obrnjenoStevilo = enice * 100 + desetice * 10 + stotice;
            Console.WriteLine(obrnjenoStevilo);

            // Naloga 1.0.0.15
            int numA = 15;
            int numB = 25;
            int numC = 37;
            int numD = 41;

            Console.WriteLine(numA <= numB); // manjse ali enako
            Console.WriteLine(numC != numD); // razlicno
            Console.WriteLine(numA == numA); // enakost (ni v nalogi)
            Console.WriteLine(numA + numD > numC && numB < numC);

            // Zaporedje operacij: 1-aritmetične operacije, 2-primerjalne, 3-logične

            // Naloga 1.0.0.16
            string niz1 = "Prvi niz";
            string niz2 = "Drugi niz";

            Console.WriteLine(niz1 + " " + niz2);

            string niz3 = niz1;
            niz1 = niz2;
            niz2 = niz3;

            Console.WriteLine(niz1 + " " + niz2);


            // Dodatno - Pretvorba tipov
            double spr1 = 5.4;
            int spr2 = (int)spr1; // type casting

            int spr3 = 10;
            double spr4 = spr3;

            string spr5 = "5";
            int spr6 = int.Parse(spr5);
            Console.WriteLine(spr6);
            */


            // 2. poglavje

            // Naloga 2.1.0.1

            Console.WriteLine("Vnesi celo stevilo!");
            string vnos = Console.ReadLine();
            int stevilo = int.Parse(vnos);

            if (stevilo % 2 == 0)
            {
                Console.WriteLine("Stevilo " + stevilo + " je sodo.");
                Console.WriteLine($"Stevilo {stevilo} je sodo.");
            }
            else
            {
                Console.WriteLine($"Stevilo {stevilo} je liho.");
            }


            // Naloga 2.1.0.2
            Console.WriteLine("Vnesi celo stevilo!");
            vnos = Console.ReadLine();
            int stevilo1 = int.Parse(vnos);
            Console.WriteLine("Vnesi celo stevilo!");
            vnos = Console.ReadLine();
            int stevilo2 = int.Parse(vnos);

            if (stevilo1 > stevilo2)
            {
                Console.WriteLine($"{stevilo1}");// pogoj je True - resničen
            }
            else // v vseh ostalih primerih : stevilo2 večje ali enako kot stevilo1
            {
                Console.WriteLine($"{stevilo2}");
            }

            // Naloga 2.1.0.3 - stevilo1 in stevilo2 od prej
            Console.WriteLine("Vnesi celo stevilo!");
            vnos = Console.ReadLine();
            int stevilo3 = int.Parse(vnos);

            if (stevilo1 > stevilo2 && stevilo1 > stevilo3)
            {
                Console.WriteLine("Število 1 je največje");
            }
            else if (stevilo2 > stevilo1 && stevilo2 > stevilo3)
            {
                Console.WriteLine("Število 2 je največje");
            }
            else
            {
                Console.WriteLine("Število 3 je največje");
            }


            if (stevilo1 > stevilo2)
            {
                if (stevilo1 > stevilo3)
                {
                    Console.WriteLine("Število 1 je največje");
                }
                else
                {
                    Console.WriteLine("Število 3 je največje");
                }
            }
            else
            {
                if (stevilo2 > stevilo3)
                {
                    Console.WriteLine("Število 2 je največje");
                }
                else
                {
                    Console.WriteLine("Število 3 je največje");
                }
            }

            // Naloga 2.1.0.6
            stevilo = 12;

            if (stevilo % 3 == 0 && stevilo % 5 == 0)
            {
                Console.WriteLine("Stevilo je deljivo s 3 in s 5.");
            }
            else if (stevilo % 3 == 0)
            {
                Console.WriteLine("Stevilo je deljivo le s 3.");
            }
            else if (stevilo % 5 == 0)
            {
                Console.WriteLine("Stevilo je deljivo le s 5.");
            }
            else
            {
                Console.WriteLine("Stevilo ni deljivo z nobenim izmed 3 in 5.");
            }


            // Naloga 2.3.0.1
            int starost = 17;

            switch (starost)
            {
                case >= 18:
                    Console.WriteLine("Lahko se udeleži volitev");
                    break;
                default:
                    Console.WriteLine("Ne more se udeležiti volitev");
                    break;
            }


            // Naloga 2.3.0.3
            char crka = 'e';
            // deluje za male črke
            switch (crka)
            {
                case 'a' or 'e' or 'i' or 'o' or 'u':
                    Console.WriteLine("Samoglasnik.");
                    break;
                default:
                    Console.WriteLine("Soglasnik.");
                    break;
            }


            // Naloga 2.3.0.5
            Console.WriteLine("Vnesi prvo stevilo.");
            int prvo = int.Parse(Console.ReadLine());
            Console.WriteLine("Vnesi drugo stevilo.");
            int drugo = int.Parse(Console.ReadLine());

            Console.WriteLine("Vnesi znak za operacijo.");
            vnos = Console.ReadLine();
            char operacija = vnos[0]; // preberi prvi znak iz niza

            switch (operacija)
            {
                case '+':
                    Console.WriteLine($"Rezultat: {prvo + drugo}");
                    break;
                case '-':
                    Console.WriteLine($"Rezultat: {prvo - drugo}");
                    break;
                case '*':
                    Console.WriteLine($"Rezultat: {prvo * drugo}");
                    break;
                case '/':
                    Console.WriteLine($"Rezultat: {prvo / drugo}");
                    break;
                default:
                    Console.WriteLine("Te operacije pa ne poznam.");
                    break;
            }
        }
    }
}
