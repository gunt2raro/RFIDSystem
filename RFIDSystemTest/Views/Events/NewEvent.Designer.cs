namespace RFIDSystemTest.Views.Events
{
    partial class NewEvent
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
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.lCompetitorsLimit = new System.Windows.Forms.Label();
            this.nudCompetitorsLimit = new System.Windows.Forms.NumericUpDown();
            this.lDateLimit = new System.Windows.Forms.Label();
            this.dtDateLimit = new System.Windows.Forms.DateTimePicker();
            this.lDateFinish = new System.Windows.Forms.Label();
            this.dtDateFinish = new System.Windows.Forms.DateTimePicker();
            this.lDateStart = new System.Windows.Forms.Label();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.lDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(133, 742);
            this.bCancel.Margin = new System.Windows.Forms.Padding(5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(388, 108);
            this.bCancel.TabIndex = 87;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(1143, 742);
            this.bAdd.Margin = new System.Windows.Forms.Padding(5);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(388, 108);
            this.bAdd.TabIndex = 86;
            this.bAdd.Text = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lCompetitorsLimit
            // 
            this.lCompetitorsLimit.AutoSize = true;
            this.lCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorsLimit.Location = new System.Drawing.Point(948, 199);
            this.lCompetitorsLimit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lCompetitorsLimit.Name = "lCompetitorsLimit";
            this.lCompetitorsLimit.Size = new System.Drawing.Size(329, 46);
            this.lCompetitorsLimit.TabIndex = 85;
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
            this.nudCompetitorsLimit.Location = new System.Drawing.Point(956, 272);
            this.nudCompetitorsLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Name = "nudCompetitorsLimit";
            this.nudCompetitorsLimit.Size = new System.Drawing.Size(167, 53);
            this.nudCompetitorsLimit.TabIndex = 84;
            this.nudCompetitorsLimit.Tag = "";
            // 
            // lDateLimit
            // 
            this.lDateLimit.AutoSize = true;
            this.lDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateLimit.Location = new System.Drawing.Point(948, 363);
            this.lDateLimit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDateLimit.Name = "lDateLimit";
            this.lDateLimit.Size = new System.Drawing.Size(197, 46);
            this.lDateLimit.TabIndex = 83;
            this.lDateLimit.Text = "lDateLimit";
            // 
            // dtDateLimit
            // 
            this.dtDateLimit.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateLimit.Location = new System.Drawing.Point(956, 434);
            this.dtDateLimit.Margin = new System.Windows.Forms.Padding(5);
            this.dtDateLimit.Name = "dtDateLimit";
            this.dtDateLimit.Size = new System.Drawing.Size(575, 53);
            this.dtDateLimit.TabIndex = 82;
            // 
            // lDateFinish
            // 
            this.lDateFinish.AutoSize = true;
            this.lDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateFinish.Location = new System.Drawing.Point(948, 523);
            this.lDateFinish.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDateFinish.Name = "lDateFinish";
            this.lDateFinish.Size = new System.Drawing.Size(219, 46);
            this.lDateFinish.TabIndex = 81;
            this.lDateFinish.Text = "lDateFinish";
            // 
            // dtDateFinish
            // 
            this.dtDateFinish.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFinish.Location = new System.Drawing.Point(956, 586);
            this.dtDateFinish.Margin = new System.Windows.Forms.Padding(5);
            this.dtDateFinish.Name = "dtDateFinish";
            this.dtDateFinish.Size = new System.Drawing.Size(575, 53);
            this.dtDateFinish.TabIndex = 80;
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateStart.Location = new System.Drawing.Point(313, 523);
            this.lDateStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(197, 46);
            this.lDateStart.TabIndex = 79;
            this.lDateStart.Text = "lDateStart";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(321, 586);
            this.dtDateStart.Margin = new System.Windows.Forms.Padding(5);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(575, 53);
            this.dtDateStart.TabIndex = 78;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(36, 363);
            this.lDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(230, 46);
            this.lDescription.TabIndex = 77;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(322, 356);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(575, 149);
            this.txtDescription.TabIndex = 76;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(125, 281);
            this.lName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(135, 46);
            this.lName.TabIndex = 73;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(322, 272);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(575, 53);
            this.txtName.TabIndex = 72;
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lCompetitorsLimit);
            this.Controls.Add(this.nudCompetitorsLimit);
            this.Controls.Add(this.lDateLimit);
            this.Controls.Add(this.dtDateLimit);
            this.Controls.Add(this.lDateFinish);
            this.Controls.Add(this.dtDateFinish);
            this.Controls.Add(this.lDateStart);
            this.Controls.Add(this.dtDateStart);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtName);
            this.Name = "NewEvent";
            this.Size = new System.Drawing.Size(1854, 986);
            this.Load += new System.EventHandler(this.NewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Label lCompetitorsLimit;
        private System.Windows.Forms.NumericUpDown nudCompetitorsLimit;
        private System.Windows.Forms.Label lDateLimit;
        private System.Windows.Forms.DateTimePicker dtDateLimit;
        private System.Windows.Forms.Label lDateFinish;
        private System.Windows.Forms.DateTimePicker dtDateFinish;
        private System.Windows.Forms.Label lDateStart;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
    }
}
