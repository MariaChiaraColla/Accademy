using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Classi
{
    public class Impiegato : Persona
    {
        //metodi
        public string Dettagli()
        {
            return Cognome + "( " + NumeroFigli + " )";
        }

        public override string FullName(string title)
        {
            return "[Impiegato]" + Nome + " " + Dettagli();
        }
    }
}
