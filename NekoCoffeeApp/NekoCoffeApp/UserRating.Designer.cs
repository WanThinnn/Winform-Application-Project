namespace UI
{
    partial class UserRating
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRating));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.commentsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ratingStars = new Bunifu.UI.WinForms.BunifuRating();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbPeople = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbPoint = new Bunifu.UI.WinForms.BunifuLabel();
            this.AdminOrderTableBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Montserrat Black", 16F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(307, 26);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(115, 29);
            this.bunifuLabel1.TabIndex = 53;
            this.bunifuLabel1.Text = "ĐÁNH GIÁ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(177)))), ((int)(((byte)(60)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(114)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(731, 80);
            this.bunifuGradientPanel1.TabIndex = 89;
            // 
            // commentsFlowLayoutPanel
            // 
            this.commentsFlowLayoutPanel.Location = new System.Drawing.Point(40, 165);
            this.commentsFlowLayoutPanel.Name = "commentsFlowLayoutPanel";
            this.commentsFlowLayoutPanel.Size = new System.Drawing.Size(678, 295);
            this.commentsFlowLayoutPanel.TabIndex = 94;
            // 
            // ratingStars
            // 
            this.ratingStars.BackColor = System.Drawing.Color.Transparent;
            this.ratingStars.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingStars.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.ratingStars.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingStars.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ratingStars.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingStars.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingStars.InnerRadius = 2F;
            this.ratingStars.Location = new System.Drawing.Point(289, 95);
            this.ratingStars.Name = "ratingStars";
            this.ratingStars.OuterRadius = 10F;
            this.ratingStars.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingStars.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingStars.ReadOnly = true;
            this.ratingStars.RightClickToClear = true;
            this.ratingStars.Size = new System.Drawing.Size(121, 22);
            this.ratingStars.TabIndex = 95;
            this.ratingStars.Text = "bunifuRating1";
            this.ratingStars.Value = 2;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 12;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(289, 120);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(24, 24);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 97;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbPeople
            // 
            this.lbPeople.AllowParentOverrides = false;
            this.lbPeople.AutoEllipsis = false;
            this.lbPeople.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbPeople.Location = new System.Drawing.Point(319, 123);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPeople.Size = new System.Drawing.Size(77, 17);
            this.lbPeople.TabIndex = 98;
            this.lbPeople.Text = "100 nhận xét";
            this.lbPeople.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbPeople.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbPoint
            // 
            this.lbPoint.AllowParentOverrides = false;
            this.lbPoint.AutoEllipsis = false;
            this.lbPoint.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbPoint.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lbPoint.Location = new System.Drawing.Point(127, 73);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPoint.Size = new System.Drawing.Size(156, 86);
            this.lbPoint.TabIndex = 99;
            this.lbPoint.Text = "4.9/5";
            this.lbPoint.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbPoint.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // AdminOrderTableBtn
            // 
            this.AdminOrderTableBtn.AllowAnimations = true;
            this.AdminOrderTableBtn.AllowMouseEffects = true;
            this.AdminOrderTableBtn.AllowToggling = false;
            this.AdminOrderTableBtn.AnimationSpeed = 200;
            this.AdminOrderTableBtn.AutoGenerateColors = false;
            this.AdminOrderTableBtn.AutoRoundBorders = false;
            this.AdminOrderTableBtn.AutoSizeLeftIcon = true;
            this.AdminOrderTableBtn.AutoSizeRightIcon = true;
            this.AdminOrderTableBtn.BackColor = System.Drawing.Color.Transparent;
            this.AdminOrderTableBtn.BackColor1 = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminOrderTableBtn.BackgroundImage")));
            this.AdminOrderTableBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminOrderTableBtn.ButtonText = "Nhận xét";
            this.AdminOrderTableBtn.ButtonTextMarginLeft = 0;
            this.AdminOrderTableBtn.ColorContrastOnClick = 45;
            this.AdminOrderTableBtn.ColorContrastOnHover = 45;
            this.AdminOrderTableBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.AdminOrderTableBtn.CustomizableEdges = borderEdges4;
            this.AdminOrderTableBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminOrderTableBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminOrderTableBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminOrderTableBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminOrderTableBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AdminOrderTableBtn.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminOrderTableBtn.ForeColor = System.Drawing.Color.White;
            this.AdminOrderTableBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminOrderTableBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AdminOrderTableBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AdminOrderTableBtn.IconMarginLeft = 11;
            this.AdminOrderTableBtn.IconPadding = 10;
            this.AdminOrderTableBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminOrderTableBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AdminOrderTableBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AdminOrderTableBtn.IconSize = 25;
            this.AdminOrderTableBtn.IdleBorderColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.IdleBorderRadius = 37;
            this.AdminOrderTableBtn.IdleBorderThickness = 1;
            this.AdminOrderTableBtn.IdleFillColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.IdleIconLeftImage = null;
            this.AdminOrderTableBtn.IdleIconRightImage = null;
            this.AdminOrderTableBtn.IndicateFocus = false;
            this.AdminOrderTableBtn.Location = new System.Drawing.Point(432, 101);
            this.AdminOrderTableBtn.Name = "AdminOrderTableBtn";
            this.AdminOrderTableBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminOrderTableBtn.OnDisabledState.BorderRadius = 37;
            this.AdminOrderTableBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminOrderTableBtn.OnDisabledState.BorderThickness = 1;
            this.AdminOrderTableBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminOrderTableBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminOrderTableBtn.OnDisabledState.IconLeftImage = null;
            this.AdminOrderTableBtn.OnDisabledState.IconRightImage = null;
            this.AdminOrderTableBtn.onHoverState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.onHoverState.BorderRadius = 37;
            this.AdminOrderTableBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminOrderTableBtn.onHoverState.BorderThickness = 1;
            this.AdminOrderTableBtn.onHoverState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AdminOrderTableBtn.onHoverState.IconLeftImage = null;
            this.AdminOrderTableBtn.onHoverState.IconRightImage = null;
            this.AdminOrderTableBtn.OnIdleState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.OnIdleState.BorderRadius = 37;
            this.AdminOrderTableBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminOrderTableBtn.OnIdleState.BorderThickness = 1;
            this.AdminOrderTableBtn.OnIdleState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AdminOrderTableBtn.OnIdleState.IconLeftImage = null;
            this.AdminOrderTableBtn.OnIdleState.IconRightImage = null;
            this.AdminOrderTableBtn.OnPressedState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.OnPressedState.BorderRadius = 37;
            this.AdminOrderTableBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminOrderTableBtn.OnPressedState.BorderThickness = 1;
            this.AdminOrderTableBtn.OnPressedState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminOrderTableBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AdminOrderTableBtn.OnPressedState.IconLeftImage = null;
            this.AdminOrderTableBtn.OnPressedState.IconRightImage = null;
            this.AdminOrderTableBtn.Size = new System.Drawing.Size(150, 39);
            this.AdminOrderTableBtn.TabIndex = 100;
            this.AdminOrderTableBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminOrderTableBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminOrderTableBtn.TextMarginLeft = 0;
            this.AdminOrderTableBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AdminOrderTableBtn.UseDefaultRadiusAndThickness = true;
            this.AdminOrderTableBtn.Click += new System.EventHandler(this.AdminOrderTableBtn_Click);
            // 
            // UserRating
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AdminOrderTableBtn);
            this.Controls.Add(this.lbPeople);
            this.Controls.Add(this.ratingStars);
            this.Controls.Add(this.commentsFlowLayoutPanel);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "UserRating";
            this.Size = new System.Drawing.Size(731, 484);
            this.Load += new System.EventHandler(this.UserRating_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.FlowLayoutPanel commentsFlowLayoutPanel;
        private Bunifu.UI.WinForms.BunifuRating ratingStars;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel lbPeople;
        private Bunifu.UI.WinForms.BunifuLabel lbPoint;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AdminOrderTableBtn;
    }
}
