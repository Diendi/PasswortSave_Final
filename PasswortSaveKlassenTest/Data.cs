using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//using System.Diagnostics;
using System.Security;
using System.Security.Cryptography;


namespace PasswortSaveKlassenTest
{
    class Data
    {
        #region Variablen
        private string benutzername;
        private Passw passwort;
        private string pfad;
        private string details;

        public enum ReturnCode
        {
            noError = 0,
            missingParameter,
            BenutzernameUngültig,
            PasswortUngültig,
            generellerFeher
        }

        private static char TRENNZEICHEN = '\t';
        private static char NEUEzEILE = '\n';
        //private static string ERSTEzEILE = "Benutzername" + TRENNZEICHEN + "Passwort" + TRENNZEICHEN + "Webseite" + TRENNZEICHEN + "Details" + TRENNZEICHEN + "Konfig" + NEUEzEILE;
        #endregion

        #region Eingenschaften
        public string Benutzername
        {
            get { return benutzername; }
            set 
            {
                if (Benutzer.CheckBenutzername(value)==true)
                {
                    throw new ArgumentException("Benutzername ungültig!");
                }
                benutzername = value; 
            }
        }
        public Passw Passwort
        {
            get { return passwort; }
            //set 
            //{
            //    if (Passw.CheckPasswort(value)==true)
            //    {
            //        throw new ArgumentException("Passwort ungültig!");
            //    }
            //    passwort = value; 
            //}
        }
        public string Pfad
        {
            get { return pfad; }
            set 
            {
                if (value == null)
                {
                    throw new ArgumentException("Webseite ungültig!");
                }
                pfad = value; 
            }
        }
        public string Details
        {
            get { return details; }
            //Die Überprüfung auf Tabulator muss ich noch machen.
            set { details = value; }
        }
        #endregion

        #region Konstruktor
        /// <summary>
        /// Erstellt einen neuen Datensatz mit den übergebenen Eigenschaften.
        /// Wird ein Fehler zurückgegeben (ReturnCode != noError) so ist ein null Datensatz erstellt worden,
        /// welcher gelöscht werden sollte.
        /// </summary>
        /// <param name="benutzer">Benutzername</param>
        /// <param name="passw">Passwort</param>
        /// <param name="webs">Webseite der Zugangsdaten oder Pfad zur User-Datei</param>
        /// <param name="detail">Zusätzliche Infos (optional)</param>
        /// <param name="passwEigensch">Eigenschaften welche das Passwort erfüllen muss</param>
        /// <param name="code">Rückgabe des ReturnCode</param>
        public Data(string benutzer, string passw, string webs, string detail, Passw.UserConfig passwEigensch, out ReturnCode code)
        {
            code = ReturnCode.noError;
            if (Benutzer.CheckBenutzername(benutzer) == true) code = ReturnCode.BenutzernameUngültig;
            Program.stopw.Restart();
            if (Passw.CheckPasswort(passw, passwEigensch) == true) code = ReturnCode.PasswortUngültig;
            Program.stopw.Stop();
            if (webs == null) code = ReturnCode.missingParameter;

            if (code == ReturnCode.noError)
            {
                this.benutzername = benutzer;
                this.passwort = new Passw(passw, passwEigensch);
                this.pfad = webs;
                this.details = detail;
            }
        }

        /// <summary>
        /// Erstellt einen neuen Datensatz mit den übergebenen Eigenschaften.
        /// Wird ein Fehler zurückgegeben (ReturnCode != noError) so ist ein null Datensatz erstellt worden,
        /// welcher gelöscht werden sollte.
        /// </summary>
        /// <param name="benutzer">Benutzername</param>
        /// <param name="passw">Passwort</param>
        /// <param name="webs">Webseite der Zugangsdaten oder Pfad zur User-Datei</param>
        /// <param name="detail">Zusätzliche Infos (optional)</param>
        /// <param name="code">Rückgabe des ReturnCode</param>
        public Data(string benutzer, Passw passw, string webs, string detail, out ReturnCode code)
        {
            code = ReturnCode.noError;
            if (Benutzer.CheckBenutzername(benutzer) == true) code = ReturnCode.BenutzernameUngültig;
            Program.stopw.Restart();
            if (Passw.CheckPasswort(passw.Passwort, passw.PasswortEigenschaften) == true) code = ReturnCode.PasswortUngültig;
            Program.stopw.Stop();
            if (webs == null) code = ReturnCode.missingParameter;

            if (code == ReturnCode.noError)
            {
                this.benutzername = benutzer;
                this.passwort = passw;
                this.pfad = webs;
                this.details = detail;
            }
        }


