using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Vaje2
    {

        public static void Naloga1()
        {
            // vsota prvih 10 naravnih števil
            // for, while, do-while

            // for(začetek, pogoj, korak)
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Naloga3()
        {
            int stevilo = 12345; // začetek

            int vsota = 0;
            while (stevilo > 0) // pogoj
            {
                vsota = vsota + stevilo % 10;
                stevilo /= 10; // korak
            }

            Console.WriteLine(vsota);
        }

        public static void Naloga4()
        {
            Random random = new Random();
            int stevecGeneriranih = 0;
            int stevilo = 0;

            do
            {
                stevilo = random.Next(0, 100); // zgeneriramo random število
                stevecGeneriranih++;
                Console.WriteLine(stevilo);
            } while (stevilo <= 90);
            Console.WriteLine($"Stevilo zgeneriranih: {stevecGeneriranih}");
        }

        public static void Naloga6()
        {
            int n = 1234;
            int vsota = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    vsota += i;
                }
            }
            Console.WriteLine(vsota);
        }

        public static void Naloga7()
        {
            int stevilo = 1234; // začetek

            int obrnjenoStevilo = 0;
            while (stevilo > 0) // pogoj
            {
                obrnjenoStevilo *= 10;
                obrnjenoStevilo += stevilo % 10; // prištejemo enice števila
                //obrnjenoStevilo *= 10;

                stevilo /= 10; // korak
            }
            //obrnjenoStevilo /= 10;

            Console.WriteLine(obrnjenoStevilo);
        }

        public static void Naloga8()
        {
            // Primer: 12321
            int stevilo = 12321;
            int zacasna = stevilo;

            int obrnjenoStevilo = 0;
            while (stevilo > 0)
            {
                obrnjenoStevilo *= 10;
                obrnjenoStevilo += stevilo % 10;

                stevilo /= 10;
            }

            if (zacasna == obrnjenoStevilo)
            {
                Console.WriteLine("Je palindrom");
            }
            else
            {
                Console.WriteLine("Ni palindrom");
            }
        }

        public static void Naloga10()
        {
            // fib(n+2) = fib(n+1) + fib(n)
            // 1,1,2,3,5,8,13,21,34,55
            int n = 55;

            int fib1 = 0;
            int fib2 = 1;

            do
            {
                if (fib1 != 0)
                {
                    Console.WriteLine(fib1);
                }
                int zacasna = fib1;
                fib1 = fib2;
                fib2 = zacasna + fib1;
            } while (fib1 < n);
        }

        public static void Naloga13()
        {
            Console.WriteLine("Vnesi celo število:");
            int stevilo = int.Parse(Console.ReadLine());

            int stevecLihih = 0;

            for (int i = 1; i <= stevilo; i++)
            {
                if (i % 2 == 0) // sodo
                {
                    Console.WriteLine(i);
                }
                else
                {
                    stevecLihih++;
                }
            }
            Console.WriteLine("Stevilo lihih: " + stevecLihih);
        }

        public static void Naloga13_1()
        {
            Console.WriteLine("Vnesi celo število:");
            int stevilo = int.Parse(Console.ReadLine());

            int stevecLihih = 0;

            for (int i = 1; i <= stevilo; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    continue;
                }
                stevecLihih++;
            }
            Console.WriteLine("Stevilo lihih: " + stevecLihih);
        }

        public static void Naloga16()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // vrstice
            {
                for (int j = 0; j < n; j++) // stolpci
                {
                    Console.Write("*"); // write izpiše in ostane na istem mestu
                }
                Console.WriteLine(); // prazna vrstica (oz. prestavi se v novo vrstico)
            }
        }

        public static void Naloga17()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // vrstice
            {
                for (int j = 0; j < n; j++) // stolpci
                {
                    // i == 0 - prva vrstica, i == n-1 - zadnja vrstica
                    // j == 0 - prvi stolpec, j == n-1 - zadnji stolpec
                    if (i == 0 || i == n - 1 || j == 0 || j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(); // prazna vrstica (oz. prestavi se v novo vrstico)
            }
        }

        public static void Naloga18()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) // vrstice
            {
                for (int j = 0; j < n; j++) // stolpci
                {
                    // i == j - glavna diagonala (levo zgoraj - desno spodaj), i+j==n-1 - druga diagonala
                    if (i == j || i + j == n - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            /* N = 5
             *  j= 01234
             * i=0 *   *
             * i=1  * *
             * i=2   *
             * i=3  * *
             * i=4 *   *
             * 
             * 0,4   1,3   2,2   3,1   4,0 
             * i se povečuje za 1, j se zmanjšuje za 1
             */
        }

        public static void Naloga19()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; i + j <= n - 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Naloga21()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void Naloga21_1()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            int steviloZvezdic = n;
            int steviloPresledkov = 0;

            for (int i = 0; i < n; i++)
            {
                // izpisuje presledke na začetku vrstice
                for (int j = 0; j < steviloPresledkov; j++)
                {
                    Console.Write(" ");
                }
                // izpisuje zvezdice
                for (int j = 0; j < steviloZvezdic; j++)
                {
                    Console.Write("*");
                }
                steviloZvezdic--;
                steviloPresledkov++;
                Console.WriteLine();
            }
        }

        public static void Naloga23()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            // za prvo vrstico
            int steviloZvezdic = 1;
            int steviloPresledkov = n - 1;

            for (int i = 0; i < n; i++)
            {
                // izpisuje presledke na začetku vrstice
                for (int j = 0; j < steviloPresledkov; j++)
                {
                    Console.Write(" ");
                }
                // izpisuje zvezdice
                for (int j = 0; j < steviloZvezdic; j++)
                {
                    Console.Write("*");
                }

                // kako se spreminja ob prehodu v novo vrstico
                steviloZvezdic += 2;
                steviloPresledkov--;
                Console.WriteLine();
            }
        }

        public static void Naloga24()
        {
            Console.WriteLine("Vnesi celo število:");
            int n = int.Parse(Console.ReadLine());

            // za prvo vrstico
            int steviloZvezdic = 2 * n - 1;
            int steviloPresledkov = 0;

            for (int i = 0; i < n; i++)
            {
                // izpisuje presledke na začetku vrstice
                for (int j = 0; j < steviloPresledkov; j++)
                {
                    Console.Write(" ");
                }
                // izpisuje zvezdice
                for (int j = 0; j < steviloZvezdic; j++)
                {
                    Console.Write("*");
                }

                // kako se spreminja ob prehodu v novo vrstico
                steviloZvezdic -= 2;
                steviloPresledkov++;
                Console.WriteLine();
            }
        }

        public static void DodatnaNaloga()
        {
            Console.WriteLine("Vnesi največje možno število za ugibanje:");
            int n = int.Parse(Console.ReadLine());

            Random random = new Random();
            int iskanoStevilo = random.Next(1, n + 1);
            int vpisanoStevilo = -1;

            while (iskanoStevilo != vpisanoStevilo)
            {
                Console.WriteLine("Vnesi število:");
                vpisanoStevilo = int.Parse(Console.ReadLine());

                if (vpisanoStevilo < iskanoStevilo)
                {
                    Console.WriteLine("Iskano število je večje.");
                }
                else if (vpisanoStevilo > iskanoStevilo)
                {
                    Console.WriteLine("Iskano število je manjše.");
                }
                else // števili enaki
                {
                    Console.WriteLine("Uganili ste število!");
                }
            }
        }

    }
}
