using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Araba
        {
            private string _ArabaTipi;

            private System.Collections.Hashtable cParcalar = new System.Collections.Hashtable();

            public Araba(string ArabaTipi)
            {
                _ArabaTipi = ArabaTipi;
            }

            public object this[string key]
            {
                get { return cParcalar[key]; }
                set { cParcalar[key] = value; }
            }

            public void ArabaGetir()
            {
                Console.WriteLine("Araba tipi: " + _ArabaTipi);
                Console.WriteLine("Kaporta: " + cParcalar["kaporta"]);
                Console.WriteLine("Motor: " + cParcalar["motor"]);
                Console.WriteLine("Sanzıman: " + cParcalar["sanziman"]);
            }
        }
}
