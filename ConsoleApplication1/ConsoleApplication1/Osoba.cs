using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Osoba
    {
        protected string imie; //hermetyzacja!
        protected string nazwisko; //hermetyzacja!

        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        //konstruktor domyślny
        public Osoba()
        {
            imie = "Jan";
            nazwisko = "Kowalski";
        }
    }
}