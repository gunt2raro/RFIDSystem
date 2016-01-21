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
            this.dataEvents = new System.Windows.Forms.DataGridView();
            this.bNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // bEdit
            // 
            this.bEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEdit.Location = new System.Drawing.Point(1309, 32);
            this.bEdit.Margin = new System.Windows.Forms.Padding(5);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(385, 91);
            this.bEdit.TabIndex = 6;
            this.bEdit.Text = "bEdit";
            this.bEdit.UseVisualStyleBackColor = true;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            // 
            // bReturn
            // 
            this.bReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReturn.Location = new System.Drawing.Point(0, 32);
            this.bReturn.Margin = new System.Windows.Forms.Padding(5);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(531, 91);
            this.bReturn.TabIndex = 5;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            this.bReturn.Click += new System.EventHandler(this.bReturn_Click);
            // 
            // dataEvents
            // 
            this.dataEvents.AllowUserToOrderColumns = true;
            this.dataEvents.BackgroundColor = System.Drawing.Color.White;
            this.dataEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataEvents.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataEvents.GridColor = System.Drawing.Color.AliceBlue;
            this.dataEvents.Location = new System.Drawing.Point(0, 151);
            this.dataEvents.Margin = new System.Windows.Forms.Padding(5);
            this.dataEvents.MultiSelect = false;
            this.dataEvents.Name = "dataEvents";
            this.dataEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataEvents.RowTemplate.Height = 28;
            this.dataEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataEvents.Size = new System.Drawing.Size(2096, 824);
            this.dataEvents.TabIndex = 4;
            // 
            // bNew
            // 
            this.bNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNew.Location = new System.Drawing.Point(1704, 32);
            this.bNew.Margin = new System.Windows.Forms.Padding(5);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(373, 88);
            this.bNew.TabIndex = 7;
            this.bNew.Text = "bNew";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // ListEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.dataEvents);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ListEvent";
            this.Size = new System.Drawing.Size(2096, 980);
            this.Load += new System.EventHandler(this.ListEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.DataGridView dataEvents;
        private System.Windows.Forms.Button bNew;
    }
}
