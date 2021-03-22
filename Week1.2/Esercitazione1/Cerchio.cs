using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Esercitazione1
{
    public class Cerchio : FormeGeometriche
    {
        //proprietà
        public int X { get; set; }
        public int Y { get; set; }
        public double Raggio { get; set; }


        //metodi
        //Forme Geometriche
        public override double Area()
        {
            return Math.Pow(Raggio,2) * Math.PI;
        }

        public override void DisegnaForma()
        {
            Console.WriteLine("Questo è un " + Nome + " con: Coordinate X= "+X+" Y= "+Y + ", Raggio= " + Raggio +" e Area= " + Area());
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
