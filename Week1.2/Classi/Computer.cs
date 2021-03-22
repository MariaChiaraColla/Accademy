using System;
using System.Collections.Generic;
using System.Text;
using Week1._2.Classi.Intefacce;

namespace Week1._2.Classi
{
    public class Computer : ILogging
    {
        //proprietà
        public string Modello { get; set; }

        //metodi
        public void LogError(string messaggio)
        {
            Console.WriteLine("[ERROR] " + messaggio + "(C)");
        }

        public void LogInfo(string messaggio)
        {
            Console.WriteLine("[INFO] " + messaggio + "(C)");
        }

        public void LogWarming(string messaggio)
        {
            Console.WriteLine("[WARMING] " + messaggio + "(C)");
        }
    }
}
