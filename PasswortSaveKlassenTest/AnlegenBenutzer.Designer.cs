namespace PasswortSaveKlassenTest
{
    partial class AnlegenBenutzer
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_min = new System.Windows.Forms.NumericUpDown();
            this.nud_max = new System.Windows.Forms.NumericUpDown();
            this.flp_Size = new System.Windows.Forms.FlowLayoutPanel();
            this.errorProvider_Value = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_Info = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_nonletters = new System.Windows.Forms.NumericUpDown();
            this.errorProvider_nonletters = new System.Windows.Forms.ErrorProvider(this.components);
            this.nud_special = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_special = new System.Windows.Forms.TextBox();
            this.errorProvider_special = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_doppelt = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ep_non_min = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_last = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).BeginInit();
            this.flp_Size.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nonletters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nonletters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_special)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_special)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doppelt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_non_min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_last)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(687, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(606, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "min password length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Max password length";
            // 
            // nud_min
            // 
            this.nud_min.Location = new System.Drawing.Point(116, 3);
            this.nud_min.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_min.Name = "nud_min";
            this.nud_min.Size = new System.Drawing.Size(120, 20);
            this.nud_min.TabIndex = 1;
            // 
            // nud_max
            // 
            this.nud_max.Location = new System.Drawing.Point(3, 3);
            this.nud_max.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_max.Name = "nud_max";
            this.nud_max.Size = new System.Drawing.Size(107, 20);
            this.nud_max.TabIndex = 0;
            // 
            // flp_Size
            // 
            this.flp_Size.Controls.Add(this.nud_max);
            this.flp_Size.Controls.Add(this.nud_min);
            this.flp_Size.Controls.Add(this.label2);
            this.flp_Size.Controls.Add(this.label1);
            this.flp_Size.Location = new System.Drawing.Point(11, 3);
            this.flp_Size.Name = "flp_Size";
            this.flp_Size.Size = new System.Drawing.Size(256, 64);
            this.flp_Size.TabIndex = 6;
            // 
            // errorProvider_Value
            // 
            this.errorProvider_Value.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "special symbols";
            // 
            // tbx_Info
            // 
            this.tbx_Info.Location = new System.Drawing.Point(539, 5);
            this.tbx_Info.Multiline = true;
            this.tbx_Info.Name = "tbx_Info";
            this.tbx_Info.ReadOnly = true;
            this.tbx_Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbx_Info.Size = new System.Drawing.Size(223, 346);
            this.tbx_Info.TabIndex = 9;
            this.tbx_Info.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Value of non-letters";
            // 
            // nud_nonletters
            // 
            this.nud_nonletters.Location = new System.Drawing.Point(14, 91);
            this.nud_nonletters.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud_nonletters.Name = "nud_nonletters";
            this.nud_nonletters.Size = new System.Drawing.Size(120, 20);
            this.nud_nonletters.TabIndex = 2;
            // 
            // errorProvider_nonletters
            // 
            this.errorProvider_nonletters.ContainerControl = this;
            // 
            // nud_special
            // 
            this.nud_special.Location = new System.Drawing.Point(11, 160);
            this.nud_special.Name = "nud_special";
            this.nud_special.Size = new System.Drawing.Size(110, 20);
            this.nud_special.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Value for special symbols";
            // 
            // tbx_special
            // 
            this.tbx_special.Location = new System.Drawing.Point(11, 200);
            this.tbx_special.Name = "tbx_special";
            this.tbx_special.Size = new System.Drawing.Size(110, 20);
            this.tbx_special.TabIndex = 4;
            // 
            // errorProvider_special
            // 
            this.errorProvider_special.ContainerControl = this;
            // 
            // errorProvider_doppelt
            // 
            this.errorProvider_doppelt.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Username";
            // 
            // tbx_username
            // 
            this.tbx_username.Location = new System.Drawing.Point(11, 244);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(236, 20);
            this.tbx_username.TabIndex = 5;
            // 
            // tbx_password
            // 
            this.tbx_password.Location = new System.Drawing.Point(11, 294);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(236, 20);
            this.tbx_password.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Password";
            // 
            // ep_non_min
            // 
            this.ep_non_min.ContainerControl = this;
            // 
            // errorProvider_last
            // 
            this.errorProvider_last.ContainerControl = this;
            // 
            // AnlegenBenutzer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(774, 392);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbx_special);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_special);
            this.Controls.Add(this.nud_nonletters);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbx_Info);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flp_Size);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "AnlegenBenutzer";
            this.Text = "AnlegenBenutzer";
            ((System.ComponentModel.ISupportInitialize)(this.nud_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_max)).EndInit();
            this.flp_Size.ResumeLayout(false);
            this.flp_Size.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nonletters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_nonletters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_special)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_special)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_doppelt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_non_min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_last)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_min;
        private System.Windows.Forms.NumericUpDown nud_max;
        private System.Windows.Forms.FlowLayoutPanel flp_Size;
        private System.Windows.Forms.ErrorProvider errorProvider_Value;
        private System.Windows.Forms.TextBox tbx_Info;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_nonletters;
        private System.Windows.Forms.ErrorProvider errorProvider_nonletters;
        private System.Windows.Forms.TextBox tbx_special;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_special;
        private System.Windows.Forms.ErrorProvider errorProvider_special;
        private System.Windows.Forms.ErrorProvider errorProvider_doppelt;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.ErrorProvider ep_non_min;
        private System.Windows.Forms.ErrorProvider errorProvider_last;
    }
}