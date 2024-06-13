namespace UI
{
    partial class AdminItems
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
            this.itemsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // itemsFlowLayoutPanel
            // 
            this.itemsFlowLayoutPanel.AutoScroll = true;
            this.itemsFlowLayoutPanel.Location = new System.Drawing.Point(13, 42);
            this.itemsFlowLayoutPanel.Name = "itemsFlowLayoutPanel";
            this.itemsFlowLayoutPanel.Size = new System.Drawing.Size(705, 412);
            this.itemsFlowLayoutPanel.TabIndex = 93;
            // 
            // AdminItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.itemsFlowLayoutPanel);
            this.Name = "AdminItems";
            this.Size = new System.Drawing.Size(731, 484);
            this.Load += new System.EventHandler(this.AdminItems_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel itemsFlowLayoutPanel;
    }
}
