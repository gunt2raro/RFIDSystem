﻿namespace RFIDSystemTest.Views.Events
{
    partial class MenuEvent
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
            this.bList = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bMore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bList
            // 
            this.bList.AutoSize = true;
            this.bList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bList.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bList.Location = new System.Drawing.Point(150, 150);
            this.bList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bList.Name = "bList";
            this.bList.Size = new System.Drawing.Size(1210, 150);
            this.bList.TabIndex = 19;
            this.bList.Text = "Events";
            this.bList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bList.UseVisualStyleBackColor = true;
            this.bList.Click += new System.EventHandler(this.bList_Click);
            // 
            // bNew
            // 
            this.bNew.AutoSize = true;
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bNew.Location = new System.Drawing.Point(150, 320);
            this.bNew.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(1210, 150);
            this.bNew.TabIndex = 20;
            this.bNew.Text = "Add new event";
            this.bNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bSearch.Location = new System.Drawing.Point(150, 490);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(1210, 150);
            this.bSearch.TabIndex = 21;
            this.bSearch.Text = "Search";
            this.bSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bSearch.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(150, 660);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1500, 300);
            this.dataGridView1.TabIndex = 22;
            // 
            // bMore
            // 
            this.bMore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMore.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bMore.Location = new System.Drawing.Point(150, 980);
            this.bMore.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bMore.Name = "bMore";
            this.bMore.Size = new System.Drawing.Size(1210, 75);
            this.bMore.TabIndex = 23;
            this.bMore.Text = "More...";
            this.bMore.UseVisualStyleBackColor = true;
            this.bMore.Click += new System.EventHandler(this.bMore_Click);
            // 
            // MenuEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bMore);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bList);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MenuEvent";
            this.Size = new System.Drawing.Size(1412, 1092);
            this.Load += new System.EventHandler(this.MenuEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bList;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bMore;
    }
}
