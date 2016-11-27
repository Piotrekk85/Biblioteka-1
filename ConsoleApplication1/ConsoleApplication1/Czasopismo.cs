using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Czasopismo : Pozycja
    {
        private int numer;

        //konstruktor parametryczny 
        public Czasopismo(int numer, string tytuł, int id, string wydawnictwo, int rokWydania)
            : base(tytuł, id, wydawnictwo, rokWydania)
        {
            this.numer = numer;
        }
        
        //konstruktor domyślny
        public Czasopismo()
        {           
        }

        //trzeba przesłonić metodę i dodać tu implementację
        public override void WypiszInfo()
        {
            Console.WriteLine("Tytuł: {0}", tytul);
            Console.WriteLine("Numer: {0}", numer);
            Console.WriteLine("Nr katalogowy: {0}", id);
            Console.WriteLine("Wydawnictwo: {0}", wydawnictwo);
            Console.WriteLine("Rok wydaniwa: {0}", rokWydania);
        }

    }
}
