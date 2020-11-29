using System;

namespace Builder
{
    class Program
    { 
        
        static void Main(string[] args)
        {
            ArabaService cs = new ArabaService();

            IArabaToplayicisi bmw = new BMW();
            IArabaToplayicisi mercedes = new Mercedes();
             
            cs.ArabaTopla(bmw);
            bmw.araba.ArabaGetir();
            Console.WriteLine();
            cs.ArabaTopla(mercedes);
            mercedes.araba.ArabaGetir();

        }
    }
}
