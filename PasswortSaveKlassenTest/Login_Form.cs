using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswortSaveKlassenTest
{
    public partial class Login_Form : Form
    {
        public static  int index = 0;
        public Login_Form()
        {
            InitializeComponent();
#if SPEEDTEST
            tbx_LoginName.Text = "speedtest";
            tbx_password.Text = "all4speed!!!";
            Program.speedTestWatch.Stop();
#endif
        }
        /// <summary>
        /// Überprüft ob Eingabe richtig ist und gibt öffnet bei richtiger Eingabe die nächste Form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
#if SPEEDTEST
            Program.speedTestWatch.Start();
#endif
            bool right = false;
            
            for (int i = 0; i < Program.user.Count; i++)
            {
                if (tbx_LoginName.Text == Program.user[i].Benutzername)
                {
                    right = true;
                    index = i;
                    //MessageBox.Show(index.ToString());
                    break;
                }
            }
            if (right == false)
            {
                errorProvider_loginName.SetError(tbx_LoginName, "Your login name is not registered in the system");
            }
            else
            {
                errorProvider_loginName.Clear();
            }
            if ((right == true) && (tbx_password.Text == Program.user[index].Passwort.Passwort))
            {
                Program.benutzer = Data.LeseDatei(Program.user[index].Pfad, Program.user[index].Passwort.Passwort, Program.user[index].Benutzername);
                Passwort_Form psw = new Passwort_Form();
                

                psw.Show();
                errorProvider_password.Clear();
                this.Hide();
            }
            else
            {
                errorProvider_password.SetError(tbx_password, "You entered the wrong password");
            }
        }
        /// <summary>
        /// Schließt die ganze Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
