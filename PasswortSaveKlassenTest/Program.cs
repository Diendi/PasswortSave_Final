using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Diagnostics;

namespace PasswortSaveKlassenTest
{
    static class Program 
    {
        public static List<Data> user;
        public static List<Data> benutzer = new List<Data>();
        public static Stopwatch stopw = new Stopwatch();
        
        public static byte[] AESiV = new byte[] { 0xcf, 0x5e, 0x46, 0x20, 0x45, 0x5c, 0xd7, 0x19, 0x0f, 0xcb, 0x53, 0xed, 0xe8, 0x74, 0xf1, 0xa8 };
        public static byte[] AESkEY = new byte[] { 0x11, 0x5e, 0x46, 0x20, 0x45, 0x5c, 0xd7, 0x19, 0x0f, 0xcb, 0x53, 0xed, 0xe8, 0x74, 0xf1, 0xa8 };
        private static Passw.UserConfig PWgRUNDKONFIG = new Passw.UserConfig(12, 12, 1, new char[] { '!', '?' });
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            try
            {
                //Testweises Erstellen einer User.bin (Enthält die Daten der Benutzer)
                //Data.ReturnCode code;
                
                //Passw.UserConfig conf = new Passw.UserConfig(5, 10, 2, new char[]{'!', '?', '&', '$', '§', ':', '-'});
                //benutzer.Add(new Data("Kreuzer", new Passw("ABCDEF123456", PWgRUNDKONFIG), @"..\kreuzer.bin", conf.ToString(), out code));
                //Data.SchreibeDatei(@"..\user.bin", benutzer, AESkEY, AESiV);

                //In der User.bin stehen die Daten der Benutzer, dieses ist mit einem Standardschlüssel verschlüsselt
                //In den Details können die Einstellungen des Benutzers für ein gültiges Passwort hinterlegt werden.
                
                
                //Wurde ein gültiger Benutzername und Passwort eingegeben, so ist die entsprechende Datei zu laden.
                //Der Pfad ist unter Pfad zu finden, als Key wird das Passwort und als Initialisierungsvektor der Benutzername verwendet.
                //List<Data> benutzerdaten = Data.LeseDatei(user[0].Pfad, user[0].Passwort.Passwort, user[0].Benutzername);
                //Ermitteln der Passworteinstellungen des Users
                //Passw.UserConfig passwortEinstellungen = Passw.UserConfig.FromString(user[0].Details);
                //Hinzufügen einer Webseite
                //Speichern der Passwortdatei des Users
                //Data.SchreibeDatei(@"..\kreuzer.bin", benutzerdaten, user[0].Passwort.Passwort, user[0].Benutzername);

                //Testreiber erstellen:

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Start());
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            
            
        }
    }
}
