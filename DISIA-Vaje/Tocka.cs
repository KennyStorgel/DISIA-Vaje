using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISIA_Vaje
{
    public class Tocka
    {
        // lastnosti
        public string Oznaka { get; set; }
        public string Barva { get; set; }

        // konstruktorji
        public Tocka() 
        {
            Oznaka = "X";
            Barva = "bela";
        }

        public Tocka(string oznaka, string barva) 
        {
            Oznaka = oznaka;
            Barva = barva;
        }

        // metode - funkcionalnosti
        public override string ToString()
        {
            string niz = "";
            niz += $"Oznaka tocke: {Oznaka}\n";
            niz += $"Barva: {Barva}\n";
            return niz;
        }

        public string VNiz()
        {
            string niz = "";
            niz += $"Oznaka tocke: {Oznaka}\n";
            niz += $"Barva: {Barva}\n";
            return niz;
        }
    }

    public class Tocka2D : Tocka 
    {
        public int KoordinataX { get; set; }
        public int KoordinataY { get; set; }

        public Tocka2D() : base() 
        {
            KoordinataX = 0;
            KoordinataY = 0;
        }

        public Tocka2D(int x, int y) : base() 
        {
            KoordinataX = x;
            KoordinataY = y;
        }

        public Tocka2D(string oznaka, string barva, int x, int y) : base(oznaka, barva)
        {
            KoordinataX = x;
            KoordinataY = y;
        }

        public override string ToString()
        {
            string niz = "";
            niz += base.ToString();
            niz += $"({KoordinataX}, {KoordinataY})\n";
            return niz;
        }
    }

    public class Tocka3D : Tocka2D 
    {
        public int KoordinataZ { get; set; }

        public Tocka3D() : base() 
        {
            //KoordinataX = 10;
            KoordinataZ = 0;
        }

        public Tocka3D(string oznaka, string barva, int x, int y, int z) : base(oznaka, barva, x, y) 
        {
            KoordinataZ = z;
        }

        public override string ToString()
        {
            string niz = "";
            niz += this.VNiz(); // this - referenca na trenutni razred (Tocka3D)
            niz += $"({KoordinataX}, {KoordinataY}, {KoordinataZ})\n";
            return niz;
        }
    }
}
