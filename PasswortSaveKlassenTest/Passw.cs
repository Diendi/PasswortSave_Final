using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswortSaveKlassenTest
{
    class Passw
    {
        #region Variablen
        private static char TRENNZEICHEN = '\v';
        private static char[] ALPHABET = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'Ä', 'Ö', 'Ü' };


        public struct UserConfig
        {
            public byte minimumPwLength;
            public byte maximumPwLength;
            public byte minimumSpecialChar;
            public char[] specialChar;
            public UserConfig(byte minPwLength, byte maxPwLength, byte minSpecialChar, char[] specChar)
            {
                minimumPwLength = minPwLength;
                maximumPwLength = maxPwLength;
                minimumSpecialChar = minSpecialChar;
                specialChar = specChar;
            }

            public override string ToString()
            {
                string erg = minimumPwLength.ToString();
                erg += TRENNZEICHEN;
                erg += maximumPwLength.ToString();
                erg += TRENNZEICHEN;
                erg += minimumSpecialChar.ToString();
                foreach (char item in specialChar)
                {
                    erg += TRENNZEICHEN;
                    erg += item.ToString();
                }
                return erg;
            }

            public static UserConfig FromString(string quellstr)
            {
                UserConfig conf = new UserConfig();
                string[] quell = quellstr.Split(TRENNZEICHEN);
                if (quell.Length < 3)
                {
                    throw new ArgumentException("Nicht genügend Einzelkomponenten im String enthalten!");
                }
                try
                {
                    conf.minimumPwLength = byte.Parse(quell[0]);
                    conf.maximumPwLength = byte.Parse(quell[1]);
                    conf.minimumSpecialChar = byte.Parse(quell[2]);
                }
                catch (Exception e)
                {
                    throw new ArgumentException(e.Message);
                }
                conf.specialChar = new char[(quell.Length - 3)];
                for (int i = 3; i < quell.Length; i++)
                {
                    conf.specialChar[(i - 3)] = quell[i].ToCharArray()[0];
                }
                return conf;
            }
        }


        private string passwort;
        private UserConfig passwortEigenschaften;

        #endregion

        #region Eingenschaften
        public string Passwort
        {
            /// <summary>
            /// Schreibt oder liest ein Passwort nach Überprüfung auf Gültigkeit.
            /// </summary>
            /// <exception cref="ArgumentException">Wenn Passwort nicht 12 Zeichen lang oder unerlaubte Sonderzeichen
            /// enthält oder kein Sonderzeichen oder Ziffer enthält</exception>
            get { return this.passwort; }
            set
            {
                if (CheckPasswort(value, this.passwortEigenschaften) == true)
                {
                    throw new ArgumentException("Fehler im Passwort!");
                }
                this.passwort = value;
            }
        }

        public UserConfig PasswortEigenschaften
        {
            get { return passwortEigenschaften; }
            set
            { 
                if (value.minimumPwLength > value.maximumPwLength)
                {
                    throw new ArgumentException("Minimale Länge > Maximale Länge!");
                }
                if (value.minimumSpecialChar > value.minimumPwLength)
                {
                    throw new ArgumentException("Minimale Sonderzeichen > Minimale Länge!");
                }
                passwortEigenschaften = value; 
            }
        }
        #endregion

        #region Konstruktor
        /// <summary>
        /// Legt ein neues Passwort nach Überprüfung auf Gültigkeit an.
        /// </summary>
        /// <param name="conf">Parameter Struct für Passwort</param>
        /// <exception cref="ArgumentException">Wenn Passwort ungültig.</exception>
        /// <param name="passw">anzulegendes Passwort</param>
        public Passw(string passw, UserConfig conf)
        {
            this.PasswortEigenschaften = conf;
            this.Passwort = passw;
        }

        /// <summary>
        /// Legt ein neues Passwort nach Überprüfung auf Gültigkeit an.
        /// </summary>
        /// <param name="conf">Parameter Struct für Passwort</param>
        /// <exception cref="ArgumentException">Wenn Passwort ungültig.</exception>
        public Passw(UserConfig conf)
        {
            this.PasswortEigenschaften = conf;
            this.passwort = GeneratePasswort(conf);
        }

        /// <summary>
        /// Legt ein neues Passwort nach Überprüfung auf Gültigkeit an.
        /// </summary>
        /// <param name="pass">Passwort</param>
        /// <exception cref="ArgumentException">Wenn Passwort ungültig.</exception>
        public Passw(Passw pass)
        {
            this.PasswortEigenschaften = pass.PasswortEigenschaften;
            this.Passwort = pass.Passwort;
        }

        /// <summary>
        /// Legt ein neues Passwort nach Überprüfung auf Gültigkeit an.
        /// </summary>
        /// <param name="quellstring">String aus der ToString() Methode</param>
        /// <exception cref="ArgumentException">Wenn Passwort ungültig.</exception>
        public Passw(string quellstring)
        {
            Passw quelle = Passw.FromString(quellstring);
            this.PasswortEigenschaften = quelle.PasswortEigenschaften;
            this.Passwort = quelle.Passwort;
        }
        #endregion

        #region statische Methoden
        /// <summary>
        /// Testet das übergebene Passwort auf Gültigkeit.
        /// </summary>
        /// <param name="passw">Passwort zur Überprüfung</param>
        /// <param name="conf">Parameter Struct für Passwort</param>
        /// <returns>false = OK, true = Fehler</returns>
        public static bool CheckPasswort(string passw, UserConfig conf)
        {
            if (passw == null)
            {
                return true;
            }

            if (passw.Length < conf.minimumPwLength)
            {
                return true;
            }

            if (passw.Length > conf.maximumPwLength)
            {
                return true;
            }

            char [] zeichen = passw.ToCharArray();
            int enthalteneSonderzeichen = 0;
            int enthalteneZiffern = 0;
            int ungueltigeZeichen = 0;

            foreach (var item in zeichen)
            {
                if (char.IsDigit(item) == true) 
                {
                    enthalteneZiffern++;
                    continue;
                }
                if (conf.specialChar.Contains(item) == true)
                {
                    enthalteneSonderzeichen++;
                    continue;
                }
                if (ALPHABET.Contains(Char.ToUpper(item)) == false)
                {
                    ungueltigeZeichen++;
                }
            }

            if ((enthalteneSonderzeichen + enthalteneZiffern) < conf.minimumSpecialChar) return true;
            if (ungueltigeZeichen > 0) return true;

            return false;
        }

        /// <summary>
        /// Generiert ein gültiges Passwort
        /// </summary>
        /// <param name="conf">Parameter Struct für Passwort</param>
        /// <returns>gültiges Passwort</returns>
        /// <exception cref="InvalidOperationException">Wenn ungültiger Status im Switch auftritt.</exception>
        public static string GeneratePasswort(UserConfig conf)
        {
            Random zufallszahl = new Random();
            char[] zeichen = new char[zufallszahl.Next(conf.minimumPwLength, conf.maximumPwLength)];
            int enthalteneSonderzeichen = 0;
            int enthalteneZiffern = 0;
            int maxSwitch = 4;

            for (int i = 0; i < zeichen.Length; i++)
            {
                //Sonderzeichen oder Ziffer an letzter Stelle erzwingen
                if ((i >= zeichen.Length - conf.minimumSpecialChar) && (enthalteneSonderzeichen + enthalteneZiffern < conf.minimumSpecialChar)) maxSwitch = 2;
                
                //Zufällige Auswahl von Zeichen
                switch (zufallszahl.Next(maxSwitch))
                {
                    case 0:     //Ziffer
                        zeichen[i] = zufallszahl.Next(10).ToString().ToCharArray(0,1)[0];
                        enthalteneZiffern++;
                        break;
                    case 1:     //Sonderzeichen
                        zeichen[i] = conf.specialChar[zufallszahl.Next(conf.specialChar.Length)];
                        enthalteneSonderzeichen++;
                        break;
                    case 2:     //Großbuchstabe
                        zeichen[i] = ALPHABET[zufallszahl.Next(ALPHABET.Length)]; 
                        break;
                    case 3:     //Kleinbuchstabe
                        zeichen[i] = Char.ToLower(ALPHABET[zufallszahl.Next(ALPHABET.Length)]); 
                        break;

                    default:
                        throw new InvalidOperationException("Switch state error!");
                }
            }

            return new string(zeichen);
        }

        /// <summary>
        /// Rekonstruiert ein Passwort aus einem durch die ToSTring() Methode erstellten String
        /// </summary>
        /// <param name="quellstr">Quellstring</param>
        /// <returns>Passwort</returns>
        public static Passw FromString(string quellstr)
        {
            UserConfig conf = new UserConfig();
            string[] quell = quellstr.Split(TRENNZEICHEN);
            if (quell.Length < 4)
            {
                throw new ArgumentException("Nicht genügend Einzelkomponenten im String enthalten!");
            }
            try
            {
                conf.minimumPwLength = byte.Parse(quell[1]);
                conf.maximumPwLength = byte.Parse(quell[2]);
                conf.minimumSpecialChar = byte.Parse(quell[3]);
            }
            catch (Exception e)
            {
                throw new ArgumentException(e.Message);
            }
            conf.specialChar = new char[(quell.Length - 4)];
            for (int i = 4; i < quell.Length; i++)
            {
                conf.specialChar[(i - 4)] = quell[i].ToCharArray()[0];
            }
            Passw erg = new Passw(quell[0], conf);
            return erg;
        }
        #endregion

        #region Methoden

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string erg = this.Passwort + TRENNZEICHEN;
            erg += this.PasswortEigenschaften.ToString();
            return erg;
        }
        #endregion
    }
}
