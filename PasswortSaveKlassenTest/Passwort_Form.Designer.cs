namespace PasswortSaveKlassenTest
{
    partial class Passwort_Form
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
            this.dgv_Liste = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_generator = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.tbx_details = new System.Windows.Forms.TextBox();
            this.tbx_password = new System.Windows.Forms.TextBox();
            this.tbx_username = new System.Windows.Forms.TextBox();
            this.tbx_website = new System.Windows.Forms.TextBox();
            this.lbl_details = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_website = new System.Windows.Forms.Label();
            this.btn_change = new System.Windows.Forms.Button();
            this.lbl_change = new System.Windows.Forms.Label();
            this.tbx_newPassword = new System.Windows.Forms.TextBox();
            this.btn_SaveNew = new System.Windows.Forms.Button();
            this.errorProvider_new = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_new_generator = new System.Windows.Forms.Button();
            this.tbx_UserConfig = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_new)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Liste
            // 
            this.dgv_Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Liste.Location = new System.Drawing.Point(13, 13);
            this.dgv_Liste.Name = "dgv_Liste";
            this.dgv_Liste.Size = new System.Drawing.Size(599, 511);
            this.dgv_Liste.TabIndex = 0;
            this.dgv_Liste.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Liste_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(13, 531);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 1;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(95, 530);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click_1);
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(177, 529);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(75, 23);
            this.btn_copy.TabIndex = 3;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Enabled = false;
            this.btn_ok.Location = new System.Drawing.Point(767, 222);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 24;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Visible = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_generator
            // 
            this.btn_generator.Enabled = false;
            this.btn_generator.Location = new System.Drawing.Point(859, 222);
            this.btn_generator.Name = "btn_generator";
            this.btn_generator.Size = new System.Drawing.Size(75, 23);
            this.btn_generator.TabIndex = 23;
            this.btn_generator.Text = "Generator";
            this.btn_generator.UseVisualStyleBackColor = true;
            this.btn_generator.Visible = false;
            this.btn_generator.Click += new System.EventHandler(this.btn_generator_Click);
            // 
            // btn_save
            // 
            this.btn_save.Enabled = false;
            this.btn_save.Location = new System.Drawing.Point(668, 222);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 22;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // tbx_details
            // 
            this.tbx_details.Enabled = false;
            this.tbx_details.Location = new System.Drawing.Point(710, 121);
            this.tbx_details.Multiline = true;
            this.tbx_details.Name = "tbx_details";
            this.tbx_details.Size = new System.Drawing.Size(184, 95);
            this.tbx_details.TabIndex = 21;
            // 
            // tbx_password
            // 
            this.tbx_password.Enabled = false;
            this.tbx_password.Location = new System.Drawing.Point(710, 85);
            this.tbx_password.Name = "tbx_password";
            this.tbx_password.Size = new System.Drawing.Size(184, 20);
            this.tbx_password.TabIndex = 20;
            // 
            // tbx_username
            // 
            this.tbx_username.Enabled = false;
            this.tbx_username.Location = new System.Drawing.Point(710, 59);
            this.tbx_username.Name = "tbx_username";
            this.tbx_username.Size = new System.Drawing.Size(184, 20);
            this.tbx_username.TabIndex = 19;
            // 
            // tbx_website
            // 
            this.tbx_website.Enabled = false;
            this.tbx_website.Location = new System.Drawing.Point(710, 24);
            this.tbx_website.Name = "tbx_website";
            this.tbx_website.Size = new System.Drawing.Size(184, 20);
            this.tbx_website.TabIndex = 18;
            // 
            // lbl_details
            // 
            this.lbl_details.AutoSize = true;
            this.lbl_details.Location = new System.Drawing.Point(665, 124);
            this.lbl_details.Name = "lbl_details";
            this.lbl_details.Size = new System.Drawing.Size(39, 13);
            this.lbl_details.TabIndex = 17;
            this.lbl_details.Text = "Details";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Location = new System.Drawing.Point(651, 92);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(53, 13);
            this.label_password.TabIndex = 16;
            this.label_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(649, 66);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(55, 13);
            this.lbl_username.TabIndex = 15;
            this.lbl_username.Text = "Username";
            // 
            // lbl_website
            // 
            this.lbl_website.AutoSize = true;
            this.lbl_website.Location = new System.Drawing.Point(658, 31);
            this.lbl_website.Name = "lbl_website";
            this.lbl_website.Size = new System.Drawing.Size(46, 13);
            this.lbl_website.TabIndex = 14;
            this.lbl_website.Text = "Website";
            // 
            // btn_change
            // 
            this.btn_change.Location = new System.Drawing.Point(258, 529);
            this.btn_change.Name = "btn_change";
            this.btn_change.Size = new System.Drawing.Size(75, 23);
            this.btn_change.TabIndex = 25;
            this.btn_change.Text = "Change Admin Password";
            this.btn_change.UseVisualStyleBackColor = true;
            this.btn_change.Click += new System.EventHandler(this.btn_change_Click);
            // 
            // lbl_change
            // 
            this.lbl_change.AutoSize = true;
            this.lbl_change.Location = new System.Drawing.Point(668, 281);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(78, 13);
            this.lbl_change.TabIndex = 26;
            this.lbl_change.Text = "New Password";
            this.lbl_change.Visible = false;
            // 
            // tbx_newPassword
            // 
            this.tbx_newPassword.Location = new System.Drawing.Point(753, 281);
            this.tbx_newPassword.Name = "tbx_newPassword";
            this.tbx_newPassword.Size = new System.Drawing.Size(141, 20);
            this.tbx_newPassword.TabIndex = 27;
            this.tbx_newPassword.Visible = false;
            // 
            // btn_SaveNew
            // 
            this.btn_SaveNew.Location = new System.Drawing.Point(671, 318);
            this.btn_SaveNew.Name = "btn_SaveNew";
            this.btn_SaveNew.Size = new System.Drawing.Size(75, 23);
            this.btn_SaveNew.TabIndex = 28;
            this.btn_SaveNew.Text = "Save";
            this.btn_SaveNew.UseVisualStyleBackColor = true;
            this.btn_SaveNew.Visible = false;
            this.btn_SaveNew.Click += new System.EventHandler(this.btn_SaveNew_Click);
            // 
            // errorProvider_new
            // 
            this.errorProvider_new.ContainerControl = this;
            // 
            // btn_new_generator
            // 
            this.btn_new_generator.Location = new System.Drawing.Point(752, 318);
            this.btn_new_generator.Name = "btn_new_generator";
            this.btn_new_generator.Size = new System.Drawing.Size(75, 23);
            this.btn_new_generator.TabIndex = 29;
            this.btn_new_generator.Text = "Generator";
            this.btn_new_generator.UseVisualStyleBackColor = true;
            this.btn_new_generator.Visible = false;
            this.btn_new_generator.Click += new System.EventHandler(this.btn_new_generator_Click);
            // 
            // tbx_UserConfig
            // 
            this.tbx_UserConfig.Location = new System.Drawing.Point(671, 358);
            this.tbx_UserConfig.Multiline = true;
            this.tbx_UserConfig.Name = "tbx_UserConfig";
            this.tbx_UserConfig.ReadOnly = true;
            this.tbx_UserConfig.Size = new System.Drawing.Size(274, 185);
            this.tbx_UserConfig.TabIndex = 30;
            // 
            // Passwort_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 602);
            this.Controls.Add(this.tbx_UserConfig);
            this.Controls.Add(this.btn_new_generator);
            this.Controls.Add(this.btn_SaveNew);
            this.Controls.Add(this.tbx_newPassword);
            this.Controls.Add(this.lbl_change);
            this.Controls.Add(this.btn_change);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.btn_generator);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tbx_details);
            this.Controls.Add(this.tbx_password);
            this.Controls.Add(this.tbx_username);
            this.Controls.Add(this.tbx_website);
            this.Controls.Add(this.lbl_details);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_website);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.dgv_Liste);
            this.Name = "Passwort_Form";
            this.Text = "Passwort_Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Passwort_Form_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_new)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Liste;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_generator;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox tbx_details;
        private System.Windows.Forms.TextBox tbx_password;
        private System.Windows.Forms.TextBox tbx_username;
        private System.Windows.Forms.TextBox tbx_website;
        private System.Windows.Forms.Label lbl_details;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_website;
        private System.Windows.Forms.Button btn_change;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.TextBox tbx_newPassword;
        private System.Windows.Forms.Button btn_SaveNew;
        private System.Windows.Forms.ErrorProvider errorProvider_new;
        private System.Windows.Forms.Button btn_new_generator;
        private System.Windows.Forms.TextBox tbx_UserConfig;
    }
}