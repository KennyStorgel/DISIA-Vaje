using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    public class Zgradba
    {
        public string ImeLastnika { get; set; }
        public double Kvadratura { get; set; }
        public double Cena { get; set; }
        public int Nadstropja { get; set; }

        public Zgradba(string lastnik) 
        {
            ImeLastnika = lastnik;
            Kvadratura = 0;
            Cena = 0;
            Nadstropja = 0;
        }

        public Zgradba(string lastnik, double kvadratura, double cena, int nadstropja) 
        {
            ImeLastnika = lastnik;
            Kvadratura = kvadratura;
            Cena = cena;
            Nadstropja = nadstropja;
        }

        // Metoda ToString je iz razreda Object (deklarirana je kot virtual)
        public override string ToString() 
        {
            string niz = "";
            niz += "Lastnik zgradbe: " + ImeLastnika + "\n";
            niz += "Kvadratura: " + Kvadratura + " kvadratnih metrov\n";
            niz += $"Cena: {Cena}\u20AC\n";
            niz += "Stevilo nadstropij: " + Nadstropja + "\n";
            return niz;
        }

        public virtual string Metoda() 
        {
            return "";
        }
    }

    public class Hisa : Zgradba
    {
        public bool JeSamostojna { get; set; }
        public int SteviloPrebivalcev { get; set; }

        public Hisa() : base("Lastnik")
        {
            
        }
        public Hisa(string lastnik, bool jeSamostojna, int steviloPrebivalcev) : base(lastnik)
        {
            JeSamostojna = jeSamostojna;
            SteviloPrebivalcev = steviloPrebivalcev;
        }

        public Hisa(string lastnik, bool jeSamostojna) : base(lastnik, 0, 0, 0)
        {
            JeSamostojna = jeSamostojna;
            SteviloPrebivalcev = 0;
        }

        
        public override string ToString() 
        {
            string niz = "";
            niz += base.ToString(); // kličemo metodo ToString iz nadrazreda
            niz += "Samostojna: " + JeSamostojna + "\n";
            niz += "Stevilo prebivalcev: " + SteviloPrebivalcev + "\n";
            return niz;
        }

        public override string Metoda() 
        {
            return "";
        }
        
    }
}
