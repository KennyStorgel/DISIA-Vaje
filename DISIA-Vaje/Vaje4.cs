using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Vaje4
    {

        // Dodatna
        public static void DodatnaMetoda() 
        {
            // Kako bi iz besedila pobrali le besede.
            // Besedilo ima presledki, pike, vejice, dvopičja, podpičja
            // Presledki in ločila ločujejo besede.

            string besedilo = "To je besedilo, ki ga bomo obravnavali.";

            // 1. sprehodimo se čez besedilo
            int zacetek = -1; // začetek besede
            int konec = -1; // konec besede
            for (int i = 0; i < besedilo.Length; i++)
            {
                // našli smo prvo črko nove besede
                if (zacetek == -1 && JeCrka(besedilo[i]))
                {
                    zacetek = i;
                }
                else if (zacetek != -1 && !JeCrka(besedilo[i])) 
                {
                    konec = i - 1;
                    Console.WriteLine(besedilo.Substring(zacetek, konec-zacetek+1));
                    zacetek = -1;
                    konec = -1;
                }
            }
        }

        public static bool JeCrka(char znak) 
        {
            switch (znak) 
            {
                case ' ' or '.' or ',' or ':' or ';':
                    return false;
                default:
                    return true;
            }
        }

        // Naloga 6.9 - vračanje n-teric
        public static (string beseda, int idx) NajdaljsaBeseda(List<string> seznam) 
        {
            string najdaljsa = "";
            int indeks = -1;

            for (int i = 0; i < seznam.Count; i++) 
            {
                if (indeks == -1)
                {
                    najdaljsa = seznam[i];
                    indeks = i;
                }
                else if (seznam[i].Length > najdaljsa.Length) 
                {
                    najdaljsa = seznam[i];
                    indeks = i;
                }
            }

            return (najdaljsa, indeks);
        }

        // tabela       - string[]
        // tabela[i]    - string
        // tabela[i][j] - char

        // Naloga 6.7
        public static List<string> Besede(char crka, List<string> seznam) 
        {
            List<string> novSeznam = new List<string>(); // ustvari prazen seznam
            for (int i = 0; i < seznam.Count; i++) 
            {
                // seznam       - List<string>
                // seznam[i]    - string
                // seznam[i][0] - char
                if (seznam[i][0] == crka) 
                {
                    novSeznam.Add(seznam[i]);
                }
            }
            return novSeznam;
        }

        // Naloga 6.5
        public static int ZnakovVNizu(char znak, string niz) 
        {
            int stevec = 0;
            for (int i = 0; i < niz.Length; i++) 
            {
                if (niz[i] == znak) 
                {
                    stevec++;
                }
            }
            return stevec;
        }

        // Naloga 6.3
        public static bool JeVTabeli(char[] tabela, char znak) 
        {
            //bool nasli = false;
            for (int i = 0; i < tabela.Length; i++) 
            {
                if (tabela[i] == znak)
                {
                    return true;
                    //nasli = true;
                }
            }
            return false;
            //return nasli;
        }

        // Naloga 6.2
        public static int Delitelji(int stevilo) 
        {
            // 1. stevec za delitelje
            // 2. sprehod preko stevil 1 do stevilo
            // 3. za vsako od teh stevil preverimo ali deli stevilo

            int stevec = 0;
            for (int i = 1; i <= stevilo; i++) 
            {
                if (stevilo % i == 0) 
                {
                    stevec++;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
            return stevec;
        }


        // Naloga 6.1 - a na b (2 na 4) = 1 * 2 * 2 * 2 * 2
        public static int Potenca(int a, int b) 
        {
            int rezultat = 1;
            for (int i = 1; i <= b; i++) 
            {
                rezultat *= a;
            }
            return rezultat;
        }

    }
}
