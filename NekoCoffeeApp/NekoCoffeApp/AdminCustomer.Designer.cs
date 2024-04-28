namespace UI
{
    partial class AdminCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCustomer));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AdminViewAllCustomer = new System.Windows.Forms.ListView();
            this.AdminShowRating = new Bunifu.UI.WinForms.BunifuRating();
            this.AdminShowAllCustomers = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AdminFillCustomerID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.AdminCheckCustomer = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // AdminViewAllCustomer
            // 
            this.AdminViewAllCustomer.HideSelection = false;
            this.AdminViewAllCustomer.Location = new System.Drawing.Point(22, 15);
            this.AdminViewAllCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.AdminViewAllCustomer.Name = "AdminViewAllCustomer";
            this.AdminViewAllCustomer.Size = new System.Drawing.Size(1029, 571);
            this.AdminViewAllCustomer.TabIndex = 21;
            this.AdminViewAllCustomer.UseCompatibleStateImageBehavior = false;
            // 
            // AdminShowRating
            // 
            this.AdminShowRating.BackColor = System.Drawing.Color.Transparent;
            this.AdminShowRating.DisabledEmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.AdminShowRating.DisabledRatedFillColor = System.Drawing.Color.DarkGray;
            this.AdminShowRating.EmptyBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.AdminShowRating.EmptyFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.AdminShowRating.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminShowRating.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.AdminShowRating.HoverFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.AdminShowRating.InnerRadius = 2F;
            this.AdminShowRating.Location = new System.Drawing.Point(911, 660);
            this.AdminShowRating.Margin = new System.Windows.Forms.Padding(2);
            this.AdminShowRating.Name = "AdminShowRating";
            this.AdminShowRating.OuterRadius = 10F;
            this.AdminShowRating.RatedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.AdminShowRating.RatedFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(217)))), ((int)(((byte)(20)))));
            this.AdminShowRating.ReadOnly = false;
            this.AdminShowRating.RightClickToClear = true;
            this.AdminShowRating.Size = new System.Drawing.Size(121, 22);
            this.AdminShowRating.TabIndex = 20;
            this.AdminShowRating.Text = "bunifuRating1";
            this.AdminShowRating.Value = 2;
            // 
            // AdminShowAllCustomers
            // 
            this.AdminShowAllCustomers.AllowAnimations = true;
            this.AdminShowAllCustomers.AllowMouseEffects = true;
            this.AdminShowAllCustomers.AllowToggling = false;
            this.AdminShowAllCustomers.AnimationSpeed = 200;
            this.AdminShowAllCustomers.AutoGenerateColors = false;
            this.AdminShowAllCustomers.AutoRoundBorders = false;
            this.AdminShowAllCustomers.AutoSizeLeftIcon = true;
            this.AdminShowAllCustomers.AutoSizeRightIcon = true;
            this.AdminShowAllCustomers.BackColor = System.Drawing.Color.Transparent;
            this.AdminShowAllCustomers.BackColor1 = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminShowAllCustomers.BackgroundImage")));
            this.AdminShowAllCustomers.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminShowAllCustomers.ButtonText = "VIEW ALL YOUR CUSTOMERS";
            this.AdminShowAllCustomers.ButtonTextMarginLeft = 0;
            this.AdminShowAllCustomers.ColorContrastOnClick = 45;
            this.AdminShowAllCustomers.ColorContrastOnHover = 45;
            this.AdminShowAllCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AdminShowAllCustomers.CustomizableEdges = borderEdges1;
            this.AdminShowAllCustomers.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminShowAllCustomers.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminShowAllCustomers.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminShowAllCustomers.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminShowAllCustomers.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AdminShowAllCustomers.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminShowAllCustomers.ForeColor = System.Drawing.Color.White;
            this.AdminShowAllCustomers.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminShowAllCustomers.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AdminShowAllCustomers.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AdminShowAllCustomers.IconMarginLeft = 11;
            this.AdminShowAllCustomers.IconPadding = 10;
            this.AdminShowAllCustomers.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminShowAllCustomers.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AdminShowAllCustomers.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AdminShowAllCustomers.IconSize = 25;
            this.AdminShowAllCustomers.IdleBorderColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.IdleBorderRadius = 37;
            this.AdminShowAllCustomers.IdleBorderThickness = 1;
            this.AdminShowAllCustomers.IdleFillColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.IdleIconLeftImage = null;
            this.AdminShowAllCustomers.IdleIconRightImage = null;
            this.AdminShowAllCustomers.IndicateFocus = false;
            this.AdminShowAllCustomers.Location = new System.Drawing.Point(837, 603);
            this.AdminShowAllCustomers.Name = "AdminShowAllCustomers";
            this.AdminShowAllCustomers.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminShowAllCustomers.OnDisabledState.BorderRadius = 37;
            this.AdminShowAllCustomers.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminShowAllCustomers.OnDisabledState.BorderThickness = 1;
            this.AdminShowAllCustomers.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminShowAllCustomers.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminShowAllCustomers.OnDisabledState.IconLeftImage = null;
            this.AdminShowAllCustomers.OnDisabledState.IconRightImage = null;
            this.AdminShowAllCustomers.onHoverState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.onHoverState.BorderRadius = 37;
            this.AdminShowAllCustomers.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminShowAllCustomers.onHoverState.BorderThickness = 1;
            this.AdminShowAllCustomers.onHoverState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AdminShowAllCustomers.onHoverState.IconLeftImage = null;
            this.AdminShowAllCustomers.onHoverState.IconRightImage = null;
            this.AdminShowAllCustomers.OnIdleState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.OnIdleState.BorderRadius = 37;
            this.AdminShowAllCustomers.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminShowAllCustomers.OnIdleState.BorderThickness = 1;
            this.AdminShowAllCustomers.OnIdleState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AdminShowAllCustomers.OnIdleState.IconLeftImage = null;
            this.AdminShowAllCustomers.OnIdleState.IconRightImage = null;
            this.AdminShowAllCustomers.OnPressedState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.OnPressedState.BorderRadius = 37;
            this.AdminShowAllCustomers.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminShowAllCustomers.OnPressedState.BorderThickness = 1;
            this.AdminShowAllCustomers.OnPressedState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminShowAllCustomers.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AdminShowAllCustomers.OnPressedState.IconLeftImage = null;
            this.AdminShowAllCustomers.OnPressedState.IconRightImage = null;
            this.AdminShowAllCustomers.Size = new System.Drawing.Size(214, 36);
            this.AdminShowAllCustomers.TabIndex = 19;
            this.AdminShowAllCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminShowAllCustomers.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminShowAllCustomers.TextMarginLeft = 0;
            this.AdminShowAllCustomers.TextPadding = new System.Windows.Forms.Padding(0);
            this.AdminShowAllCustomers.UseDefaultRadiusAndThickness = true;
            // 
            // AdminFillCustomerID
            // 
            this.AdminFillCustomerID.AcceptsReturn = false;
            this.AdminFillCustomerID.AcceptsTab = false;
            this.AdminFillCustomerID.AnimationSpeed = 200;
            this.AdminFillCustomerID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AdminFillCustomerID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AdminFillCustomerID.BackColor = System.Drawing.Color.Transparent;
            this.AdminFillCustomerID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminFillCustomerID.BackgroundImage")));
            this.AdminFillCustomerID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.AdminFillCustomerID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminFillCustomerID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.AdminFillCustomerID.BorderColorIdle = System.Drawing.Color.Silver;
            this.AdminFillCustomerID.BorderRadius = 1;
            this.AdminFillCustomerID.BorderThickness = 1;
            this.AdminFillCustomerID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AdminFillCustomerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminFillCustomerID.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.AdminFillCustomerID.DefaultText = "";
            this.AdminFillCustomerID.FillColor = System.Drawing.Color.White;
            this.AdminFillCustomerID.HideSelection = true;
            this.AdminFillCustomerID.IconLeft = null;
            this.AdminFillCustomerID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminFillCustomerID.IconPadding = 10;
            this.AdminFillCustomerID.IconRight = null;
            this.AdminFillCustomerID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.AdminFillCustomerID.Lines = new string[0];
            this.AdminFillCustomerID.Location = new System.Drawing.Point(22, 645);
            this.AdminFillCustomerID.MaxLength = 32767;
            this.AdminFillCustomerID.MinimumSize = new System.Drawing.Size(1, 1);
            this.AdminFillCustomerID.Modified = false;
            this.AdminFillCustomerID.Multiline = false;
            this.AdminFillCustomerID.Name = "AdminFillCustomerID";
            stateProperties1.BorderColor = System.Drawing.Color.Transparent;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AdminFillCustomerID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.Transparent;
            stateProperties2.FillColor = System.Drawing.Color.Transparent;
            stateProperties2.ForeColor = System.Drawing.Color.Transparent;
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AdminFillCustomerID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.Transparent;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AdminFillCustomerID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AdminFillCustomerID.OnIdleState = stateProperties4;
            this.AdminFillCustomerID.Padding = new System.Windows.Forms.Padding(3);
            this.AdminFillCustomerID.PasswordChar = '\0';
            this.AdminFillCustomerID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.AdminFillCustomerID.PlaceholderText = "Fill your Customer\'s ID";
            this.AdminFillCustomerID.ReadOnly = false;
            this.AdminFillCustomerID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AdminFillCustomerID.SelectedText = "";
            this.AdminFillCustomerID.SelectionLength = 0;
            this.AdminFillCustomerID.SelectionStart = 0;
            this.AdminFillCustomerID.ShortcutsEnabled = true;
            this.AdminFillCustomerID.Size = new System.Drawing.Size(260, 37);
            this.AdminFillCustomerID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.AdminFillCustomerID.TabIndex = 18;
            this.AdminFillCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AdminFillCustomerID.TextMarginBottom = 0;
            this.AdminFillCustomerID.TextMarginLeft = 3;
            this.AdminFillCustomerID.TextMarginTop = 0;
            this.AdminFillCustomerID.TextPlaceholder = "Fill your Customer\'s ID";
            this.AdminFillCustomerID.UseSystemPasswordChar = false;
            this.AdminFillCustomerID.WordWrap = true;
            // 
            // AdminCheckCustomer
            // 
            this.AdminCheckCustomer.AllowAnimations = true;
            this.AdminCheckCustomer.AllowMouseEffects = true;
            this.AdminCheckCustomer.AllowToggling = false;
            this.AdminCheckCustomer.AnimationSpeed = 200;
            this.AdminCheckCustomer.AutoGenerateColors = false;
            this.AdminCheckCustomer.AutoRoundBorders = false;
            this.AdminCheckCustomer.AutoSizeLeftIcon = true;
            this.AdminCheckCustomer.AutoSizeRightIcon = true;
            this.AdminCheckCustomer.BackColor = System.Drawing.Color.Transparent;
            this.AdminCheckCustomer.BackColor1 = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminCheckCustomer.BackgroundImage")));
            this.AdminCheckCustomer.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminCheckCustomer.ButtonText = "CHECK";
            this.AdminCheckCustomer.ButtonTextMarginLeft = 0;
            this.AdminCheckCustomer.ColorContrastOnClick = 45;
            this.AdminCheckCustomer.ColorContrastOnHover = 45;
            this.AdminCheckCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.AdminCheckCustomer.CustomizableEdges = borderEdges2;
            this.AdminCheckCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AdminCheckCustomer.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminCheckCustomer.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminCheckCustomer.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminCheckCustomer.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AdminCheckCustomer.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCheckCustomer.ForeColor = System.Drawing.Color.White;
            this.AdminCheckCustomer.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdminCheckCustomer.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AdminCheckCustomer.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AdminCheckCustomer.IconMarginLeft = 11;
            this.AdminCheckCustomer.IconPadding = 10;
            this.AdminCheckCustomer.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AdminCheckCustomer.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AdminCheckCustomer.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AdminCheckCustomer.IconSize = 25;
            this.AdminCheckCustomer.IdleBorderColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.IdleBorderRadius = 37;
            this.AdminCheckCustomer.IdleBorderThickness = 1;
            this.AdminCheckCustomer.IdleFillColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.IdleIconLeftImage = null;
            this.AdminCheckCustomer.IdleIconRightImage = null;
            this.AdminCheckCustomer.IndicateFocus = false;
            this.AdminCheckCustomer.Location = new System.Drawing.Point(22, 603);
            this.AdminCheckCustomer.Name = "AdminCheckCustomer";
            this.AdminCheckCustomer.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AdminCheckCustomer.OnDisabledState.BorderRadius = 37;
            this.AdminCheckCustomer.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminCheckCustomer.OnDisabledState.BorderThickness = 1;
            this.AdminCheckCustomer.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AdminCheckCustomer.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AdminCheckCustomer.OnDisabledState.IconLeftImage = null;
            this.AdminCheckCustomer.OnDisabledState.IconRightImage = null;
            this.AdminCheckCustomer.onHoverState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.onHoverState.BorderRadius = 37;
            this.AdminCheckCustomer.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminCheckCustomer.onHoverState.BorderThickness = 1;
            this.AdminCheckCustomer.onHoverState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.onHoverState.ForeColor = System.Drawing.Color.Black;
            this.AdminCheckCustomer.onHoverState.IconLeftImage = null;
            this.AdminCheckCustomer.onHoverState.IconRightImage = null;
            this.AdminCheckCustomer.OnIdleState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.OnIdleState.BorderRadius = 37;
            this.AdminCheckCustomer.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminCheckCustomer.OnIdleState.BorderThickness = 1;
            this.AdminCheckCustomer.OnIdleState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AdminCheckCustomer.OnIdleState.IconLeftImage = null;
            this.AdminCheckCustomer.OnIdleState.IconRightImage = null;
            this.AdminCheckCustomer.OnPressedState.BorderColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.OnPressedState.BorderRadius = 37;
            this.AdminCheckCustomer.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AdminCheckCustomer.OnPressedState.BorderThickness = 1;
            this.AdminCheckCustomer.OnPressedState.FillColor = System.Drawing.Color.LightSalmon;
            this.AdminCheckCustomer.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AdminCheckCustomer.OnPressedState.IconLeftImage = null;
            this.AdminCheckCustomer.OnPressedState.IconRightImage = null;
            this.AdminCheckCustomer.Size = new System.Drawing.Size(117, 36);
            this.AdminCheckCustomer.TabIndex = 17;
            this.AdminCheckCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AdminCheckCustomer.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdminCheckCustomer.TextMarginLeft = 0;
            this.AdminCheckCustomer.TextPadding = new System.Windows.Forms.Padding(0);
            this.AdminCheckCustomer.UseDefaultRadiusAndThickness = true;
            // 
            // AdminCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.AdminViewAllCustomer);
            this.Controls.Add(this.AdminShowRating);
            this.Controls.Add(this.AdminShowAllCustomers);
            this.Controls.Add(this.AdminFillCustomerID);
            this.Controls.Add(this.AdminCheckCustomer);
            this.Name = "AdminCustomer";
            this.Size = new System.Drawing.Size(1069, 705);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.ListView AdminViewAllCustomer;
        private Bunifu.UI.WinForms.BunifuRating AdminShowRating;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AdminShowAllCustomers;
        private Bunifu.UI.WinForms.BunifuTextBox AdminFillCustomerID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AdminCheckCustomer;
    }
}
