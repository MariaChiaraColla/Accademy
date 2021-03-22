using System;
using System.Collections.Generic;
using System.Text;
using Week1._2.Classi;
using Week1._2.Classi.Intefacce;
using Week1._2.Esercitazione1;

namespace Week1._2
{
    public enum Stato
    {
        New = 0,
        Open = 1,
        OnHold = 2,
        Closed = 3
    }

    public class Funzionalita
    {
        public static void EsercizioTipo()
        {
            #region value type vs references type
            //value type

            //bool
            bool x = true;
            bool y = false;
            bool z = !x;
            Console.WriteLine("Valore z: {0}", z);

            //Numerici
            int i = 0;
            int j = 34;
            int numero = 1 * (2 + 3) * 4;

            float f = 1f / 3F;
            double doub = 1d / 3d;
            decimal dec = 1m / 3m;
            Console.WriteLine("Float: " + f); //meno cifre decimali
            Console.WriteLine("Double: " + doub); //medio
            Console.WriteLine("Decimal: " + dec); //più cifre di tutti

            Console.WriteLine($"Range float: " + float.MinValue + " - " + float.MaxValue);
            Console.WriteLine($"Range double: " + double.MinValue + " - " + double.MaxValue);
            Console.WriteLine($"Range decimal: " + decimal.MinValue + " - " + decimal.MaxValue);

            //DateTime
            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime date = new DateTime(2020, 12, 25);
            Console.WriteLine("Data ora: " + now);
            Console.WriteLine("Data oggi: " + today);
            Console.WriteLine("Data natale: " + date);

            DateTime tomorrow = now.AddDays(1);
            DateTime In5Hours = now.AddHours(5);
            Console.WriteLine("Tomorrow: " + tomorrow + ", 5 ore: " + In5Hours);

            //enum, definito all'inizio
            Stato myStato = Stato.New;

            if(myStato == Stato.New) // o == 0, stessa cosa
            {
                Console.WriteLine("MyStato contiene New");
            }



            //references type

            //string
            string nome = " Maria Chiara Colla ";
            Console.WriteLine("Nome Completo: " + nome + ",");
            int lunghezza = nome.Length;
            Console.WriteLine("Lunghezza nome completo: " + lunghezza);
            string trimString = nome.Trim();
            Console.WriteLine("Nome completo senza spazi: " + trimString + ",");
            string subString = nome.Substring(0, 13); //da dove inizia e dove finisce
            Console.WriteLine("Solo nome: " + subString);

            //classi (nuova cartella: Classi)
            Console.Clear(); // resetta la console

            Console.WriteLine("_________ CLASSI _________");

            Persona persona = new Persona();
            try
            {
                persona.CodiceFiscale = "RSSMRC";
                persona.Nome = "Marco";
                persona.Cognome = "Rossi";
                persona.DataNascita = new DateTime(1958, 07, 20);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Persona persona2 = new Persona()
            {
                Nome = "Alessia",
                Cognome = "Bianchi",
                CodiceFiscale = "BNCLSS59G57J123M"
            };

            Console.WriteLine(persona.FullName("Signor"));
            Console.WriteLine(persona2.FullName("Signora"));

            Impiegato impiegato = new Impiegato()
            {
                Nome = "Luca",
                Cognome = "Gialli",
                CodiceFiscale = "GLLLCU12N45L456C",
                NumeroFigli = 1,
                DataNascita = new DateTime(1987, 11, 15)
            };
            Console.WriteLine(impiegato.FullName(""));

            Persona impiegato2 = new Impiegato()  //prende l'implementazione di impiegato
            {
                Nome = "Anna",
                Cognome = "Neri",
                CodiceFiscale = "NRENNA09V67N186X",
                DataNascita = new DateTime(1989, 09, 02),
                NumeroFigli = 3
            };

            Console.WriteLine(impiegato2.FullName(""));

            Manager m = new Manager();


            //interfacce
            persona.LogInfo("Il log funziona");
            impiegato.LogInfo("log ok"); //funziona comunque, lo eredita dalla classe padre
            impiegato2.LogInfo("log ok"); //funziona anche qui, stesso motivo

            //classe computer e interfaccia ilogging
            Computer myComputer = new Computer()
            {
                Modello = "DELL XPS 9570"
            };

            myComputer.LogInfo("Funziona anche per la classe computer");

            //array dell'interfaccia
            ILogging[] loggingItems = { myComputer, persona };
            foreach(var elem in loggingItems)
            {
                elem.LogInfo("Prova");
            }

            //eccezioni
            Persona persona1 = new Persona();
            try
            {
                persona1.CodiceFiscale = "RSSMRC";
                persona1.Nome = "Marco";
                persona1.Cognome = "Rossi";
                persona1.DataNascita = new DateTime(1958, 07, 20);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                int a = 5;
                int b = 0;
                int result = a / b;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Divide by Zero Exception: "+ d.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }



            #endregion

        }

        public static void Esercitazioni()
        {
            //Esercitazione 1
            Cerchio cerchio = new Cerchio()
            {
                Nome = "Cerchio",
                X = 0,
                Y = 0,
                Raggio = 5d
            };
            cerchio.DisegnaForma();

            Rettangolo rettangolo = new Rettangolo()
            {
                Nome = "Rettangolo",
                Larghezza = 5d,
                Altezza = 10d
            };
            rettangolo.DisegnaForma();

            Triangolo triangolo = new Triangolo()
            {
                Nome = "Triangolo",
                Base = 8d,
                Altezza = 10d
            };
            triangolo.DisegnaForma();

            //Esercitazione 2 (interfaccia fileSeriaizable)
            cerchio.SaveToFile("CerchioFile");
            Cerchio nuovoCerchio = new Cerchio();
            nuovoCerchio.FromFile("CerchioFile");
            nuovoCerchio.DisegnaForma();
            nuovoCerchio.Nome = "Cerchio modificato";
            nuovoCerchio.SaveToFile("CerchioFile");

            rettangolo.SaveToFile("RettangoloFile");
            Rettangolo nuovoRettangolo = new Rettangolo();
            nuovoRettangolo.FromFile("RettangoloFile");
            nuovoRettangolo.DisegnaForma();
            nuovoRettangolo.Nome = "Rettangolo modificato";
            nuovoRettangolo.SaveToFile("RettangoloFile");

            triangolo.SaveToFile("TriangoloFile");
            Triangolo nuovoTriangolo = new Triangolo();
            nuovoTriangolo.FromFile("TriangoloFile");
            nuovoTriangolo.DisegnaForma();
            nuovoTriangolo.Nome = "Tringolo modificato";
            nuovoTriangolo.SaveToFile("TriangoloFile");
        }


        public static int MySum(int a, int b)
        {
            return a + b;
        }
        public static int MySum3P(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
