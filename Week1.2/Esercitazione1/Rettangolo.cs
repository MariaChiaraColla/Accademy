using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Esercitazione1
{
    public class Rettangolo : FormeGeometriche
    {
        //proprietà
        public double Larghezza{ get; set; }
        public double Altezza { get; set; }

        //metodi

        //forme geometriche
        public override double Area()
        {
            return Larghezza * Altezza;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine("Questo è un " + Nome + " con: " + "Larghezza= " + Larghezza + ", Altezza= " + Altezza + " e Area= " + Area());
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
