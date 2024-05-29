namespace UI
{
    partial class TableDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableDetail));
            this.AdminOrderTableLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.lbTableStatus = new System.Windows.Forms.Label();
            this.lbTableName = new System.Windows.Forms.Label();
            this.lbTableID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminOrderTableLabel
            // 
            this.AdminOrderTableLabel.AutoSize = true;
            this.AdminOrderTableLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminOrderTableLabel.Location = new System.Drawing.Point(51, 313);
            this.AdminOrderTableLabel.Name = "AdminOrderTableLabel";
            this.AdminOrderTableLabel.Size = new System.Drawing.Size(81, 23);
            this.AdminOrderTableLabel.TabIndex = 28;
            this.AdminOrderTableLabel.Text = "Table 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 206);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(12, 104);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(522, 206);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox13.TabIndex = 29;
            this.pictureBox13.TabStop = false;
            // 
            // lbTableStatus
            // 
            this.lbTableStatus.AutoSize = true;
            this.lbTableStatus.Location = new System.Drawing.Point(307, 249);
            this.lbTableStatus.Name = "lbTableStatus";
            this.lbTableStatus.Size = new System.Drawing.Size(51, 20);
            this.lbTableStatus.TabIndex = 32;
            this.lbTableStatus.Text = "label1";
            // 
            // lbTableName
            // 
            this.lbTableName.AutoSize = true;
            this.lbTableName.Location = new System.Drawing.Point(307, 190);
            this.lbTableName.Name = "lbTableName";
            this.lbTableName.Size = new System.Drawing.Size(51, 20);
            this.lbTableName.TabIndex = 32;
            this.lbTableName.Text = "label1";
            // 
            // lbTableID
            // 
            this.lbTableID.AutoSize = true;
            this.lbTableID.Location = new System.Drawing.Point(307, 139);
            this.lbTableID.Name = "lbTableID";
            this.lbTableID.Size = new System.Drawing.Size(51, 20);
            this.lbTableID.TabIndex = 32;
            this.lbTableID.Text = "label1";
            // 
            // TableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(703, 438);
            this.Controls.Add(this.lbTableName);
            this.Controls.Add(this.lbTableStatus);
            this.Controls.Add(this.lbTableID);
            this.Controls.Add(this.AdminOrderTableLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox13);
            this.Name = "TableDetail";
            this.Text = "TableDetail";
            this.Load += new System.EventHandler(this.TableDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminOrderTableLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.Label lbTableStatus;
        private System.Windows.Forms.Label lbTableName;
        private System.Windows.Forms.Label lbTableID;
    }
}