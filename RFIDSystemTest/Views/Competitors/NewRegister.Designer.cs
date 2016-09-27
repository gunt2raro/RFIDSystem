namespace RFIDSystemTest.Views.Competitors
{
    partial class NewRegister
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bSearch = new System.Windows.Forms.Button();
            this.dataCompetitors = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.lBirthDate = new System.Windows.Forms.Label();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtSecondName = new System.Windows.Forms.TextBox();
            this.lSecondName = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.lZipCode = new System.Windows.Forms.Label();
            this.lCountry = new System.Windows.Forms.Label();
            this.lState = new System.Windows.Forms.Label();
            this.lCity = new System.Windows.Forms.Label();
            this.lTitCompetitor = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lSex = new System.Windows.Forms.Label();
            this.lAddress2 = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lTeam = new System.Windows.Forms.Label();
            this.cbTeam = new System.Windows.Forms.ComboBox();
            this.bRegisterAnother = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.lRegisterState = new System.Windows.Forms.Label();
            this.cbRegisterState = new System.Windows.Forms.ComboBox();
            this.lCompetitorNumberDes = new System.Windows.Forms.Label();
            this.lCompetitorNumber = new System.Windows.Forms.Label();
            this.lKitState = new System.Windows.Forms.Label();
            this.lCategory = new System.Windows.Forms.Label();
            this.cbKitState = new System.Windows.Forms.ComboBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.lTitRegister = new System.Windows.Forms.Label();
            this.txtCompetitorNum = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompetitors)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(18, 155);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(562, 48);
            this.bSearch.TabIndex = 52;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // dataCompetitors
            // 
            this.dataCompetitors.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCompetitors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataCompetitors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCompetitors.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataCompetitors.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCompetitors.GridColor = System.Drawing.Color.AliceBlue;
            this.dataCompetitors.Location = new System.Drawing.Point(18, 230);
            this.dataCompetitors.MultiSelect = false;
            this.dataCompetitors.Name = "dataCompetitors";
            this.dataCompetitors.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCompetitors.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataCompetitors.RowTemplate.Height = 28;
            this.dataCompetitors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCompetitors.Size = new System.Drawing.Size(562, 638);
            this.dataCompetitors.TabIndex = 51;
            this.dataCompetitors.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCompetitors_CellContentDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(18, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(562, 39);
            this.txtSearch.TabIndex = 53;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(177, 233);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(243, 35);
            this.txtEmail.TabIndex = 61;
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEmail.Location = new System.Drawing.Point(71, 238);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(80, 29);
            this.lEmail.TabIndex = 60;
            this.lEmail.Text = "lEmail";
            // 
            // lBirthDate
            // 
            this.lBirthDate.AutoSize = true;
            this.lBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBirthDate.Location = new System.Drawing.Point(672, 235);
            this.lBirthDate.Name = "lBirthDate";
            this.lBirthDate.Size = new System.Drawing.Size(118, 29);
            this.lBirthDate.TabIndex = 59;
            this.lBirthDate.Text = "lBirthDate";
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.CustomFormat = "yyyy-dd-MM";
            this.dtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBirthDate.Location = new System.Drawing.Point(818, 230);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(243, 35);
            this.dtBirthDate.TabIndex = 58;
            // 
            // txtSecondName
            // 
            this.txtSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondName.Location = new System.Drawing.Point(818, 174);
            this.txtSecondName.Name = "txtSecondName";
            this.txtSecondName.Size = new System.Drawing.Size(243, 35);
            this.txtSecondName.TabIndex = 57;
            // 
            // lSecondName
            // 
            this.lSecondName.AutoSize = true;
            this.lSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSecondName.Location = new System.Drawing.Point(645, 177);
            this.lSecondName.Name = "lSecondName";
            this.lSecondName.Size = new System.Drawing.Size(167, 29);
            this.lSecondName.TabIndex = 56;
            this.lSecondName.Text = "lSecondName";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(699, 123);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(84, 29);
            this.lName.TabIndex = 55;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(818, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(243, 35);
            this.txtName.TabIndex = 54;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(1209, 288);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(242, 35);
            this.txtAddress.TabIndex = 66;
            // 
            // txtZipCode
            // 
            this.txtZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtZipCode.Location = new System.Drawing.Point(568, 292);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(242, 35);
            this.txtZipCode.TabIndex = 65;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(1208, 234);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(243, 35);
            this.txtCountry.TabIndex = 64;
            // 
            // txtState
            // 
            this.txtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtState.Location = new System.Drawing.Point(1208, 171);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(243, 35);
            this.txtState.TabIndex = 63;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(1208, 114);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(243, 35);
            this.txtCity.TabIndex = 62;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddress.Location = new System.Drawing.Point(1085, 290);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(108, 29);
            this.lAddress.TabIndex = 71;
            this.lAddress.Text = "lAddress";
            // 
            // lZipCode
            // 
            this.lZipCode.AutoSize = true;
            this.lZipCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lZipCode.Location = new System.Drawing.Point(442, 294);
            this.lZipCode.Name = "lZipCode";
            this.lZipCode.Size = new System.Drawing.Size(112, 29);
            this.lZipCode.TabIndex = 70;
            this.lZipCode.Text = "lZipCode";
            // 
            // lCountry
            // 
            this.lCountry.AutoSize = true;
            this.lCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCountry.Location = new System.Drawing.Point(1089, 236);
            this.lCountry.Name = "lCountry";
            this.lCountry.Size = new System.Drawing.Size(101, 29);
            this.lCountry.TabIndex = 69;
            this.lCountry.Text = "lCountry";
            // 
            // lState
            // 
            this.lState.AutoSize = true;
            this.lState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lState.Location = new System.Drawing.Point(1118, 174);
            this.lState.Name = "lState";
            this.lState.Size = new System.Drawing.Size(74, 29);
            this.lState.TabIndex = 68;
            this.lState.Text = "lState";
            // 
            // lCity
            // 
            this.lCity.AutoSize = true;
            this.lCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCity.Location = new System.Drawing.Point(1121, 117);
            this.lCity.Name = "lCity";
            this.lCity.Size = new System.Drawing.Size(59, 29);
            this.lCity.TabIndex = 67;
            this.lCity.Text = "lCity";
            // 
            // lTitCompetitor
            // 
            this.lTitCompetitor.AutoSize = true;
            this.lTitCompetitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitCompetitor.Location = new System.Drawing.Point(677, 78);
            this.lTitCompetitor.Name = "lTitCompetitor";
            this.lTitCompetitor.Size = new System.Drawing.Size(132, 29);
            this.lTitCompetitor.TabIndex = 72;
            this.lTitCompetitor.Text = "Competitor";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lSex);
            this.panel1.Controls.Add(this.lAddress2);
            this.panel1.Controls.Add(this.cbSex);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtAddress2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lZipCode);
            this.panel1.Controls.Add(this.txtZipCode);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.lEmail);
            this.panel1.Location = new System.Drawing.Point(640, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 355);
            this.panel1.TabIndex = 73;
            // 
            // lSex
            // 
            this.lSex.AutoSize = true;
            this.lSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSex.Location = new System.Drawing.Point(225, 190);
            this.lSex.Name = "lSex";
            this.lSex.Size = new System.Drawing.Size(60, 29);
            this.lSex.TabIndex = 120;
            this.lSex.Text = "lSex";
            // 
            // lAddress2
            // 
            this.lAddress2.AutoSize = true;
            this.lAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddress2.Location = new System.Drawing.Point(444, 241);
            this.lAddress2.Name = "lAddress2";
            this.lAddress2.Size = new System.Drawing.Size(121, 29);
            this.lAddress2.TabIndex = 80;
            this.lAddress2.Text = "lAddress2";
            // 
            // cbSex
            // 
            this.cbSex.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cbSex.Location = new System.Drawing.Point(310, 182);
            this.cbSex.Margin = new System.Windows.Forms.Padding(2);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(111, 40);
            this.cbSex.TabIndex = 119;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(177, 289);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(243, 35);
            this.txtPhoneNumber.TabIndex = 80;
            // 
            // txtAddress2
            // 
            this.txtAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress2.Location = new System.Drawing.Point(568, 238);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(242, 35);
            this.txtAddress2.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "lPhone";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(139)))));
            this.panel2.Location = new System.Drawing.Point(640, 475);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(834, 27);
            this.panel2.TabIndex = 76;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtCompetitorNum);
            this.panel3.Controls.Add(this.lTeam);
            this.panel3.Controls.Add(this.cbTeam);
            this.panel3.Controls.Add(this.bRegisterAnother);
            this.panel3.Controls.Add(this.bCancel);
            this.panel3.Controls.Add(this.bRegister);
            this.panel3.Controls.Add(this.lRegisterState);
            this.panel3.Controls.Add(this.cbRegisterState);
            this.panel3.Controls.Add(this.lCompetitorNumber);
            this.panel3.Controls.Add(this.lKitState);
            this.panel3.Controls.Add(this.lCategory);
            this.panel3.Controls.Add(this.cbKitState);
            this.panel3.Controls.Add(this.cbCategory);
            this.panel3.Location = new System.Drawing.Point(640, 530);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(834, 351);
            this.panel3.TabIndex = 77;
            // 
            // lTeam
            // 
            this.lTeam.AutoSize = true;
            this.lTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTeam.Location = new System.Drawing.Point(124, 77);
            this.lTeam.Name = "lTeam";
            this.lTeam.Size = new System.Drawing.Size(82, 29);
            this.lTeam.TabIndex = 116;
            this.lTeam.Text = "lTeam";
            // 
            // cbTeam
            // 
            this.cbTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTeam.FormattingEnabled = true;
            this.cbTeam.Location = new System.Drawing.Point(214, 71);
            this.cbTeam.Margin = new System.Windows.Forms.Padding(2);
            this.cbTeam.Name = "cbTeam";
            this.cbTeam.Size = new System.Drawing.Size(325, 40);
            this.cbTeam.TabIndex = 115;
            // 
            // bRegisterAnother
            // 
            this.bRegisterAnother.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegisterAnother.Location = new System.Drawing.Point(591, 154);
            this.bRegisterAnother.Name = "bRegisterAnother";
            this.bRegisterAnother.Size = new System.Drawing.Size(218, 70);
            this.bRegisterAnother.TabIndex = 114;
            this.bRegisterAnother.Text = "bRegisterAnother";
            this.bRegisterAnother.UseVisualStyleBackColor = true;
            this.bRegisterAnother.Click += new System.EventHandler(this.bRegisterAnother_Click);
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(591, 71);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(218, 70);
            this.bCancel.TabIndex = 113;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bRegister
            // 
            this.bRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegister.Location = new System.Drawing.Point(591, 240);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(218, 70);
            this.bRegister.TabIndex = 79;
            this.bRegister.Text = "bRegister";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // lRegisterState
            // 
            this.lRegisterState.AutoSize = true;
            this.lRegisterState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRegisterState.Location = new System.Drawing.Point(44, 275);
            this.lRegisterState.Name = "lRegisterState";
            this.lRegisterState.Size = new System.Drawing.Size(165, 29);
            this.lRegisterState.TabIndex = 112;
            this.lRegisterState.Text = "lRegisterState";
            // 
            // cbRegisterState
            // 
            this.cbRegisterState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRegisterState.FormattingEnabled = true;
            this.cbRegisterState.Location = new System.Drawing.Point(215, 267);
            this.cbRegisterState.Margin = new System.Windows.Forms.Padding(2);
            this.cbRegisterState.Name = "cbRegisterState";
            this.cbRegisterState.Size = new System.Drawing.Size(325, 40);
            this.cbRegisterState.TabIndex = 111;
            // 
            // lCompetitorNumberDes
            // 
            this.lCompetitorNumberDes.AutoSize = true;
            this.lCompetitorNumberDes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorNumberDes.ForeColor = System.Drawing.Color.Red;
            this.lCompetitorNumberDes.Location = new System.Drawing.Point(1206, 499);
            this.lCompetitorNumberDes.Name = "lCompetitorNumberDes";
            this.lCompetitorNumberDes.Size = new System.Drawing.Size(268, 29);
            this.lCompetitorNumberDes.TabIndex = 110;
            this.lCompetitorNumberDes.Text = "lCompetitorNumberDes";
            // 
            // lCompetitorNumber
            // 
            this.lCompetitorNumber.AutoSize = true;
            this.lCompetitorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorNumber.Location = new System.Drawing.Point(314, 18);
            this.lCompetitorNumber.Name = "lCompetitorNumber";
            this.lCompetitorNumber.Size = new System.Drawing.Size(225, 29);
            this.lCompetitorNumber.TabIndex = 79;
            this.lCompetitorNumber.Text = "lCompetitorNumber";
            // 
            // lKitState
            // 
            this.lKitState.AutoSize = true;
            this.lKitState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKitState.Location = new System.Drawing.Point(104, 212);
            this.lKitState.Name = "lKitState";
            this.lKitState.Size = new System.Drawing.Size(102, 29);
            this.lKitState.TabIndex = 109;
            this.lKitState.Text = "lKitState";
            // 
            // lCategory
            // 
            this.lCategory.AutoSize = true;
            this.lCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCategory.Location = new System.Drawing.Point(91, 146);
            this.lCategory.Name = "lCategory";
            this.lCategory.Size = new System.Drawing.Size(116, 29);
            this.lCategory.TabIndex = 79;
            this.lCategory.Text = "lCategory";
            // 
            // cbKitState
            // 
            this.cbKitState.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKitState.FormattingEnabled = true;
            this.cbKitState.Location = new System.Drawing.Point(215, 204);
            this.cbKitState.Margin = new System.Windows.Forms.Padding(2);
            this.cbKitState.Name = "cbKitState";
            this.cbKitState.Size = new System.Drawing.Size(325, 40);
            this.cbKitState.TabIndex = 108;
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(215, 138);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(2);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(325, 40);
            this.cbCategory.TabIndex = 107;
            // 
            // lTitRegister
            // 
            this.lTitRegister.AutoSize = true;
            this.lTitRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitRegister.Location = new System.Drawing.Point(672, 511);
            this.lTitRegister.Name = "lTitRegister";
            this.lTitRegister.Size = new System.Drawing.Size(104, 29);
            this.lTitRegister.TabIndex = 78;
            this.lTitRegister.Text = "Register";
            // 
            // txtCompetitorNum
            // 
            this.txtCompetitorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompetitorNum.Location = new System.Drawing.Point(591, 12);
            this.txtCompetitorNum.Name = "txtCompetitorNum";
            this.txtCompetitorNum.Size = new System.Drawing.Size(218, 35);
            this.txtCompetitorNum.TabIndex = 121;
            // 
            // NewRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lTitRegister);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lTitCompetitor);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.lCountry);
            this.Controls.Add(this.lState);
            this.Controls.Add(this.lCity);
            this.Controls.Add(this.lCompetitorNumberDes);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.lBirthDate);
            this.Controls.Add(this.dtBirthDate);
            this.Controls.Add(this.txtSecondName);
            this.Controls.Add(this.lSecondName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.dataCompetitors);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewRegister";
            this.Size = new System.Drawing.Size(1528, 926);
            this.Load += new System.EventHandler(this.NewRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCompetitors)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridView dataCompetitors;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lBirthDate;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtSecondName;
        private System.Windows.Forms.Label lSecondName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtZipCode;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lZipCode;
        private System.Windows.Forms.Label lCountry;
        private System.Windows.Forms.Label lState;
        private System.Windows.Forms.Label lCity;
        private System.Windows.Forms.Label lTitCompetitor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lTitRegister;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lCompetitorNumberDes;
        private System.Windows.Forms.Label lCompetitorNumber;
        private System.Windows.Forms.Label lKitState;
        private System.Windows.Forms.Label lCategory;
        private System.Windows.Forms.ComboBox cbKitState;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label lRegisterState;
        private System.Windows.Forms.ComboBox cbRegisterState;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bRegisterAnother;
        private System.Windows.Forms.Label lAddress2;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lTeam;
        private System.Windows.Forms.ComboBox cbTeam;
        private System.Windows.Forms.TextBox txtCompetitorNum;
    }
}
