using System;
using System.Collections.Generic;
using System.Text;

namespace Week1._2.Classi.Intefacce
{
    public interface ILogging
    {
        void LogInfo(string messaggio);
        void LogWarming(string messaggio);
        void LogError(string messaggio);
    }
}
