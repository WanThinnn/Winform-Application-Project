namespace UI
{
    partial class AdminFinancial
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminFinancial));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.AdminFinancialMoney = new Bunifu.UI.WinForms.BunifuPanel();
            this.AdminFinancialMoneyLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.AdminFinancialMoneyImg = new System.Windows.Forms.PictureBox();
            this.AdminFinancialViewTable = new System.Windows.Forms.ListView();
            this.AdminFinancialBank = new Bunifu.UI.WinForms.BunifuPanel();
            this.AdminFinancialBankLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.AdminFinancialBankImg = new System.Windows.Forms.PictureBox();
            this.AdminFinancialView = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AdminFinancialDate = new System.Windows.Forms.DateTimePicker();
            this.AdminFinancialMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminFinancialMoneyImg)).BeginInit();
            this.AdminFinancialBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminFinancialBankImg)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel10.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel10.ForeColor = System.Drawing.Color.LightSalmon;
            this.bunifuLabel10.Location = new System.Drawing.Point(31, 19);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(323, 33);
            this.bunifuLabel10.TabIndex = 35;
            this.bunifuLabel10.Text = "Total in This Shift";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AdminFinancialMoney
            // 
            this.AdminFinancialMoney.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialMoney.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminFinancialMoney.BackgroundImage")));
            this.AdminFinancialMoney.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminFinancialMoney.BorderColor = System.Drawing.Color.Transparent;
            this.AdminFinancialMoney.BorderRadius = 40;
            this.AdminFinancialMoney.BorderThickness = 1;
            this.AdminFinancialMoney.Controls.Add(this.AdminFinancialMoneyLabel);
            this.AdminFinancialMoney.Controls.Add(this.AdminFinancialMoneyImg);
            this.AdminFinancialMoney.Location = new System.Drawing.Point(31, 59);
            this.AdminFinancialMoney.Name = "AdminFinancialMoney";
            this.AdminFinancialMoney.ShowBorders = true;
            this.AdminFinancialMoney.Size = new System.Drawing.Size(1010, 80);
            this.AdminFinancialMoney.TabIndex = 36;
            // 
            // AdminFinancialMoneyLabel
            // 
            this.AdminFinancialMoneyLabel.AllowParentOverrides = false;
            this.AdminFinancialMoneyLabel.AutoEllipsis = false;
            this.AdminFinancialMoneyLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.AdminFinancialMoneyLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.AdminFinancialMoneyLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFinancialMoneyLabel.Location = new System.Drawing.Point(179, 17);
            this.AdminFinancialMoneyLabel.Name = "AdminFinancialMoneyLabel";
            this.AdminFinancialMoneyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminFinancialMoneyLabel.Size = new System.Drawing.Size(54, 44);
            this.AdminFinancialMoneyLabel.TabIndex = 1;
            this.AdminFinancialMoneyLabel.Text = "30 Bills\r\nTotal: \r\n";
            this.AdminFinancialMoneyLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.AdminFinancialMoneyLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AdminFinancialMoneyImg
            // 
            this.AdminFinancialMoneyImg.Image = ((System.Drawing.Image)(resources.GetObject("AdminFinancialMoneyImg.Image")));
            this.AdminFinancialMoneyImg.Location = new System.Drawing.Point(0, 0);
            this.AdminFinancialMoneyImg.Name = "AdminFinancialMoneyImg";
            this.AdminFinancialMoneyImg.Size = new System.Drawing.Size(152, 80);
            this.AdminFinancialMoneyImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminFinancialMoneyImg.TabIndex = 0;
            this.AdminFinancialMoneyImg.TabStop = false;
            // 
            // AdminFinancialViewTable
            // 
            this.AdminFinancialViewTable.HideSelection = false;
            this.AdminFinancialViewTable.Location = new System.Drawing.Point(31, 268);
            this.AdminFinancialViewTable.Name = "AdminFinancialViewTable";
            this.AdminFinancialViewTable.Size = new System.Drawing.Size(1010, 411);
            this.AdminFinancialViewTable.TabIndex = 38;
            this.AdminFinancialViewTable.UseCompatibleStateImageBehavior = false;
            // 
            // AdminFinancialBank
            // 
            this.AdminFinancialBank.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialBank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminFinancialBank.BackgroundImage")));
            this.AdminFinancialBank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdminFinancialBank.BorderColor = System.Drawing.Color.Transparent;
            this.AdminFinancialBank.BorderRadius = 40;
            this.AdminFinancialBank.BorderThickness = 1;
            this.AdminFinancialBank.Controls.Add(this.AdminFinancialBankLabel);
            this.AdminFinancialBank.Controls.Add(this.AdminFinancialBankImg);
            this.AdminFinancialBank.Location = new System.Drawing.Point(31, 145);
            this.AdminFinancialBank.Name = "AdminFinancialBank";
            this.AdminFinancialBank.ShowBorders = true;
            this.AdminFinancialBank.Size = new System.Drawing.Size(1010, 80);
            this.AdminFinancialBank.TabIndex = 37;
            // 
            // AdminFinancialBankLabel
            // 
            this.AdminFinancialBankLabel.AllowParentOverrides = false;
            this.AdminFinancialBankLabel.AutoEllipsis = false;
            this.AdminFinancialBankLabel.CursorType = null;
            this.AdminFinancialBankLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFinancialBankLabel.Location = new System.Drawing.Point(179, 18);
            this.AdminFinancialBankLabel.Name = "AdminFinancialBankLabel";
            this.AdminFinancialBankLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AdminFinancialBankLabel.Size = new System.Drawing.Size(54, 44);
            this.AdminFinancialBankLabel.TabIndex = 1;
            this.AdminFinancialBankLabel.Text = "30 Bills\r\nTotal: \r\n";
            this.AdminFinancialBankLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.AdminFinancialBankLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AdminFinancialBankImg
            // 
            this.AdminFinancialBankImg.Image = ((System.Drawing.Image)(resources.GetObject("AdminFinancialBankImg.Image")));
            this.AdminFinancialBankImg.Location = new System.Drawing.Point(0, 0);
            this.AdminFinancialBankImg.Name = "AdminFinancialBankImg";
            this.AdminFinancialBankImg.Size = new System.Drawing.Size(152, 80);
            this.AdminFinancialBankImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AdminFinancialBankImg.TabIndex = 0;
            this.AdminFinancialBankImg.TabStop = false;
            // 
            // AdminFinancialView
            // 
            this.AdminFinancialView.AllowAnimations = true;
            this.AdminFinancialView.AllowMouseEffects = true;
            this.AdminFinancialView.AllowToggling = false;
            this.AdminFinancialView.AnimationSpeed = 200;
            this.AdminFinancialView.AutoGenerateColors = false;
            this.AdminFinancialView.AutoRoundBorders = false;
            this.AdminFinancialView.AutoSizeLeftIcon = true;
            this.AdminFinancialView.AutoSizeRightIcon = true;
            this.AdminFinancialView.BackColor = System.Drawing.Color.Transparent;
            this.AdminFinancialView.BackColor1 = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminFinancialView.BackgroundImage")));
            this.AdminFinancialView.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminFinancialView.ButtonText = "VIEW";
            this.AdminFinancialView.ButtonTextMarginLeft = 0;
            this.AdminFinancialView.ColorContrastOnClick = 45;
            this.AdminFinancialView.ColorContrastOnHover = 45;
            this.AdminFinancialView.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AdminFinancialView.CustomizableEdges = borderEdges1;
            this.AdminFinancialView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminFinancialView.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminFinancialView.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminFinancialView.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminFinancialView.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AdminFinancialView.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFinancialView.ForeColor = System.Drawing.Color.White;
            this.AdminFinancialView.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminFinancialView.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AdminFinancialView.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AdminFinancialView.IconMarginLeft = 11;
            this.AdminFinancialView.IconPadding = 10;
            this.AdminFinancialView.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminFinancialView.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AdminFinancialView.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AdminFinancialView.IconSize = 25;
            this.AdminFinancialView.IdleBorderColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.IdleBorderRadius = 37;
            this.AdminFinancialView.IdleBorderThickness = 1;
            this.AdminFinancialView.IdleFillColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.IdleIconLeftImage = null;
            this.AdminFinancialView.IdleIconRightImage = null;
            this.AdminFinancialView.IndicateFocus = false;
            this.AdminFinancialView.Location = new System.Drawing.Point(435, 226);
            this.AdminFinancialView.Name = "AdminFinancialView";
            this.AdminFinancialView.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminFinancialView.OnDisabledState.BorderRadius = 37;
            this.AdminFinancialView.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminFinancialView.OnDisabledState.BorderThickness = 1;
            this.AdminFinancialView.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminFinancialView.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminFinancialView.OnDisabledState.IconLeftImage = null;
            this.AdminFinancialView.OnDisabledState.IconRightImage = null;
            this.AdminFinancialView.onHoverState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.onHoverState.BorderRadius = 37;
            this.AdminFinancialView.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminFinancialView.onHoverState.BorderThickness = 1;
            this.AdminFinancialView.onHoverState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AdminFinancialView.onHoverState.IconLeftImage = null;
            this.AdminFinancialView.onHoverState.IconRightImage = null;
            this.AdminFinancialView.OnIdleState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.OnIdleState.BorderRadius = 37;
            this.AdminFinancialView.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminFinancialView.OnIdleState.BorderThickness = 1;
            this.AdminFinancialView.OnIdleState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AdminFinancialView.OnIdleState.IconLeftImage = null;
            this.AdminFinancialView.OnIdleState.IconRightImage = null;
            this.AdminFinancialView.OnPressedState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.OnPressedState.BorderRadius = 37;
            this.AdminFinancialView.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminFinancialView.OnPressedState.BorderThickness = 1;
            this.AdminFinancialView.OnPressedState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminFinancialView.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AdminFinancialView.OnPressedState.IconLeftImage = null;
            this.AdminFinancialView.OnPressedState.IconRightImage = null;
            this.AdminFinancialView.Size = new System.Drawing.Size(105, 37);
            this.AdminFinancialView.TabIndex = 8;
            this.AdminFinancialView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminFinancialView.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminFinancialView.TextMarginLeft = 0;
            this.AdminFinancialView.TextPadding = new System.Windows.Forms.Padding(0);
            this.AdminFinancialView.UseDefaultRadiusAndThickness = true;
            // 
            // AdminFinancialDate
            // 
            this.AdminFinancialDate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFinancialDate.Location = new System.Drawing.Point(31, 231);
            this.AdminFinancialDate.Name = "AdminFinancialDate";
            this.AdminFinancialDate.Size = new System.Drawing.Size(364, 27);
            this.AdminFinancialDate.TabIndex = 39;
            // 
            // AdminFinancial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AdminFinancialDate);
            this.Controls.Add(this.AdminFinancialView);
            this.Controls.Add(this.AdminFinancialBank);
            this.Controls.Add(this.AdminFinancialViewTable);
            this.Controls.Add(this.AdminFinancialMoney);
            this.Controls.Add(this.bunifuLabel10);
            this.Name = "AdminFinancial";
            this.Size = new System.Drawing.Size(1069, 705);
            this.AdminFinancialMoney.ResumeLayout(false);
            this.AdminFinancialMoney.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminFinancialMoneyImg)).EndInit();
            this.AdminFinancialBank.ResumeLayout(false);
            this.AdminFinancialBank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminFinancialBankImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel AdminFinancialMoney;
        private System.Windows.Forms.PictureBox AdminFinancialMoneyImg;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuLabel AdminFinancialMoneyLabel;
        private Bunifu.UI.WinForms.BunifuPanel AdminFinancialBank;
        private Bunifu.UI.WinForms.BunifuLabel AdminFinancialBankLabel;
        private System.Windows.Forms.PictureBox AdminFinancialBankImg;
        private System.Windows.Forms.ListView AdminFinancialViewTable;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AdminFinancialView;
        private System.Windows.Forms.DateTimePicker AdminFinancialDate;
    }
}
