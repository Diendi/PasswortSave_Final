namespace PasswortSaveKlassenTest
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNeuenBenutzer = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNeuenBenutzer
            // 
            this.btnNeuenBenutzer.Location = new System.Drawing.Point(13, 13);
            this.btnNeuenBenutzer.Name = "btnNeuenBenutzer";
            this.btnNeuenBenutzer.Size = new System.Drawing.Size(151, 23);
            this.btnNeuenBenutzer.TabIndex = 0;
            this.btnNeuenBenutzer.Text = "Neuen Benutzer anlegen";
            this.btnNeuenBenutzer.UseVisualStyleBackColor = true;
            this.btnNeuenBenutzer.Click += new System.EventHandler(this.btnNeuenBenutzer_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 42);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(151, 23);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(13, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(151, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(182, 110);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnNeuenBenutzer);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNeuenBenutzer;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnCancel;
    }
}