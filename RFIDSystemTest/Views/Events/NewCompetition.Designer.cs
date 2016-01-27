﻿namespace RFIDSystemTest.Views.Events
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
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // lCompetitorsLimit
            // 
            this.lCompetitorsLimit.AutoSize = true;
            this.lCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorsLimit.Location = new System.Drawing.Point(761, 201);
            this.lCompetitorsLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCompetitorsLimit.Name = "lCompetitorsLimit";
            this.lCompetitorsLimit.Size = new System.Drawing.Size(265, 37);
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
            this.nudCompetitorsLimit.Location = new System.Drawing.Point(1071, 199);
            this.nudCompetitorsLimit.Margin = new System.Windows.Forms.Padding(2);
            this.nudCompetitorsLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Name = "nudCompetitorsLimit";
            this.nudCompetitorsLimit.Size = new System.Drawing.Size(159, 44);
            this.nudCompetitorsLimit.TabIndex = 96;
            this.nudCompetitorsLimit.Tag = "";
            // 
            // lDateFinish
            // 
            this.lDateFinish.AutoSize = true;
            this.lDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateFinish.Location = new System.Drawing.Point(1238, 273);
            this.lDateFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDateFinish.Name = "lDateFinish";
            this.lDateFinish.Size = new System.Drawing.Size(177, 37);
            this.lDateFinish.TabIndex = 93;
            this.lDateFinish.Text = "lDateFinish";
            // 
            // dtDateFinish
            // 
            this.dtDateFinish.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFinish.Location = new System.Drawing.Point(1244, 324);
            this.dtDateFinish.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateFinish.Name = "dtDateFinish";
            this.dtDateFinish.Size = new System.Drawing.Size(432, 44);
            this.dtDateFinish.TabIndex = 92;
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateStart.Location = new System.Drawing.Point(762, 273);
            this.lDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(159, 37);
            this.lDateStart.TabIndex = 91;
            this.lDateStart.Text = "lDateStart";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(768, 324);
            this.dtDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(432, 44);
            this.dtDateStart.TabIndex = 90;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(75, 275);
            this.lDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(184, 37);
            this.lDescription.TabIndex = 89;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(290, 269);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(432, 121);
            this.txtDescription.TabIndex = 88;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(142, 209);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(110, 37);
            this.lName.TabIndex = 87;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(290, 201);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 44);
            this.txtName.TabIndex = 86;
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(149, 675);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(291, 87);
            this.bCancel.TabIndex = 99;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(448, 675);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(291, 87);
            this.bAdd.TabIndex = 98;
            this.bAdd.Text = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lbCategories
            // 
            this.lbCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 45;
            this.lbCategories.Location = new System.Drawing.Point(769, 398);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(409, 364);
            this.lbCategories.TabIndex = 100;
            // 
            // lbCategories2
            // 
            this.lbCategories2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories2.FormattingEnabled = true;
            this.lbCategories2.ItemHeight = 45;
            this.lbCategories2.Location = new System.Drawing.Point(1299, 398);
            this.lbCategories2.Name = "lbCategories2";
            this.lbCategories2.Size = new System.Drawing.Size(377, 274);
            this.lbCategories2.TabIndex = 101;
            // 
            // bAC
            // 
            this.bAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAC.Location = new System.Drawing.Point(1195, 447);
            this.bAC.Name = "bAC";
            this.bAC.Size = new System.Drawing.Size(80, 67);
            this.bAC.TabIndex = 102;
            this.bAC.Text = ">>";
            this.bAC.UseVisualStyleBackColor = true;
            this.bAC.Click += new System.EventHandler(this.bAC_Click);
            // 
            // bRC
            // 
            this.bRC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRC.Location = new System.Drawing.Point(1195, 520);
            this.bRC.Name = "bRC";
            this.bRC.Size = new System.Drawing.Size(80, 67);
            this.bRC.TabIndex = 103;
            this.bRC.Text = "<<";
            this.bRC.UseVisualStyleBackColor = true;
            this.bRC.Click += new System.EventHandler(this.bRC_Click);
            // 
            // bClear
            // 
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClear.Location = new System.Drawing.Point(1299, 695);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(377, 67);
            this.bClear.TabIndex = 104;
            this.bClear.Text = "bClear";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bAll
            // 
            this.bAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAll.Location = new System.Drawing.Point(1195, 605);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(80, 102);
            this.bAll.TabIndex = 105;
            this.bAll.Text = "bAll";
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // cbCompetitiontype
            // 
            this.cbCompetitiontype.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCompetitiontype.FormattingEnabled = true;
            this.cbCompetitiontype.Location = new System.Drawing.Point(290, 421);
            this.cbCompetitiontype.Name = "cbCompetitiontype";
            this.cbCompetitiontype.Size = new System.Drawing.Size(432, 53);
            this.cbCompetitiontype.TabIndex = 106;
            // 
            // lCompetitionType
            // 
            this.lCompetitionType.AutoSize = true;
            this.lCompetitionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitionType.Location = new System.Drawing.Point(18, 431);
            this.lCompetitionType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lCompetitionType.Name = "lCompetitionType";
            this.lCompetitionType.Size = new System.Drawing.Size(265, 37);
            this.lCompetitionType.TabIndex = 107;
            this.lCompetitionType.Text = "lCompetitionType";
            // 
            // NewCompetition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "NewCompetition";
            this.Size = new System.Drawing.Size(1830, 930);
            this.Load += new System.EventHandler(this.NewCompetition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).EndInit();
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
    }
}
