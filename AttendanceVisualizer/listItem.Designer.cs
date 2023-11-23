namespace AttendanceVisualizer
{
    partial class listItem
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
            this.lblTimePanel = new System.Windows.Forms.Panel();
            this.lblDayNumber = new System.Windows.Forms.Label();
            this.statusColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTimePanel
            // 
            this.lblTimePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblTimePanel.Location = new System.Drawing.Point(61, 10);
            this.lblTimePanel.Name = "lblTimePanel";
            this.lblTimePanel.Size = new System.Drawing.Size(968, 35);
            this.lblTimePanel.TabIndex = 0;
            // 
            // lblDayNumber
            // 
            this.lblDayNumber.AutoSize = true;
            this.lblDayNumber.Location = new System.Drawing.Point(7, 64);
            this.lblDayNumber.Name = "lblDayNumber";
            this.lblDayNumber.Size = new System.Drawing.Size(62, 13);
            this.lblDayNumber.TabIndex = 1;
            this.lblDayNumber.Text = "dayNumber";
            this.lblDayNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusColor
            // 
            this.statusColor.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.statusColor.Location = new System.Drawing.Point(10, 10);
            this.statusColor.Name = "statusColor";
            this.statusColor.Size = new System.Drawing.Size(29, 23);
            this.statusColor.TabIndex = 2;
            // 
            // listItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.statusColor);
            this.Controls.Add(this.lblDayNumber);
            this.Controls.Add(this.lblTimePanel);
            this.Name = "listItem";
            this.Size = new System.Drawing.Size(1029, 84);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel lblTimePanel;
        private System.Windows.Forms.Label lblDayNumber;
        private System.Windows.Forms.Panel statusColor;
    }
}
