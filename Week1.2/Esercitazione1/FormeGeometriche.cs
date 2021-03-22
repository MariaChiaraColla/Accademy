using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Esercitazione1
{
    public abstract class FormeGeometriche : IFileSerializable
    {
        //proprietà
        public string Nome { get; set; }

        //Metodi
        public abstract double Area();
        public abstract void DisegnaForma();

        public abstract void FromFile(string fileName);

        public abstract void SaveToFile(string fileName);
    }
}
