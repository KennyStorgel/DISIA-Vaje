using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Vaje3
    {

        public static void Naloga1()
        {
            // tabela, ki shranjuje podatke tipa int
            int[] tabela = [1, 2, 3, 4, 5]; // ko točno poznamo elemente, ki jih želimo imeti v tabeli

            int[] tabela2 = new int[10]; // ko ne poznamo elementov, si le pripravimo tabelo določene dolžine

            // izpis prvega elementa
            Console.WriteLine(tabela[0]); // prvi element je na indeksu 0
            Console.WriteLine(tabela2[0]);

            // izpis zadnjega elementa
            // tabela.Length vrne dolžino tabele (število elementov v tabeli)
            Console.WriteLine(tabela[tabela.Length - 1]);

            // enako
            Console.WriteLine(tabela[4]);

        }

        public static void Naloga2() 
        {
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            for (int i = 0; i < tabela.Length; i++) 
            {
                Console.WriteLine(tabela[i]);
            }

            // drugi način izpisovanja
            for (int i = 0; i < tabela.Length; i++)
            {
                Console.Write(tabela[i] + " ");
            }
            Console.WriteLine();

            // še ena rešitev - foreach se sprehaja preko elementov tabele
            foreach (int element in tabela) 
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }

        public static void Naloga3()
        {
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // izpis v obratnem vrstnem redu
            for (int i = tabela.Length - 1; i >= 0; i--)
            {
                Console.Write(tabela[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Naloga4() 
        {
            int[] tabela = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

            // ustvarimo novo tabelo enake dolžine
            int[] novaTabela = new int[tabela.Length];

            // sprehajamo se preko tabele tabela
            for (int i = 0; i < tabela.Length; i++) 
            {
                novaTabela[novaTabela.Length - i - 1] = tabela[i];
            }

            // indeks i=0 -> indeks dolžina - 1
            // indeks i=1 -> indeks dolžine - 2 = dolžina - i - 1
            // indeks i=2 -> indeks dolžina - 3 = dolžina - i - 1

            // izpis tabele
            foreach (int element in novaTabela) 
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // za natančnost naloge
            tabela = novaTabela;
        }

        public static void Naloga6() 
        {
            int[] tabela = [5, 10, 15, 20, 25, 30];

            // 1. sprehod preko tabele (zanka)
            // 2. za vsak element preverimo ali je element liho število (if)
            // 3. spremenljivka, ki hrani vsoto

            int vsotaLihih = 0; // 3.

            // 1.
            for (int i = 0; i < tabela.Length; i++) 
            {
                // 2.
                if (tabela[i] % 2 == 1) 
                {
                    vsotaLihih += tabela[i];
                }
            }

            Console.WriteLine(vsotaLihih);
        }

        public static void Naloga9() 
        {
            int[] tabela = [25, 29, 30, 89, 12, 48, 20, 13, 5, 30];

            // 1. spremenljivke za max in min in njuna indeksa
            // 2. sprehod preko tabele (zanka - for)
            // 3. primerjat element s trenutnim min in max (if)
            // 4. če najdemo nov min ali max, ga popravimo in popravimo tudi indekse

            // 1.
            int min = tabela[0];
            int max = tabela[0];
            int indeksMin = 0;
            int indeksMax = 0;

            // 2.
            for (int i = 0; i < tabela.Length; i++) 
            {
                // 3.
                if (tabela[i] < min) // trenutni element je manjši od trenutnega min
                {
                    // 4.
                    min = tabela[i];
                    indeksMin = i;
                }
                if (tabela[i] > max) 
                {
                    // 4.
                    max = tabela[i];
                    indeksMax = i;
                }
            }

            // min - spremenljivka, ki shranjuje vrednost dejanskega minimuma
            // tabela[indeksMin] - element v tabeli, ki se nahaja na indeksu indeksMin - enako - vrednost minimuma
            Console.WriteLine(min + " " + tabela[indeksMin] + " indeks: " + indeksMin);
            Console.WriteLine(max + " " + tabela[indeksMax] + " indeks: " + indeksMax);
        }

        public static void Naloga11() 
        {
            // 1. deklariramo tabelo
            // 2. branje vnosa števila iz konzole
            // 3. vsak element primerjamo z vsakim (dvojna zanka)
            // 4. ali se elementa seštejeta v ustrezno število (if)
            // 5. kaj če tak par ne obstaja (bool spremenljivka)

            // 1.
            int[] tabela = [25, 29, 30, 89, 12, 48, 20, 13, 5, 30];
            // 5.
            bool obstajaPar = false;

            // 2.
            Console.WriteLine("Vnesi celo število");
            int stevilo = int.Parse(Console.ReadLine());

            // 3.
            for (int i = 0; i < tabela.Length; i++) 
            {
                for (int j = 0; j < tabela.Length; j++) 
                {
                    // 4.
                    if (tabela[i] + tabela[j] == stevilo) 
                    {
                        Console.WriteLine($"Indeksa: {i} in {j}");
                        // 5.
                        obstajaPar = true;
                    }
                }
            }

            // 5.
            if (obstajaPar == false) // !obstajaPar 
            {
                Console.WriteLine("Tak par ne obstaja.");
            }

            /*
            Console.WriteLine("Resitev brez ponovljenih parov");
            for (int i = 0; i < tabela.Length; i++)
            {
                for (int j = i; j < tabela.Length; j++)
                {
                    // 4.
                    if (tabela[i] + tabela[j] == stevilo)
                    {
                        Console.WriteLine($"Indeksa: {i} in {j}");
                    }
                }
            }
            */
        }

        // 32
        // [25, 29, 30, 89, 12, 48, 20, 13, 5, 30]
        // dve števili na indeksih 4 in 6

        // večdimenzionalne tabele (matrika)
        public static void Naloga21() 
        {
            // 2-dimenzionalno tabelo nizov
            string[,] tabela = { { "niz 1", "niz 2", "niz 3" },
                                 { "niz 4", "niz 5", "niz 6" } };

            string[,] tabela2 = new string[2, 3]; // "" - prazen niz

            // izpis
            for (int i = 0; i < tabela.GetLength(0); i++) // GetLength(dimenzija)
            {
                for (int j = 0; j < tabela.GetLength(1); j++)
                {
                    Console.Write(tabela[i, j] + " ");
                }
                Console.WriteLine();
            }

        }

        // Naloga 4.1.0.3.
        public static void Naloga23() 
        {
            int[,] tabela = { { 1, 2, 3 }, 
                              { 3, 4, 5 }, 
                              { 5, 6, 7 } };

            // prvi indeks - vrstice
            // drugi indeks - stolpci

            int vsota = 0;
            for (int j = 0; j < tabela.GetLength(1); j++) // po številu stolpcev
            {
                vsota = 0;
                // vsota po stolpcih
                for (int i = 0; i < tabela.GetLength(0); i++) // po številu vrstic
                {
                    vsota += tabela[i, j];
                }
                Console.WriteLine(vsota);
            }
        }

        //************************
        // SEZNAMI
        //************************

        public static void Naloga5_1()
        {
            // seznam - List
            List<int> seznam = new List<int>(); // ustvari prazen seznam

            seznam.Add(1); // 1 doda na konec seznama
            seznam.Add(2); seznam.Add(3); seznam.Add(4); seznam.Add(5);
            seznam.Add(6); seznam.Add(7); seznam.Add(8); seznam.Add(9);

            seznam.Insert(5, 11); // Insert(indeks, element)

            // izpis seznama
            for (int i = 0; i < seznam.Count(); i++) // Count - število elementov
            {
                Console.Write(seznam[i] + " ");
            }
            Console.WriteLine();
        }

        // Pomembna za poznavanje delovanja seznamov
        public static void Naloga5_12() 
        {
            // 1. deklariramo seznam znakov
            // 2. sprehodimo se čez seznam (for)
            // 3. preverimo ali je trenutni element (znak) samoglasnik (if)
            // 4. če je, ga izbrišemo iz seznama

            // 1.
            List<char> seznam = new List<char>() { 'a', 'b', 'e', 'i', 'c', 'd', 'o'};

            // 2.
            for (int i = 0; i < seznam.Count(); i++) 
            {
                // 3.
                if (JeSamoglasnik(seznam[i])) 
                {
                    // 4.
                    seznam.RemoveAt(i); // z indeksi uporabimo RemoveAt()
                    i--; // ostanemo na istem mestu v seznamu
                }
            }

            // ločen izpis seznama
            foreach (char element in seznam)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
        // Na začetku (i == 0)
        // 0, 1, 2, 3, 4, 5, 6
        // a, b, e, i, c, d, o

        // Po prvi iteraciji (i == 1)
        // 0, 1, 2, 3, 4, 5
        // b, e, i, c, d, o

        // 0, 1, 2, 3, 4 (i == 2)
        // b, i, c, d, o

        // ločena metoda, ki za podan znak preveri ali je mali samoglasnik
        public static bool JeSamoglasnik(char znak) 
        {
            switch (znak) 
            {
                case 'a' or 'e' or 'i' or 'o' or 'u':
                    return true;
                default:
                    return false;
            }
        }


        public static void Naloga5_4() 
        {
            // 1. deklariramo seznam
            // 2. deklariramo seznama sodih in lihih
            // 3. sprehod čez seznam (zanka)
            // 4. za vsak element se odločimo ali ga dodamo med sode ali med lihe (if)

            // 1.
            List<int> seznam = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // 2.
            List<int> seznamSodih = new List<int>();
            List<int> seznamLihih = new List<int>();

            // 3.
            for (int i = 0; i < seznam.Count(); i++)
            {
                // 4.
                if (seznam[i] % 2 == 0) // sodi elementi
                {
                    seznamSodih.Add(seznam[i]);
                }
                else
                {
                    seznamLihih.Add(seznam[i]);
                }
            }

            // izpis sodega seznama
            foreach (int element in seznamSodih) 
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            // izpis lihega seznama
            foreach (int element in seznamLihih)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }


    }
}
