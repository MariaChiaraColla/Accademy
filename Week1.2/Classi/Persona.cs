using System;
using System.Collections.Generic;
using System.Text;
using Week1._2.Classi.Intefacce;

namespace Week1._2.Classi
{
    public class Persona : ILogging
    {
        //campi
        private string _codiceFiscale;

        //proprietà
        public string CodiceFiscale
        {
            get { return _codiceFiscale; }
            set { _codiceFiscale = value; }
        }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public int NumeroFigli { get; set; }

        //metodi
        public virtual string FullName(string title)
        {
            return "[" + title + "]" + " " + Nome + " " + Cognome;
        }

        //interfaccia ILogging
        public void LogError(string messaggio)
        {
            Console.WriteLine("[ERORRO] " +messaggio);
        }

        public void LogInfo(string messaggio)
        {
            Console.WriteLine("[INFO] " + messaggio);
        }

        public void LogWarming(string messaggio)
        {
            Console.WriteLine("[WARNING] "+ messaggio);
        }
    }
}