        /// <summary>
        /// Erstellt einen neuen Datensatz mit den übergebenen Eigenschaften.
        /// Passwort wird generiert und kann nachträglich aus dem Datensatz ausgelesen werden.
        /// Wird ein Fehler zurückgegeben (ReturnCode != noError) so ist ein null Datensatz erstellt worden,
        /// welcher gelöscht werden sollte.
        /// </summary>
        /// <param name="benutzer">Benutzername</param>
        /// <param name="webs">Webseite der Zugangsdaten</param>
        /// <param name="detail">Zusätzliche Infos (optional)</param>
        /// <param name="code">Rückgabe des ReturnCode</param>
        public Data(string benutzer, string webs, string detail, Passw.UserConfig passwEigensch, out ReturnCode code)
        {
            code = ReturnCode.noError;
            if (Benutzer.CheckBenutzername(benutzer) == true) code = ReturnCode.BenutzernameUngültig;
            if (webs == null) code = ReturnCode.missingParameter;

            if (code == ReturnCode.noError)
            {
                this.benutzername = benutzer;
                this.passwort = new Passw(passwEigensch);
                this.pfad = webs;
                this.details = detail;
            }
        }

        #endregion

        #region Methoden

        #endregion

        #region private Methoden
        /// <summary>
        /// Erzeugt aus einem String eine AES verschlüsseltes Byte Array
        /// </summary>
        /// <param name="plainText">String welcher verschlüsselt werden soll</param>
        /// <param name="Key">Schlüssel (16 Byte)</param>
        /// <param name="IV">Initialisierungsvektor (16 Byte)</param>
        /// <returns>Verschlüsselte Daten</returns>
        private static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");
            byte[] encrypted;
            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                // Create a decrytor to perform the stream transform.
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for encryption.
                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            //Write all data to the stream.
                            swEncrypt.Write(plainText);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            // Return the encrypted bytes from the memory stream.
            return encrypted;
        }

        /// <summary>
        /// Erzeugt aus einem AES verschlüsselten Byte Array einen klartext String
        /// </summary>
        /// <param name="cipherText">AES verschlüsseltes Byte Array</param>
        /// <param name="Key">Schlüssel (16 Byte)</param>
        /// <param name="IV">Initialisierungsvektor (16 Byte)</param>
        /// <returns>Klartext String</returns>
        private static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("Key");

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an Aes object
            // with the specified key and IV.
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;
                // Create a decrytor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes from the decrypting stream and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }

        /// <summary>
        /// Erstellt aus dem übergebenen String ein Byte Array mit 16 Einträgen,
        /// für die Verwendung als Initialisierungsvektor oder Schlüssel
        /// </summary>
        /// <param name="str">Quellstring</param>
        /// <returns>Byte Array</returns>
        private static byte[] StringToKey(string str)
        {
            if (str == null)
            {
                throw new ArgumentNullException("String null!");
            }
            if (str.Length < 1)
            {
                throw new ArgumentException("String zu kurz!");
            }

            byte[] ergebnis = new byte[16];
            byte[] strAr = System.Text.Encoding.UTF8.GetBytes(str);
            int j = 0;
            int strArLen = strAr.Length - 1;

            for (int i = 0; i < ergebnis.Length; i++)
            {
                ergebnis[i] = strAr[j];
                j++;
                j = j % strArLen;
            }
            return ergebnis;
        }

        #endregion

        #region statische Methoden
        /// <summary>
        /// Überprüft den übergebenen Datensatz auf Gültigkeit.
        /// </summary>
        /// <param name="dat">Datensatz zur Überprüfung.</param>
        /// <returns>ReturnCode</returns>
        public static ReturnCode CheckData(Data dat)
        {
            if (Benutzer.CheckBenutzername(dat.benutzername) == true) return ReturnCode.BenutzernameUngültig;
            if (Passw.CheckPasswort(dat.passwort.Passwort, dat.passwort.PasswortEigenschaften) == true) return ReturnCode.PasswortUngültig;
            if (dat.pfad == null) return ReturnCode.missingParameter;
            return ReturnCode.noError;
        }

