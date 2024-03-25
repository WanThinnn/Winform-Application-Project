namespace SignIn_SignUp
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            textBox7 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            lbUsername = new Label();
            txUsername = new TextBox();
            btLogin = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.PeachPuff;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(308, -36);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(205, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btLogin);
            panel1.Location = new Point(40, 12);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 412);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lbUsername);
            panel2.Controls.Add(txUsername);
            panel2.Location = new Point(23, 144);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 209);
            panel2.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft Sans Serif", 9F);
            textBox7.Location = new Point(514, 16);
            textBox7.Margin = new Padding(4, 3, 4, 3);
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "DD/MM/YYYY";
            textBox7.Size = new Size(228, 28);
            textBox7.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(383, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(136, 25);
            label4.TabIndex = 15;
            label4.Text = "Date of birth:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Microsoft Sans Serif", 9F);
            textBox4.Location = new Point(514, 162);
            textBox4.Margin = new Padding(4, 3, 4, 3);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Address";
            textBox4.Size = new Size(228, 28);
            textBox4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(407, 162);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(99, 25);
            label5.TabIndex = 13;
            label5.Text = "Address:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Microsoft Sans Serif", 9F);
            textBox5.Location = new Point(514, 111);
            textBox5.Margin = new Padding(4, 3, 4, 3);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email address";
            textBox5.Size = new Size(228, 28);
            textBox5.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(407, 113);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(72, 25);
            label6.TabIndex = 11;
            label6.Text = "Email:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Microsoft Sans Serif", 9F);
            textBox6.Location = new Point(514, 62);
            textBox6.Margin = new Padding(4, 3, 4, 3);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Phone number";
            textBox6.Size = new Size(228, 28);
            textBox6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(407, 67);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(81, 25);
            label7.TabIndex = 9;
            label7.Text = "Phone:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 165);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 25);
            label3.TabIndex = 7;
            label3.Text = "Confirm:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Microsoft Sans Serif", 9F);
            textBox3.Location = new Point(127, 162);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Confirm your password";
            textBox3.Size = new Size(228, 28);
            textBox3.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 5;
            label2.Text = "Password:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Microsoft Sans Serif", 9F);
            textBox2.Location = new Point(127, 111);
            textBox2.Margin = new Padding(4, 3, 4, 3);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(228, 28);
            textBox2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 9F);
            textBox1.Location = new Point(127, 62);
            textBox1.Margin = new Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Username";
            textBox1.Size = new Size(228, 28);
            textBox1.TabIndex = 2;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbUsername.Location = new Point(6, 19);
            lbUsername.Margin = new Padding(4, 0, 4, 0);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(113, 25);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Full name:";
            lbUsername.TextAlign = ContentAlignment.TopRight;
            // 
            // txUsername
            // 
            txUsername.Font = new Font("Microsoft Sans Serif", 9F);
            txUsername.Location = new Point(127, 16);
            txUsername.Margin = new Padding(4, 3, 4, 3);
            txUsername.Name = "txUsername";
            txUsername.PlaceholderText = "Full name";
            txUsername.Size = new Size(228, 28);
            txUsername.TabIndex = 0;
            // 
            // btLogin
            // 
            btLogin.BackColor = Color.Sienna;
            btLogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btLogin.ForeColor = SystemColors.ControlLightLight;
            btLogin.Location = new Point(113, 370);
            btLogin.Margin = new Padding(4, 3, 4, 3);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(566, 42);
            btLogin.TabIndex = 1;
            btLogin.Text = "Sign up";
            btLogin.UseVisualStyleBackColor = false;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(869, 450);
            Controls.Add(panel1);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "SignUp";
            Text = "SignUp";
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label lbUsername;
        private TextBox txUsername;
        private Button btLogin;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private Label label3;
        private TextBox textBox3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox7;
    }
}