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
            this.adminDrink1 = new UI.AdminDrink();
            this.SuspendLayout();
            // 
            // adminDrink1
            // 
            this.adminDrink1.BackColor = System.Drawing.Color.White;
            this.adminDrink1.Location = new System.Drawing.Point(-3, 2);
            this.adminDrink1.Margin = new System.Windows.Forms.Padding(4);
            this.adminDrink1.Name = "adminDrink1";
            this.adminDrink1.Size = new System.Drawing.Size(939, 518);
            this.adminDrink1.TabIndex = 3;
            // 
            // edit_Order
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 519);
            this.Controls.Add(this.adminDrink1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit_Order";
            this.Load += new System.EventHandler(this.edit_Order_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private AdminDrink adminDrink1;
    }
}