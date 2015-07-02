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
    public partial class Start : Form
    {
        /// <summary>
        /// Beim Laden der Start-Form werden die User Daten geladen
        /// </summary>
        public Start()
        {
            InitializeComponent();
            Program.user = Data.LeseDatei(@"..\user.bin", Program.AESkEY, Program.AESiV);
            if (Program.user.Count < 1)
            {
                btnLogin.Visible = false;
            }
            else
            {
                btnLogin.Visible = true;
            }
#if SPEEDTEST
            this.Hide();
            Login_Form login = new Login_Form(); 
            login.Show();   
#endif
        }
        /// <summary>
        /// Durch drücken des Button, wird die Login-Form aufgerufen
        /// Ist jedoch am Anfang noch kein User erstellt worden, ist dieser Button ausgeblendet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }
        /// <summary>
        /// Durch drücken des Button, wird die Former für die Usererstellung aufgerufen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNeuenBenutzer_Click(object sender, EventArgs e)
        {
            AnlegenBenutzer neuerAdmin = new AnlegenBenutzer();
            neuerAdmin.Show();
            this.Hide();

        }
        /// <summary>
        /// Application wird geschlossen und nichts gespeichert.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
