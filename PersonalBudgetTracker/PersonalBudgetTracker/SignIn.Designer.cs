namespace PersonalBudgetTracker
{
    partial class SignIn
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_signupSignIn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_signIn = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_loginSignIn = new System.Windows.Forms.Button();
            this.chckBx_showPassword = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btn_signupSignIn);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 630);
            this.panel1.TabIndex = 0;
            // 
            // btn_signupSignIn
            // 
            this.btn_signupSignIn.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_signupSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signupSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signupSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_signupSignIn.Location = new System.Drawing.Point(125, 553);
            this.btn_signupSignIn.Name = "btn_signupSignIn";
            this.btn_signupSignIn.Size = new System.Drawing.Size(288, 38);
            this.btn_signupSignIn.TabIndex = 9;
            this.btn_signupSignIn.Text = "SIGN UP";
            this.btn_signupSignIn.UseVisualStyleBackColor = false;
            this.btn_signupSignIn.Click += new System.EventHandler(this.btn_signupSignIn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Felix Titling", 19.8F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(99, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 39);
            this.label7.TabIndex = 4;
            this.label7.Text = "TRACKER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 515);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 26);
            this.label6.TabIndex = 3;
            this.label6.Text = "Register Here";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Income and Expense";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_close.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(972, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(21, 21);
            this.lbl_close.TabIndex = 1;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // lbl_signIn
            // 
            this.lbl_signIn.AutoSize = true;
            this.lbl_signIn.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_signIn.Location = new System.Drawing.Point(507, 121);
            this.lbl_signIn.Name = "lbl_signIn";
            this.lbl_signIn.Size = new System.Drawing.Size(155, 40);
            this.lbl_signIn.TabIndex = 2;
            this.lbl_signIn.Text = "SIGN IN";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(510, 202);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(100, 24);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(514, 253);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(462, 22);
            this.txt_username.TabIndex = 4;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(514, 357);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(462, 22);
            this.txt_password.TabIndex = 5;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(516, 307);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(94, 24);
            this.lbl_password.TabIndex = 6;
            this.lbl_password.Text = "Password";
            // 
            // btn_loginSignIn
            // 
            this.btn_loginSignIn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_loginSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_loginSignIn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loginSignIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_loginSignIn.Location = new System.Drawing.Point(514, 451);
            this.btn_loginSignIn.Name = "btn_loginSignIn";
            this.btn_loginSignIn.Size = new System.Drawing.Size(103, 67);
            this.btn_loginSignIn.TabIndex = 7;
            this.btn_loginSignIn.Text = "LOGIN";
            this.btn_loginSignIn.UseVisualStyleBackColor = false;
            this.btn_loginSignIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // chckBx_showPassword
            // 
            this.chckBx_showPassword.AutoSize = true;
            this.chckBx_showPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckBx_showPassword.Location = new System.Drawing.Point(815, 417);
            this.chckBx_showPassword.Name = "chckBx_showPassword";
            this.chckBx_showPassword.Size = new System.Drawing.Size(161, 26);
            this.chckBx_showPassword.TabIndex = 8;
            this.chckBx_showPassword.Text = "Show Password";
            this.chckBx_showPassword.UseVisualStyleBackColor = true;
            this.chckBx_showPassword.CheckedChanged += new System.EventHandler(this.chckBx_showPassword_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalBudgetTracker.Properties.Resources.Capturee;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(431, 379);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 630);
            this.Controls.Add(this.chckBx_showPassword);
            this.Controls.Add(this.btn_loginSignIn);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_signIn);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignIn";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignInForm";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_signIn;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Button btn_loginSignIn;
        private System.Windows.Forms.CheckBox chckBx_showPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_signupSignIn;
    }
}

