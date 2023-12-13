namespace BankManagement
{
    partial class Settings
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
            this.cboTheme = new Guna.UI.WinForms.GunaComboBox();
            this.txtAdminNewPassword = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmitANP = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnSubmitTheme = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnReset = new Guna.UI.WinForms.GunaGradientTileButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.flowLayoutPanel1.Controls.Add(this.gunaPictureBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 562);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // cboTheme
            // 
            this.cboTheme.BackColor = System.Drawing.Color.Transparent;
            this.cboTheme.BaseColor = System.Drawing.Color.White;
            this.cboTheme.BorderColor = System.Drawing.Color.Silver;
            this.cboTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheme.FocusedColor = System.Drawing.Color.Empty;
            this.cboTheme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboTheme.ForeColor = System.Drawing.Color.Black;
            this.cboTheme.FormattingEnabled = true;
            this.cboTheme.Location = new System.Drawing.Point(204, 390);
            this.cboTheme.Name = "cboTheme";
            this.cboTheme.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboTheme.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboTheme.Size = new System.Drawing.Size(291, 40);
            this.cboTheme.TabIndex = 33;
            // 
            // txtAdminNewPassword
            // 
            this.txtAdminNewPassword.BaseColor = System.Drawing.Color.White;
            this.txtAdminNewPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtAdminNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAdminNewPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAdminNewPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAdminNewPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAdminNewPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAdminNewPassword.Location = new System.Drawing.Point(204, 229);
            this.txtAdminNewPassword.Name = "txtAdminNewPassword";
            this.txtAdminNewPassword.PasswordChar = '\0';
            this.txtAdminNewPassword.SelectedText = "";
            this.txtAdminNewPassword.Size = new System.Drawing.Size(291, 40);
            this.txtAdminNewPassword.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 35);
            this.label2.TabIndex = 30;
            this.label2.Text = "Admin New Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 42);
            this.label3.TabIndex = 29;
            this.label3.Text = "New Account Form";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(921, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(42, 42);
            this.lblClose.TabIndex = 34;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 35);
            this.label1.TabIndex = 36;
            this.label1.Text = "Theme";
            // 
            // btnSubmitANP
            // 
            this.btnSubmitANP.AnimationHoverSpeed = 0.07F;
            this.btnSubmitANP.AnimationSpeed = 0.03F;
            this.btnSubmitANP.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnSubmitANP.BaseColor2 = System.Drawing.Color.Black;
            this.btnSubmitANP.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitANP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmitANP.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmitANP.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitANP.ForeColor = System.Drawing.Color.White;
            this.btnSubmitANP.Image = null;
            this.btnSubmitANP.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSubmitANP.Location = new System.Drawing.Point(614, 229);
            this.btnSubmitANP.Name = "btnSubmitANP";
            this.btnSubmitANP.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSubmitANP.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSubmitANP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmitANP.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmitANP.OnHoverImage = null;
            this.btnSubmitANP.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmitANP.Size = new System.Drawing.Size(142, 40);
            this.btnSubmitANP.TabIndex = 37;
            this.btnSubmitANP.Text = "Submit";
            this.btnSubmitANP.Click += new System.EventHandler(this.btnSubmitANP_Click);
            // 
            // btnSubmitTheme
            // 
            this.btnSubmitTheme.AnimationHoverSpeed = 0.07F;
            this.btnSubmitTheme.AnimationSpeed = 0.03F;
            this.btnSubmitTheme.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnSubmitTheme.BaseColor2 = System.Drawing.Color.Black;
            this.btnSubmitTheme.BorderColor = System.Drawing.Color.Black;
            this.btnSubmitTheme.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmitTheme.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmitTheme.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitTheme.ForeColor = System.Drawing.Color.White;
            this.btnSubmitTheme.Image = null;
            this.btnSubmitTheme.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSubmitTheme.Location = new System.Drawing.Point(614, 390);
            this.btnSubmitTheme.Name = "btnSubmitTheme";
            this.btnSubmitTheme.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSubmitTheme.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSubmitTheme.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmitTheme.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmitTheme.OnHoverImage = null;
            this.btnSubmitTheme.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmitTheme.Size = new System.Drawing.Size(142, 40);
            this.btnSubmitTheme.TabIndex = 39;
            this.btnSubmitTheme.Text = "Apply";
            this.btnSubmitTheme.Click += new System.EventHandler(this.btnSubmitTheme_Click);
            // 
            // btnReset
            // 
            this.btnReset.AnimationHoverSpeed = 0.07F;
            this.btnReset.AnimationSpeed = 0.03F;
            this.btnReset.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnReset.BaseColor2 = System.Drawing.Color.Black;
            this.btnReset.BorderColor = System.Drawing.Color.Black;
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnReset.FocusedColor = System.Drawing.Color.Empty;
            this.btnReset.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Image = null;
            this.btnReset.ImageSize = new System.Drawing.Size(52, 52);
            this.btnReset.Location = new System.Drawing.Point(418, 485);
            this.btnReset.Name = "btnReset";
            this.btnReset.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnReset.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnReset.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnReset.OnHoverForeColor = System.Drawing.Color.White;
            this.btnReset.OnHoverImage = null;
            this.btnReset.OnPressedColor = System.Drawing.Color.Black;
            this.btnReset.Size = new System.Drawing.Size(142, 40);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 562);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSubmitTheme);
            this.Controls.Add(this.btnSubmitANP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.cboTheme);
            this.Controls.Add(this.txtAdminNewPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaComboBox cboTheme;
        private Guna.UI.WinForms.GunaTextBox txtAdminNewPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientTileButton btnSubmitANP;
        private Guna.UI.WinForms.GunaGradientTileButton btnSubmitTheme;
        private Guna.UI.WinForms.GunaGradientTileButton btnReset;
    }
}