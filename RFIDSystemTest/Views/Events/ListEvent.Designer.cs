namespace RFIDSystemTest.Views.Events
{
    partial class ListEvent
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bEdit = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pButtons = new System.Windows.Forms.Panel();
            this.bReports = new System.Windows.Forms.Button();
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.pButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // bEdit
            // 
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(386, 34);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(300, 60);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "bEdit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bReturn
            // 
            this.bReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReturn.Location = new System.Drawing.Point(22, 34);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(300, 60);
            this.bReturn.TabIndex = 5;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(724, 34);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(300, 60);
            this.bNew.TabIndex = 7;
            this.bNew.Text = "bNew";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(22, 111);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(300, 60);
            this.bSearch.TabIndex = 8;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(386, 111);
            this.txtSearch.MaximumSize = new System.Drawing.Size(607, 75);
            this.txtSearch.MinimumSize = new System.Drawing.Size(607, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(607, 35);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pButtons
            // 
            this.pButtons.Controls.Add(this.bReports);
            this.pButtons.Controls.Add(this.bSearch);
            this.pButtons.Controls.Add(this.txtSearch);
            this.pButtons.Controls.Add(this.bNew);
            this.pButtons.Controls.Add(this.bReturn);
            this.pButtons.Controls.Add(this.bEdit);
            this.pButtons.Location = new System.Drawing.Point(0, 0);
            this.pButtons.Margin = new System.Windows.Forms.Padding(2);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(1497, 193);
            this.pButtons.TabIndex = 49;
            // 
            // bReports
            // 
            this.bReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReports.Location = new System.Drawing.Point(1044, 34);
            this.bReports.Name = "bReports";
            this.bReports.Size = new System.Drawing.Size(300, 60);
            this.bReports.TabIndex = 49;
            this.bReports.Text = "Reports";
            this.bReports.UseVisualStyleBackColor = true;
            this.bReports.Click += new System.EventHandler(this.bReports_Click);
            // 
            // dgEvents
            // 
            this.dgEvents.AllowUserToOrderColumns = true;
            this.dgEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgEvents.BackgroundColor = System.Drawing.Color.White;
            this.dgEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgEvents.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEvents.GridColor = System.Drawing.Color.AliceBlue;
            this.dgEvents.Location = new System.Drawing.Point(22, 219);
            this.dgEvents.MultiSelect = false;
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgEvents.RowTemplate.Height = 28;
            this.dgEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEvents.Size = new System.Drawing.Size(1720, 573);
            this.dgEvents.TabIndex = 50;
            // 
            // ListEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgEvents);
            this.Controls.Add(this.pButtons);
            this.Name = "ListEvent";
            this.Size = new System.Drawing.Size(1912, 1053);
            this.Load += new System.EventHandler(this.ListEvent_Load);
            this.pButtons.ResumeLayout(false);
            this.pButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSearch;
        public System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button bReports;
        private System.Windows.Forms.DataGridView dgEvents;
    }
}
