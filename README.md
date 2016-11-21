# Program.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {


            
            //Osoba osoba1 = new Osoba();
            //osoba1.imie = "Adam";
            //osoba1.nazwisko = "Mickiewicz";
            //Console.WriteLine("Imie osoby: {0}", osoba1.imie);
            //Console.WriteLine("Rok produkcji: {0}", osoba1.nazwisko);
                       
            string autor = "Autor";
            Autor autor1 = new Autor();
            autor1.narodowosc = "Polska";
            Console.WriteLine("Narodowosc: {0}", autor1.narodowosc);

            //string pozycja = "Pozycja";
            //Pozycja pozycja1 = new Pozycja();
            //pozycja1.tytul = "III cz. Dziadow";
            //pozycja1.id = 1;
            //pozycja1.wydawnictwo = "...";
            //pozycja1.rokWydania = 1832;

            
            

        }
    }
}

#Osoba.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Osoba
    {
        public string imie;
        public string nazwisko;
        public Osoba(string imie, string nazwisko)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

    }
}

#Autor
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Autor : Osoba
    {
        public string narodowosc;
        
        public void Autor(string narodowosc)
        {
            this.narodowosc = narodowosc;
        }
    }
}

#Pozycja.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    abstract class Pozycja
    {
        public string tytul;
        public int id;
        public string wydawnictwo;
        public int rokWydania;

        public abstract void Pozycja(string tytul, int id, string wydawnictwo, int rokWydania)
        {
            this.tytul = tytul;
            this.id = id;
            this.wydawnictwo = wydawnictwo;
            this.rokWydania = rokWydania;
        }

        
        
        //public abstract void WypiszInfo();
    //{
        //Console.WriteLine("Tytul: {0}", tytul);
        //Console.WriteLine("ID: {0}", id);
        //Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
        //Console.WriteLine("Rok wydania: {0}", rokWydania);
        //Console.ReadKey();
    //}
    
    }
}

#Ksiazka.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Ksiazka : Pozycja
    {
        int liczbaStron;

        public Ksiazka(int liczbaStron)
        {
            this.liczbaStron = liczbaStron;
        }
    }
}
