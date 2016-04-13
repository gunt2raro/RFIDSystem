namespace RFIDSystemTest.Views.Categories
{
    partial class NewCategory
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
            this.lDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudAge1 = new System.Windows.Forms.NumericUpDown();
            this.lAges = new System.Windows.Forms.Label();
            this.nudAge2 = new System.Windows.Forms.NumericUpDown();
            this.lTo = new System.Windows.Forms.Label();
            this.cdColorChooser = new System.Windows.Forms.ColorDialog();
            this.bColor = new System.Windows.Forms.Button();
            this.lColorDescription = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge2)).BeginInit();
            this.SuspendLayout();
            // 
            // lDescription
            // 
            this.lDescription.AutoSize = true;
            this.lDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescription.Location = new System.Drawing.Point(164, 292);
            this.lDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescription.Name = "lDescription";
            this.lDescription.Size = new System.Drawing.Size(184, 37);
            this.lDescription.TabIndex = 81;
            this.lDescription.Text = "lDescription";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(379, 286);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(432, 121);
            this.txtDescription.TabIndex = 80;
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lName.Location = new System.Drawing.Point(231, 226);
            this.lName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(110, 37);
            this.lName.TabIndex = 79;
            this.lName.Text = "lName";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(379, 218);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(432, 44);
            this.txtName.TabIndex = 78;
            // 
            // nudAge1
            // 
            this.nudAge1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAge1.Location = new System.Drawing.Point(982, 224);
            this.nudAge1.Margin = new System.Windows.Forms.Padding(2);
            this.nudAge1.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAge1.Name = "nudAge1";
            this.nudAge1.Size = new System.Drawing.Size(125, 44);
            this.nudAge1.TabIndex = 85;
            this.nudAge1.Tag = "";
            // 
            // lAges
            // 
            this.lAges.AutoSize = true;
            this.lAges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAges.Location = new System.Drawing.Point(864, 225);
            this.lAges.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAges.Name = "lAges";
            this.lAges.Size = new System.Drawing.Size(97, 37);
            this.lAges.TabIndex = 86;
            this.lAges.Text = "lAges";
            // 
            // nudAge2
            // 
            this.nudAge2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAge2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudAge2.Location = new System.Drawing.Point(1193, 223);
            this.nudAge2.Margin = new System.Windows.Forms.Padding(2);
            this.nudAge2.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.nudAge2.Name = "nudAge2";
            this.nudAge2.Size = new System.Drawing.Size(125, 44);
            this.nudAge2.TabIndex = 87;
            this.nudAge2.Tag = "";
            // 
            // lTo
            // 
            this.lTo.AutoSize = true;
            this.lTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTo.Location = new System.Drawing.Point(1125, 225);
            this.lTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTo.Name = "lTo";
            this.lTo.Size = new System.Drawing.Size(62, 37);
            this.lTo.TabIndex = 88;
            this.lTo.Text = "lTo";
            // 
            // bColor
            // 
            this.bColor.Location = new System.Drawing.Point(1188, 314);
            this.bColor.Name = "bColor";
            this.bColor.Size = new System.Drawing.Size(130, 59);
            this.bColor.TabIndex = 89;
            this.bColor.Text = "bColor";
            this.bColor.UseVisualStyleBackColor = true;
            this.bColor.Click += new System.EventHandler(this.bColor_Click);
            // 
            // lColorDescription
            // 
            this.lColorDescription.AutoSize = true;
            this.lColorDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lColorDescription.Location = new System.Drawing.Point(861, 322);
            this.lColorDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lColorDescription.Name = "lColorDescription";
            this.lColorDescription.Size = new System.Drawing.Size(261, 37);
            this.lColorDescription.TabIndex = 90;
            this.lColorDescription.Text = "lColorDescription";
            // 
            // bCancel
            // 
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.Location = new System.Drawing.Point(270, 496);
            this.bCancel.Margin = new System.Windows.Forms.Padding(4);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(291, 87);
            this.bCancel.TabIndex = 92;
            this.bCancel.Text = "bCancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bAdd
            // 
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.Location = new System.Drawing.Point(1026, 496);
            this.bAdd.Margin = new System.Windows.Forms.Padding(4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(291, 87);
            this.bAdd.TabIndex = 91;
            this.bAdd.Text = "bAdd";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // NewCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.lColorDescription);
            this.Controls.Add(this.bColor);
            this.Controls.Add(this.lTo);
            this.Controls.Add(this.nudAge2);
            this.Controls.Add(this.lAges);
            this.Controls.Add(this.nudAge1);
            this.Controls.Add(this.lDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.txtName);
            this.Name = "NewCategory";
            this.Size = new System.Drawing.Size(1335, 695);
            this.Load += new System.EventHandler(this.NewCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudAge1;
        private System.Windows.Forms.Label lAges;
        private System.Windows.Forms.NumericUpDown nudAge2;
        private System.Windows.Forms.Label lTo;
        private System.Windows.Forms.ColorDialog cdColorChooser;
        private System.Windows.Forms.Button bColor;
        private System.Windows.Forms.Label lColorDescription;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bAdd;
    }
}
