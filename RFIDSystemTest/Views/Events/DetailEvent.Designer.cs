namespace RFIDSystemTest.Views.Events
{
    partial class DetailEvent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailEvent));
            this.lIdDescription = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lDateStart = new System.Windows.Forms.Label();
            this.dtDateStart = new System.Windows.Forms.DateTimePicker();
            this.lDateFinish = new System.Windows.Forms.Label();
            this.dtDateFinish = new System.Windows.Forms.DateTimePicker();
            this.lDateLimit = new System.Windows.Forms.Label();
            this.dtDateLimit = new System.Windows.Forms.DateTimePicker();
            this.nudCompetitorsLimit = new System.Windows.Forms.NumericUpDown();
            this.lCompetitorsLimit = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEnable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // lIdDescription
            // 
            this.lIdDescription.AutoSize = true;
            this.lIdDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdDescription.Location = new System.Drawing.Point(291, 175);
            this.lIdDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lIdDescription.Name = "lIdDescription";
            this.lIdDescription.Size = new System.Drawing.Size(262, 46);
            this.lIdDescription.TabIndex = 57;
            this.lIdDescription.Text = "lIdDescription";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(183, 175);
            this.lId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(61, 46);
            this.lId.TabIndex = 56;
            this.lId.Text = "lId";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(103, 257);
            this.lName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(135, 46);
            this.lName.TabIndex = 55;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(300, 248);
            this.txtName.Margin = new System.Windows.Forms.Padding(5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(575, 53);
            this.txtName.TabIndex = 54;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(14, 339);
            this.lDescription.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(230, 46);
            this.lDescription.TabIndex = 59;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(300, 332);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(5);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(575, 149);
            this.txtDescription.TabIndex = 58;
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateStart.Location = new System.Drawing.Point(291, 499);
            this.lDateStart.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(197, 46);
            this.lDateStart.TabIndex = 61;
            this.lDateStart.Text = "lDateStart";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateStart.Enabled = false;
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(299, 562);
            this.dtDateStart.Margin = new System.Windows.Forms.Padding(5);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(575, 53);
            this.dtDateStart.TabIndex = 60;
            // 
            // lDateFinish
            // 
            this.lDateFinish.AutoSize = true;
            this.lDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateFinish.Location = new System.Drawing.Point(926, 499);
            this.lDateFinish.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDateFinish.Name = "lDateFinish";
            this.lDateFinish.Size = new System.Drawing.Size(219, 46);
            this.lDateFinish.TabIndex = 63;
            this.lDateFinish.Text = "lDateFinish";
            // 
            // dtDateFinish
            // 
            this.dtDateFinish.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateFinish.Enabled = false;
            this.dtDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFinish.Location = new System.Drawing.Point(934, 562);
            this.dtDateFinish.Margin = new System.Windows.Forms.Padding(5);
            this.dtDateFinish.Name = "dtDateFinish";
            this.dtDateFinish.Size = new System.Drawing.Size(575, 53);
            this.dtDateFinish.TabIndex = 62;
            // 
            // lDateLimit
            // 
            this.lDateLimit.AutoSize = true;
            this.lDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateLimit.Location = new System.Drawing.Point(926, 339);
            this.lDateLimit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lDateLimit.Name = "lDateLimit";
            this.lDateLimit.Size = new System.Drawing.Size(197, 46);
            this.lDateLimit.TabIndex = 65;
            this.lDateLimit.Text = "lDateLimit";
            // 
            // dtDateLimit
            // 
            this.dtDateLimit.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.dtDateLimit.Enabled = false;
            this.dtDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateLimit.Location = new System.Drawing.Point(934, 410);
            this.dtDateLimit.Margin = new System.Windows.Forms.Padding(5);
            this.dtDateLimit.Name = "dtDateLimit";
            this.dtDateLimit.Size = new System.Drawing.Size(575, 53);
            this.dtDateLimit.TabIndex = 64;
            // 
            // nudCompetitorsLimit
            // 
            this.nudCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCompetitorsLimit.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Location = new System.Drawing.Point(934, 248);
            this.nudCompetitorsLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Name = "nudCompetitorsLimit";
            this.nudCompetitorsLimit.Size = new System.Drawing.Size(167, 53);
            this.nudCompetitorsLimit.TabIndex = 66;
            this.nudCompetitorsLimit.Tag = "";
            // 
            // lCompetitorsLimit
            // 
            this.lCompetitorsLimit.AutoSize = true;
            this.lCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorsLimit.Location = new System.Drawing.Point(926, 175);
            this.lCompetitorsLimit.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lCompetitorsLimit.Name = "lCompetitorsLimit";
            this.lCompetitorsLimit.Size = new System.Drawing.Size(329, 46);
            this.lCompetitorsLimit.TabIndex = 67;
            this.lCompetitorsLimit.Text = "lCompetitorsLimit";
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(111, 718);
            this.bCancel.Margin = new System.Windows.Forms.Padding(5);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(388, 108);
            this.bCancel.TabIndex = 69;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(1121, 718);
            this.bUpdate.Margin = new System.Windows.Forms.Padding(5);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(388, 108);
            this.bUpdate.TabIndex = 68;
            this.bUpdate.Text = "bUpdate";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.Image")));
            this.bDelete.Location = new System.Drawing.Point(1413, 36);
            this.bDelete.Margin = new System.Windows.Forms.Padding(5);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(165, 113);
            this.bDelete.TabIndex = 71;
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bEnable
            // 
            this.bEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnable.Image = ((System.Drawing.Image)(resources.GetObject("bEnable.Image")));
            this.bEnable.Location = new System.Drawing.Point(1589, 36);
            this.bEnable.Margin = new System.Windows.Forms.Padding(5);
            this.bEnable.Name = "bEnable";
            this.bEnable.Size = new System.Drawing.Size(165, 113);
            this.bEnable.TabIndex = 70;
            this.bEnable.UseVisualStyleBackColor = true;
            this.bEnable.Click += new System.EventHandler(this.bEnable_Click);
            // 
            // DetailEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEnable);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bUpdate);
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
            this.Controls.Add(this.lIdDescription);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtName);
            this.Name = "DetailEvent";
            this.Size = new System.Drawing.Size(1795, 949);
            this.Load += new System.EventHandler(this.DetailEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lIdDescription;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lDateStart;
        private System.Windows.Forms.DateTimePicker dtDateStart;
        private System.Windows.Forms.Label lDateFinish;
        private System.Windows.Forms.DateTimePicker dtDateFinish;
        private System.Windows.Forms.Label lDateLimit;
        private System.Windows.Forms.DateTimePicker dtDateLimit;
        private System.Windows.Forms.NumericUpDown nudCompetitorsLimit;
        private System.Windows.Forms.Label lCompetitorsLimit;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bEnable;
    }
}
