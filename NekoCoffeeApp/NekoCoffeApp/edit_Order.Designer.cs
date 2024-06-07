namespace UI
{
    partial class edit_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_Order));
            this.AdminMainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SuspendLayout();
            // 
            // AdminMainPanel
            // 
            this.AdminMainPanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.AdminMainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminMainPanel.BackgroundImage")));
            this.AdminMainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminMainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.AdminMainPanel.BorderRadius = 1;
            this.AdminMainPanel.BorderThickness = 1;
            this.AdminMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminMainPanel.Location = new System.Drawing.Point(0, 0);
            this.AdminMainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.AdminMainPanel.Name = "AdminMainPanel";
            this.AdminMainPanel.ShowBorders = true;
            this.AdminMainPanel.Size = new System.Drawing.Size(745, 457);
            this.AdminMainPanel.TabIndex = 2;
            // 
            // edit_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(745, 457);
            this.Controls.Add(this.AdminMainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_Order";
            this.Load += new System.EventHandler(this.edit_Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel AdminMainPanel;
    }
}