        /// <summary>
        /// Liest die CSV-Datei mit den Datensätzen vom übergebenen Pfad.
        /// </summary>
        /// <param name="pfad">Dateipfad</param>
        /// <param name="key">AES Schlüssel (16 Byte)</param>
        /// <param name="iv">AES Initialisierungsvektor (16 Byte)</param>
        /// <returns>Liste mit Datensätzen</returns>
        /// <exception cref="ArgumentException">Wenn der übergebene KEY oder IV keine Länge von 16 Byte haben.</exception>
        /// <exception cref="FileNotFoundException">Wenn Datei nicht existiert.</exception>
        /// <exception cref="FormatException">Wenn erste Zeile der Datei nicht den Formatvorgaben enstspricht.</exception>
        public static List<Data> LeseDatei(string pfad, byte[] key, byte[] iv)
        {
            if ((key.Length != 16) || (iv.Length != 16))
            {
                throw new ArgumentException("KEY und IV müssen 16 Byte haben.");
            }

            List<Data> daten = new List<Data>();
            ReturnCode code = new ReturnCode();

            BinaryReader datei = new BinaryReader(File.Open(pfad, FileMode.OpenOrCreate));
            List<byte> datenb = new List<byte>();
            try
            {
                while (true)
                {
                    datenb.Add(datei.ReadByte());
                }
            }
            catch (Exception)
            {
            }
            datei.Close();

            //keine Daten -> leere Liste
            if (datenb.Count == 0)
            {
                return daten;
            }

            // Decrypt the bytes to a string.
            string datenstr = DecryptStringFromBytes_Aes(datenb.ToArray<byte>(), key, iv);
            int start = 0;
            int ende = 0;

            while (ende < (datenstr.Length - 1))
            {
                ende = datenstr.IndexOf('\n', start);
                string[] elemente = datenstr.Substring(start, (ende - start)).Split(TRENNZEICHEN);
                //TODO: weitere Überprüfungen
                if (elemente.Length == 4)
                {
                    daten.Add(new Data(elemente[0], Passw.FromString(elemente[1]), elemente[2], elemente[3], out code));
                }
                if (code != ReturnCode.noError)
                {
                    daten.RemoveAt(daten.Count - 1);
                }
                start = ende + 1;
            }
            return daten;
        }

        /// <summary>
        /// Liest die CSV-Datei mit den Datensätzen vom übergebenen Pfad.
        /// </summary>
        /// <param name="pfad">Dateipfad</param>
        /// <param name="key">AES Schlüssel (Passwort)</param>
        /// <param name="iv">AES Initialisierungsvektor (Benutzername)</param>
        /// <returns>Liste mit Datensätzen</returns>
        /// <exception cref="ArgumentException">Wenn der übergebene KEY oder IV keine Länge von 16 Byte haben.</exception>
        /// <exception cref="FileNotFoundException">Wenn Datei nicht existiert.</exception>
        /// <exception cref="FormatException">Wenn erste Zeile der Datei nicht den Formatvorgaben enstspricht.</exception>
        public static List<Data> LeseDatei(string pfad, string key, string iv)
        {
            byte[] aesKey = StringToKey(key);
            byte[] aesIv = StringToKey(iv);
            return LeseDatei(pfad, aesKey, aesIv);
        }

        /// <summary>
        /// Schreibt die übergebene Liste mit Datensätzen an den übergebenen Pfad.
        /// </summary>
        /// <param name="pfad">Dateipfad</param>
        /// <param name="daten">Liste mit Datensätzen</param>
        /// <param name="key">AES Schlüssel (16 Byte)</param>
        /// <param name="iv">AES Initialisierungsvektor (16 Byte)</param>
        /// <returns>false = OK, true = Fehler</returns>
        public static bool SchreibeDatei(string pfad, List<Data> daten, byte[] key, byte[] iv)
        {
            if ((key.Length != 16) || (iv.Length != 16))
            {
                return true;
            }

            try
            {
                BinaryWriter datei = new BinaryWriter(File.Open(pfad, FileMode.Create));
                string datenstring = null;// = ERSTEzEILE;
                foreach (Data item in daten)
                {
                    datenstring += item.benutzername + TRENNZEICHEN + item.passwort.ToString() + TRENNZEICHEN + item.pfad + TRENNZEICHEN + item.details + NEUEzEILE;
                }
                using (Aes myAes = Aes.Create())
                {
                    // Encrypt the string to an array of bytes.
                    byte[] encrypted = EncryptStringToBytes_Aes(datenstring, key, iv);
                    datei.Write(encrypted);
                }
                datei.Close();
            }
            catch (Exception)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// Schreibt die übergebene Liste mit Datensätzen an den übergebenen Pfad.
        /// </summary>
        /// <param name="pfad">Dateipfad</param>
        /// <param name="daten">Liste mit Datensätzen</param>
        /// <returns>false = OK, true = Fehler</returns>
        public static bool SchreibeDatei(string pfad, List<Data> daten, string passwort, string name)
        {
            byte[] key = StringToKey(passwort);
            byte[] iv = StringToKey(name);
            return SchreibeDatei(pfad, daten, key, iv);
        }


        /// <summary>
        /// Ruft die CheckPasswort Methode der Klasse Passw auf.
        /// </summary>
        /// <param name="passw">Passwort zur Überprüfung</param>
        /// <returns>false = OK, true = Fehler</returns>
        public static bool CheckPasswort(string passw, Passw.UserConfig passwEigensch)
        {
            return Passw.CheckPasswort(passw, passwEigensch);
        }

        public static string GeneratorPasswort(Passw.UserConfig passwEigensch)
        {
            return Passw.GeneratePasswort(passwEigensch);
        }
        #endregion
    }
}
