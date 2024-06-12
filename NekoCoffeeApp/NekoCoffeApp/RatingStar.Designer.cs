namespace UI
{
    partial class RatingStar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RatingStar));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ratingStars = new Bunifu.UI.WinForms.BunifuRating();
            this.btnSend = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.tbComment = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(128, 2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(150, 138);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox10.TabIndex = 21;
            this.pictureBox10.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 51);
            this.label1.TabIndex = 22;
            this.label1.Text = "Vui lòng đánh giá mức độ hài lòng\r\ncủa bạn đối với Neko Coffee.\r\nChúng tôi sẽ ghi" +
    " nhận và sửa chữa.\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.ratingStars.Location = new System.Drawing.Point(117, 189);
            this.ratingStars.Name = "ratingStars";
            this.ratingStars.OuterRadius = 15F;
            this.ratingStars.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingStars.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.ratingStars.ReadOnly = false;
            this.ratingStars.RightClickToClear = true;
            this.ratingStars.Size = new System.Drawing.Size(171, 32);
            this.ratingStars.TabIndex = 23;
            this.ratingStars.Text = "bunifuRating1";
            this.ratingStars.Value = 0;
            // 
            // btnSend
            // 
            this.btnSend.AllowAnimations = true;
            this.btnSend.AllowMouseEffects = true;
            this.btnSend.AllowToggling = false;
            this.btnSend.AnimationSpeed = 200;
            this.btnSend.AutoGenerateColors = false;
            this.btnSend.AutoRoundBorders = false;
            this.btnSend.AutoSizeLeftIcon = true;
            this.btnSend.AutoSizeRightIcon = true;
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackColor1 = System.Drawing.Color.LightSalmon;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.ButtonText = "Nhận xét";
            this.btnSend.ButtonTextMarginLeft = 0;
            this.btnSend.ColorContrastOnClick = 45;
            this.btnSend.ColorContrastOnHover = 45;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSend.CustomizableEdges = borderEdges1;
            this.btnSend.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSend.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSend.IconMarginLeft = 11;
            this.btnSend.IconPadding = 10;
            this.btnSend.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSend.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSend.IconSize = 25;
            this.btnSend.IdleBorderColor = System.Drawing.Color.LightSalmon;
            this.btnSend.IdleBorderRadius = 37;
            this.btnSend.IdleBorderThickness = 1;
            this.btnSend.IdleFillColor = System.Drawing.Color.LightSalmon;
            this.btnSend.IdleIconLeftImage = null;
            this.btnSend.IdleIconRightImage = null;
            this.btnSend.IndicateFocus = false;
            this.btnSend.Location = new System.Drawing.Point(142, 291);
            this.btnSend.Name = "btnSend";
            this.btnSend.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSend.OnDisabledState.BorderRadius = 37;
            this.btnSend.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.OnDisabledState.BorderThickness = 1;
            this.btnSend.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSend.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSend.OnDisabledState.IconLeftImage = null;
            this.btnSend.OnDisabledState.IconRightImage = null;
            this.btnSend.onHoverState.BorderColor = System.Drawing.Color.LightSalmon;
            this.btnSend.onHoverState.BorderRadius = 37;
            this.btnSend.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.onHoverState.BorderThickness = 1;
            this.btnSend.onHoverState.FillColor = System.Drawing.Color.LightSalmon;
            this.btnSend.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.btnSend.onHoverState.IconLeftImage = null;
            this.btnSend.onHoverState.IconRightImage = null;
            this.btnSend.OnIdleState.BorderColor = System.Drawing.Color.LightSalmon;
            this.btnSend.OnIdleState.BorderRadius = 37;
            this.btnSend.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.OnIdleState.BorderThickness = 1;
            this.btnSend.OnIdleState.FillColor = System.Drawing.Color.LightSalmon;
            this.btnSend.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnSend.OnIdleState.IconLeftImage = null;
            this.btnSend.OnIdleState.IconRightImage = null;
            this.btnSend.OnPressedState.BorderColor = System.Drawing.Color.LightSalmon;
            this.btnSend.OnPressedState.BorderRadius = 37;
            this.btnSend.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSend.OnPressedState.BorderThickness = 1;
            this.btnSend.OnPressedState.FillColor = System.Drawing.Color.LightSalmon;
            this.btnSend.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSend.OnPressedState.IconLeftImage = null;
            this.btnSend.OnPressedState.IconRightImage = null;
            this.btnSend.Size = new System.Drawing.Size(123, 39);
            this.btnSend.TabIndex = 95;
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSend.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSend.TextMarginLeft = 0;
            this.btnSend.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSend.UseDefaultRadiusAndThickness = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbComment
            // 
            this.tbComment.AcceptsReturn = false;
            this.tbComment.AcceptsTab = false;
            this.tbComment.AnimationSpeed = 200;
            this.tbComment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbComment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbComment.BackColor = System.Drawing.Color.Transparent;
            this.tbComment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbComment.BackgroundImage")));
            this.tbComment.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbComment.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbComment.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbComment.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbComment.BorderRadius = 1;
            this.tbComment.BorderThickness = 1;
            this.tbComment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbComment.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComment.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.tbComment.DefaultText = "";
            this.tbComment.FillColor = System.Drawing.Color.White;
            this.tbComment.HideSelection = true;
            this.tbComment.IconLeft = null;
            this.tbComment.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComment.IconPadding = 10;
            this.tbComment.IconRight = null;
            this.tbComment.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbComment.Lines = new string[0];
            this.tbComment.Location = new System.Drawing.Point(28, 236);
            this.tbComment.MaxLength = 32767;
            this.tbComment.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbComment.Modified = false;
            this.tbComment.Multiline = false;
            this.tbComment.Name = "tbComment";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbComment.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbComment.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbComment.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbComment.OnIdleState = stateProperties4;
            this.tbComment.Padding = new System.Windows.Forms.Padding(3);
            this.tbComment.PasswordChar = '\0';
            this.tbComment.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbComment.PlaceholderText = "Nhập đánh giá và góp ý của bạn";
            this.tbComment.ReadOnly = false;
            this.tbComment.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbComment.SelectedText = "";
            this.tbComment.SelectionLength = 0;
            this.tbComment.SelectionStart = 0;
            this.tbComment.ShortcutsEnabled = true;
            this.tbComment.Size = new System.Drawing.Size(361, 39);
            this.tbComment.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbComment.TabIndex = 94;
            this.tbComment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbComment.TextMarginBottom = 0;
            this.tbComment.TextMarginLeft = 3;
            this.tbComment.TextMarginTop = 0;
            this.tbComment.TextPlaceholder = "Nhập đánh giá và góp ý của bạn";
            this.tbComment.UseSystemPasswordChar = false;
            this.tbComment.WordWrap = true;
            // 
            // RatingStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 352);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbComment);
            this.Controls.Add(this.ratingStars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RatingStar";
            this.Text = "Neko Coffee";
            this.Load += new System.EventHandler(this.RatingStar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuRating ratingStars;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSend;
        private Bunifu.UI.WinForms.BunifuTextBox tbComment;
    }
}