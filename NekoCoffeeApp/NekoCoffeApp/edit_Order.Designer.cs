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
            this.adminDrink1 = new UI.AdminDrink();
            this.SuspendLayout();
            // 
            // adminDrink1
            // 
            this.adminDrink1.BackColor = System.Drawing.Color.White;
            this.adminDrink1.Location = new System.Drawing.Point(-20, -1);
            this.adminDrink1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adminDrink1.Name = "adminDrink1";
            this.adminDrink1.Size = new System.Drawing.Size(1604, 1058);
            this.adminDrink1.TabIndex = 0;
            this.adminDrink1.Load += new System.EventHandler(this.adminDrink1_Load);
            // 
            // edit_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 1050);
            this.Controls.Add(this.adminDrink1);
            this.Name = "edit_Order";
            this.Text = "edit_Order";
            this.ResumeLayout(false);

        }

        #endregion

        private AdminDrink adminDrink1;
    }
}