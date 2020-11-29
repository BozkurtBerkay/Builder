using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class BMW : IArabaToplayicisi
    {
        private Araba _araba;

        public Araba araba { get { return _araba; } }

        public BMW()
        {
            _araba = new Araba("BMW");
        }

        public void Kaporta()
        {
            _araba["kaporta"] = "Mkasa";
        }

        public void Motor()
        {
            _araba["motor"] = "3.20";
        }

        public void Sanziman()
        {
            _araba["sanziman"] = "Otomatik";
        }
    }
}
