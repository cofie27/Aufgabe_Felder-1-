
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
    class Testreihe
    {
        //Array als Objektvariable
        private int[] werte;

        //Standardkonstruktor
        public Testreihe()
        {
            //initialisiert 1000 Werte
            werte = new int[1000];
            //alternativ int[] wert = new int[1000];

            //Random Objekt, welches mit der Methode Next Random Werte (hier: zwischen 1-1000) liefert
            Random randomiser = new Random();
            //durchläuft nacheinander alle Elemente des Arrays und weist jeweils einen Werr (zwischen 1 und 1000) zu
            for (int i = 0; i < werte.Length; i++)
            {
                //gibt EINEN Wert zurück und weist ihn dem entsprechenden Element im Array zu
                werte[i] = randomiser.Next(1, 1000);
            }
        }

        //Überladener Konstruktor soll die Länge des Feldes bestimmen und automatisch mit zufälligen Werten zwischen 1 und der Anzahl möglicher Werte füllen
        public Testreihe(int anzahl)
        {
            //Array "Werte" werden mit "anzahl" initialisiert --> so kann die Länge des Feldes bestimmt werden
            werte = new int[anzahl];

            //Random Objekt, welches mit der Methode Next Random Werte liefert
            Random randomiser = new Random();

            for (int i = 0; i < werte.Length; i++)
            {
                //gibt EINEN Wert zurück und weist ihn dem entsprechenden Element im Array zu
                //Besonderheit hier: Werte zwischen 1 und "Anzahl"
                werte[i] = randomiser.Next(1, anzahl);
            }
        }

        //Überladener konstruktor, der mit Hilfe eines Wahrheitswerts aufsteigend absteiegend sortiert
        public Testreihe(int index, bool aufsteigend)
        {
            //Array "Werte" werden mit "index" initialisiert --> so kann die Länge des Feldes bestimmt werden
            werte = new int[index];
            if (aufsteigend == true)
                
            {
                //Zählerschleife die aufsteigend generiert
                for(int i = 1; i< werte.Length; i++)
                {
                    werte[i] = i+1;
                }
            }

            else
            {
                //lokale Variable zum Setzen des ersten Array Elements = 0

                //Zählerschleife die absteigend generiert
                for (int i = 0 ; i < werte.Length; i++)
                {
                    werte[i] = index - i;
                }
            }
        }

        //Set und Get-Methoden
        public void setWert(int wert, int index)
        {
            //ein Array-Element an der Index soll auf "Wert" gesetzt werden
            werte[index] = wert;
        }

        //liest einzelne Werte des Feldes [index] aus
        public int getWert(int index)
        {
            return werte[index];
        }

        public override string ToString()
        {
            string ausgabeString = Convert.ToString(werte[0]);
            //durchläuft alle Indizes ab dem zweiten bis zum Ende des Arrays
            for (int i= 1; i < werte.Length; i++)
            {
                ausgabeString = ausgabeString + ", " + werte[i];
            }
            return ausgabeString;
        }

        public long Summe()
        {
            //lokale Variable
            long summe= 0;

            //in jedem Schleifendurchlauf wird eine Variable (wert) vom Typ der Array-Elemente definiert (hier: int)
            //dieser Variablen wird bei jedem Durchlauf der Wert des entsprechenden Array-Elements zugewiesen
            //alle Elemete werdenn nacheinander angesprochen und somit wird Summe nach jedem Durchlauf aktualisiert
            foreach (int wert in werte)
            {
                //erhöht "summe" bei jedem Durchlauf um "wert"
                summe = summe + wert;
            }
            return summe;
        }

        public double Mittelwert()
        {
            //lokale Variable
            double mittelwert = 0;

            //der Mittelwert wird ermittelt, indem die Methode Summe ausgeführt wird um am Ende durch die Länge des Arrays geteilt wird
            mittelwert = Summe() / werte.Length;
            return mittelwert;
        }

        public int Maximum()
        {
            //lokale Variable wird mit dem ersten Element (Wert) des Arrays initialisiert
            int maximum = werte[0];

            //in jedem Schleifendurchlauf wird eine Variable (wert) vom Typ int definiert
            //dieser Variablen wird bei jedem Durchlauf der Wert des entsprechenden Array-Element zugewiesen
            //alle Elemente werden nacheinander angesprochen und somit wird bei jedem Durchlauf geprpüft, ob der "wert", der dem maximum zugewiesen ist kleiner  ist, als der aktuell ausgewählte Wert
            //falls diese Bedindung gilt wird der Variable "maximum" ein neuer Wert zugewiesen
            foreach (int wert in werte)
            {
                if (maximum < wert)
                {
                    maximum = wert;
                }            
            }
            return maximum;
        }

        public int Minimum()
        {
            //lokale Variable wird mit dem ersten Element (wert) des Arrays initialisiert
            int minimum = werte[0];

            //in jedem Schleifendurchlauf wird eine Variable (wert) vom Typ int definiert
            //dieser Variablen wird bei jedem Durchlauf der Wert des entsprechenden Array-Element zugewiesen
            //alle Elemente werden nacheinander angesprochen und somit wird bei jedem Durchlauf geprpüft, ob der "wert", der dem minimum zugewiesen ist größer ist, als der aktuell ausgewählte Wert
            //falls diese Bedindung gilt wird der Variable "maximum" ein neuer Wert zugewiesen
            foreach (int wert in werte)
            {
                if (minimum > wert)
                {
                    minimum = wert;
                }
            }
            return minimum;
        }

        public int Spannweite()
        {
            int spannweite = Maximum() - Minimum();
            return spannweite;
        }

        public string AusgabeBereich(int von, int bis)
        {
            string ausgabebereich = Convert.ToString(werte[von]);

            for (int i = von+1; i < bis; i++)
            {
                ausgabebereich = ausgabebereich+", "+Convert.ToString(werte[i]);
            }

            return ausgabebereich;
        }
    }
}
