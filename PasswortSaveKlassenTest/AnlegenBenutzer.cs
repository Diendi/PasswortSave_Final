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
    public partial class AnlegenBenutzer : Form
    {
        char[] sonderzeichen;
        
        /// <summary>
        /// Ladet Textbox mit Informationen für anwender
        /// </summary>
        public AnlegenBenutzer()
        {
            InitializeComponent();
            tbx_Info.Text = "Info Box " + Environment.NewLine + "the maximum value of the numeric up down elemts are 100." + Environment.NewLine + Environment.NewLine +
                            "The maximum value must be higher then the minimum value, because otherwise an error will occur" + Environment.NewLine + Environment.NewLine +
                            "The value of the non letters numeric up down element must be higher then the value of the minimum nud and lower" + Environment.NewLine +
                            "then the value of the max nud."+Environment.NewLine+Environment.NewLine+
                            "If the error provider says the username is wrong, the username contains a space! This is not allowed!"+Environment.NewLine+Environment.NewLine+
                            "If any mistake orrcur, please look at the developer handbook!";
        }
        /// <summary>
        /// Überprüft Eingabe und legt bei richtiger Eingabe einen neuen User an.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool status_ep_value = true;
            bool status_ep_non = true;
            bool status_ep_special = true;
            bool status_ep_doppel = false;
            bool status_ep_non_min = true;
            byte nud_max_int = 0, nud_min_int=0, nud_non_int=0;
            if(nud_max.Value< nud_min.Value)
            {
                errorProvider_Value.SetError(this.flp_Size, "Max value is lower then min value");
                status_ep_value = true;
            }
            else
            {
                errorProvider_Value.Clear();
                nud_max_int = Convert.ToByte(nud_max.Value);
                nud_min_int = Convert.ToByte(nud_min.Value);
                status_ep_value = false;
            }
            if (nud_nonletters.Value < nud_max.Value)
            {
                errorProvider_nonletters.Clear();
                nud_non_int = Convert.ToByte(nud_nonletters.Value);
                status_ep_non = false;                
            }
            else
            {
                errorProvider_nonletters.SetError(this.nud_nonletters, "Wrong Value--> look at Info Box");
                status_ep_non = true;
            }
            if(nud_special.Value < nud_max.Value)
            {
                if(nud_special.Value == tbx_special.TextLength)
                {
                    errorProvider_special.Clear();
                    status_ep_special = false;
                    int anzahl = 0;
                    sonderzeichen=tbx_special.Text.ToCharArray();
                    string text="";
                    for(int j= 0 ; j < tbx_special.TextLength;j++)
                    {
                        anzahl = 0;
                        for (int i = 0; i < tbx_special.TextLength;i++ )
                        {
                            if(sonderzeichen[j] == tbx_special.Text[i])
                            {
                                anzahl = anzahl + 1;
                            }
                            if (anzahl > 1)
                            {
                                text = "The special letter " + sonderzeichen[j] + " is not unique!";
                                errorProvider_doppelt.SetError(tbx_special, text);
                                status_ep_doppel = true;
                                break;
                            }
                            else
                            {
                                errorProvider_doppelt.Clear();
                            }    
                        }
                        if (anzahl > 1)
                        {
                            break;
                        }                  
                    }
                }
                else
                {
                    errorProvider_special.SetError(this.tbx_special, "The Value of the numeric up down is not the same, as the lenght from the string");
                    status_ep_special = true;
                }
            }
            else
            {
                errorProvider_special.SetError(this.tbx_special, "Look at the info box");
                status_ep_special = true;
            }
            if(nud_min.Value<nud_nonletters.Value)
            {
                ep_non_min.SetError(this.nud_min,"The value of the minimum must be higher then the value of non-letters in the password!");
                status_ep_non_min=true;
            }
            else
            {
                ep_non_min.Clear();
                status_ep_non_min = false;
            }
            if (status_ep_value == false && status_ep_non == false && status_ep_special == false && status_ep_doppel==false && status_ep_non_min == false)
            {
                Passw.UserConfig neu = new Passw.UserConfig(nud_min_int,nud_max_int,nud_non_int,sonderzeichen);
                if (Passw.CheckPasswort(this.tbx_password.Text, neu))
                {
                    errorProvider_last.SetError(btnSave, "Passwort ungültig!");
                }
                else
                {
                    Passw neues_passwort = new Passw(this.tbx_password.Text, neu);
                    Data.ReturnCode code;
                    string pfad = @"..\" + this.tbx_username.Text + ".bin";
                    Data neuer_User = new Data(this.tbx_username.Text, neues_passwort, pfad, neu.ToString(), out code);
                    if (code == Data.ReturnCode.noError)
                    {
                        Program.user.Add(neuer_User);
                        Data.SchreibeDatei(@"..\user.bin", Program.user, Program.AESkEY, Program.AESiV);
                        Start erneut = new Start();
                        erneut.Show();
                        this.Hide();
                        errorProvider_last.Clear();
                    }
                    else
                    {
                        errorProvider_last.SetError(btnSave, code.ToString());
                    }
                }
            }
        }
        /// <summary>
        /// schließt die gesamte Anwendung
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
