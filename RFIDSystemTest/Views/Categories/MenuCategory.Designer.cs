namespace RFIDSystemTest.Views.Categories
{
    partial class MenuCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuCategory));
            this.bSearch = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSearch.Location = new System.Drawing.Point(150, 490);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(1210, 150);
            this.bSearch.TabIndex = 26;
            this.bSearch.Text = "Search";
            this.bSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.AutoSize = true;
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Image = ((System.Drawing.Image)(resources.GetObject("bNew.Image")));
            this.bNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNew.Location = new System.Drawing.Point(150, 320);
            this.bNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(1210, 150);
            this.bNew.TabIndex = 25;
            this.bNew.Text = "Add new category";
            this.bNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bList
            // 
            this.bList.AutoSize = true;
            this.bList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bList.Image = ((System.Drawing.Image)(resources.GetObject("bList.Image")));
            this.bList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bList.Location = new System.Drawing.Point(150, 150);
            this.bList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(1210, 150);
            this.bList.TabIndex = 24;
            this.bList.Text = "Categories";
            this.bList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // MenuCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bList);
            this.Name = "MenuCategory";
            this.Size = new System.Drawing.Size(1495, 1127);
            this.Load += new System.EventHandler(this.MenuCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bList;
    }
}
