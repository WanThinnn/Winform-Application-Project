namespace UI
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.AdminTitle1 = new System.Windows.Forms.Label();
            this.AdminLabel1 = new System.Windows.Forms.Label();
            this.AdminDate1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.AdminComeOder = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.AdminLabel2 = new System.Windows.Forms.Label();
            this.AdminBillCircle = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.AdminTableCircle = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.AdminLabel3 = new System.Windows.Forms.Label();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.AdminComePayment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 40;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.AdminComeOder);
            this.bunifuPanel1.Controls.Add(this.AdminDate1);
            this.bunifuPanel1.Controls.Add(this.AdminLabel1);
            this.bunifuPanel1.Controls.Add(this.AdminTitle1);
            this.bunifuPanel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bunifuPanel1.Location = new System.Drawing.Point(15, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(681, 172);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // AdminTitle1
            // 
            this.AdminTitle1.AutoSize = true;
            this.AdminTitle1.BackColor = System.Drawing.Color.Transparent;
            this.AdminTitle1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTitle1.Location = new System.Drawing.Point(44, 13);
            this.AdminTitle1.Name = "AdminTitle1";
            this.AdminTitle1.Size = new System.Drawing.Size(451, 26);
            this.AdminTitle1.TabIndex = 0;
            this.AdminTitle1.Text = "Best place for healing your mental health";
            // 
            // AdminLabel1
            // 
            this.AdminLabel1.AutoSize = true;
            this.AdminLabel1.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel1.Location = new System.Drawing.Point(45, 49);
            this.AdminLabel1.Name = "AdminLabel1";
            this.AdminLabel1.Size = new System.Drawing.Size(570, 46);
            this.AdminLabel1.TabIndex = 1;
            this.AdminLabel1.Text = "We serve more than 40 coffee and stay with that is many cats\r\nall will cost with " +
    "a affordable, given you many good time\r\n";
            // 
            // AdminDate1
            // 
            this.AdminDate1.BackColor = System.Drawing.Color.Transparent;
            this.AdminDate1.BorderRadius = 17;
            this.AdminDate1.CalendarFont = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDate1.Color = System.Drawing.Color.Black;
            this.AdminDate1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.AdminDate1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.AdminDate1.DisabledColor = System.Drawing.Color.Gray;
            this.AdminDate1.DisplayWeekNumbers = false;
            this.AdminDate1.DPHeight = 0;
            this.AdminDate1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.AdminDate1.FillDatePicker = false;
            this.AdminDate1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDate1.ForeColor = System.Drawing.Color.Black;
            this.AdminDate1.Icon = ((System.Drawing.Image)(resources.GetObject("AdminDate1.Icon")));
            this.AdminDate1.IconColor = System.Drawing.Color.Black;
            this.AdminDate1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.AdminDate1.LeftTextMargin = 5;
            this.AdminDate1.Location = new System.Drawing.Point(49, 115);
            this.AdminDate1.MinimumSize = new System.Drawing.Size(4, 32);
            this.AdminDate1.Name = "AdminDate1";
            this.AdminDate1.Size = new System.Drawing.Size(372, 32);
            this.AdminDate1.TabIndex = 2;
            // 
            // AdminComeOder
            // 
            this.AdminComeOder.AllowAnimations = true;
            this.AdminComeOder.AllowMouseEffects = true;
            this.AdminComeOder.AllowToggling = false;
            this.AdminComeOder.AnimationSpeed = 200;
            this.AdminComeOder.AutoGenerateColors = false;
            this.AdminComeOder.AutoRoundBorders = false;
            this.AdminComeOder.AutoSizeLeftIcon = true;
            this.AdminComeOder.AutoSizeRightIcon = true;
            this.AdminComeOder.BackColor = System.Drawing.Color.Transparent;
            this.AdminComeOder.BackColor1 = System.Drawing.Color.Black;
            this.AdminComeOder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminComeOder.BackgroundImage")));
            this.AdminComeOder.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComeOder.ButtonText = "ORDER";
            this.AdminComeOder.ButtonTextMarginLeft = 0;
            this.AdminComeOder.ColorContrastOnClick = 45;
            this.AdminComeOder.ColorContrastOnHover = 45;
            this.AdminComeOder.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.AdminComeOder.CustomizableEdges = borderEdges3;
            this.AdminComeOder.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminComeOder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminComeOder.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminComeOder.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminComeOder.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AdminComeOder.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminComeOder.ForeColor = System.Drawing.Color.LightSalmon;
            this.AdminComeOder.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminComeOder.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AdminComeOder.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AdminComeOder.IconMarginLeft = 11;
            this.AdminComeOder.IconPadding = 10;
            this.AdminComeOder.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminComeOder.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AdminComeOder.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AdminComeOder.IconSize = 25;
            this.AdminComeOder.IdleBorderColor = System.Drawing.Color.Black;
            this.AdminComeOder.IdleBorderRadius = 35;
            this.AdminComeOder.IdleBorderThickness = 1;
            this.AdminComeOder.IdleFillColor = System.Drawing.Color.Black;
            this.AdminComeOder.IdleIconLeftImage = null;
            this.AdminComeOder.IdleIconRightImage = null;
            this.AdminComeOder.IndicateFocus = false;
            this.AdminComeOder.Location = new System.Drawing.Point(477, 115);
            this.AdminComeOder.Name = "AdminComeOder";
            this.AdminComeOder.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminComeOder.OnDisabledState.BorderRadius = 35;
            this.AdminComeOder.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComeOder.OnDisabledState.BorderThickness = 1;
            this.AdminComeOder.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminComeOder.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminComeOder.OnDisabledState.IconLeftImage = null;
            this.AdminComeOder.OnDisabledState.IconRightImage = null;
            this.AdminComeOder.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.AdminComeOder.onHoverState.BorderRadius = 35;
            this.AdminComeOder.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComeOder.onHoverState.BorderThickness = 1;
            this.AdminComeOder.onHoverState.FillColor = System.Drawing.Color.Black;
            this.AdminComeOder.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AdminComeOder.onHoverState.IconLeftImage = null;
            this.AdminComeOder.onHoverState.IconRightImage = null;
            this.AdminComeOder.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.AdminComeOder.OnIdleState.BorderRadius = 35;
            this.AdminComeOder.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComeOder.OnIdleState.BorderThickness = 1;
            this.AdminComeOder.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.AdminComeOder.OnIdleState.ForeColor = System.Drawing.Color.LightSalmon;
            this.AdminComeOder.OnIdleState.IconLeftImage = null;
            this.AdminComeOder.OnIdleState.IconRightImage = null;
            this.AdminComeOder.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.AdminComeOder.OnPressedState.BorderRadius = 35;
            this.AdminComeOder.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComeOder.OnPressedState.BorderThickness = 1;
            this.AdminComeOder.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.AdminComeOder.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AdminComeOder.OnPressedState.IconLeftImage = null;
            this.AdminComeOder.OnPressedState.IconRightImage = null;
            this.AdminComeOder.Size = new System.Drawing.Size(138, 42);
            this.AdminComeOder.TabIndex = 4;
            this.AdminComeOder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminComeOder.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminComeOder.TextMarginLeft = 0;
            this.AdminComeOder.TextPadding = new System.Windows.Forms.Padding(0);
            this.AdminComeOder.UseDefaultRadiusAndThickness = true;
            this.AdminComeOder.Click += new System.EventHandler(this.AdminComeOder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 185);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 35;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.AdminLabel3);
            this.bunifuPanel2.Controls.Add(this.AdminTableCircle);
            this.bunifuPanel2.Controls.Add(this.AdminBillCircle);
            this.bunifuPanel2.Controls.Add(this.AdminLabel2);
            this.bunifuPanel2.Location = new System.Drawing.Point(15, 6);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(350, 273);
            this.bunifuPanel2.TabIndex = 2;
            this.bunifuPanel2.Click += new System.EventHandler(this.bunifuPanel2_Click);
            // 
            // AdminLabel2
            // 
            this.AdminLabel2.AutoSize = true;
            this.AdminLabel2.BackColor = System.Drawing.Color.Transparent;
            this.AdminLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel2.Location = new System.Drawing.Point(46, 23);
            this.AdminLabel2.Name = "AdminLabel2";
            this.AdminLabel2.Size = new System.Drawing.Size(102, 18);
            this.AdminLabel2.TabIndex = 5;
            this.AdminLabel2.Text = "UNPAID BILLS";
            // 
            // AdminBillCircle
            // 
            this.AdminBillCircle.Animated = false;
            this.AdminBillCircle.AnimationInterval = 1;
            this.AdminBillCircle.AnimationSpeed = 1;
            this.AdminBillCircle.BackColor = System.Drawing.Color.Transparent;
            this.AdminBillCircle.CircleMargin = 10;
            this.AdminBillCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBillCircle.ForeColor = System.Drawing.Color.Black;
            this.AdminBillCircle.IsPercentage = false;
            this.AdminBillCircle.LineProgressThickness = 10;
            this.AdminBillCircle.LineThickness = 10;
            this.AdminBillCircle.Location = new System.Drawing.Point(3, 52);
            this.AdminBillCircle.Name = "AdminBillCircle";
            this.AdminBillCircle.ProgressAnimationSpeed = 200;
            this.AdminBillCircle.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.AdminBillCircle.ProgressColor = System.Drawing.Color.Black;
            this.AdminBillCircle.ProgressColor2 = System.Drawing.Color.Black;
            this.AdminBillCircle.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.AdminBillCircle.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.AdminBillCircle.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Triangle;
            this.AdminBillCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBillCircle.Size = new System.Drawing.Size(163, 163);
            this.AdminBillCircle.SubScriptColor = System.Drawing.Color.Black;
            this.AdminBillCircle.SubScriptMargin = new System.Windows.Forms.Padding(3, -7, 0, 0);
            this.AdminBillCircle.SubScriptText = "   BILLS";
            this.AdminBillCircle.SuperScriptColor = System.Drawing.Color.Black;
            this.AdminBillCircle.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.AdminBillCircle.SuperScriptText = "";
            this.AdminBillCircle.TabIndex = 16;
            this.AdminBillCircle.Text = "30";
            this.AdminBillCircle.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.AdminBillCircle.Value = 30;
            this.AdminBillCircle.ValueByTransition = 30;
            this.AdminBillCircle.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // AdminTableCircle
            // 
            this.AdminTableCircle.Animated = false;
            this.AdminTableCircle.AnimationInterval = 1;
            this.AdminTableCircle.AnimationSpeed = 1;
            this.AdminTableCircle.BackColor = System.Drawing.Color.Transparent;
            this.AdminTableCircle.CircleMargin = 10;
            this.AdminTableCircle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTableCircle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminTableCircle.IsPercentage = false;
            this.AdminTableCircle.LineProgressThickness = 10;
            this.AdminTableCircle.LineThickness = 10;
            this.AdminTableCircle.Location = new System.Drawing.Point(172, 54);
            this.AdminTableCircle.Maximum = 20;
            this.AdminTableCircle.Name = "AdminTableCircle";
            this.AdminTableCircle.ProgressAnimationSpeed = 200;
            this.AdminTableCircle.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.AdminTableCircle.ProgressColor = System.Drawing.Color.Black;
            this.AdminTableCircle.ProgressColor2 = System.Drawing.Color.Black;
            this.AdminTableCircle.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.AdminTableCircle.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.AdminTableCircle.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.AdminTableCircle.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminTableCircle.Size = new System.Drawing.Size(161, 161);
            this.AdminTableCircle.SubScriptColor = System.Drawing.Color.Black;
            this.AdminTableCircle.SubScriptMargin = new System.Windows.Forms.Padding(3, -7, 0, 0);
            this.AdminTableCircle.SubScriptText = "   TABLES";
            this.AdminTableCircle.SuperScriptColor = System.Drawing.Color.Black;
            this.AdminTableCircle.SuperScriptMargin = new System.Windows.Forms.Padding(5, 20, 0, 0);
            this.AdminTableCircle.SuperScriptText = "";
            this.AdminTableCircle.TabIndex = 17;
            this.AdminTableCircle.Text = "12";
            this.AdminTableCircle.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.AdminTableCircle.Value = 12;
            this.AdminTableCircle.ValueByTransition = 12;
            this.AdminTableCircle.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.AdminTableCircle.ProgressChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCircleProgress.ProgressChangedEventArgs>(this.AdminTableCircle_ProgressChanged);
            // 
            // AdminLabel3
            // 
            this.AdminLabel3.AutoSize = true;
            this.AdminLabel3.BackColor = System.Drawing.Color.LightSalmon;
            this.AdminLabel3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminLabel3.ForeColor = System.Drawing.Color.Black;
            this.AdminLabel3.Location = new System.Drawing.Point(186, 23);
            this.AdminLabel3.Name = "AdminLabel3";
            this.AdminLabel3.Size = new System.Drawing.Size(146, 18);
            this.AdminLabel3.TabIndex = 6;
            this.AdminLabel3.Text = "REMAINING TABLES\r\n";
            this.AdminLabel3.Click += new System.EventHandler(this.AdminLabel3_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel3.BorderRadius = 35;
            this.bunifuPanel3.BorderThickness = 1;
            this.bunifuPanel3.Controls.Add(this.AdminComePayment);
            this.bunifuPanel3.Controls.Add(this.label2);
            this.bunifuPanel3.Location = new System.Drawing.Point(371, 6);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(325, 273);
            this.bunifuPanel3.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "RECENTLY PAY";
            // 
            // AdminComePayment
            // 
            this.AdminComePayment.AllowAnimations = true;
            this.AdminComePayment.AllowMouseEffects = true;
            this.AdminComePayment.AllowToggling = false;
            this.AdminComePayment.AnimationSpeed = 200;
            this.AdminComePayment.AutoGenerateColors = false;
            this.AdminComePayment.AutoRoundBorders = false;
            this.AdminComePayment.AutoSizeLeftIcon = true;
            this.AdminComePayment.AutoSizeRightIcon = true;
            this.AdminComePayment.BackColor = System.Drawing.Color.Transparent;
            this.AdminComePayment.BackColor1 = System.Drawing.Color.Black;
            this.AdminComePayment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminComePayment.BackgroundImage")));
            this.AdminComePayment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComePayment.ButtonText = "PAYMENT";
            this.AdminComePayment.ButtonTextMarginLeft = 0;
            this.AdminComePayment.ColorContrastOnClick = 45;
            this.AdminComePayment.ColorContrastOnHover = 45;
            this.AdminComePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.AdminComePayment.CustomizableEdges = borderEdges4;
            this.AdminComePayment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminComePayment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminComePayment.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminComePayment.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminComePayment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AdminComePayment.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminComePayment.ForeColor = System.Drawing.Color.LightSalmon;
            this.AdminComePayment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminComePayment.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AdminComePayment.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AdminComePayment.IconMarginLeft = 11;
            this.AdminComePayment.IconPadding = 10;
            this.AdminComePayment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminComePayment.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AdminComePayment.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AdminComePayment.IconSize = 25;
            this.AdminComePayment.IdleBorderColor = System.Drawing.Color.Black;
            this.AdminComePayment.IdleBorderRadius = 35;
            this.AdminComePayment.IdleBorderThickness = 1;
            this.AdminComePayment.IdleFillColor = System.Drawing.Color.Black;
            this.AdminComePayment.IdleIconLeftImage = null;
            this.AdminComePayment.IdleIconRightImage = null;
            this.AdminComePayment.IndicateFocus = false;
            this.AdminComePayment.Location = new System.Drawing.Point(90, 218);
            this.AdminComePayment.Name = "AdminComePayment";
            this.AdminComePayment.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminComePayment.OnDisabledState.BorderRadius = 35;
            this.AdminComePayment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComePayment.OnDisabledState.BorderThickness = 1;
            this.AdminComePayment.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminComePayment.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminComePayment.OnDisabledState.IconLeftImage = null;
            this.AdminComePayment.OnDisabledState.IconRightImage = null;
            this.AdminComePayment.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.AdminComePayment.onHoverState.BorderRadius = 35;
            this.AdminComePayment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComePayment.onHoverState.BorderThickness = 1;
            this.AdminComePayment.onHoverState.FillColor = System.Drawing.Color.Black;
            this.AdminComePayment.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AdminComePayment.onHoverState.IconLeftImage = null;
            this.AdminComePayment.onHoverState.IconRightImage = null;
            this.AdminComePayment.OnIdleState.BorderColor = System.Drawing.Color.Black;
            this.AdminComePayment.OnIdleState.BorderRadius = 35;
            this.AdminComePayment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComePayment.OnIdleState.BorderThickness = 1;
            this.AdminComePayment.OnIdleState.FillColor = System.Drawing.Color.Black;
            this.AdminComePayment.OnIdleState.ForeColor = System.Drawing.Color.LightSalmon;
            this.AdminComePayment.OnIdleState.IconLeftImage = null;
            this.AdminComePayment.OnIdleState.IconRightImage = null;
            this.AdminComePayment.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.AdminComePayment.OnPressedState.BorderRadius = 35;
            this.AdminComePayment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminComePayment.OnPressedState.BorderThickness = 1;
            this.AdminComePayment.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.AdminComePayment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AdminComePayment.OnPressedState.IconLeftImage = null;
            this.AdminComePayment.OnPressedState.IconRightImage = null;
            this.AdminComePayment.Size = new System.Drawing.Size(144, 42);
            this.AdminComePayment.TabIndex = 5;
            this.AdminComePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminComePayment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminComePayment.TextMarginLeft = 0;
            this.AdminComePayment.TextPadding = new System.Windows.Forms.Padding(0);
            this.AdminComePayment.UseDefaultRadiusAndThickness = true;
            this.AdminComePayment.Click += new System.EventHandler(this.AdminComePayment_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.bunifuPanel3);
            this.panel2.Controls.Add(this.bunifuPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 185);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 299);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // AdminMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMenu";
            this.Size = new System.Drawing.Size(706, 484);
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.bunifuPanel3.ResumeLayout(false);
            this.bunifuPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AdminComeOder;
        private Bunifu.UI.WinForms.BunifuDatePicker AdminDate1;
        private System.Windows.Forms.Label AdminLabel1;
        private System.Windows.Forms.Label AdminTitle1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AdminComePayment;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private System.Windows.Forms.Label AdminLabel3;
        private Bunifu.UI.WinForms.BunifuCircleProgress AdminTableCircle;
        private Bunifu.UI.WinForms.BunifuCircleProgress AdminBillCircle;
        private System.Windows.Forms.Label AdminLabel2;
    }
}
