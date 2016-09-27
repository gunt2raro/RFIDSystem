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
            this.bImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUbication = new System.Windows.Forms.TextBox();
            this.lUbication = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lAddress = new System.Windows.Forms.Label();
            this.lEventType = new System.Windows.Forms.Label();
            this.cbEventType = new System.Windows.Forms.ComboBox();
            this.txtOrginizer = new System.Windows.Forms.TextBox();
            this.lOrginizer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(112, 776);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(218, 70);
            this.bCancel.TabIndex = 87;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(1072, 776);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(218, 70);
            this.bAdd.TabIndex = 86;
            this.bAdd.Text = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // lCompetitorsLimit
            // 
            this.lCompetitorsLimit.AutoSize = true;
            this.lCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorsLimit.Location = new System.Drawing.Point(975, 524);
            this.lCompetitorsLimit.Name = "lCompetitorsLimit";
            this.lCompetitorsLimit.Size = new System.Drawing.Size(201, 29);
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
            this.nudCompetitorsLimit.Location = new System.Drawing.Point(980, 579);
            this.nudCompetitorsLimit.Margin = new System.Windows.Forms.Padding(2);
            this.nudCompetitorsLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Name = "nudCompetitorsLimit";
            this.nudCompetitorsLimit.Size = new System.Drawing.Size(94, 35);
            this.nudCompetitorsLimit.TabIndex = 84;
            this.nudCompetitorsLimit.Tag = "";
            // 
            // lDateLimit
            // 
            this.lDateLimit.AutoSize = true;
            this.lDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateLimit.Location = new System.Drawing.Point(605, 524);
            this.lDateLimit.Name = "lDateLimit";
            this.lDateLimit.Size = new System.Drawing.Size(120, 29);
            this.lDateLimit.TabIndex = 83;
            this.lDateLimit.Text = "lDateLimit";
            // 
            // dtDateLimit
            // 
            this.dtDateLimit.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateLimit.Location = new System.Drawing.Point(610, 580);
            this.dtDateLimit.Name = "dtDateLimit";
            this.dtDateLimit.Size = new System.Drawing.Size(325, 35);
            this.dtDateLimit.TabIndex = 82;
            // 
            // lDateFinish
            // 
            this.lDateFinish.AutoSize = true;
            this.lDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateFinish.Location = new System.Drawing.Point(962, 419);
            this.lDateFinish.Name = "lDateFinish";
            this.lDateFinish.Size = new System.Drawing.Size(134, 29);
            this.lDateFinish.TabIndex = 81;
            this.lDateFinish.Text = "lDateFinish";
            // 
            // dtDateFinish
            // 
            this.dtDateFinish.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFinish.Location = new System.Drawing.Point(967, 460);
            this.dtDateFinish.Name = "dtDateFinish";
            this.dtDateFinish.Size = new System.Drawing.Size(325, 35);
            this.dtDateFinish.TabIndex = 80;
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateStart.Location = new System.Drawing.Point(605, 419);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(118, 29);
            this.lDateStart.TabIndex = 79;
            this.lDateStart.Text = "lDateStart";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(610, 460);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(325, 35);
            this.dtDateStart.TabIndex = 78;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(448, 179);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(141, 29);
            this.lDescription.TabIndex = 77;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(610, 174);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(681, 226);
            this.txtDescription.TabIndex = 76;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(499, 126);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(84, 29);
            this.lName.TabIndex = 73;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(610, 120);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(681, 35);
            this.txtName.TabIndex = 72;
            // 
            // bImage
            // 
            this.bImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImage.Location = new System.Drawing.Point(112, 446);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(318, 50);
            this.bImage.TabIndex = 88;
            this.bImage.Text = "Image";
            this.bImage.UseVisualStyleBackColor = true;
            this.bImage.Click += new System.EventHandler(this.bImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(112, 120);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 316);
            this.pictureBox1.TabIndex = 90;
            this.pictureBox1.TabStop = false;
            // 
            // txtUbication
            // 
            this.txtUbication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbication.Location = new System.Drawing.Point(273, 518);
            this.txtUbication.Name = "txtUbication";
            this.txtUbication.Size = new System.Drawing.Size(310, 35);
            this.txtUbication.TabIndex = 91;
            // 
            // lUbication
            // 
            this.lUbication.AutoSize = true;
            this.lUbication.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUbication.Location = new System.Drawing.Point(118, 521);
            this.lUbication.Name = "lUbication";
            this.lUbication.Size = new System.Drawing.Size(120, 29);
            this.lUbication.TabIndex = 92;
            this.lUbication.Text = "lUbication";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(273, 650);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(1019, 35);
            this.txtAddress.TabIndex = 93;
            // 
            // lAddress
            // 
            this.lAddress.AutoSize = true;
            this.lAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAddress.Location = new System.Drawing.Point(118, 653);
            this.lAddress.Name = "lAddress";
            this.lAddress.Size = new System.Drawing.Size(94, 29);
            this.lAddress.TabIndex = 94;
            this.lAddress.Text = "lAdress";
            // 
            // lEventType
            // 
            this.lEventType.AutoSize = true;
            this.lEventType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEventType.Location = new System.Drawing.Point(118, 586);
            this.lEventType.Name = "lEventType";
            this.lEventType.Size = new System.Drawing.Size(134, 29);
            this.lEventType.TabIndex = 96;
            this.lEventType.Text = "lEventType";
            // 
            // cbEventType
            // 
            this.cbEventType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEventType.FormattingEnabled = true;
            this.cbEventType.Location = new System.Drawing.Point(273, 579);
            this.cbEventType.Margin = new System.Windows.Forms.Padding(2);
            this.cbEventType.Name = "cbEventType";
            this.cbEventType.Size = new System.Drawing.Size(310, 40);
            this.cbEventType.TabIndex = 107;
            // 
            // txtOrginizer
            // 
            this.txtOrginizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrginizer.Location = new System.Drawing.Point(273, 708);
            this.txtOrginizer.Name = "txtOrginizer";
            this.txtOrginizer.Size = new System.Drawing.Size(1019, 35);
            this.txtOrginizer.TabIndex = 108;
            // 
            // lOrginizer
            // 
            this.lOrginizer.AutoSize = true;
            this.lOrginizer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOrginizer.Location = new System.Drawing.Point(118, 714);
            this.lOrginizer.Name = "lOrginizer";
            this.lOrginizer.Size = new System.Drawing.Size(118, 29);
            this.lOrginizer.TabIndex = 109;
            this.lOrginizer.Text = "lOrginizer";
            // 
            // NewEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lOrginizer);
            this.Controls.Add(this.txtOrginizer);
            this.Controls.Add(this.cbEventType);
            this.Controls.Add(this.lEventType);
            this.Controls.Add(this.lAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lUbication);
            this.Controls.Add(this.txtUbication);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bImage);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "NewEvent";
            this.Size = new System.Drawing.Size(1401, 863);
            this.Load += new System.EventHandler(this.NewEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button bImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtUbication;
        private System.Windows.Forms.Label lUbication;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lAddress;
        private System.Windows.Forms.Label lEventType;
        private System.Windows.Forms.ComboBox cbEventType;
        private System.Windows.Forms.TextBox txtOrginizer;
        private System.Windows.Forms.Label lOrginizer;
    }
}
