namespace DISIA_Vaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tocka t1 = new Tocka();
            Tocka t2 = new Tocka("A", "modra");

            Tocka2D t3 = new Tocka2D();
            Tocka2D t4 = new Tocka2D(5, 3);
            Tocka2D t5 = new Tocka2D("B", "rumena", 2, 2);

            Tocka3D t6 = new Tocka3D();
            Tocka3D t7 = new Tocka3D("C", "zelena", 1, 0, 2);

            List<Tocka> seznam = new List<Tocka>();
            seznam.Add(t1); seznam.Add(t2); seznam.Add(t3); seznam.Add(t4);
            seznam.Add(t5); seznam.Add(t6); seznam.Add(t7);

            /*
            foreach (Tocka t in seznam) 
            {
                Console.WriteLine(t.ToString());
            }
            */
            // Izpisimo vse točke tipa Tocka2D in Tocka3D
            foreach (Tocka t in seznam) 
            {
                if (t is Tocka2D && !(t is Tocka3D)) 
                {
                    Console.WriteLine(t.ToString());
                }
            }

        }

        public static void TestZgradba() 
        {
            Zgradba zgradba1 = new Zgradba("FIŠ", 120.5, 2500000.50, 3);
            Console.WriteLine(zgradba1.ToString());

            Hisa hisa = new Hisa("FIŠ", true, 3);
            Console.WriteLine(hisa.ToString());

            Zgradba zgradba2 = new Hisa();

            List<Zgradba> seznamZgradb = new List<Zgradba>();
            seznamZgradb.Add(zgradba1);
            seznamZgradb.Add(hisa);
            seznamZgradb.Add(zgradba2);

            foreach (Zgradba zg in seznamZgradb)
            {
                Console.WriteLine(zg.ToString());
            }
        }

        public static void TestAvtorKnjiga() 
        {
            Avtor avtor = new Avtor();
            Avtor avtor2 = new Avtor("Bine");
            Avtor avtor3 = new Avtor("Bine", "Jagodnik", 'm', 30, "bine@gmail.com");

            // metoda objekta, vsak objekt ima svojo kopijo metode
            Console.WriteLine(avtor.SpremeniVNiz());
            Console.WriteLine(avtor2.SpremeniVNiz());
            Console.WriteLine(avtor3.SpremeniVNiz());

            Console.WriteLine(avtor.Ime);

            // metoda razreda (ena sama), ki ji podamo objekt Avtor
            Console.WriteLine(Avtor.SpremeniVNiz2(avtor3));

            Knjiga knjiga = new Knjiga(avtor3);
            Console.WriteLine(knjiga.SpremeniVNiz());
        }

        public static void DumpMetoda() 
        {
            Primeri.TryCatch1();
            //Primeri.TryCatch2();

            //Vislice.Igraj();
            Primeri.Geslo();

            /*
            Vaje4.DodatnaMetoda();

            string besedilo = "To je besedilo, ki ga bomo obravnavali.";

            char[] locila = [' ', '.', ',', ':', ';'];

            string[] besede = besedilo.Split(locila);
            foreach (string niz in besede) 
            {
                Console.WriteLine(niz);
            }

            
            List<string> seznam = new List<string>();
            seznam.Add("niz"); seznam.Add("raca"); seznam.Add("jabolko");
            seznam.Add("programiranje");

            // var - ko ne poznamo točnega tipa podatka
            (string beseda, int indeks) = Vaje4.NajdaljsaBeseda(seznam);
            Console.WriteLine(beseda);
            Console.WriteLine(indeks);

            
            int a = 5;
            Console.WriteLine($"Pred metodo {a}");
            Test1(a);
            Console.WriteLine($"Po metodi {a}");

            int[] tabela = new int[2];
            Console.WriteLine($"Pred metodo {tabela[0]}");
            Test2(tabela);
            Console.WriteLine($"Po metodi {tabela[0]}");
            
            List<string> seznam = new List<string>();
            seznam.Add("Abeceda"); seznam.Add("Banana");
            seznam.Add("Ananas");

            List<string> novSeznam = Vaje4.Besede('A', seznam);

            // po elementih
            foreach (string niz in novSeznam) 
            {
                Console.WriteLine(niz);
            }

            // po indeksih
            for (int i = 0; i < novSeznam.Count; i++) 
            {
                Console.WriteLine(novSeznam[i]);
            }
            */
        }

        public static void Test1(int a)
        {
            a += 2;
            Console.WriteLine($"V metodi {a}");
        }

        public static void Test2(int[] tabela)
        {
            tabela[0] += 2;
            Console.WriteLine($"V metodi {tabela[0]}");
        }
    }
}
