using System;

namespace Builder
{
    class Program
    {
        public interface ICarToplayicisi
        {
            Car araba { get; }

            void Motor();
            void Kaporta();
            void Sanziman();
        }

        public class BMW : ICarToplayicisi
        {
            private Car _araba;

            public Car araba { get { return _araba; } }

            public BMW()
            {
                _araba = new Car("BMW");
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

        public class Mercedes : ICarToplayicisi
        {
            private Car _araba;
            public Car araba
            {
                get { return _araba; }
            }

            public Mercedes()
            {
                _araba = new Car("Mercedes");
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


        public class Car
        {
            private string _CarTipi;

            private System.Collections.Hashtable cParcalar = new System.Collections.Hashtable();

            public Car(string CarTipi)
            {
                _CarTipi = CarTipi;
            }

            public object this[string key]
            {
                get { return cParcalar[key]; }
                set { cParcalar[key] = value; }
            }

            public void ArabaGetir()
            {
                Console.WriteLine("Araba tipi: " + _CarTipi);
                Console.WriteLine("Kaporta: " + cParcalar["kaporta"]);
                Console.WriteLine("Motor: " + cParcalar["motor"]);
                Console.WriteLine("Sanzıman: " + cParcalar["sanziman"]);
            }
        }

        public class CarService
        {
            public void CarTopla(ICarToplayicisi arabatoplayicisi)
            {
                arabatoplayicisi.Kaporta();
                arabatoplayicisi.Motor();
                arabatoplayicisi.Sanziman();
            }
        }
        static void Main(string[] args)
        {
            CarService cs = new CarService();

            ICarToplayicisi bmw = new BMW();
            ICarToplayicisi mercedes = new Mercedes();

            cs.CarTopla(bmw);
            bmw.araba.ArabaGetir();

            cs.CarTopla(mercedes);
            mercedes.araba.ArabaGetir();

        }
    }
}
