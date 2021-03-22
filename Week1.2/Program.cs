using System;
using Week1._2.Esercitazione1;

namespace Week1._2
{
    class Program
    {
        delegate int Somma(int primoNumero, int secondoNumero);

        static void Main(string[] args)
        {
            //Funzionalita.EsercizioTipo();

            //Funzionalita.Esercitazioni();

            //delegate
            //associo a somma il metodo mysum che deve avere lo stesso tipo di ritorno e lo stesso numero e tipo dei parametri
            Somma somma = new Somma(Funzionalita.MySum);
            int risultato = somma(1, 2);
            int risultato2 = Funzionalita.MySum(1, 2);
        }
    }
}
