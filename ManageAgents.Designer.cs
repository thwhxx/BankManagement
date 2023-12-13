namespace BankManagement
{
    partial class ManageAgents
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.AgentsDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.btnCancel = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnEdit = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnSubmit = new Guna.UI.WinForms.GunaGradientTileButton();
            this.txtAgentAddress = new Guna.UI.WinForms.GunaTextBox();
            this.txtAgentPhone = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAgentPassword = new Guna.UI.WinForms.GunaTextBox();
            this.txtAgentName = new Guna.UI.WinForms.GunaTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentsDGV)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
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
            // AgentsDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AgentsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AgentsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AgentsDGV.BackgroundColor = System.Drawing.Color.White;
            this.AgentsDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgentsDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AgentsDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AgentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AgentsDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AgentsDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AgentsDGV.EnableHeadersVisualStyles = false;
            this.AgentsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AgentsDGV.Location = new System.Drawing.Point(105, 555);
            this.AgentsDGV.Name = "AgentsDGV";
            this.AgentsDGV.ReadOnly = true;
            this.AgentsDGV.RowHeadersVisible = false;
            this.AgentsDGV.RowHeadersWidth = 72;
            this.AgentsDGV.RowTemplate.Height = 31;
            this.AgentsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AgentsDGV.Size = new System.Drawing.Size(1728, 445);
            this.AgentsDGV.TabIndex = 56;
            this.AgentsDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AgentsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AgentsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AgentsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AgentsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AgentsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AgentsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AgentsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AgentsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AgentsDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.AgentsDGV.ThemeStyle.ReadOnly = true;
            this.AgentsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AgentsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AgentsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AgentsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AgentsDGV.ThemeStyle.RowsStyle.Height = 31;
            this.AgentsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AgentsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AgentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AgentsDGV_CellContentClick);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnCancel.BaseColor2 = System.Drawing.Color.Black;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCancel.Location = new System.Drawing.Point(1338, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCancel.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Size = new System.Drawing.Size(172, 54);
            this.btnCancel.TabIndex = 55;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnEdit.BaseColor2 = System.Drawing.Color.Black;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnEdit.Location = new System.Drawing.Point(879, 377);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(172, 54);
            this.btnEdit.TabIndex = 54;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.AnimationHoverSpeed = 0.07F;
            this.btnSubmit.AnimationSpeed = 0.03F;
            this.btnSubmit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnSubmit.BaseColor2 = System.Drawing.Color.Black;
            this.btnSubmit.BorderColor = System.Drawing.Color.Black;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSubmit.FocusedColor = System.Drawing.Color.Empty;
            this.btnSubmit.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Image = null;
            this.btnSubmit.ImageSize = new System.Drawing.Size(52, 52);
            this.btnSubmit.Location = new System.Drawing.Point(403, 377);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSubmit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Size = new System.Drawing.Size(172, 54);
            this.btnSubmit.TabIndex = 53;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtAgentAddress
            // 
            this.txtAgentAddress.BaseColor = System.Drawing.Color.White;
            this.txtAgentAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAgentAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAgentAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAgentAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAgentAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgentAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgentAddress.Location = new System.Drawing.Point(1007, 152);
            this.txtAgentAddress.Name = "txtAgentAddress";
            this.txtAgentAddress.PasswordChar = '\0';
            this.txtAgentAddress.SelectedText = "";
            this.txtAgentAddress.Size = new System.Drawing.Size(340, 174);
            this.txtAgentAddress.TabIndex = 48;
            // 
            // txtAgentPhone
            // 
            this.txtAgentPhone.BaseColor = System.Drawing.Color.White;
            this.txtAgentPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtAgentPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAgentPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAgentPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAgentPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgentPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgentPhone.Location = new System.Drawing.Point(1446, 152);
            this.txtAgentPhone.Name = "txtAgentPhone";
            this.txtAgentPhone.PasswordChar = '\0';
            this.txtAgentPhone.SelectedText = "";
            this.txtAgentPhone.Size = new System.Drawing.Size(291, 40);
            this.txtAgentPhone.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1440, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 35);
            this.label8.TabIndex = 45;
            this.label8.Text = "Phone";
            // 
            // txtAgentPassword
            // 
            this.txtAgentPassword.BaseColor = System.Drawing.Color.White;
            this.txtAgentPassword.BorderColor = System.Drawing.Color.Silver;
            this.txtAgentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAgentPassword.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAgentPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAgentPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgentPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgentPassword.Location = new System.Drawing.Point(595, 152);
            this.txtAgentPassword.Name = "txtAgentPassword";
            this.txtAgentPassword.PasswordChar = '\0';
            this.txtAgentPassword.SelectedText = "";
            this.txtAgentPassword.Size = new System.Drawing.Size(291, 40);
            this.txtAgentPassword.TabIndex = 44;
            // 
            // txtAgentName
            // 
            this.txtAgentName.BaseColor = System.Drawing.Color.White;
            this.txtAgentName.BorderColor = System.Drawing.Color.Silver;
            this.txtAgentName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAgentName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAgentName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAgentName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAgentName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAgentName.Location = new System.Drawing.Point(215, 152);
            this.txtAgentName.Name = "txtAgentName";
            this.txtAgentName.PasswordChar = '\0';
            this.txtAgentName.SelectedText = "";
            this.txtAgentName.Size = new System.Drawing.Size(291, 40);
            this.txtAgentName.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1001, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 35);
            this.label5.TabIndex = 42;
            this.label5.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(589, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 35);
            this.label1.TabIndex = 40;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(209, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 39;
            this.label2.Text = "Name";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1791, 3);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(42, 42);
            this.lblClose.TabIndex = 38;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(718, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 42);
            this.label3.TabIndex = 37;
            this.label3.Text = "Manage Agents";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.flowLayoutPanel1.Controls.Add(this.gunaPictureBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 1000);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // ManageAgents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1834, 1000);
            this.Controls.Add(this.AgentsDGV);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtAgentAddress);
            this.Controls.Add(this.txtAgentPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAgentPassword);
            this.Controls.Add(this.txtAgentName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAgents";
            this.Text = "ManageAgents";
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AgentsDGV)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private Guna.UI.WinForms.GunaDataGridView AgentsDGV;
        private Guna.UI.WinForms.GunaGradientTileButton btnCancel;
        private Guna.UI.WinForms.GunaGradientTileButton btnEdit;
        private Guna.UI.WinForms.GunaGradientTileButton btnSubmit;
        private Guna.UI.WinForms.GunaTextBox txtAgentAddress;
        private Guna.UI.WinForms.GunaTextBox txtAgentPhone;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtAgentPassword;
        private Guna.UI.WinForms.GunaTextBox txtAgentName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}