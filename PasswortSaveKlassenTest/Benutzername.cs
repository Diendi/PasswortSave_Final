using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswortSaveKlassenTest
{
    class Benutzer 
    {
        #region Variablen
        private string benutzername;
        #endregion

        #region Eingenschaften
        public string Benutzername
        {
            /// <summary>
            /// Schreibt oder liest einen Benutzernamen nach Überprüfung auf Gültigkeit.
            /// </summary>
            /// <exception cref="ArgumentException">Wenn Benutzername null oder Leerzeichen enthält.</exception>
            get { return benutzername; }
            set 
            {
                if (CheckBenutzername(value) == true)
                {
                    throw new ArgumentException("Fehler im Benutzernamen!");
                }
                benutzername = value; 
            }
        }
        #endregion

        #region Konstruktor
        /// <summary>
        /// Legt einen neuen Benutzernamen nach Überprüfung auf Gültigkeit an.
        /// </summary>
        /// <exception cref="ArgumentException">Wenn Benutzername null oder Leerzeichen enthält.</exception>
        /// <param name="benutzer">anzulegender Benutzername</param>
        public Benutzer(string benutzer)
        {
            this.Benutzername = benutzer;
        }
        #endregion

        #region statische Methoden
        /// <summary>
        /// Testet den übergebenen Benutzernamen auf Gültigkeit.
        /// nicht null und keine Leerzeichen
        /// </summary>
        /// <param name="benutzer">Benutzername zur Überprüfung</param>
        /// <returns>false = OK, true = Fehler</returns>
        public static bool CheckBenutzername(string benutzer)
        {
            if (benutzer == null)
            {
                return true;
            }

            if (benutzer.Contains(' '))
            {
                return true;
            }
            return false;
        }

        
        #endregion

        #region private Methoden

        #endregion
    }
}
