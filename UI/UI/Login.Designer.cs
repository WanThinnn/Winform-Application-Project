namespace UI
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txPass = new Bunifu.UI.WinForms.BunifuTextBox();
            this.txUser = new Bunifu.UI.WinForms.BunifuTextBox();
            this.lbDangNhap = new System.Windows.Forms.Label();
            this.lkForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSignUp = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(162, -6);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(126, 121);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txPass);
            this.panel1.Controls.Add(this.txUser);
            this.panel1.Controls.Add(this.lbDangNhap);
            this.panel1.Controls.Add(this.btnSignUp);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.lkForgotPass);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Location = new System.Drawing.Point(103, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(581, 345);
            this.panel1.TabIndex = 4;
            // 
            // txPass
            // 
            this.txPass.AcceptsReturn = false;
            this.txPass.AcceptsTab = false;
            this.txPass.AnimationSpeed = 200;
            this.txPass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txPass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txPass.BackColor = System.Drawing.Color.Transparent;
            this.txPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txPass.BackgroundImage")));
            this.txPass.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txPass.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txPass.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txPass.BorderColorIdle = System.Drawing.Color.Silver;
            this.txPass.BorderRadius = 40;
            this.txPass.BorderThickness = 1;
            this.txPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txPass.DefaultFont = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txPass.DefaultText = "";
            this.txPass.FillColor = System.Drawing.Color.White;
            this.txPass.HideSelection = true;
            this.txPass.IconLeft = null;
            this.txPass.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txPass.IconPadding = 10;
            this.txPass.IconRight = null;
            this.txPass.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txPass.Lines = new string[0];
            this.txPass.Location = new System.Drawing.Point(104, 144);
            this.txPass.MaxLength = 32767;
            this.txPass.MinimumSize = new System.Drawing.Size(1, 1);
            this.txPass.Modified = false;
            this.txPass.Multiline = false;
            this.txPass.Name = "txPass";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txPass.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txPass.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txPass.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txPass.OnIdleState = stateProperties4;
            this.txPass.Padding = new System.Windows.Forms.Padding(3);
            this.txPass.PasswordChar = '\0';
            this.txPass.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txPass.PlaceholderText = "Passwork";
            this.txPass.ReadOnly = false;
            this.txPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txPass.SelectedText = "";
            this.txPass.SelectionLength = 0;
            this.txPass.SelectionStart = 0;
            this.txPass.ShortcutsEnabled = true;
            this.txPass.Size = new System.Drawing.Size(372, 42);
            this.txPass.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txPass.TabIndex = 10;
            this.txPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txPass.TextMarginBottom = 0;
            this.txPass.TextMarginLeft = 3;
            this.txPass.TextMarginTop = 0;
            this.txPass.TextPlaceholder = "Passwork";
            this.txPass.UseSystemPasswordChar = false;
            this.txPass.WordWrap = true;
            // 
            // txUser
            // 
            this.txUser.AcceptsReturn = false;
            this.txUser.AcceptsTab = false;
            this.txUser.AnimationSpeed = 200;
            this.txUser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txUser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txUser.BackColor = System.Drawing.Color.Transparent;
            this.txUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txUser.BackgroundImage")));
            this.txUser.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txUser.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txUser.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txUser.BorderColorIdle = System.Drawing.Color.Silver;
            this.txUser.BorderRadius = 40;
            this.txUser.BorderThickness = 1;
            this.txUser.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txUser.DefaultFont = new System.Drawing.Font("UTM Avo", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txUser.DefaultText = "";
            this.txUser.FillColor = System.Drawing.Color.White;
            this.txUser.HideSelection = true;
            this.txUser.IconLeft = null;
            this.txUser.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txUser.IconPadding = 10;
            this.txUser.IconRight = null;
            this.txUser.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txUser.Lines = new string[0];
            this.txUser.Location = new System.Drawing.Point(104, 87);
            this.txUser.MaxLength = 32767;
            this.txUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.txUser.Modified = false;
            this.txUser.Multiline = false;
            this.txUser.Name = "txUser";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txUser.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txUser.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txUser.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txUser.OnIdleState = stateProperties8;
            this.txUser.Padding = new System.Windows.Forms.Padding(3);
            this.txUser.PasswordChar = '\0';
            this.txUser.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txUser.PlaceholderText = "Username";
            this.txUser.ReadOnly = false;
            this.txUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txUser.SelectedText = "";
            this.txUser.SelectionLength = 0;
            this.txUser.SelectionStart = 0;
            this.txUser.ShortcutsEnabled = true;
            this.txUser.Size = new System.Drawing.Size(372, 42);
            this.txUser.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txUser.TabIndex = 9;
            this.txUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txUser.TextMarginBottom = 0;
            this.txUser.TextMarginLeft = 3;
            this.txUser.TextMarginTop = 0;
            this.txUser.TextPlaceholder = "Username";
            this.txUser.UseSystemPasswordChar = false;
            this.txUser.WordWrap = true;
            // 
            // lbDangNhap
            // 
            this.lbDangNhap.AutoSize = true;
            this.lbDangNhap.Font = new System.Drawing.Font("Montserrat ExtraBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDangNhap.Location = new System.Drawing.Point(268, 32);
            this.lbDangNhap.Name = "lbDangNhap";
            this.lbDangNhap.Size = new System.Drawing.Size(112, 39);
            this.lbDangNhap.TabIndex = 8;
            this.lbDangNhap.Text = "LOGIN";
            // 
            // lkForgotPass
            // 
            this.lkForgotPass.AutoSize = true;
            this.lkForgotPass.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lkForgotPass.LinkColor = System.Drawing.Color.Maroon;
            this.lkForgotPass.Location = new System.Drawing.Point(304, 194);
            this.lkForgotPass.Name = "lkForgotPass";
            this.lkForgotPass.Size = new System.Drawing.Size(170, 20);
            this.lkForgotPass.TabIndex = 6;
            this.lkForgotPass.TabStop = true;
            this.lkForgotPass.Text = "Forgot your passwork?";
            // 
            // btnLogin
            // 
            this.btnLogin.AllowAnimations = true;
            this.btnLogin.AllowMouseEffects = true;
            this.btnLogin.AllowToggling = false;
            this.btnLogin.AnimationSpeed = 200;
            this.btnLogin.AutoGenerateColors = false;
            this.btnLogin.AutoRoundBorders = false;
            this.btnLogin.AutoSizeLeftIcon = true;
            this.btnLogin.AutoSizeRightIcon = true;
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BackColor1 = System.Drawing.Color.Black;
            this.btnLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogin.BackgroundImage")));
            this.btnLogin.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.ButtonText = "Login";
            this.btnLogin.ButtonTextMarginLeft = 0;
            this.btnLogin.ColorContrastOnClick = 45;
            this.btnLogin.ColorContrastOnHover = 45;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnLogin.CustomizableEdges = borderEdges2;
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnLogin.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogin.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnLogin.IconMarginLeft = 11;
            this.btnLogin.IconPadding = 10;
            this.btnLogin.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogin.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnLogin.IconSize = 25;
            this.btnLogin.IdleBorderColor = System.Drawing.Color.Black;
            this.btnLogin.IdleBorderRadius = 25;
            this.btnLogin.IdleBorderThickness = 1;
            this.btnLogin.IdleFillColor = System.Drawing.Color.Black;
            this.btnLogin.IdleIconLeftImage = null;
            this.btnLogin.IdleIconRightImage = null;
            this.btnLogin.IndicateFocus = false;
            this.btnLogin.Location = new System.Drawing.Point(102, 235);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnLogin.OnDisabledState.BorderRadius = 25;
            this.btnLogin.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnDisabledState.BorderThickness = 1;
            this.btnLogin.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnLogin.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnLogin.OnDisabledState.IconLeftImage = null;
            this.btnLogin.OnDisabledState.IconRightImage = null;
            this.btnLogin.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.onHoverState.BorderRadius = 25;
            this.btnLogin.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.onHoverState.BorderThickness = 1;
            this.btnLogin.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnLogin.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.onHoverState.IconLeftImage = null;
            this.btnLogin.onHoverState.IconRightImage = null;
            this.btnLogin.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnIdleState.BorderRadius = 25;
            this.btnLogin.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnIdleState.BorderThickness = 1;
            this.btnLogin.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.btnLogin.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogin.OnIdleState.IconLeftImage = null;
            this.btnLogin.OnIdleState.IconRightImage = null;
            this.btnLogin.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnLogin.OnPressedState.BorderRadius = 25;
            this.btnLogin.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnLogin.OnPressedState.BorderThickness = 1;
            this.btnLogin.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnLogin.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnLogin.OnPressedState.IconLeftImage = null;
            this.btnLogin.OnPressedState.IconRightImage = null;
            this.btnLogin.Size = new System.Drawing.Size(372, 42);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogin.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogin.TextMarginLeft = 0;
            this.btnLogin.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnLogin.UseDefaultRadiusAndThickness = true;
            // 
            // btnSignUp
            // 
            this.btnSignUp.AllowAnimations = true;
            this.btnSignUp.AllowMouseEffects = true;
            this.btnSignUp.AllowToggling = false;
            this.btnSignUp.AnimationSpeed = 200;
            this.btnSignUp.AutoGenerateColors = false;
            this.btnSignUp.AutoRoundBorders = false;
            this.btnSignUp.AutoSizeLeftIcon = true;
            this.btnSignUp.AutoSizeRightIcon = true;
            this.btnSignUp.BackColor = System.Drawing.Color.Transparent;
            this.btnSignUp.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSignUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSignUp.BackgroundImage")));
            this.btnSignUp.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.ButtonText = "Sign up";
            this.btnSignUp.ButtonTextMarginLeft = 0;
            this.btnSignUp.ColorContrastOnClick = 45;
            this.btnSignUp.ColorContrastOnHover = 45;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnSignUp.CustomizableEdges = borderEdges1;
            this.btnSignUp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignUp.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignUp.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignUp.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnSignUp.Font = new System.Drawing.Font("Montserrat SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSignUp.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUp.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnSignUp.IconMarginLeft = 11;
            this.btnSignUp.IconPadding = 10;
            this.btnSignUp.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSignUp.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUp.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnSignUp.IconSize = 25;
            this.btnSignUp.IdleBorderColor = System.Drawing.Color.Black;
            this.btnSignUp.IdleBorderRadius = 25;
            this.btnSignUp.IdleBorderThickness = 1;
            this.btnSignUp.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSignUp.IdleIconLeftImage = null;
            this.btnSignUp.IdleIconRightImage = null;
            this.btnSignUp.IndicateFocus = false;
            this.btnSignUp.Location = new System.Drawing.Point(102, 291);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnSignUp.OnDisabledState.BorderRadius = 25;
            this.btnSignUp.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.OnDisabledState.BorderThickness = 1;
            this.btnSignUp.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSignUp.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnSignUp.OnDisabledState.IconLeftImage = null;
            this.btnSignUp.OnDisabledState.IconRightImage = null;
            this.btnSignUp.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.onHoverState.BorderRadius = 25;
            this.btnSignUp.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.onHoverState.BorderThickness = 1;
            this.btnSignUp.onHoverState.FillColor = System.Drawing.Color.Black;
            this.btnSignUp.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.onHoverState.IconLeftImage = null;
            this.btnSignUp.onHoverState.IconRightImage = null;
            this.btnSignUp.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.OnIdleState.BorderRadius = 25;
            this.btnSignUp.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.OnIdleState.BorderThickness = 1;
            this.btnSignUp.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSignUp.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnSignUp.OnIdleState.IconLeftImage = null;
            this.btnSignUp.OnIdleState.IconRightImage = null;
            this.btnSignUp.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.btnSignUp.OnPressedState.BorderRadius = 25;
            this.btnSignUp.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnSignUp.OnPressedState.BorderThickness = 1;
            this.btnSignUp.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.btnSignUp.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.OnPressedState.IconLeftImage = null;
            this.btnSignUp.OnPressedState.IconRightImage = null;
            this.btnSignUp.Size = new System.Drawing.Size(372, 42);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignUp.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignUp.TextMarginLeft = 0;
            this.btnSignUp.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnSignUp.UseDefaultRadiusAndThickness = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuTextBox txPass;
        private Bunifu.UI.WinForms.BunifuTextBox txUser;
        private System.Windows.Forms.Label lbDangNhap;
        private System.Windows.Forms.LinkLabel lkForgotPass;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignUp;
    }
}