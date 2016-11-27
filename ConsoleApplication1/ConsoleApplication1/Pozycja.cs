using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class Pozycja
    {
        public string tytul;
        public int id;
        public string wydawnictwo;
        public int rokWydania;

        //konstruktor nie jest abstrakcyjny i nie potrzebuje slowa void
        public Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        //konstruktor domyslny
        public Pozycja() { }

        //metoda wypisująca informacje, wg polecenia miała być abstrakcyjna, więc "wnętrza"/implementacji tu nie dodajemy
        public abstract void WypiszInfo();

        //metoda pomocnicza do wyszukania po tytule
        public string PobierzTytul()
        {
            return tytul;
        }

        //metoda pomocnicza do wyszukania po id
        public int PobierzId()
        {
            return id;
        }

    }
}