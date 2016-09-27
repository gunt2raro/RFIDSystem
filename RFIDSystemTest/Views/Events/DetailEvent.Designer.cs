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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataCompetitions = new System.Windows.Forms.DataGridView();
            this.bEdit = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bRegiter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompetitions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lIdDescription
            // 
            this.lIdDescription.AutoSize = true;
            this.lIdDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdDescription.Location = new System.Drawing.Point(175, 426);
            this.lIdDescription.Name = "lIdDescription";
            this.lIdDescription.Size = new System.Drawing.Size(161, 29);
            this.lIdDescription.TabIndex = 57;
            this.lIdDescription.Text = "lIdDescription";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(114, 426);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(39, 29);
            this.lId.TabIndex = 56;
            this.lId.Text = "lId";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(69, 475);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(84, 29);
            this.lName.TabIndex = 55;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(180, 473);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(635, 35);
            this.txtName.TabIndex = 54;
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(19, 531);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(141, 29);
            this.lDescription.TabIndex = 59;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Enabled = false;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(180, 527);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(325, 163);
            this.txtDescription.TabIndex = 58;
            // 
            // lDateStart
            // 
            this.lDateStart.AutoSize = true;
            this.lDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateStart.Location = new System.Drawing.Point(176, 697);
            this.lDateStart.Name = "lDateStart";
            this.lDateStart.Size = new System.Drawing.Size(118, 29);
            this.lDateStart.TabIndex = 61;
            this.lDateStart.Text = "lDateStart";
            // 
            // dtDateStart
            // 
            this.dtDateStart.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtDateStart.Enabled = false;
            this.dtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateStart.Location = new System.Drawing.Point(180, 738);
            this.dtDateStart.Name = "dtDateStart";
            this.dtDateStart.Size = new System.Drawing.Size(290, 35);
            this.dtDateStart.TabIndex = 60;
            // 
            // lDateFinish
            // 
            this.lDateFinish.AutoSize = true;
            this.lDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateFinish.Location = new System.Drawing.Point(531, 697);
            this.lDateFinish.Name = "lDateFinish";
            this.lDateFinish.Size = new System.Drawing.Size(134, 29);
            this.lDateFinish.TabIndex = 63;
            this.lDateFinish.Text = "lDateFinish";
            // 
            // dtDateFinish
            // 
            this.dtDateFinish.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtDateFinish.Enabled = false;
            this.dtDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateFinish.Location = new System.Drawing.Point(536, 738);
            this.dtDateFinish.Name = "dtDateFinish";
            this.dtDateFinish.Size = new System.Drawing.Size(279, 35);
            this.dtDateFinish.TabIndex = 62;
            // 
            // lDateLimit
            // 
            this.lDateLimit.AutoSize = true;
            this.lDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDateLimit.Location = new System.Drawing.Point(532, 617);
            this.lDateLimit.Name = "lDateLimit";
            this.lDateLimit.Size = new System.Drawing.Size(120, 29);
            this.lDateLimit.TabIndex = 65;
            this.lDateLimit.Text = "lDateLimit";
            // 
            // dtDateLimit
            // 
            this.dtDateLimit.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.dtDateLimit.Enabled = false;
            this.dtDateLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDateLimit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtDateLimit.Location = new System.Drawing.Point(536, 654);
            this.dtDateLimit.Name = "dtDateLimit";
            this.dtDateLimit.Size = new System.Drawing.Size(279, 35);
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
            this.nudCompetitorsLimit.Location = new System.Drawing.Point(537, 568);
            this.nudCompetitorsLimit.Margin = new System.Windows.Forms.Padding(2);
            this.nudCompetitorsLimit.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudCompetitorsLimit.Name = "nudCompetitorsLimit";
            this.nudCompetitorsLimit.Size = new System.Drawing.Size(94, 35);
            this.nudCompetitorsLimit.TabIndex = 66;
            this.nudCompetitorsLimit.Tag = "";
            // 
            // lCompetitorsLimit
            // 
            this.lCompetitorsLimit.AutoSize = true;
            this.lCompetitorsLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCompetitorsLimit.Location = new System.Drawing.Point(530, 527);
            this.lCompetitorsLimit.Name = "lCompetitorsLimit";
            this.lCompetitorsLimit.Size = new System.Drawing.Size(201, 29);
            this.lCompetitorsLimit.TabIndex = 67;
            this.lCompetitorsLimit.Text = "lCompetitorsLimit";
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(74, 796);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(218, 70);
            this.bCancel.TabIndex = 69;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdate.Location = new System.Drawing.Point(596, 796);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(218, 70);
            this.bUpdate.TabIndex = 68;
            this.bUpdate.Text = "bUpdate";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bDelete
            // 
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.Image = ((System.Drawing.Image)(resources.GetObject("bDelete.Image")));
            this.bDelete.Location = new System.Drawing.Point(622, 82);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(93, 73);
            this.bDelete.TabIndex = 71;
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bEnable
            // 
            this.bEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnable.Image = ((System.Drawing.Image)(resources.GetObject("bEnable.Image")));
            this.bEnable.Location = new System.Drawing.Point(721, 82);
            this.bEnable.Name = "bEnable";
            this.bEnable.Size = new System.Drawing.Size(93, 73);
            this.bEnable.TabIndex = 70;
            this.bEnable.UseVisualStyleBackColor = true;
            this.bEnable.Click += new System.EventHandler(this.bEnable_Click);
            // 
            // dataCompetitions
            // 
            this.dataCompetitions.AllowUserToOrderColumns = true;
            this.dataCompetitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataCompetitions.BackgroundColor = System.Drawing.Color.White;
            this.dataCompetitions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCompetitions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataCompetitions.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataCompetitions.GridColor = System.Drawing.Color.AliceBlue;
            this.dataCompetitions.Location = new System.Drawing.Point(920, 183);
            this.dataCompetitions.MultiSelect = false;
            this.dataCompetitions.Name = "dataCompetitions";
            this.dataCompetitions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataCompetitions.RowTemplate.Height = 28;
            this.dataCompetitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataCompetitions.Size = new System.Drawing.Size(649, 682);
            this.dataCompetitions.TabIndex = 72;
            // 
            // bEdit
            // 
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(928, 82);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(200, 70);
            this.bEdit.TabIndex = 73;
            this.bEdit.Text = "bEdit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(1368, 85);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(201, 70);
            this.bAdd.TabIndex = 74;
            this.bAdd.Text = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(113)))), ((int)(((byte)(139)))));
            this.panel1.Location = new System.Drawing.Point(853, 82);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 784);
            this.panel1.TabIndex = 75;
            // 
            // bRegiter
            // 
            this.bRegiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegiter.Location = new System.Drawing.Point(1160, 85);
            this.bRegiter.Name = "bRegiter";
            this.bRegiter.Size = new System.Drawing.Size(184, 70);
            this.bRegiter.TabIndex = 76;
            this.bRegiter.Text = "bRegister";
            this.bRegiter.UseVisualStyleBackColor = true;
            this.bRegiter.Click += new System.EventHandler(this.bRegiter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(181, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(412, 316);
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // bImage
            // 
            this.bImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImage.Location = new System.Drawing.Point(622, 347);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(192, 50);
            this.bImage.TabIndex = 91;
            this.bImage.Text = "Image";
            this.bImage.UseVisualStyleBackColor = true;
            // 
            // DetailEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bImage);
            this.Controls.Add(this.bRegiter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.dataCompetitions);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DetailEvent";
            this.Size = new System.Drawing.Size(1634, 914);
            this.Load += new System.EventHandler(this.DetailEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCompetitorsLimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCompetitions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.DataGridView dataCompetitions;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bRegiter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bImage;
    }
}
