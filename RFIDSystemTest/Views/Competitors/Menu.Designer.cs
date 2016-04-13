namespace RFIDSystemTest.Views.Competitors
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.bSearch = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSearch.Location = new System.Drawing.Point(150, 660);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(1579, 150);
            this.bSearch.TabIndex = 21;
            this.bSearch.Text = "Search";
            this.bSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // bRegister
            // 
            this.bRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegister.Image = ((System.Drawing.Image)(resources.GetObject("bRegister.Image")));
            this.bRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bRegister.Location = new System.Drawing.Point(150, 490);
            this.bRegister.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(1579, 150);
            this.bRegister.TabIndex = 20;
            this.bRegister.Text = "Register To Event";
            this.bRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Image = ((System.Drawing.Image)(resources.GetObject("bNew.Image")));
            this.bNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNew.Location = new System.Drawing.Point(150, 320);
            this.bNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(1579, 150);
            this.bNew.TabIndex = 19;
            this.bNew.Text = "New Competitor";
            this.bNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bList
            // 
            this.bList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bList.Image = ((System.Drawing.Image)(resources.GetObject("bList.Image")));
            this.bList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bList.Location = new System.Drawing.Point(150, 150);
            this.bList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(1579, 150);
            this.bList.TabIndex = 18;
            this.bList.Text = "Competitors";
            this.bList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bList);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Menu";
            this.Size = new System.Drawing.Size(1877, 896);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bList;
    }
}
