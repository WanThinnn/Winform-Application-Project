namespace SignIn_SignUp
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            panel2 = new Panel();
            lbPassword = new Label();
            txPassword = new TextBox();
            lbUsername = new Label();
            txUsername = new TextBox();
            pictureBox1 = new PictureBox();
            btLogin = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btLogin);
            panel1.Location = new Point(17, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(709, 412);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel2.Location = new Point(510, 335);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(79, 25);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign up";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.FromArgb(128, 64, 0);
            linkLabel1.Location = new Point(117, 335);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(211, 25);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot your password?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbPassword);
            panel2.Controls.Add(txPassword);
            panel2.Controls.Add(lbUsername);
            panel2.Controls.Add(txUsername);
            panel2.Location = new Point(41, 148);
            panel2.Name = "panel2";
            panel2.Size = new Size(622, 124);
            panel2.TabIndex = 5;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPassword.Location = new Point(80, 69);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(113, 25);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Password:";
            // 
            // txPassword
            // 
            txPassword.Font = new Font("Microsoft Sans Serif", 9F);
            txPassword.Location = new Point(202, 66);
            txPassword.Name = "txPassword";
            txPassword.PlaceholderText = "Enter your password";
            txPassword.Size = new Size(346, 28);
            txPassword.TabIndex = 2;
            txPassword.UseSystemPasswordChar = true;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(76, 22);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(117, 25);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Username:";
            // 
            // txUsername
            // 
            txUsername.Font = new Font("Microsoft Sans Serif", 9F);
            txUsername.Location = new Point(202, 19);
            txUsername.Name = "txUsername";
            txUsername.PlaceholderText = "Enter your username";
            txUsername.Size = new Size(346, 28);
            txUsername.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PeachPuff;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(266, -11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Sienna;
            btLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = SystemColors.ControlLightLight;
            btLogin.Location = new Point(117, 278);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(472, 42);
            btLogin.TabIndex = 1;
            btLogin.Text = "Login";
            btLogin.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(750, 450);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Login";
            Text = "Login ";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btLogin;
        private Panel panel2;
        private Label lbPassword;
        private TextBox txPassword;
        private Label lbUsername;
        private TextBox txUsername;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
    }
}
