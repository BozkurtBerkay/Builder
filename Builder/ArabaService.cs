using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class ArabaService
    {
        public void ArabaTopla(IArabaToplayicisi arabatoplayicisi)
        {
            arabatoplayicisi.Kaporta();
            arabatoplayicisi.Motor();
            arabatoplayicisi.Sanziman();
        }
    }
}
