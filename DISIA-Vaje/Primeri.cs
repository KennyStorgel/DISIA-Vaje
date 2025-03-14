using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Primeri
    {
        public static void TryCatch2()
        {
            int a = 1, b = 0;
            int[] stevila = [1, 2, 3, 4, 5];
            int stevec = 0;
            //Razlicni primeri izjem
            try
            {
                Console.WriteLine(a / b);
                Console.WriteLine(stevila[5]);
            }
            catch (DivideByZeroException e1)
            {
                Console.WriteLine("Deljenje z 0. Spada med aritmeticne izjeme.");
            }
            catch (ArithmeticException e2)
            {
                Console.WriteLine("Aritmeticna izjema.");
            }
            catch (IndexOutOfRangeException e3)
            {
                Console.WriteLine("Napacen indeks. Tega elementa v tabeli ni.");
            }
            catch (FileNotFoundException e4)
            {
                Console.WriteLine("Datoteka ne obstaja.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Tukaj ujamemo vse preostale izjeme.");
            }
            finally 
            {
                Console.WriteLine("Izvede se ne glede na izjemo ali ne.");
            }
            
        }

        public static void TryCatch1() 
        {
            try
            {
                CheckAge(18);
                Console.WriteLine("Smo v try bloku kode.");
            }
            catch (ArithmeticException e) 
            {
                Console.WriteLine(e.Message);
            }
        }
        // Metanje izjem (throw) - primer 
        public static void CheckAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        public static void Geslo() 
        {
            Console.Write("password: ");
            string password = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
                Console.Write("*");
            }
            Console.WriteLine();
            Console.WriteLine(password);
        }
    }
}
