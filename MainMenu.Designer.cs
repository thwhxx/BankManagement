namespace BankManagement
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.picSettings = new Guna.UI.WinForms.GunaPictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.picTransaction = new Guna.UI.WinForms.GunaPictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.picAccount = new Guna.UI.WinForms.GunaPictureBox();
            this.PicLogo = new Guna.UI.WinForms.GunaPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaGradient2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "ACCOUNTS";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.picSettings);
            this.gunaGradient2Panel1.Controls.Add(this.label5);
            this.gunaGradient2Panel1.Controls.Add(this.picTransaction);
            this.gunaGradient2Panel1.Controls.Add(this.label4);
            this.gunaGradient2Panel1.Controls.Add(this.picAccount);
            this.gunaGradient2Panel1.Controls.Add(this.PicLogo);
            this.gunaGradient2Panel1.Controls.Add(this.label2);
            this.gunaGradient2Panel1.Controls.Add(this.label3);
            this.gunaGradient2Panel1.Controls.Add(this.gunaPictureBox1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(658, 709);
            this.gunaGradient2Panel1.TabIndex = 4;
            // 
            // picSettings
            // 
            this.picSettings.BaseColor = System.Drawing.Color.White;
            this.picSettings.Image = ((System.Drawing.Image)(resources.GetObject("picSettings.Image")));
            this.picSettings.Location = new System.Drawing.Point(268, 515);
            this.picSettings.Name = "picSettings";
            this.picSettings.Size = new System.Drawing.Size(88, 84);
            this.picSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSettings.TabIndex = 9;
            this.picSettings.TabStop = false;
            this.picSettings.Click += new System.EventHandler(this.picSettings_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 602);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 35);
            this.label5.TabIndex = 8;
            this.label5.Text = "Settings";
            // 
            // picTransaction
            // 
            this.picTransaction.BaseColor = System.Drawing.Color.White;
            this.picTransaction.Image = ((System.Drawing.Image)(resources.GetObject("picTransaction.Image")));
            this.picTransaction.Location = new System.Drawing.Point(268, 341);
            this.picTransaction.Name = "picTransaction";
            this.picTransaction.Size = new System.Drawing.Size(88, 84);
            this.picTransaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTransaction.TabIndex = 7;
            this.picTransaction.TabStop = false;
            this.picTransaction.Click += new System.EventHandler(this.picTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(222, 428);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 35);
            this.label4.TabIndex = 6;
            this.label4.Text = "Transaction";
            // 
            // picAccount
            // 
            this.picAccount.BaseColor = System.Drawing.Color.White;
            this.picAccount.Image = global::BankManagement.Properties.Resources.AccountLogo;
            this.picAccount.Location = new System.Drawing.Point(268, 172);
            this.picAccount.Name = "picAccount";
            this.picAccount.Size = new System.Drawing.Size(88, 84);
            this.picAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAccount.TabIndex = 5;
            this.picAccount.TabStop = false;
            this.picAccount.Click += new System.EventHandler(this.picAccount_Click);
            // 
            // PicLogo
            // 
            this.PicLogo.BaseColor = System.Drawing.Color.White;
            this.PicLogo.Image = global::BankManagement.Properties.Resources.BankLogo;
            this.PicLogo.Location = new System.Drawing.Point(28, 23);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(99, 96);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 4;
            this.PicLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(246, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 42);
            this.label3.TabIndex = 2;
            this.label3.Text = "Main Menu";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::BankManagement.Properties.Resources.InteracLogo;
            this.gunaPictureBox1.Location = new System.Drawing.Point(760, 356);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(400, 200);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(658, 709);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTransaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaPictureBox PicLogo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPictureBox picAccount;
        private Guna.UI.WinForms.GunaPictureBox picSettings;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaPictureBox picTransaction;
        private System.Windows.Forms.Label label4;
    }
}