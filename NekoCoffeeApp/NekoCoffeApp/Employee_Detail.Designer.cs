namespace UI
{
    partial class EmployeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetail));
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbEmployeeShift = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbEmployeeShift);
            this.bunifuPanel1.Controls.Add(this.lbEmployeeName);
            this.bunifuPanel1.Controls.Add(this.lbEmployeeID);
            this.bunifuPanel1.Controls.Add(this.bunifuPictureBox2);
            this.bunifuPanel1.Location = new System.Drawing.Point(60, 119);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(499, 197);
            this.bunifuPanel1.TabIndex = 3;
            // 
            // lbEmployeeShift
            // 
            this.lbEmployeeShift.AutoSize = true;
            this.lbEmployeeShift.Location = new System.Drawing.Point(233, 130);
            this.lbEmployeeShift.Name = "lbEmployeeShift";
            this.lbEmployeeShift.Size = new System.Drawing.Size(51, 20);
            this.lbEmployeeShift.TabIndex = 1;
            this.lbEmployeeShift.Text = "label1";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Location = new System.Drawing.Point(233, 94);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(51, 20);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "label1";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Location = new System.Drawing.Point(233, 57);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(51, 20);
            this.lbEmployeeID.TabIndex = 1;
            this.lbEmployeeID.Text = "label1";
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 46;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(110, 57);
            this.bunifuPictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(93, 93);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "EmployeeDetail";
            this.Text = "Employee_Detail";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
        private System.Windows.Forms.Label lbEmployeeShift;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label lbEmployeeID;
    }
}