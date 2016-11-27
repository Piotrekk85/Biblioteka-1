using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Autor : Osoba
    {
        private string narodowosc;  //hermetyzacja!

        //konstruktor parametryczny, fajnie gdyby ten konstruktor nie ustawiał tylko samą narodowosc, w konstruktorze nie uzywam slowa kluczowego void(!)
        public Autor(string imie, string nazwisko, string narodowosc)
            :base(imie,nazwisko)
        {
            this.narodowosc = narodowosc;
        }

        //konstruktor domyslny
        public Autor() { }

        //konstruktor z 2 parametrami (bez narodowosci) - uwaga jw
        public Autor(string imie, string nazwisko)
            : base(imie, nazwisko)
        {
            narodowosc = "Polska";
        }

        public string PobierzAutora()
        {
            return imie + " " + nazwisko;
        }
    }
}