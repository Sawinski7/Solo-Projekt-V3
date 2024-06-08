using System.Runtime.CompilerServices;
using ProjektSolo;
using System.IO;

namespace ProjektSolo
{
    internal class Program
    {
        public static List<Utwor> listaUtworow = new List<Utwor>();
        public static List<Plyta> listaPlyt = new List<Plyta>();
        public static List<UlubionyUtworT> listaUlubUtworow = new List<UlubionyUtworT>();
        public static List<UlubionyWykonawcaEver> listaUlubWyk = new List<UlubionyWykonawcaEver>();

        static void Main(string[] args)
        {
            int wybor;

            do
            {
                Console.WriteLine("Menadżer zbioru płyt");
                Console.WriteLine("1. Dodaj płytę");
                Console.WriteLine("2. Dodaj ulubionego polskiego wykonawcę wszech czasów");
                Console.WriteLine("3. Dodaj ulubiony utwór wydany w 2024 roku");
                Console.WriteLine("4. Wyświetl wszystkie płyty");
                Console.WriteLine("5. Wyświetl szczegółowe informacje na temat wybranej płyty");
                Console.WriteLine("6. Wyświetl wykonawców wykonujących utwory na danej płycie");
                Console.WriteLine("7. Wyświetl szczegóły na temat wybranego utworu");
                Console.WriteLine("8. Zapisz całość do pliku");
                Console.WriteLine("9. Odczytaj całość z pliku");
                Console.WriteLine("10. Zakończ");
                wybor = Convert.ToInt32(Console.ReadLine());

                if(wybor == 1)
                {
                    DodajPlyte();
                }
                else if (wybor == 2)
                {
                    DodajUlubWyk();
                }
                else if (wybor == 3)
                {
                    DodajUlubUtwor();
                }
                else if(wybor == 4)
                {
                    WyswietlPlyty();
                }
                else if(wybor == 5)
                {
                    WyswietlSzczegolPlyty();
                }
                else if(wybor == 6)
                {
                    WyswietlWykonawcow();
                }
                else if(wybor == 7)
                {
                    WyswietlSzczegolUtworu();
                }
                else if(wybor == 8)
                {
                    Zapis();
                }
                else if (wybor == 9)
                {
                    Odczyt();
                }
            }
            while(wybor != 10);
        }

        static void DodajPlyte()
        {
            Console.Clear();
            Console.Write("Podaj tytuł płyty: ");
            string tytul = Console.ReadLine();
            Console.Write("Podaj typ płyty: ");
            string typ = Console.ReadLine().ToUpper();
            Console.Write("Podaj czas trwania płyty: ");
            string czasTrwania = Console.ReadLine();

            while (true)
            {
                Console.Write("Czy chcesz dodać utwór? (t/n)");
                string wyb = Console.ReadLine().ToLower();

                if(wyb == "n")
                {
                    break;
                }
                else if(wyb == "t")
                {
                    Console.Write("Podaj tytuł utworu: ");
                    string tytUtworu = Console.ReadLine();
                    Console.Write("Podaj czas trwania utworu: ");
                    string czasUtworu = Console.ReadLine();
                    Console.Write("Podaj wykonawców utworu: ");
                    string wykUtworu = Console.ReadLine();
                    Console.Write("Podaj kompozytora utworu: ");
                    string komUtworu = Console.ReadLine();
                    Console.Write("Podaj numer utworu: ");
                    int nUtworu = Convert.ToInt32(Console.ReadLine());

                    Utwor nowyUtwor = new Utwor(tytUtworu, czasUtworu, wykUtworu, komUtworu, nUtworu);
                    listaUtworow.Add(nowyUtwor);
                }
                else
                {
                    Console.WriteLine("Zły klawisz");
                }    
            }

            Console.Write("Podaj wykonawców utworów na płycie: ");
            string wykPlyty = Console.ReadLine();
            Console.Write("Podaj numer płyty: ");
            int nPlyty = Convert.ToInt32(Console.ReadLine());

            Plyta nowaPlyta = new Plyta(tytul, typ, czasTrwania, listaUtworow, wykPlyty, nPlyty);
            listaPlyt.Add(nowaPlyta);
            Console.Clear();
            Console.WriteLine("Dodano płytę\n");
        }

        static void DodajUlubWyk()
        {
            Console.Clear();
            Console.WriteLine("Podaj imię ulubionego wykonawcy: ");
            string imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko ulubionego wykonawcy: ");
            string nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj gatunek muzyczny, który wykonuje ulubiony artysta: ");
            string gat = Console.ReadLine();

            UlubionyWykonawcaEver nowyUlubWyk = new UlubionyWykonawcaEver(imie, nazwisko, gat);
            listaUlubWyk.Add(nowyUlubWyk);
            Console.Clear();
            Console.WriteLine("Dodano ulubionego wykonawcę\n");
        }

        static void DodajUlubUtwor()
        {
            Console.Clear();
            Console.WriteLine("Podaj tytuł ulubionego utworu: ");
            string t = Console.ReadLine();
            Console.WriteLine("Podaj wykonawcę ulubionego utworu: ");
            string w = Console.ReadLine();
            Console.WriteLine("Podaj gatunek ulubionego utworu: ");
            string g = Console.ReadLine();

            UlubionyUtworT nowyUlubU = new UlubionyUtworT(t, w, g);
            listaUlubUtworow.Add(nowyUlubU);
            Console.Clear();
            Console.WriteLine("Dodano utwór\n");
        }

