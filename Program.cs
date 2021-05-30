//------------------------------------------------------------------------------------------------------------------------------------
//Dateiname	    : Aufgabe_Felder (1)
//Projekt	    : Implementation der Testreihe-Klasse
//Beschreibung  : Implementation der Testreihe-Klasse
//Autoren	    : Paul A.
//Erstellung	: 21.05.2021
//letzte Änd.	: 23.05.2021
//Fehler	    : 
//Dokument	    : auf_felder
//------------------------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_Felder__1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Testreihe t1 = new Testreihe(10);
            Testreihe t2 = new Testreihe(1000, true);
            Testreihe t3 = new Testreihe(1000000, false);
            
            Console.WriteLine("--------------------------------------------------Test 1--------------------------------------------------");
            //Der Wert des 8. Elements (weil Array startet bei 0)/ des Index 7 wird auf 549 gesetzt
            t1.setWert(7, 5);
            Console.WriteLine("Wert des Index 5: " + t1.getWert(5));
            Console.WriteLine("Alle Feldelemente: " + t1.ToString());
            Console.WriteLine("Summe: " + t1.Summe());
            Console.WriteLine("Mittelwert: " + t1.Mittelwert());
            Console.WriteLine("Maximum: " + t1.Maximum());
            Console.WriteLine("Minimum: "+ t1.Minimum());
            Console.WriteLine("Spannweite: " + t1.Spannweite());
            Console.WriteLine("Ausgabebereich: " + t1.AusgabeBereich(3, 10));

            Console.WriteLine("--------------------------------------------------Test 2--------------------------------------------------");
            //t2.setWert(854,500);
            Console.WriteLine("Wert des Index 500: " + t2.getWert(500));
            Console.WriteLine("Alle Feldelemente: " + t2.ToString());
            Console.WriteLine("Summe: " + t2.Summe());
            Console.WriteLine("Mittelwert: " + t2.Mittelwert());
            Console.WriteLine("Maximum: " + t2.Maximum());
            Console.WriteLine("Minimum: " + t2.Minimum());
            Console.WriteLine("Spannweite: " + t2.Spannweite());
            Console.WriteLine("Ausgabebereich: " + t2.AusgabeBereich(450, 500));

            Console.WriteLine("--------------------------------------------------Test 3--------------------------------------------------");
            t3.setWert(85400, 50000);
            Console.WriteLine("Wert des Index 50000: " + t3.getWert(50000));
            //Console.WriteLine("Alle Feldelemente: " + t3.ToString()); --> kann er nicht anzeigen auf konsole
            Console.WriteLine("Summe: " + t3.Summe());
            Console.WriteLine("Mittelwert: " + t3.Mittelwert());
            Console.WriteLine("Maximum: " + t3.Maximum());
            Console.WriteLine("Minimum: " + t3.Minimum());
            Console.WriteLine("Spannweite: " + t3.Spannweite());
            Console.WriteLine("Ausgabebereich: " + t3.AusgabeBereich(450, 500));           
           
            Console.ReadKey();
        }
    }
}
