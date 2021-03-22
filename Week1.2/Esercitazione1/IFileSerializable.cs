using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Esercitazione1
{
    interface IFileSerializable
    {
        void SaveToFile(string fileName);
        void FromFile(string fileName);
    }
}
