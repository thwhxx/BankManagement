namespace BankManagement
{
    partial class AddAccount
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccName = new Guna.UI.WinForms.GunaTextBox();
            this.txtAccPhone = new Guna.UI.WinForms.GunaTextBox();
            this.txtOccupation = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboEducation = new Guna.UI.WinForms.GunaComboBox();
            this.txtIncome = new Guna.UI.WinForms.GunaTextBox();
            this.cboGender = new Guna.UI.WinForms.GunaComboBox();
            this.btnSubmit = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnEdit = new Guna.UI.WinForms.GunaGradientTileButton();
            this.btnCancal = new Guna.UI.WinForms.GunaGradientTileButton();
            this.AccountDGV = new Guna.UI.WinForms.GunaDataGridView();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.flowLayoutPanel1.Controls.Add(this.gunaPictureBox2);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(105, 1064);
            this.flowLayoutPanel1.TabIndex = 1;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(725, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(357, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Account Form";
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.BackColor = System.Drawing.Color.Transparent;
            this.lblClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClose.Location = new System.Drawing.Point(1819, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(42, 42);
            this.lblClose.TabIndex = 12;
            this.lblClose.Text = "X";
            this.lblClose.Click += new System.EventHandler(this.lblClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(602, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 35);
            this.label4.TabIndex = 15;
            this.label4.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1014, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 35);
            this.label5.TabIndex = 16;
            this.label5.Text = "Address";
            // 
            // txtAccName
            // 
            this.txtAccName.BaseColor = System.Drawing.Color.White;
            this.txtAccName.BorderColor = System.Drawing.Color.Silver;
            this.txtAccName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAccName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAccName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccName.Location = new System.Drawing.Point(228, 184);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.PasswordChar = '\0';
            this.txtAccName.SelectedText = "";
            this.txtAccName.Size = new System.Drawing.Size(291, 40);
            this.txtAccName.TabIndex = 18;
            // 
            // txtAccPhone
            // 
            this.txtAccPhone.BaseColor = System.Drawing.Color.White;
            this.txtAccPhone.BorderColor = System.Drawing.Color.Silver;
            this.txtAccPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAccPhone.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAccPhone.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAccPhone.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAccPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAccPhone.Location = new System.Drawing.Point(608, 184);
            this.txtAccPhone.Name = "txtAccPhone";
            this.txtAccPhone.PasswordChar = '\0';
            this.txtAccPhone.SelectedText = "";
            this.txtAccPhone.Size = new System.Drawing.Size(291, 40);
            this.txtAccPhone.TabIndex = 19;
            // 
            // txtOccupation
            // 
            this.txtOccupation.BaseColor = System.Drawing.Color.White;
            this.txtOccupation.BorderColor = System.Drawing.Color.Silver;
            this.txtOccupation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOccupation.FocusedBaseColor = System.Drawing.Color.White;
            this.txtOccupation.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtOccupation.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtOccupation.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtOccupation.Location = new System.Drawing.Point(1459, 184);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.PasswordChar = '\0';
            this.txtOccupation.SelectedText = "";
            this.txtOccupation.Size = new System.Drawing.Size(291, 40);
            this.txtOccupation.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1453, 266);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 35);
            this.label7.TabIndex = 22;
            this.label7.Text = "Income";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1453, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 35);
            this.label8.TabIndex = 21;
            this.label8.Text = "Occupation";
            // 
            // txtAddress
            // 
            this.txtAddress.BaseColor = System.Drawing.Color.White;
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAddress.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAddress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAddress.Location = new System.Drawing.Point(1020, 184);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(340, 174);
            this.txtAddress.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(222, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 35);
            this.label6.TabIndex = 26;
            this.label6.Text = "Education";
            // 
            // cboEducation
            // 
            this.cboEducation.BackColor = System.Drawing.Color.Transparent;
            this.cboEducation.BaseColor = System.Drawing.Color.White;
            this.cboEducation.BorderColor = System.Drawing.Color.Silver;
            this.cboEducation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboEducation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEducation.FocusedColor = System.Drawing.Color.Empty;
            this.cboEducation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboEducation.ForeColor = System.Drawing.Color.Black;
            this.cboEducation.FormattingEnabled = true;
            this.cboEducation.Items.AddRange(new object[] {
            "Community College",
            "CEGEP Diploma",
            "Certificate Program",
            "Undergraduate",
            "Graduate",
            "Professional Degree Programs ",
            "Doctoral Programs"});
            this.cboEducation.Location = new System.Drawing.Point(232, 318);
            this.cboEducation.Name = "cboEducation";
            this.cboEducation.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboEducation.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboEducation.Size = new System.Drawing.Size(291, 40);
            this.cboEducation.TabIndex = 28;
            // 
            // txtIncome
            // 
            this.txtIncome.BaseColor = System.Drawing.Color.White;
            this.txtIncome.BorderColor = System.Drawing.Color.Silver;
            this.txtIncome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIncome.FocusedBaseColor = System.Drawing.Color.White;
            this.txtIncome.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtIncome.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtIncome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIncome.Location = new System.Drawing.Point(1459, 318);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.PasswordChar = '\0';
            this.txtIncome.SelectedText = "";
            this.txtIncome.Size = new System.Drawing.Size(291, 40);
            this.txtIncome.TabIndex = 29;
            // 
            // cboGender
            // 
            this.cboGender.BackColor = System.Drawing.Color.Transparent;
            this.cboGender.BaseColor = System.Drawing.Color.White;
            this.cboGender.BorderColor = System.Drawing.Color.Silver;
            this.cboGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FocusedColor = System.Drawing.Color.Empty;
            this.cboGender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboGender.ForeColor = System.Drawing.Color.Black;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.cboGender.Location = new System.Drawing.Point(608, 318);
            this.cboGender.Name = "cboGender";
            this.cboGender.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboGender.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboGender.Size = new System.Drawing.Size(291, 40);
            this.cboGender.TabIndex = 30;
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
            this.btnSubmit.Location = new System.Drawing.Point(416, 409);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSubmit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSubmit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSubmit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSubmit.OnHoverImage = null;
            this.btnSubmit.OnPressedColor = System.Drawing.Color.Black;
            this.btnSubmit.Size = new System.Drawing.Size(172, 54);
            this.btnSubmit.TabIndex = 32;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(892, 409);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Size = new System.Drawing.Size(172, 54);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "Edit";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancal
            // 
            this.btnCancal.AnimationHoverSpeed = 0.07F;
            this.btnCancal.AnimationSpeed = 0.03F;
            this.btnCancal.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(216)))));
            this.btnCancal.BaseColor2 = System.Drawing.Color.Black;
            this.btnCancal.BorderColor = System.Drawing.Color.Black;
            this.btnCancal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancal.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancal.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancal.ForeColor = System.Drawing.Color.White;
            this.btnCancal.Image = null;
            this.btnCancal.ImageSize = new System.Drawing.Size(52, 52);
            this.btnCancal.Location = new System.Drawing.Point(1351, 409);
            this.btnCancal.Name = "btnCancal";
            this.btnCancal.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnCancal.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnCancal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancal.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancal.OnHoverImage = null;
            this.btnCancal.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancal.Size = new System.Drawing.Size(172, 54);
            this.btnCancal.TabIndex = 34;
            this.btnCancal.Text = "Cancel";
            this.btnCancal.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AccountDGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AccountDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AccountDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDGV.BackgroundColor = System.Drawing.Color.White;
            this.AccountDGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountDGV.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AccountDGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AccountDGV.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountDGV.DefaultCellStyle = dataGridViewCellStyle3;
            this.AccountDGV.EnableHeadersVisualStyles = false;
            this.AccountDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AccountDGV.Location = new System.Drawing.Point(111, 587);
            this.AccountDGV.Name = "AccountDGV";
            this.AccountDGV.ReadOnly = true;
            this.AccountDGV.RowHeadersVisible = false;
            this.AccountDGV.RowHeadersWidth = 72;
            this.AccountDGV.RowTemplate.Height = 31;
            this.AccountDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDGV.Size = new System.Drawing.Size(1735, 477);
            this.AccountDGV.TabIndex = 35;
            this.AccountDGV.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.AccountDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AccountDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AccountDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AccountDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AccountDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AccountDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AccountDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AccountDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.AccountDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.AccountDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AccountDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AccountDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AccountDGV.ThemeStyle.HeaderStyle.Height = 4;
            this.AccountDGV.ThemeStyle.ReadOnly = true;
            this.AccountDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AccountDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AccountDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AccountDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AccountDGV.ThemeStyle.RowsStyle.Height = 31;
            this.AccountDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AccountDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AccountDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountDGV_CellContentClick);
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1858, 1064);
            this.Controls.Add(this.AccountDGV);
            this.Controls.Add(this.btnCancal);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.cboEducation);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAccPhone);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAccount";
            this.Text = "AddAccount";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaTextBox txtAccName;
        private Guna.UI.WinForms.GunaTextBox txtAccPhone;
        private Guna.UI.WinForms.GunaTextBox txtOccupation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaTextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaComboBox cboEducation;
        private Guna.UI.WinForms.GunaTextBox txtIncome;
        private Guna.UI.WinForms.GunaComboBox cboGender;
        private Guna.UI.WinForms.GunaGradientTileButton btnSubmit;
        private Guna.UI.WinForms.GunaGradientTileButton btnEdit;
        private Guna.UI.WinForms.GunaGradientTileButton btnCancal;
        private Guna.UI.WinForms.GunaDataGridView AccountDGV;
    }
}