namespace UI
{
    partial class UserBookTable
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookTable));
            this.Table_flowLayoutPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SuspendLayout();
            // 
            // Table_flowLayoutPanel
            // 
            this.Table_flowLayoutPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.Table_flowLayoutPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Table_flowLayoutPanel.BackgroundImage")));
            this.Table_flowLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Table_flowLayoutPanel.BorderColor = System.Drawing.Color.Transparent;
            this.Table_flowLayoutPanel.BorderRadius = 3;
            this.Table_flowLayoutPanel.BorderThickness = 1;
            this.Table_flowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.Table_flowLayoutPanel.Name = "Table_flowLayoutPanel";
            this.Table_flowLayoutPanel.ShowBorders = true;
            this.Table_flowLayoutPanel.Size = new System.Drawing.Size(704, 486);
            this.Table_flowLayoutPanel.TabIndex = 0;
            // 
            // UserBookTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 510);
            this.Controls.Add(this.Table_flowLayoutPanel);
            this.Name = "UserBookTable";
            this.Text = "UserBookTable";
            this.Load += new System.EventHandler(this.UserBookTable_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel Table_flowLayoutPanel;
    }
}