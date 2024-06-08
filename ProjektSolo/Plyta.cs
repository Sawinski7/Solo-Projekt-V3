using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSolo
{
    public struct Plyta
    {
        public string tytul;
        public string typ;
        public string czasTrwania;
        public List<Utwor> utwory;
        public string wykonawcy;
        public int id;

        public Plyta(string tytulPlyty, string typPlyty, string czasTrwaniaPlyty, List<Utwor> utworyPlyty, string wykonawcyPlyty, int idPlyty)
        {
            tytul = tytulPlyty;
            typ = typPlyty;
            czasTrwania = czasTrwaniaPlyty;
            utwory = utworyPlyty;
            wykonawcy = wykonawcyPlyty;
            id = idPlyty;
        }
    }

    public struct Utwor
    {
        public string tytul;
        public string czasTrwania;
        public string wykonawcy;
        public string kompozytor;
        public int id;

        public Utwor(string tytulUtworu, string czasTrwaniaUtworu, string wykonawcyUtworu, string kompozytorUtworu, int idUtworu)
        {
            tytul = tytulUtworu;
            czasTrwania = czasTrwaniaUtworu;
            wykonawcy = wykonawcyUtworu;
            kompozytor = kompozytorUtworu;
            id = idUtworu;
        }
    }

    public class Bazowa
    {
        public string tytul;
        public string wykonawca;
        public string gatunek;

        public Bazowa(string tytulU, string wykonawcaU, string gatunekU)
        {
            tytul = tytulU;
            wykonawca = wykonawcaU;
            gatunek = gatunekU;
        }
    }

    public class UlubionyWykonawcaEver
    {
        public string imie;
        public string nazwisko;
        public string gatunekMuzyczny;
        public string krajPochodzenia;

        public UlubionyWykonawcaEver(string imieWyk, string nazwiskoWyk, string gatunekMuzycznyWyk, string krajPochodzeniaWyk = "Polska")
        {
            imie = imieWyk;
            nazwisko = nazwiskoWyk;
            gatunekMuzyczny = gatunekMuzycznyWyk;
            krajPochodzenia = krajPochodzeniaWyk;
        }
    }

    public class UlubionyUtworT:Bazowa
    {
        public int rokWydania;

        public UlubionyUtworT(string tytulU, string wykonawcaU, string gatunekU, int rokWydaniaU = 2024):base(tytulU, wykonawcaU, gatunekU)
        {
            rokWydania = rokWydaniaU;
        }
    } 
}
