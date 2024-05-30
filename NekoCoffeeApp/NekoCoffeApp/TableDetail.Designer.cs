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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.TableDetailsView = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TableDetailsAdd = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TableDetailsDelete = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(336, 389);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel1.BorderRadius = 35;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.TableDetailsView);
            this.bunifuPanel1.Controls.Add(this.TableDetailsAdd);
            this.bunifuPanel1.Controls.Add(this.TableDetailsDelete);
            this.bunifuPanel1.Controls.Add(this.numericUpDown1);
            this.bunifuPanel1.Controls.Add(this.comboBox2);
            this.bunifuPanel1.Controls.Add(this.comboBox1);
            this.bunifuPanel1.ForeColor = System.Drawing.Color.LightSalmon;
            this.bunifuPanel1.Location = new System.Drawing.Point(351, 4);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(212, 389);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // TableDetailsView
            // 
            this.TableDetailsView.AllowAnimations = true;
            this.TableDetailsView.AllowMouseEffects = true;
            this.TableDetailsView.AllowToggling = false;
            this.TableDetailsView.AnimationSpeed = 200;
            this.TableDetailsView.AutoGenerateColors = false;
            this.TableDetailsView.AutoRoundBorders = false;
            this.TableDetailsView.AutoSizeLeftIcon = true;
            this.TableDetailsView.AutoSizeRightIcon = true;
            this.TableDetailsView.BackColor = System.Drawing.Color.Transparent;
            this.TableDetailsView.BackColor1 = System.Drawing.Color.White;
            this.TableDetailsView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TableDetailsView.BackgroundImage")));
            this.TableDetailsView.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsView.ButtonText = "VIEW";
            this.TableDetailsView.ButtonTextMarginLeft = 0;
            this.TableDetailsView.ColorContrastOnClick = 45;
            this.TableDetailsView.ColorContrastOnHover = 45;
            this.TableDetailsView.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.TableDetailsView.CustomizableEdges = borderEdges4;
            this.TableDetailsView.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TableDetailsView.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TableDetailsView.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableDetailsView.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TableDetailsView.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.TableDetailsView.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableDetailsView.ForeColor = System.Drawing.Color.LightSalmon;
            this.TableDetailsView.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableDetailsView.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.TableDetailsView.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.TableDetailsView.IconMarginLeft = 11;
            this.TableDetailsView.IconPadding = 10;
            this.TableDetailsView.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableDetailsView.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.TableDetailsView.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.TableDetailsView.IconSize = 25;
            this.TableDetailsView.IdleBorderColor = System.Drawing.Color.White;
            this.TableDetailsView.IdleBorderRadius = 35;
            this.TableDetailsView.IdleBorderThickness = 1;
            this.TableDetailsView.IdleFillColor = System.Drawing.Color.White;
            this.TableDetailsView.IdleIconLeftImage = null;
            this.TableDetailsView.IdleIconRightImage = null;
            this.TableDetailsView.IndicateFocus = false;
            this.TableDetailsView.Location = new System.Drawing.Point(12, 171);
            this.TableDetailsView.Name = "TableDetailsView";
            this.TableDetailsView.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TableDetailsView.OnDisabledState.BorderRadius = 35;
            this.TableDetailsView.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsView.OnDisabledState.BorderThickness = 1;
            this.TableDetailsView.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableDetailsView.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TableDetailsView.OnDisabledState.IconLeftImage = null;
            this.TableDetailsView.OnDisabledState.IconRightImage = null;
            this.TableDetailsView.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.TableDetailsView.onHoverState.BorderRadius = 35;
            this.TableDetailsView.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsView.onHoverState.BorderThickness = 1;
            this.TableDetailsView.onHoverState.FillColor = System.Drawing.Color.Black;
            this.TableDetailsView.onHoverState.ForeColor = System.Drawing.Color.White;
            this.TableDetailsView.onHoverState.IconLeftImage = null;
            this.TableDetailsView.onHoverState.IconRightImage = null;
            this.TableDetailsView.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.TableDetailsView.OnIdleState.BorderRadius = 35;
            this.TableDetailsView.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsView.OnIdleState.BorderThickness = 1;
            this.TableDetailsView.OnIdleState.FillColor = System.Drawing.Color.White;
            this.TableDetailsView.OnIdleState.ForeColor = System.Drawing.Color.LightSalmon;
            this.TableDetailsView.OnIdleState.IconLeftImage = null;
            this.TableDetailsView.OnIdleState.IconRightImage = null;
            this.TableDetailsView.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.TableDetailsView.OnPressedState.BorderRadius = 35;
            this.TableDetailsView.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsView.OnPressedState.BorderThickness = 1;
            this.TableDetailsView.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.TableDetailsView.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.TableDetailsView.OnPressedState.IconLeftImage = null;
            this.TableDetailsView.OnPressedState.IconRightImage = null;
            this.TableDetailsView.Size = new System.Drawing.Size(192, 34);
            this.TableDetailsView.TabIndex = 7;
            this.TableDetailsView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableDetailsView.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TableDetailsView.TextMarginLeft = 0;
            this.TableDetailsView.TextPadding = new System.Windows.Forms.Padding(0);
            this.TableDetailsView.UseDefaultRadiusAndThickness = true;
            this.TableDetailsView.Click += new System.EventHandler(this.TableDetailsView_Click);
            // 
            // TableDetailsAdd
            // 
            this.TableDetailsAdd.AllowAnimations = true;
            this.TableDetailsAdd.AllowMouseEffects = true;
            this.TableDetailsAdd.AllowToggling = false;
            this.TableDetailsAdd.AnimationSpeed = 200;
            this.TableDetailsAdd.AutoGenerateColors = false;
            this.TableDetailsAdd.AutoRoundBorders = false;
            this.TableDetailsAdd.AutoSizeLeftIcon = true;
            this.TableDetailsAdd.AutoSizeRightIcon = true;
            this.TableDetailsAdd.BackColor = System.Drawing.Color.Transparent;
            this.TableDetailsAdd.BackColor1 = System.Drawing.Color.White;
            this.TableDetailsAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TableDetailsAdd.BackgroundImage")));
            this.TableDetailsAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsAdd.ButtonText = "ADD";
            this.TableDetailsAdd.ButtonTextMarginLeft = 0;
            this.TableDetailsAdd.ColorContrastOnClick = 45;
            this.TableDetailsAdd.ColorContrastOnHover = 45;
            this.TableDetailsAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.TableDetailsAdd.CustomizableEdges = borderEdges5;
            this.TableDetailsAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TableDetailsAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TableDetailsAdd.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableDetailsAdd.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TableDetailsAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.TableDetailsAdd.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableDetailsAdd.ForeColor = System.Drawing.Color.LightSalmon;
            this.TableDetailsAdd.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableDetailsAdd.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.TableDetailsAdd.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.TableDetailsAdd.IconMarginLeft = 11;
            this.TableDetailsAdd.IconPadding = 10;
            this.TableDetailsAdd.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableDetailsAdd.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.TableDetailsAdd.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.TableDetailsAdd.IconSize = 25;
            this.TableDetailsAdd.IdleBorderColor = System.Drawing.Color.White;
            this.TableDetailsAdd.IdleBorderRadius = 35;
            this.TableDetailsAdd.IdleBorderThickness = 1;
            this.TableDetailsAdd.IdleFillColor = System.Drawing.Color.White;
            this.TableDetailsAdd.IdleIconLeftImage = null;
            this.TableDetailsAdd.IdleIconRightImage = null;
            this.TableDetailsAdd.IndicateFocus = false;
            this.TableDetailsAdd.Location = new System.Drawing.Point(111, 131);
            this.TableDetailsAdd.Name = "TableDetailsAdd";
            this.TableDetailsAdd.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TableDetailsAdd.OnDisabledState.BorderRadius = 35;
            this.TableDetailsAdd.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsAdd.OnDisabledState.BorderThickness = 1;
            this.TableDetailsAdd.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableDetailsAdd.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TableDetailsAdd.OnDisabledState.IconLeftImage = null;
            this.TableDetailsAdd.OnDisabledState.IconRightImage = null;
            this.TableDetailsAdd.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.TableDetailsAdd.onHoverState.BorderRadius = 35;
            this.TableDetailsAdd.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsAdd.onHoverState.BorderThickness = 1;
            this.TableDetailsAdd.onHoverState.FillColor = System.Drawing.Color.Black;
            this.TableDetailsAdd.onHoverState.ForeColor = System.Drawing.Color.White;
            this.TableDetailsAdd.onHoverState.IconLeftImage = null;
            this.TableDetailsAdd.onHoverState.IconRightImage = null;
            this.TableDetailsAdd.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.TableDetailsAdd.OnIdleState.BorderRadius = 35;
            this.TableDetailsAdd.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsAdd.OnIdleState.BorderThickness = 1;
            this.TableDetailsAdd.OnIdleState.FillColor = System.Drawing.Color.White;
            this.TableDetailsAdd.OnIdleState.ForeColor = System.Drawing.Color.LightSalmon;
            this.TableDetailsAdd.OnIdleState.IconLeftImage = null;
            this.TableDetailsAdd.OnIdleState.IconRightImage = null;
            this.TableDetailsAdd.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.TableDetailsAdd.OnPressedState.BorderRadius = 35;
            this.TableDetailsAdd.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsAdd.OnPressedState.BorderThickness = 1;
            this.TableDetailsAdd.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.TableDetailsAdd.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.TableDetailsAdd.OnPressedState.IconLeftImage = null;
            this.TableDetailsAdd.OnPressedState.IconRightImage = null;
            this.TableDetailsAdd.Size = new System.Drawing.Size(93, 34);
            this.TableDetailsAdd.TabIndex = 6;
            this.TableDetailsAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableDetailsAdd.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TableDetailsAdd.TextMarginLeft = 0;
            this.TableDetailsAdd.TextPadding = new System.Windows.Forms.Padding(0);
            this.TableDetailsAdd.UseDefaultRadiusAndThickness = true;
            this.TableDetailsAdd.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // TableDetailsDelete
            // 
            this.TableDetailsDelete.AllowAnimations = true;
            this.TableDetailsDelete.AllowMouseEffects = true;
            this.TableDetailsDelete.AllowToggling = false;
            this.TableDetailsDelete.AnimationSpeed = 200;
            this.TableDetailsDelete.AutoGenerateColors = false;
            this.TableDetailsDelete.AutoRoundBorders = false;
            this.TableDetailsDelete.AutoSizeLeftIcon = true;
            this.TableDetailsDelete.AutoSizeRightIcon = true;
            this.TableDetailsDelete.BackColor = System.Drawing.Color.Transparent;
            this.TableDetailsDelete.BackColor1 = System.Drawing.Color.White;
            this.TableDetailsDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TableDetailsDelete.BackgroundImage")));
            this.TableDetailsDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsDelete.ButtonText = "DELETE";
            this.TableDetailsDelete.ButtonTextMarginLeft = 0;
            this.TableDetailsDelete.ColorContrastOnClick = 45;
            this.TableDetailsDelete.ColorContrastOnHover = 45;
            this.TableDetailsDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.TableDetailsDelete.CustomizableEdges = borderEdges6;
            this.TableDetailsDelete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.TableDetailsDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TableDetailsDelete.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableDetailsDelete.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TableDetailsDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.TableDetailsDelete.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableDetailsDelete.ForeColor = System.Drawing.Color.LightSalmon;
            this.TableDetailsDelete.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TableDetailsDelete.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.TableDetailsDelete.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.TableDetailsDelete.IconMarginLeft = 11;
            this.TableDetailsDelete.IconPadding = 10;
            this.TableDetailsDelete.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TableDetailsDelete.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.TableDetailsDelete.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.TableDetailsDelete.IconSize = 25;
            this.TableDetailsDelete.IdleBorderColor = System.Drawing.Color.White;
            this.TableDetailsDelete.IdleBorderRadius = 35;
            this.TableDetailsDelete.IdleBorderThickness = 1;
            this.TableDetailsDelete.IdleFillColor = System.Drawing.Color.White;
            this.TableDetailsDelete.IdleIconLeftImage = null;
            this.TableDetailsDelete.IdleIconRightImage = null;
            this.TableDetailsDelete.IndicateFocus = false;
            this.TableDetailsDelete.Location = new System.Drawing.Point(12, 131);
            this.TableDetailsDelete.Name = "TableDetailsDelete";
            this.TableDetailsDelete.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.TableDetailsDelete.OnDisabledState.BorderRadius = 35;
            this.TableDetailsDelete.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsDelete.OnDisabledState.BorderThickness = 1;
            this.TableDetailsDelete.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TableDetailsDelete.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.TableDetailsDelete.OnDisabledState.IconLeftImage = null;
            this.TableDetailsDelete.OnDisabledState.IconRightImage = null;
            this.TableDetailsDelete.onHoverState.BorderColor = System.Drawing.Color.Black;
            this.TableDetailsDelete.onHoverState.BorderRadius = 35;
            this.TableDetailsDelete.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsDelete.onHoverState.BorderThickness = 1;
            this.TableDetailsDelete.onHoverState.FillColor = System.Drawing.Color.Black;
            this.TableDetailsDelete.onHoverState.ForeColor = System.Drawing.Color.White;
            this.TableDetailsDelete.onHoverState.IconLeftImage = null;
            this.TableDetailsDelete.onHoverState.IconRightImage = null;
            this.TableDetailsDelete.OnIdleState.BorderColor = System.Drawing.Color.White;
            this.TableDetailsDelete.OnIdleState.BorderRadius = 35;
            this.TableDetailsDelete.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsDelete.OnIdleState.BorderThickness = 1;
            this.TableDetailsDelete.OnIdleState.FillColor = System.Drawing.Color.White;
            this.TableDetailsDelete.OnIdleState.ForeColor = System.Drawing.Color.LightSalmon;
            this.TableDetailsDelete.OnIdleState.IconLeftImage = null;
            this.TableDetailsDelete.OnIdleState.IconRightImage = null;
            this.TableDetailsDelete.OnPressedState.BorderColor = System.Drawing.Color.Black;
            this.TableDetailsDelete.OnPressedState.BorderRadius = 35;
            this.TableDetailsDelete.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.TableDetailsDelete.OnPressedState.BorderThickness = 1;
            this.TableDetailsDelete.OnPressedState.FillColor = System.Drawing.Color.Black;
            this.TableDetailsDelete.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.TableDetailsDelete.OnPressedState.IconLeftImage = null;
            this.TableDetailsDelete.OnPressedState.IconRightImage = null;
            this.TableDetailsDelete.Size = new System.Drawing.Size(93, 34);
            this.TableDetailsDelete.TabIndex = 5;
            this.TableDetailsDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TableDetailsDelete.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.TableDetailsDelete.TextMarginLeft = 0;
            this.TableDetailsDelete.TextPadding = new System.Windows.Forms.Padding(0);
            this.TableDetailsDelete.UseDefaultRadiusAndThickness = true;
            this.TableDetailsDelete.Click += new System.EventHandler(this.TableDetailsAdd_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(84, 95);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 58);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(192, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // TableDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 397);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TableDetail";
            this.Text = "TableDetail";
            this.Load += new System.EventHandler(this.TableDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton TableDetailsDelete;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton TableDetailsView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton TableDetailsAdd;
    }
}