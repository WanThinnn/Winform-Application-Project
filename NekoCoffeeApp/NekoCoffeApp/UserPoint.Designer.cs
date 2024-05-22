namespace UI
{
    partial class UserPoint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPoint));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbPoint = new Bunifu.UI.WinForms.BunifuLabel();
            this.UserViewAllPoint = new System.Windows.Forms.ListView();
            this.btnCheck = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AdminShowEmployee4 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbName = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtPoint = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminShowEmployee4)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuGradientPanel1.TabIndex = 52;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Montserrat Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(267, 24);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(172, 33);
            this.bunifuLabel1.TabIndex = 52;
            this.bunifuLabel1.Text = "Loyalty Point";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbPoint
            // 
            this.lbPoint.AllowParentOverrides = false;
            this.lbPoint.AutoEllipsis = false;
            this.lbPoint.CursorType = null;
            this.lbPoint.Font = new System.Drawing.Font("Montserrat SemiBold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPoint.Location = new System.Drawing.Point(536, 355);
            this.lbPoint.Name = "lbPoint";
            this.lbPoint.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbPoint.Size = new System.Drawing.Size(92, 27);
            this.lbPoint.TabIndex = 84;
            this.lbPoint.Text = "Tổng điểm:";
            this.lbPoint.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbPoint.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UserViewAllPoint
            // 
            this.UserViewAllPoint.HideSelection = false;
            this.UserViewAllPoint.Location = new System.Drawing.Point(18, 100);
            this.UserViewAllPoint.Name = "UserViewAllPoint";
            this.UserViewAllPoint.Size = new System.Drawing.Size(499, 369);
            this.UserViewAllPoint.TabIndex = 88;
            this.UserViewAllPoint.UseCompatibleStateImageBehavior = false;
            // 
            // btnCheck
            // 
            this.btnCheck.AllowAnimations = true;
            this.btnCheck.AllowMouseEffects = true;
            this.btnCheck.AllowToggling = false;
            this.btnCheck.AnimationSpeed = 200;
            this.btnCheck.AutoGenerateColors = false;
            this.btnCheck.AutoRoundBorders = false;
            this.btnCheck.AutoSizeLeftIcon = true;
            this.btnCheck.AutoSizeRightIcon = true;
            this.btnCheck.BackColor = System.Drawing.Color.Transparent;
            this.btnCheck.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.btnCheck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheck.BackgroundImage")));
            this.btnCheck.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheck.ButtonText = "Check";
            this.btnCheck.ButtonTextMarginLeft = 0;
            this.btnCheck.ColorContrastOnClick = 45;
            this.btnCheck.ColorContrastOnHover = 45;
            this.btnCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnCheck.CustomizableEdges = borderEdges2;
            this.btnCheck.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCheck.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheck.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheck.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheck.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnCheck.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(143)))), ((int)(((byte)(94)))));
            this.btnCheck.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnCheck.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnCheck.IconMarginLeft = 11;
            this.btnCheck.IconPadding = 10;
            this.btnCheck.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnCheck.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnCheck.IconSize = 25;
            this.btnCheck.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(143)))), ((int)(((byte)(94)))));
            this.btnCheck.IdleBorderRadius = 40;
            this.btnCheck.IdleBorderThickness = 1;
            this.btnCheck.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.btnCheck.IdleIconLeftImage = null;
            this.btnCheck.IdleIconRightImage = null;
            this.btnCheck.IndicateFocus = false;
            this.btnCheck.Location = new System.Drawing.Point(565, 427);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnCheck.OnDisabledState.BorderRadius = 40;
            this.btnCheck.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheck.OnDisabledState.BorderThickness = 1;
            this.btnCheck.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnCheck.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnCheck.OnDisabledState.IconLeftImage = null;
            this.btnCheck.OnDisabledState.IconRightImage = null;
            this.btnCheck.onHoverState.BorderColor = System.Drawing.Color.Chocolate;
            this.btnCheck.onHoverState.BorderRadius = 40;
            this.btnCheck.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheck.onHoverState.BorderThickness = 1;
            this.btnCheck.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(143)))), ((int)(((byte)(94)))));
            this.btnCheck.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnCheck.onHoverState.IconLeftImage = null;
            this.btnCheck.onHoverState.IconRightImage = null;
            this.btnCheck.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(143)))), ((int)(((byte)(94)))));
            this.btnCheck.OnIdleState.BorderRadius = 40;
            this.btnCheck.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheck.OnIdleState.BorderThickness = 1;
            this.btnCheck.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(225)))));
            this.btnCheck.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(143)))), ((int)(((byte)(94)))));
            this.btnCheck.OnIdleState.IconLeftImage = null;
            this.btnCheck.OnIdleState.IconRightImage = null;
            this.btnCheck.OnPressedState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnCheck.OnPressedState.BorderRadius = 40;
            this.btnCheck.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnCheck.OnPressedState.BorderThickness = 1;
            this.btnCheck.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCheck.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnCheck.OnPressedState.IconLeftImage = null;
            this.btnCheck.OnPressedState.IconRightImage = null;
            this.btnCheck.Size = new System.Drawing.Size(113, 42);
            this.btnCheck.TabIndex = 87;
            this.btnCheck.TabStop = false;
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCheck.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnCheck.TextMarginLeft = 0;
            this.btnCheck.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnCheck.UseDefaultRadiusAndThickness = true;
            // 
            // AdminShowEmployee4
            // 
            this.AdminShowEmployee4.AllowFocused = false;
            this.AdminShowEmployee4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminShowEmployee4.AutoSizeHeight = true;
            this.AdminShowEmployee4.BorderRadius = 85;
            this.AdminShowEmployee4.Image = ((System.Drawing.Image)(resources.GetObject("AdminShowEmployee4.Image")));
            this.AdminShowEmployee4.IsCircle = true;
            this.AdminShowEmployee4.Location = new System.Drawing.Point(546, 135);
            this.AdminShowEmployee4.Name = "AdminShowEmployee4";
            this.AdminShowEmployee4.Size = new System.Drawing.Size(170, 170);
            this.AdminShowEmployee4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AdminShowEmployee4.TabIndex = 53;
            this.AdminShowEmployee4.TabStop = false;
            this.AdminShowEmployee4.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbName
            // 
            this.lbName.AllowParentOverrides = false;
            this.lbName.AutoEllipsis = false;
            this.lbName.CursorType = null;
            this.lbName.Font = new System.Drawing.Font("Montserrat ExtraBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(536, 311);
            this.lbName.Name = "lbName";
            this.lbName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbName.Size = new System.Drawing.Size(180, 25);
            this.lbName.TabIndex = 82;
            this.lbName.Text = "Nguyễn Thị Bunifu";
            this.lbName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtPoint
            // 
            this.txtPoint.AcceptsReturn = false;
            this.txtPoint.AcceptsTab = false;
            this.txtPoint.AnimationSpeed = 200;
            this.txtPoint.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPoint.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPoint.BackColor = System.Drawing.Color.Transparent;
            this.txtPoint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtPoint.BackgroundImage")));
            this.txtPoint.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtPoint.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtPoint.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtPoint.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtPoint.BorderRadius = 1;
            this.txtPoint.BorderThickness = 1;
            this.txtPoint.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPoint.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtPoint.DefaultText = "";
            this.txtPoint.FillColor = System.Drawing.Color.White;
            this.txtPoint.HideSelection = true;
            this.txtPoint.IconLeft = null;
            this.txtPoint.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.IconPadding = 10;
            this.txtPoint.IconRight = null;
            this.txtPoint.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPoint.Lines = new string[0];
            this.txtPoint.Location = new System.Drawing.Point(631, 342);
            this.txtPoint.MaxLength = 32767;
            this.txtPoint.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtPoint.Modified = false;
            this.txtPoint.Multiline = false;
            this.txtPoint.Name = "txtPoint";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPoint.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPoint.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPoint.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtPoint.OnIdleState = stateProperties8;
            this.txtPoint.Padding = new System.Windows.Forms.Padding(3);
            this.txtPoint.PasswordChar = '\0';
            this.txtPoint.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtPoint.PlaceholderText = "";
            this.txtPoint.ReadOnly = true;
            this.txtPoint.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPoint.SelectedText = "";
            this.txtPoint.SelectionLength = 0;
            this.txtPoint.SelectionStart = 0;
            this.txtPoint.ShortcutsEnabled = true;
            this.txtPoint.Size = new System.Drawing.Size(85, 40);
            this.txtPoint.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtPoint.TabIndex = 85;
            this.txtPoint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPoint.TextMarginBottom = 0;
            this.txtPoint.TextMarginLeft = 3;
            this.txtPoint.TextMarginTop = 0;
            this.txtPoint.TextPlaceholder = "";
            this.txtPoint.UseSystemPasswordChar = false;
            this.txtPoint.WordWrap = true;
            // 
            // UserPoint
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.txtPoint);
            this.Controls.Add(this.UserViewAllPoint);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lbPoint);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.AdminShowEmployee4);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Name = "UserPoint";
            this.Size = new System.Drawing.Size(731, 484);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminShowEmployee4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel lbPoint;
        private System.Windows.Forms.ListView UserViewAllPoint;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnCheck;
        private Bunifu.UI.WinForms.BunifuPictureBox AdminShowEmployee4;
        private Bunifu.UI.WinForms.BunifuLabel lbName;
        private Bunifu.UI.WinForms.BunifuTextBox txtPoint;
    }
}
