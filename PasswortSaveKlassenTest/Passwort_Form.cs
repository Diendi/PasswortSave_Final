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
    public partial class Passwort_Form : Form
    {
        Data.ReturnCode ret;
        DataTable data_table = new DataTable();
        int anzahl_elemente = 0;
        public Passwort_Form()
        {
            InitializeComponent();
            try
            {

                data_table.Columns.Add("Username");
                //data_table.Columns.Add("Passwort");
                data_table.Columns.Add("Link");
                data_table.Columns.Add("Details");
                //data_table.Rows.Add(Program.user[Login_Form.index].Benutzername, Program.user[Login_Form.index].Pfad, Program.user[Login_Form.index].Details);
                for (int i = 0; i < Program.benutzer.Count; i++)
                {
                    data_table.Rows.Add(Program.benutzer[i].Benutzername,Program.benutzer[i].Pfad, Program.benutzer[i].Details);
                    anzahl_elemente++;
                }
                dgv_Liste.DataSource = data_table;
                dgv_Liste.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbx_details.Enabled = true;
                this.tbx_password.Enabled = true;
                this.tbx_username.Enabled = true;
                this.tbx_website.Enabled = true;
                this.btn_ok.Enabled = true;
                this.btn_ok.Visible = true;
                this.btn_generator.Enabled = true;
                this.btn_generator.Visible = true;
                this.btn_new.Visible = false;

                int Zeile = this.dgv_Liste.CurrentCellAddress.Y;
                tbx_username.Text = Program.benutzer[Zeile].Benutzername;
                tbx_password.Text = Program.benutzer[Zeile].Passwort.Passwort;
                tbx_website.Text = Program.benutzer[Zeile].Pfad;
                tbx_details.Text = Program.benutzer[Zeile].Details;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbx_details.Enabled = true;
                this.tbx_password.Enabled = true;
                this.tbx_username.Enabled = true;
                this.tbx_website.Enabled = true;
                this.btn_save.Enabled = true;
                this.btn_save.Visible = true;
                this.btn_generator.Enabled = true;
                this.btn_generator.Visible = true;
                this.btn_edit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            this.tbx_password.Enabled = true;
            this.tbx_password.SelectAll();
            this.tbx_password.Copy();
            this.tbx_password.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Data neuer_User = new Data(this.tbx_username.Text, new Passw(this.tbx_password.Text,Program.user[Login_Form.index].Passwort.PasswortEigenschaften), this.tbx_website.Text, this.tbx_details.Text, out ret);
                if (ret == Data.ReturnCode.noError)
                {
                    Program.benutzer.Add(neuer_User);
                    data_table.Rows.Add(Program.benutzer[Program.benutzer.Count - 1].Benutzername, Program.benutzer[Program.benutzer.Count - 1].Pfad, Program.benutzer[Program.benutzer.Count - 1].Details);
                    dgv_Liste.DataSource = data_table;
                    anzahl_elemente++;
                    dgv_Liste.Refresh();

                    this.tbx_details.Clear();
                    this.tbx_password.Clear();
                    this.tbx_username.Clear();
                    this.tbx_website.Clear();
                    this.tbx_details.Enabled = false;
                    this.tbx_password.Enabled = false;
                    this.tbx_username.Enabled = false;
                    this.tbx_website.Enabled = false;

                    this.btn_save.Enabled = false;
                    this.btn_generator.Enabled = false;
                    this.btn_generator.Visible = false;
                    this.btn_save.Visible = false;
                    this.btn_edit.Visible = true;

#if (TIMECHECK)
                        string laufzeit = string.Format("Benötigte Zeit zum Paswortcheck: {0}µs.", Program.stopw.Elapsed.TotalMilliseconds * 1000);
                        MessageBox.Show(laufzeit);
#endif
                }

                else if (ret == Data.ReturnCode.BenutzernameUngültig)
                    MessageBox.Show(Data.ReturnCode.BenutzernameUngültig.ToString());
                else if (ret == Data.ReturnCode.generellerFeher)
                    MessageBox.Show(Data.ReturnCode.generellerFeher.ToString());
                else if (ret == Data.ReturnCode.missingParameter)
                    MessageBox.Show(Data.ReturnCode.missingParameter.ToString());
                else if (ret == Data.ReturnCode.PasswortUngültig)
                    MessageBox.Show(Data.ReturnCode.PasswortUngültig.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Gespeichert!");
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                int Zeile = 0;
                Zeile = this.dgv_Liste.CurrentCell.RowIndex;
                Program.benutzer[Zeile].Benutzername = tbx_username.Text;
                Program.benutzer[Zeile].Passwort.Passwort = tbx_password.Text;
                Program.benutzer[Zeile].Pfad = tbx_website.Text;
                Program.benutzer[Zeile].Details = tbx_details.Text;

                dgv_Liste.Rows[Zeile].Cells["Username"].Value = tbx_username.Text;
                //dgv_Liste.Rows[Zeile].Cells["Passwort"].Value = tbx_password.Text;
                dgv_Liste.Rows[Zeile].Cells["Link"].Value = tbx_website.Text;
                dgv_Liste.Rows[Zeile].Cells["Details"].Value = tbx_details.Text;
                dgv_Liste.DataSource = data_table;
                dgv_Liste.Refresh();

                this.tbx_details.Clear();
                this.tbx_password.Clear();
                this.tbx_username.Clear();
                this.tbx_website.Clear();
                this.tbx_details.Enabled = false;
                this.tbx_password.Enabled = false;
                this.tbx_username.Enabled = false;
                this.tbx_website.Enabled = false;

                this.btn_ok.Enabled = false;
                this.btn_generator.Enabled = false;
                this.btn_generator.Visible = false;
                this.btn_ok.Visible = false;
                this.btn_new.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_generator_Click(object sender, EventArgs e)
        {
            try
            {
                string passwort = null;
                Program.stopw.Restart();
                passwort = Passw.GeneratePasswort(Program.user[Login_Form.index].Passwort.PasswortEigenschaften);
                Program.stopw.Stop();
                this.tbx_password.Text = passwort;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Passwort_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.stopw.Restart();
            try
            {
                string pfad = Program.user[Login_Form.index].Pfad;
                Data.SchreibeDatei(pfad, Program.benutzer, Program.user[Login_Form.index].Passwort.Passwort, Program.user[Login_Form.index].Benutzername);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Application.Exit();
            Program.stopw.Stop();
#if (TIMECHECK)
                string laufzeit = string.Format("Benötigte Zeit zum Beenden: {0}µs.", Program.stopw.Elapsed.TotalMilliseconds * 1000);
                MessageBox.Show(laufzeit);
#endif  

        }

        private void dgv_Liste_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Zeile = this.dgv_Liste.CurrentCellAddress.Y;
            if (Zeile < anzahl_elemente)
            {
                tbx_username.Text = Program.benutzer[Zeile].Benutzername;
                tbx_password.Text = Program.benutzer[Zeile].Passwort.Passwort;
                tbx_website.Text = Program.benutzer[Zeile].Pfad;
                tbx_details.Text = Program.benutzer[Zeile].Details;
            }

        }

        private void btn_new_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.tbx_details.Enabled = true;
                this.tbx_password.Enabled = true;
                this.tbx_username.Enabled = true;
                this.tbx_website.Enabled = true;
                this.btn_save.Enabled = true;
                this.btn_save.Visible = true;
                this.btn_generator.Enabled = true;
                this.btn_generator.Visible = true;
                this.btn_edit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btn_change_Click(object sender, EventArgs e)
        {
            try
            {
                this.lbl_change.Visible = true;
                this.tbx_newPassword.Visible = true;
                this.btn_SaveNew.Visible = true;
                this.btn_new_generator.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            

            
        }


        private void btn_SaveNew_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Login_Form.index.ToString());
            if (Passw.CheckPasswort(this.tbx_newPassword.Text, Program.user[Login_Form.index].Passwort.PasswortEigenschaften)==false)
            {
                
                Program.user[Login_Form.index].Passwort.Passwort = this.tbx_newPassword.Text;
                errorProvider_new.Clear();
                this.lbl_change.Visible = false;
                this.tbx_newPassword.Visible = false;
                this.btn_SaveNew.Visible = false;
                this.btn_new_generator.Visible = false;
            }
            else
            {
                errorProvider_new.SetError(this.tbx_newPassword, "You entered a wrong password");
            }

        }

        private void btn_new_generator_Click(object sender, EventArgs e)
        {
            try
            {
                string passwort = null;
                passwort = Passw.GeneratePasswort(Program.user[Login_Form.index].Passwort.PasswortEigenschaften);
                this.tbx_newPassword.Text = passwort;
                errorProvider_new.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }


    }
}
