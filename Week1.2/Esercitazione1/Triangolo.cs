using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Esercitazione1
{
    public class Triangolo : FormeGeometriche
    {
        //proprietà
        public double Base { get; set; }
        public double Altezza { get; set; }

        //metodi
        //forme geometriche
        public override double Area()
        {
            return (Base * Altezza) / 2;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine("Questo è un " + Nome + " con: " + "Base= " + Base + ", Altezza= " + Altezza + " e Area= " + Area());
        }

        //file serializable
        public override void FromFile(string fileName)
        {
            Console.WriteLine(Nome + " dal file: " + fileName);
        }

        public override void SaveToFile(string fileName)
        {
            Console.WriteLine(Nome + " salvato sul file: " + fileName);
        }
    }
}
