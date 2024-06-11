namespace UI
{
    partial class UserBooking
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
            this.Table_flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // Table_flowLayoutPanel
            // 
            this.Table_flowLayoutPanel.Location = new System.Drawing.Point(36, 40);
            this.Table_flowLayoutPanel.Name = "Table_flowLayoutPanel";
            this.Table_flowLayoutPanel.Size = new System.Drawing.Size(630, 329);
            this.Table_flowLayoutPanel.TabIndex = 33;
            // 
            // UserBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Table_flowLayoutPanel);
            this.Name = "UserBooking";
            this.Size = new System.Drawing.Size(700, 479);
            this.Load += new System.EventHandler(this.UserBooking_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Table_flowLayoutPanel;
    }
}
