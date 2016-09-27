namespace RFIDSystemTest.Views.Events
{
    partial class ReportControl
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
            this.pbDataProgress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGlobal = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lEvent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbGenerating = new System.Windows.Forms.ProgressBar();
            this.lbCompetitions = new System.Windows.Forms.ListBox();
            this.lbCategories = new System.Windows.Forms.ListBox();
            this.nudCHPs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCHPs)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDataProgress
            // 
            this.pbDataProgress.Location = new System.Drawing.Point(210, 550);
            this.pbDataProgress.Name = "pbDataProgress";
            this.pbDataProgress.Size = new System.Drawing.Size(856, 23);
            this.pbDataProgress.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Getting data from db";
            // 
            // cbGlobal
            // 
            this.cbGlobal.AutoSize = true;
            this.cbGlobal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGlobal.Location = new System.Drawing.Point(909, 136);
            this.cbGlobal.Name = "cbGlobal";
            this.cbGlobal.Size = new System.Drawing.Size(110, 33);
            this.cbGlobal.TabIndex = 7;
            this.cbGlobal.Text = "Global";
            this.cbGlobal.UseVisualStyleBackColor = true;
            this.cbGlobal.CheckedChanged += new System.EventHandler(this.cbGlobal_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(909, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 179);
            this.button1.TabIndex = 8;
            this.button1.Text = "Generate Reports";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lEvent
            // 
            this.lEvent.AutoSize = true;
            this.lEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEvent.Location = new System.Drawing.Point(192, 60);
            this.lEvent.Name = "lEvent";
            this.lEvent.Size = new System.Drawing.Size(122, 37);
            this.lEvent.TabIndex = 9;
            this.lEvent.Text = "lEvento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(574, 607);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Generating reports";
            // 
            // pbGenerating
            // 
            this.pbGenerating.Location = new System.Drawing.Point(210, 648);
            this.pbGenerating.Name = "pbGenerating";
            this.pbGenerating.Size = new System.Drawing.Size(856, 23);
            this.pbGenerating.TabIndex = 10;
            // 
            // lbCompetitions
            // 
            this.lbCompetitions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompetitions.FormattingEnabled = true;
            this.lbCompetitions.ItemHeight = 32;
            this.lbCompetitions.Location = new System.Drawing.Point(199, 136);
            this.lbCompetitions.Margin = new System.Windows.Forms.Padding(2);
            this.lbCompetitions.Name = "lbCompetitions";
            this.lbCompetitions.Size = new System.Drawing.Size(302, 292);
            this.lbCompetitions.TabIndex = 101;
            this.lbCompetitions.SelectedIndexChanged += new System.EventHandler(this.lbCompetitions_SelectedIndexChanged);
            // 
            // lbCategories
            // 
            this.lbCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategories.FormattingEnabled = true;
            this.lbCategories.ItemHeight = 32;
            this.lbCategories.Location = new System.Drawing.Point(560, 136);
            this.lbCategories.Margin = new System.Windows.Forms.Padding(2);
            this.lbCategories.Name = "lbCategories";
            this.lbCategories.Size = new System.Drawing.Size(302, 292);
            this.lbCategories.TabIndex = 102;
            // 
            // nudCHPs
            // 
            this.nudCHPs.Location = new System.Drawing.Point(992, 200);
            this.nudCHPs.Name = "nudCHPs";
            this.nudCHPs.Size = new System.Drawing.Size(120, 26);
            this.nudCHPs.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(905, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 104;
            this.label2.Text = "CHPs";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(909, 464);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(206, 26);
            this.txtStartTime.TabIndex = 105;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(905, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 106;
            this.label3.Text = "Start time";
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudCHPs);
            this.Controls.Add(this.lbCategories);
            this.Controls.Add(this.lbCompetitions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbGenerating);
            this.Controls.Add(this.lEvent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbGlobal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pbDataProgress);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(1261, 773);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCHPs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbDataProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbGlobal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lEvent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbGenerating;
        private System.Windows.Forms.ListBox lbCompetitions;
        private System.Windows.Forms.ListBox lbCategories;
        private System.Windows.Forms.NumericUpDown nudCHPs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStartTime;
        private System.Windows.Forms.Label label3;
    }
}
