namespace RFIDSystemTest.Views.Events
{
    partial class NewCompetition
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
            this.lCompetitorsLimit = new System.Windows.Forms.Label();
            this.nudCompetitorsLimit = new System.Windows.Forms.NumericUpDown();
            this.lDateFinish = new System.Windows.Forms.Label();
            this.dtDateFinish = new System.Windows.Forms.DateTimePicker();
            this.lDateStart = new System.Windows.Forms.Label();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.lDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.lbCategories2 = new System.Windows.Forms.ListBox();
            this.bAC = new System.Windows.Forms.Button();
            this.bRC = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.cbCompetitiontype = new System.Windows.Forms.ComboBox();
            this.lCompetitionType = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.nudCost = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).BeginInit();
            this.SuspendLayout();
            // 
            // lCompetitorsLimit
            // 
            this.lCompetitorsLimit.AutoSize = true;
            this.lCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorsLimit.Location = new System.Drawing.Point(791, 262);
            this.lCompetitorsLimit.Name = "lCompetitorsLimit";
            this.lCompetitorsLimit.Size = new System.Drawing.Size(201, 29);
            this.lCompetitorsLimit.TabIndex = 97;
            this.lCompetitorsLimit.Text = "lCompetitorsLimit";
            // 
            // nudCompetitorsLimit
            // 
            this.nudCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCompetitorsLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Location = new System.Drawing.Point(1023, 260);
            this.nudCompetitorsLimit.Margin = new System.Windows.Forms.Padding(2);
            this.nudCompetitorsLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Name = "nudCompetitorsLimit";
            this.nudCompetitorsLimit.Size = new System.Drawing.Size(119, 35);
            this.nudCompetitorsLimit.TabIndex = 96;
            this.nudCompetitorsLimit.Tag = "";
            // 
            // lDateFinish
            // 
            this.lDateFinish.AutoSize = true;
            this.lDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateFinish.Location = new System.Drawing.Point(1148, 319);
            this.lDateFinish.Name = "lDateFinish";
            this.lDateFinish.Size = new System.Drawing.Size(134, 29);
            this.lDateFinish.TabIndex = 93;
            this.lDateFinish.Text = "lDateFinish";
            // 
            // dtDateFinish
            // 
            this.dtDateFinish.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFinish.Location = new System.Drawing.Point(1153, 360);
            this.dtDateFinish.Name = "dtDateFinish";
            this.dtDateFinish.Size = new System.Drawing.Size(325, 35);
            this.dtDateFinish.TabIndex = 92;
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateStart.Location = new System.Drawing.Point(792, 319);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(118, 29);
            this.lDateStart.TabIndex = 91;
            this.lDateStart.Text = "lDateStart";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(796, 360);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(325, 35);
            this.dtDateStart.TabIndex = 90;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(163, 416);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(141, 29);
            this.lDescription.TabIndex = 89;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(310, 416);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(464, 98);
            this.txtDescription.TabIndex = 88;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(220, 360);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(84, 29);
            this.lName.TabIndex = 87;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(310, 362);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(464, 35);
            this.txtName.TabIndex = 86;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(332, 641);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(218, 70);
            this.bCancel.TabIndex = 99;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(556, 641);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(218, 70);
            this.bAdd.TabIndex = 98;
            this.bAdd.Text = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 32;
            this.lbCategories.Location = new System.Drawing.Point(797, 419);
            this.lbCategories.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(308, 292);
            this.lbCategories.TabIndex = 100;
            // 
            // lbCategories2
            // 
            this.lbCategories2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories2.FormattingEnabled = true;
            this.lbCategories2.ItemHeight = 32;
            this.lbCategories2.Location = new System.Drawing.Point(1194, 419);
            this.lbCategories2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbCategories2.Name = "lbCategories2";
            this.lbCategories2.Size = new System.Drawing.Size(284, 196);
            this.lbCategories2.TabIndex = 101;
            // 
            // bAC
            // 
            this.bAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAC.Location = new System.Drawing.Point(1116, 459);
            this.bAC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAC.Name = "bAC";
            this.bAC.Size = new System.Drawing.Size(60, 54);
            this.bAC.TabIndex = 102;
            this.bAC.Text = ">>";
            this.bAC.UseVisualStyleBackColor = true;
            this.bAC.Click += new System.EventHandler(this.bAC_Click);
            // 
            // bRC
            // 
            this.bRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRC.Location = new System.Drawing.Point(1116, 517);
            this.bRC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bRC.Name = "bRC";
            this.bRC.Size = new System.Drawing.Size(60, 54);
            this.bRC.TabIndex = 103;
            this.bRC.Text = "<<";
            this.bRC.UseVisualStyleBackColor = true;
            this.bRC.Click += new System.EventHandler(this.bRC_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(1194, 657);
            this.bClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(283, 54);
            this.bClear.TabIndex = 104;
            this.bClear.Text = "bClear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bAll
            // 
            this.bAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAll.Location = new System.Drawing.Point(1116, 585);
            this.bAll.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(60, 82);
            this.bAll.TabIndex = 105;
            this.bAll.Text = "bAll";
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // cbCompetitiontype
            // 
            this.cbCompetitiontype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompetitiontype.FormattingEnabled = true;
            this.cbCompetitiontype.Location = new System.Drawing.Point(310, 538);
            this.cbCompetitiontype.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCompetitiontype.Name = "cbCompetitiontype";
            this.cbCompetitiontype.Size = new System.Drawing.Size(464, 40);
            this.cbCompetitiontype.TabIndex = 106;
            // 
            // lCompetitionType
            // 
            this.lCompetitionType.AutoSize = true;
            this.lCompetitionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitionType.Location = new System.Drawing.Point(100, 542);
            this.lCompetitionType.Name = "lCompetitionType";
            this.lCompetitionType.Size = new System.Drawing.Size(204, 29);
            this.lCompetitionType.TabIndex = 107;
            this.lCompetitionType.Text = "lCompetitionType";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(310, 85);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(457, 263);
            this.pictureBox1.TabIndex = 109;
            this.pictureBox1.TabStop = false;
            // 
            // bImage
            // 
            this.bImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImage.Location = new System.Drawing.Point(796, 85);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(346, 50);
            this.bImage.TabIndex = 108;
            this.bImage.Text = "Route";
            this.bImage.UseVisualStyleBackColor = true;
            this.bImage.Click += new System.EventHandler(this.bImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // nudCost
            // 
            this.nudCost.DecimalPlaces = 2;
            this.nudCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCost.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCost.Location = new System.Drawing.Point(1023, 198);
            this.nudCost.Margin = new System.Windows.Forms.Padding(2);
            this.nudCost.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCost.Name = "nudCost";
            this.nudCost.Size = new System.Drawing.Size(119, 35);
            this.nudCost.TabIndex = 110;
            this.nudCost.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 29);
            this.label1.TabIndex = 111;
            this.label1.Text = "Cost";
            // 
            // NewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudCost);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bImage);
            this.Controls.Add(this.lCompetitionType);
            this.Controls.Add(this.cbCompetitiontype);
            this.Controls.Add(this.bAll);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bRC);
            this.Controls.Add(this.bAC);
            this.Controls.Add(this.lbCategories2);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lCompetitorsLimit);
            this.Controls.Add(this.nudCompetitorsLimit);
            this.Controls.Add(this.lDateFinish);
            this.Controls.Add(this.dtDateFinish);
            this.Controls.Add(this.lDateStart);
            this.Controls.Add(this.dtDateStart);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtName);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NewCompetition";
            this.Size = new System.Drawing.Size(1567, 819);
            this.Load += new System.EventHandler(this.NewCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lCompetitorsLimit;
        private System.Windows.Forms.NumericUpDown nudCompetitorsLimit;
        private System.Windows.Forms.Label lDateFinish;
        private System.Windows.Forms.DateTimePicker dtDateFinish;
        private System.Windows.Forms.Label lDateStart;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.ListBox lbCategories2;
        private System.Windows.Forms.Button bAC;
        private System.Windows.Forms.Button bRC;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.ComboBox cbCompetitiontype;
        private System.Windows.Forms.Label lCompetitionType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.NumericUpDown nudCost;
        private System.Windows.Forms.Label label1;
    }
}
