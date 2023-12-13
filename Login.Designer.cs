namespace BankManagement
{
    partial class Login
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.blbUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsename = new Guna.UI.WinForms.GunaTextBox();
            this.txtPassword = new Guna.UI.WinForms.GunaTextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblClose = new System.Windows.Forms.Label();
            this.cboLoginRole = new Guna.UI.WinForms.GunaComboBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.flowLayoutPanel1.Controls.Add(this.gunaPictureBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(242, 628);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::BankManagement.Properties.Resources.BankLogo;
            this.gunaPictureBox2.Location = new System.Drawing.Point(3, 3);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(99, 96);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox2.TabIndex = 5;
            this.gunaPictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Bank Management";
            // 
            // blbUsername
            // 
            this.blbUsername.AutoSize = true;
            this.blbUsername.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbUsername.Location = new System.Drawing.Point(290, 163);
            this.blbUsername.Name = "blbUsername";
            this.blbUsername.Size = new System.Drawing.Size(145, 29);
            this.blbUsername.TabIndex = 4;
            this.blbUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.857143F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(290, 289);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(146, 29);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Password: ";
            // 
            // txtUsename
            // 
            this.txtUsename.BaseColor = System.Drawing.Color.White;
            this.txtUsename.BorderColor = System.Drawing.Color.Silver;
            this.txtUsename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsename.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsename.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsename.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsename.Location = new System.Drawing.Point(295, 211);
            this.txtUsename.Name = "txtUsename";
            this.txtUsename.PasswordChar = '\0';
            this.txtUsename.SelectedText = "";
            this.txtUsename.Size = new System.Drawing.Size(393, 47);
            this.txtUsename.TabIndex = 8;
            // 
            // txtPassword
            // 
            this.txtPassword.BaseColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Location = new System.Drawing.Point(295, 342);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(393, 47);
            this.txtPassword.TabIndex = 9;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(358, 410);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(243, 46);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(761, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(42, 42);
            this.lblClose.TabIndex = 11;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // cboLoginRole
            // 
            this.cboLoginRole.BackColor = System.Drawing.Color.Transparent;
            this.cboLoginRole.BaseColor = System.Drawing.Color.White;
            this.cboLoginRole.BorderColor = System.Drawing.Color.Silver;
            this.cboLoginRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoginRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoginRole.FocusedColor = System.Drawing.Color.Empty;
            this.cboLoginRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLoginRole.ForeColor = System.Drawing.Color.Black;
            this.cboLoginRole.FormattingEnabled = true;
            this.cboLoginRole.Items.AddRange(new object[] {
            "Admin",
            "Agent"});
            this.cboLoginRole.Location = new System.Drawing.Point(295, 93);
            this.cboLoginRole.Name = "cboLoginRole";
            this.cboLoginRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboLoginRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboLoginRole.Size = new System.Drawing.Size(393, 40);
            this.cboLoginRole.TabIndex = 31;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(358, 483);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(243, 46);
            this.btnReset.TabIndex = 32;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 578);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboLoginRole);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsename);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.blbUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label blbUsername;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label lblPassword;
        private Guna.UI.WinForms.GunaTextBox txtUsename;
        private Guna.UI.WinForms.GunaTextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblClose;
        private Guna.UI.WinForms.GunaComboBox cboLoginRole;
        private System.Windows.Forms.Button btnReset;
    }
}