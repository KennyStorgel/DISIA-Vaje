using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Vaje5
    {

        public static void Naloga1() 
        {
            List<string> seznam = new List<string>();
            seznam.Add("Vrstica 1");
            seznam.Add("Vrstica 2");
            seznam.Add("Vrstica 3");

            // povozi celotno vsebino datoteke
            StreamWriter sw = new StreamWriter("DatotekaA.txt");

            // doda vsebino na konec datoteke
            //StreamWriter sw = new StreamWriter("DatotekaA.txt", true);

            foreach (string niz in seznam) 
            {
                sw.WriteLine(niz); // zapišemo vrstico v datoteko
            }

            sw.Close(); // ko končamo zapisovanje v datoteko
        }

        public static void Naloga2() 
        {
            List<string> seznam = new List<string>();

            StreamReader sr = new StreamReader("DatotekaA.txt");

            // EndOfStream = true pomeni konec datoteke
            // pogoj -> dokler nismo na koncu datoteke
            while (sr.EndOfStream == false) 
            {
                string vrstica = sr.ReadLine();
                seznam.Add(vrstica);
            }

            sr.Close();

            foreach (string niz in seznam) 
            {
                Console.WriteLine(niz);
            }
        }


        // Naloga 3

        public static void ShraniVDatoteko(List<string> seznam, string pot_do_datoteke) 
        {
            StreamWriter sw = new StreamWriter(pot_do_datoteke);

            foreach (string niz in seznam)
            {
                sw.WriteLine(niz);
            }

            sw.Close();
        }

        public static void DodajVDatoteko(List<string> seznam, string pot_do_datoteke)
        {
            StreamWriter sw = new StreamWriter(pot_do_datoteke, true);

            foreach (string niz in seznam)
            {
                sw.WriteLine(niz);
            }

            sw.Close();
        }

        public static List<string> PreberiDatoteko(string pot_do_datoteke) 
        {
            List<string> seznam = new List<string>();

            StreamReader sr = new StreamReader(pot_do_datoteke);
            
            while (sr.EndOfStream == false)
            {
                string vrstica = sr.ReadLine();
                seznam.Add(vrstica);
            }

            sr.Close();
            return seznam;
        }

        public static void Naloga4() 
        {
            List<string> evidencaFinanc = new List<string>();

            Console.WriteLine("Nasa evidenca financ");
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Vnesi (1) za branje iz datoteke");
                Console.WriteLine("Vnesi (2) za shranjevanje v datoteko");
                Console.WriteLine("Vnesi (3) za obdelavo podatkov");
                Console.WriteLine("Vnesi (0) za izhod");

                string vnos = Console.ReadLine();

                switch (vnos) 
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Vnesi ime/pot datoteke");
                        vnos = Console.ReadLine();
                        evidencaFinanc = PreberiDatoteko(vnos);
                        break;
                    case "2":
                        Console.WriteLine("Vnesi ime/pot datoteke");
                        vnos = Console.ReadLine();
                        ShraniVDatoteko(evidencaFinanc, vnos);
                        break;
                    case "3":
                        UpravljajSPodatki(evidencaFinanc);
                        break;
                    default:
                        Console.WriteLine("Napacna izbira!");
                        break;
                }
            }
        }

        public static void UpravljajSPodatki(List<string> evidencaFinanc) 
        {
            while (true)
            {
                Console.WriteLine("Vnesi (1) za nov podatek");
                Console.WriteLine("Vnesi (2) za porabo za trgovino");
                Console.WriteLine("Vnesi (0) za izhod");

                string vnos = Console.ReadLine();

                switch (vnos)
                {
                    case "0":
                        return;
                    case "1":
                        string podatek = PripraviPodatek();
                        evidencaFinanc.Add(podatek);
                        break;
                    case "2":
                        double vsota = 0;
                        foreach (string element in evidencaFinanc) 
                        {
                            string[] podatki = element.Split(',');
                            // indeks 0 - predstavlja tip
                            // indeks 1 - predstavlja znesek
                            if (podatki[0] == "T") 
                            {
                                vsota += double.Parse(podatki[1]);
                            }
                        }
                        Console.WriteLine("Skupno za trgovino: " + vsota);
                        break;
                    default:
                        Console.WriteLine("Napacna izbira!");
                        break;
                }
            }
        }

        public static string PripraviPodatek() 
        {
            string podatek = "";
            /* T - trgovina
             * G- gospodinjstvo
             */
            Console.WriteLine("Izberi tip stroska (1) trgovina (2) gospodinjstvo");
            string vnos = Console.ReadLine();

            // predpostavljamo da pravilno vnesemo izbiro
            switch (vnos) 
            {
                case "1":
                    podatek = "T";
                    break;
                case "2":
                    podatek = "G";
                    break;
            }

            Console.WriteLine("Vnesi znesek");
            string znesek = Console.ReadLine();
            podatek += "," + znesek;

            return podatek; // T,100  G,20
        }
            
    }
}
