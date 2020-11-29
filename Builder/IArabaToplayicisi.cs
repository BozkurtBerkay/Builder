using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public interface IArabaToplayicisi
    {
        Araba araba { get; }

        void Motor();
        void Kaporta();
        void Sanziman();
    }
}
