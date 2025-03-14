using System;
using System.Buffers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Avtor
    {
        // polja - (globalne) spremenljivke objekta
        /*
        public string ime;
        public string GetIme()
        {
            return this.ime;
        }
        public void SetIme(string ime)
        {
            this.ime = ime;
        }
        */

        // lastnosti
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public char Spol { get; set; }
        public int Starost { get; set; }
        public string Email { get; set; }

        // konstruktorji
        public Avtor() 
        {
            Ime = "ime";
            Priimek = "priimek";
            Spol = '?';
            Starost = 0;
            Email = "email@gmail.com";
        }

        public Avtor(string ime) 
        {
            Ime = ime;
            Priimek = "priimek";
            Spol = '?';
            Starost = 0;
            Email = "email@gmail.com";
        }

        public Avtor(string ime, string priimek, char spol, int starost, string email) 
        {
            Ime = ime;
            Priimek = priimek;
            Spol = spol;
            Starost = starost;
            Email = email;
        }


        // metoda objekta - funkcionalnost
        public string SpremeniVNiz() 
        {
            string niz = "";
            niz += Ime + "\n";
            niz += Priimek + "\n";
            niz += Spol + "\n";
            niz += Starost + "\n";
            niz += Email + "\n";
            return niz;
        }


        // metoda razreda - static
        public static string SpremeniVNiz2(Avtor avtor) 
        {
            string niz = "";
            niz += avtor.Ime + "\n";
            niz += avtor.Priimek + "\n";
            niz += avtor.Spol + "\n";
            niz += avtor.Starost + "\n";
            niz += avtor.Email + "\n";
            return niz;
        }
        
    }
}
