using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    class Knjiga
    {

        // lastnosti
        public string Naslov { get; set; }
        public Avtor Avtor { get; set; }
        public string Zalozba { get; set; }
        public int Strani { get; set; }

        // konstruktor
        
        public Knjiga(Avtor avtor) 
        {
            Naslov = "";
            Avtor = avtor;
            Zalozba = "";
            Strani = 0;
        }
        
        // metoda objekta
        public string SpremeniVNiz()
        {
            string niz = "";
            niz += "Podatki o avtorju:\n";
            niz += Avtor.SpremeniVNiz();
            niz += Naslov + "\n";
            niz += Zalozba + "\n";
            niz += Strani + "\n";
            return niz;
        }

    }
}
