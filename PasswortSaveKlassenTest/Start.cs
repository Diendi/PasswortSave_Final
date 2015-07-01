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
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login_Form login = new Login_Form();
            login.Show();
            this.Hide();
        }

        private void btnNeuenBenutzer_Click(object sender, EventArgs e)
        {
            AnlegenBenutzer neuerAdmin = new AnlegenBenutzer();
            neuerAdmin.Show();
            this.Hide();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
