namespace PersonalBudgetTracker
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLgOutMain = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnExpMain = new System.Windows.Forms.Button();
            this.btnIncmMain = new System.Windows.Forms.Button();
            this.btnAddCatMain = new System.Windows.Forms.Button();
            this.btnDashMain = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl11 = new PersonalBudgetTracker.UserControl1();
            this.incomeForm11 = new PersonalBudgetTracker.IncomeForm1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label1.Location = new System.Drawing.Point(1514, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1605, 43);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label2.Location = new System.Drawing.Point(65, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Income and Expense Tracker";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnLgOutMain);
            this.panel2.Controls.Add(this.btnExpMain);
            this.panel2.Controls.Add(this.btnIncmMain);
            this.panel2.Controls.Add(this.btnAddCatMain);
            this.panel2.Controls.Add(this.btnDashMain);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 43);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(514, 757);
            this.panel2.TabIndex = 4;
            // 
            // btnLgOutMain
            // 
            this.btnLgOutMain.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnLgOutMain.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLgOutMain.ForeColor = System.Drawing.Color.Snow;
            this.btnLgOutMain.Location = new System.Drawing.Point(104, 660);
            this.btnLgOutMain.Name = "btnLgOutMain";
            this.btnLgOutMain.Size = new System.Drawing.Size(256, 63);
            this.btnLgOutMain.TabIndex = 9;
            this.btnLgOutMain.Text = "LogOut";
            this.btnLgOutMain.UseVisualStyleBackColor = false;
            this.btnLgOutMain.Click += new System.EventHandler(this.btnLgOutMain_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("News706 BT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Welcome ,";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.incomeForm11);
            this.panel3.Controls.Add(this.userControl11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(514, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1091, 757);
            this.panel3.TabIndex = 5;
            // 
            // btnExpMain
            // 
            this.btnExpMain.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpMain.ForeColor = System.Drawing.Color.Snow;
            this.btnExpMain.Image = global::PersonalBudgetTracker.Properties.Resources.dash;
            this.btnExpMain.Location = new System.Drawing.Point(84, 489);
            this.btnExpMain.Name = "btnExpMain";
            this.btnExpMain.Size = new System.Drawing.Size(308, 37);
            this.btnExpMain.TabIndex = 8;
            this.btnExpMain.Text = "Expenses";
            this.btnExpMain.UseVisualStyleBackColor = true;
            // 
            // btnIncmMain
            // 
            this.btnIncmMain.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncmMain.ForeColor = System.Drawing.Color.Snow;
            this.btnIncmMain.Image = global::PersonalBudgetTracker.Properties.Resources.dash;
            this.btnIncmMain.Location = new System.Drawing.Point(84, 435);
            this.btnIncmMain.Name = "btnIncmMain";
            this.btnIncmMain.Size = new System.Drawing.Size(308, 37);
            this.btnIncmMain.TabIndex = 7;
            this.btnIncmMain.Text = "Income";
            this.btnIncmMain.UseVisualStyleBackColor = true;
            // 
            // btnAddCatMain
            // 
            this.btnAddCatMain.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCatMain.ForeColor = System.Drawing.Color.Snow;
            this.btnAddCatMain.Image = global::PersonalBudgetTracker.Properties.Resources.dash;
            this.btnAddCatMain.Location = new System.Drawing.Point(84, 383);
            this.btnAddCatMain.Name = "btnAddCatMain";
            this.btnAddCatMain.Size = new System.Drawing.Size(308, 37);
            this.btnAddCatMain.TabIndex = 6;
            this.btnAddCatMain.Text = "Add Catergory";
            this.btnAddCatMain.UseVisualStyleBackColor = true;
            // 
            // btnDashMain
            // 
            this.btnDashMain.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashMain.ForeColor = System.Drawing.Color.Snow;
            this.btnDashMain.Image = global::PersonalBudgetTracker.Properties.Resources.dash;
            this.btnDashMain.Location = new System.Drawing.Point(84, 331);
            this.btnDashMain.Name = "btnDashMain";
            this.btnDashMain.Size = new System.Drawing.Size(308, 37);
            this.btnDashMain.TabIndex = 5;
            this.btnDashMain.Text = "Dashboard";
            this.btnDashMain.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PersonalBudgetTracker.Properties.Resources.money;
            this.pictureBox2.Location = new System.Drawing.Point(84, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(308, 264);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PersonalBudgetTracker.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(48, 23);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(900, 700);
            this.userControl11.TabIndex = 0;
            // 
            // incomeForm11
            // 
            this.incomeForm11.Location = new System.Drawing.Point(0, 3);
            this.incomeForm11.Name = "incomeForm11";
            this.incomeForm11.Size = new System.Drawing.Size(1034, 709);
            this.incomeForm11.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1605, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDashMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExpMain;
        private System.Windows.Forms.Button btnIncmMain;
        private System.Windows.Forms.Button btnAddCatMain;
        private System.Windows.Forms.Button btnLgOutMain;
        private System.Windows.Forms.Panel panel3;
        private UserControl1 userControl11;
        private IncomeForm1 incomeForm11;
    }
}