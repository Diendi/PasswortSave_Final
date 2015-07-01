namespace PasswortSaveKlassenTest
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            this.lbl_LoginName = new System.Windows.Forms.Label();
            this.tbx_LoginName = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider_loginName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_password = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_loginName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_password)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_LoginName
            // 
            this.lbl_LoginName.AutoSize = true;
            this.lbl_LoginName.Location = new System.Drawing.Point(12, 16);
            this.lbl_LoginName.Name = "lbl_LoginName";
            this.lbl_LoginName.Size = new System.Drawing.Size(64, 13);
            this.lbl_LoginName.TabIndex = 0;
            this.lbl_LoginName.Text = "Login Name";
            // 
            // tbx_LoginName
            // 
            this.tbx_LoginName.Location = new System.Drawing.Point(82, 13);
            this.tbx_LoginName.Name = "tbx_LoginName";
            this.tbx_LoginName.Size = new System.Drawing.Size(454, 20);
            this.tbx_LoginName.TabIndex = 1;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(13, 46);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(53, 13);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(82, 43);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(454, 20);
            this.tbx_password.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(382, 90);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(463, 89);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // errorProvider_loginName
            // 
            this.errorProvider_loginName.ContainerControl = this;
            // 
            // errorProvider_password
            // 
            this.errorProvider_password.ContainerControl = this;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(550, 125);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.tbx_LoginName);
            this.Controls.Add(this.lbl_LoginName);
            this.Name = "Login_Form";
            this.Text = "Login_Form";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_loginName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_password)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_LoginName;
        private System.Windows.Forms.TextBox tbx_LoginName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider_loginName;
        private System.Windows.Forms.ErrorProvider errorProvider_password;
    }
}