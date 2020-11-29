using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Mercedes : IArabaToplayicisi
    {
        private Araba _araba;
        public Araba araba
        {
            get { return _araba; }
        }

        public Mercedes()
        {
            _araba = new Araba("Mercedes");
        }
        public void Kaporta()
        {
            _araba["kaporta"] = "C Serisi";
        }

        public void Motor()
        {
            _araba["motor"] = "2.80";
        }

        public void Sanziman()
        {
            _araba["sanziman"] = "Manuel";
        }
    }
}
