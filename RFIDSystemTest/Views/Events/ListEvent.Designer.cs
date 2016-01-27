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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bEdit = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.dataEvents = new System.Windows.Forms.DataGridView();
            this.bNew = new System.Windows.Forms.Button();
            this.bSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // bEdit
            // 
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(558, 150);
            this.bEdit.Margin = new System.Windows.Forms.Padding(4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(400, 75);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "bEdit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bReturn
            // 
            this.bReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReturn.Location = new System.Drawing.Point(150, 150);
            this.bReturn.Margin = new System.Windows.Forms.Padding(4);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(400, 75);
            this.bReturn.TabIndex = 5;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // dataEvents
            // 
            this.dataEvents.AllowUserToOrderColumns = true;
            this.dataEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEvents.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataEvents.GridColor = System.Drawing.Color.AliceBlue;
            this.dataEvents.Location = new System.Drawing.Point(150, 340);
            this.dataEvents.Margin = new System.Windows.Forms.Padding(4);
            this.dataEvents.MultiSelect = false;
            this.dataEvents.Name = "dataEvents";
            this.dataEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataEvents.RowTemplate.Height = 28;
            this.dataEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEvents.Size = new System.Drawing.Size(1572, 665);
            this.dataEvents.TabIndex = 4;
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(966, 150);
            this.bNew.Margin = new System.Windows.Forms.Padding(4);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(400, 75);
            this.bNew.TabIndex = 7;
            this.bNew.Text = "bNew";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bSearch
            // 
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.Location = new System.Drawing.Point(966, 248);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(400, 75);
            this.bSearch.TabIndex = 8;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(150, 267);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.MaximumSize = new System.Drawing.Size(808, 75);
            this.txtSearch.MinimumSize = new System.Drawing.Size(808, 75);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(808, 44);
            this.txtSearch.TabIndex = 48;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ListEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.dataEvents);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ListEvent";
            this.Size = new System.Drawing.Size(1572, 790);
            this.Load += new System.EventHandler(this.ListEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.DataGridView dataEvents;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bSearch;
        public System.Windows.Forms.TextBox txtSearch;
    }
}