        static void WyswietlPlyty()
        {
            Console.Clear();
            Console.WriteLine("Lista wszystkich płyt:");

            for (int i = 0; i<listaPlyt.Count; i++)
            {
                Console.WriteLine(listaPlyt[i].tytul);
            }
            Console.WriteLine("\n");
        }

        static void WyswietlSzczegolPlyty()
        {
            Console.Clear();
            Console.Write("Podaj numer płyty, w celu wyświetlenie jej szczegółów: ");
            int wyb = Convert.ToInt32(Console.ReadLine()) - 1;

            if(wyb < 0 || wyb >= listaPlyt.Count)
            {
                Console.WriteLine("Podano zły numer płyty");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Poniżej wyświetlam szczegółowe informacje o płycie {listaPlyt[wyb].tytul}");
                Console.WriteLine($"Tytuł płyty: {listaPlyt[wyb].tytul}");
                Console.WriteLine($"Typ płyty: {listaPlyt[wyb].typ}");
                Console.WriteLine($"Czas trwania płyty: {listaPlyt[wyb].czasTrwania}");
                Console.WriteLine("Utwory znajdujące się na płycie:");
                foreach(var utwor in listaPlyt[wyb].utwory)
                {
                    Console.WriteLine($"{utwor.id}. {utwor.tytul}");
                }
            }
        }
        static void WyswietlWykonawcow()
        {
            Console.Clear();
            Console.Write("Podaj numer płyty, w celu wyświetlenie jej wykonawców: ");
            int wyb = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Clear();
            Console.WriteLine($"Lista wszystkich wykonawców utworów na płycie {listaPlyt[wyb].tytul}: {listaPlyt[wyb].wykonawcy}\n");
        }

        static void WyswietlSzczegolUtworu()
        {
            Console.Clear();
            Console.Write("Podaj numer płyty: ");
            int wybPlyty = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Write("Podaj numer utworu: ");
            int wybUtworu = Convert.ToInt32(Console.ReadLine()) - 1;
            Console.Clear();
            Console.WriteLine($"Poniżej wyświetlam szczegółowe informacje o utworze {listaPlyt[wybPlyty].utwory[wybUtworu].tytul} z płyty {listaPlyt[wybPlyty].tytul}");
            Console.WriteLine($"Tytuł utworu: {listaPlyt[wybPlyty].utwory[wybUtworu].tytul}");
            Console.WriteLine($"Czas trwania utworu: {listaPlyt[wybPlyty].utwory[wybUtworu].czasTrwania}");
            Console.WriteLine($"Wykonawcy wykonujący utwór: {listaPlyt[wybPlyty].utwory[wybUtworu].wykonawcy}");
            Console.WriteLine($"Kompozytor utworu: {listaPlyt[wybPlyty].utwory[wybUtworu].kompozytor}\n");
        }

        static void Zapis()
        {
            Console.Clear();
            StreamWriter sw = new StreamWriter("Info.txt", true);
            foreach(var plyta in listaPlyt)
            {
                sw.WriteLine($"Tytuł płyty: {plyta.tytul}");
                sw.WriteLine($"Typ płyty: {plyta.typ}");
                sw.WriteLine($"Czas trwania płyty: {plyta.czasTrwania}");
                sw.WriteLine($"Utwory znajdujące się na płycie:");
                foreach (var utwor in plyta.utwory)
                {
                    sw.WriteLine($"Numer utworu: {utwor.id}, Tytuł utworu: {utwor.tytul}, Czas trwania utworu: {utwor.czasTrwania}, Wykonawcy utworu: {utwor.wykonawcy}, Kompozytor utworu: {utwor.kompozytor}");
                }
                sw.WriteLine($"Wykonawcy płyty: {plyta.wykonawcy}");
                sw.WriteLine($"Numer płyty: {plyta.id}\n");
            }
            sw.Close();
            StreamWriter sw2 = new StreamWriter("UlubInfo.txt");
            sw2.WriteLine($"Lista ulubionych polskich wykonawców:");
            foreach (var ulubWyk in listaUlubWyk)
            {
                sw2.WriteLine($"Imię: {ulubWyk.imie}, Nazwisko: {ulubWyk.nazwisko}, Gatunek: {ulubWyk.gatunekMuzyczny}, Kraj: {ulubWyk.krajPochodzenia}");
            }
            sw2.WriteLine($"Lista ulubionych utworów wydanych w 2024 roku:");
            foreach (var ulubUtwor in listaUlubUtworow)
            {
                sw2.WriteLine($"Tytuł: {ulubUtwor.tytul}, Wykonawca: {ulubUtwor.wykonawca}, Gatunek: {ulubUtwor.gatunek}, Rok wydania: {ulubUtwor.rokWydania}");
            }
            sw2.Close();
            Console.WriteLine("Dane zostały zapisane do pliku\n");
        }
        static void Odczyt()
        {
            Console.Clear();
            using StreamReader reader = new("Info.txt");
            string text = reader.ReadToEnd();
            Console.WriteLine(text);
            using StreamReader reader2 = new("UlubInfo.txt");
            string text2 = reader2.ReadToEnd();
            Console.WriteLine(text2);
        }
    }
}
