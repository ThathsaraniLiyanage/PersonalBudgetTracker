namespace PersonalBudgetTracker
{
    partial class ExpensesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_ctgyr_el = new System.Windows.Forms.ComboBox();
            this.tn_clr_el = new System.Windows.Forms.Button();
            this.tn_updt_el = new System.Windows.Forms.Button();
            this.tn_dlt_el = new System.Windows.Forms.Button();
            this.tn_add_el = new System.Windows.Forms.Button();
            this.dteTme_el = new System.Windows.Forms.DateTimePicker();
            this.txt_dscrptn_el = new System.Windows.Forms.TextBox();
            this.txt_itm_el = new System.Windows.Forms.TextBox();
            this.txt_incm_el = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmb_ctgyr_el);
            this.panel4.Controls.Add(this.tn_clr_el);
            this.panel4.Controls.Add(this.tn_updt_el);
            this.panel4.Controls.Add(this.tn_dlt_el);
            this.panel4.Controls.Add(this.tn_add_el);
            this.panel4.Controls.Add(this.dteTme_el);
            this.panel4.Controls.Add(this.txt_dscrptn_el);
            this.panel4.Controls.Add(this.txt_itm_el);
            this.panel4.Controls.Add(this.txt_incm_el);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(8, 389);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(930, 293);
            this.panel4.TabIndex = 5;
            // 
            // cmb_ctgyr_el
            // 
            this.cmb_ctgyr_el.FormattingEnabled = true;
            this.cmb_ctgyr_el.Items.AddRange(new object[] {
            "Gadgets"});
            this.cmb_ctgyr_el.Location = new System.Drawing.Point(166, 22);
            this.cmb_ctgyr_el.Name = "cmb_ctgyr_el";
            this.cmb_ctgyr_el.Size = new System.Drawing.Size(246, 24);
            this.cmb_ctgyr_el.TabIndex = 16;
            // 
            // tn_clr_el
            // 
            this.tn_clr_el.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tn_clr_el.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tn_clr_el.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_clr_el.Location = new System.Drawing.Point(670, 214);
            this.tn_clr_el.Name = "tn_clr_el";
            this.tn_clr_el.Size = new System.Drawing.Size(110, 51);
            this.tn_clr_el.TabIndex = 15;
            this.tn_clr_el.Text = "CLEAR";
            this.tn_clr_el.UseVisualStyleBackColor = false;
            this.tn_clr_el.Click += new System.EventHandler(this.tn_clr_el_Click);
            // 
            // tn_updt_el
            // 
            this.tn_updt_el.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tn_updt_el.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tn_updt_el.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_updt_el.Location = new System.Drawing.Point(322, 214);
            this.tn_updt_el.Name = "tn_updt_el";
            this.tn_updt_el.Size = new System.Drawing.Size(111, 51);
            this.tn_updt_el.TabIndex = 14;
            this.tn_updt_el.Text = "UPDATE";
            this.tn_updt_el.UseVisualStyleBackColor = false;
            this.tn_updt_el.Click += new System.EventHandler(this.tn_updt_el_Click);
            // 
            // tn_dlt_el
            // 
            this.tn_dlt_el.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tn_dlt_el.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tn_dlt_el.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_dlt_el.Location = new System.Drawing.Point(496, 214);
            this.tn_dlt_el.Name = "tn_dlt_el";
            this.tn_dlt_el.Size = new System.Drawing.Size(111, 51);
            this.tn_dlt_el.TabIndex = 13;
            this.tn_dlt_el.Text = "DELETE";
            this.tn_dlt_el.UseVisualStyleBackColor = false;
            this.tn_dlt_el.Click += new System.EventHandler(this.tn_dlt_el_Click);
            // 
            // tn_add_el
            // 
            this.tn_add_el.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.tn_add_el.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tn_add_el.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tn_add_el.Location = new System.Drawing.Point(154, 214);
            this.tn_add_el.Name = "tn_add_el";
            this.tn_add_el.Size = new System.Drawing.Size(110, 51);
            this.tn_add_el.TabIndex = 12;
            this.tn_add_el.Text = "ADD";
            this.tn_add_el.UseVisualStyleBackColor = false;
            this.tn_add_el.Click += new System.EventHandler(this.tn_add_el_Click);
            // 
            // dteTme_el
            // 
            this.dteTme_el.Location = new System.Drawing.Point(561, 157);
            this.dteTme_el.Name = "dteTme_el";
            this.dteTme_el.Size = new System.Drawing.Size(297, 22);
            this.dteTme_el.TabIndex = 11;
            // 
            // txt_dscrptn_el
            // 
            this.txt_dscrptn_el.Location = new System.Drawing.Point(561, 22);
            this.txt_dscrptn_el.Multiline = true;
            this.txt_dscrptn_el.Name = "txt_dscrptn_el";
            this.txt_dscrptn_el.Size = new System.Drawing.Size(331, 105);
            this.txt_dscrptn_el.TabIndex = 10;
            // 
            // txt_itm_el
            // 
            this.txt_itm_el.Location = new System.Drawing.Point(166, 83);
            this.txt_itm_el.Name = "txt_itm_el";
            this.txt_itm_el.Size = new System.Drawing.Size(246, 22);
            this.txt_itm_el.TabIndex = 9;
            // 
            // txt_incm_el
            // 
            this.txt_incm_el.Location = new System.Drawing.Point(166, 143);
            this.txt_incm_el.Name = "txt_incm_el";
            this.txt_incm_el.Size = new System.Drawing.Size(246, 22);
            this.txt_incm_el.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(440, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 5;
            this.label9.Text = "Income";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 25);
            this.label10.TabIndex = 4;
            this.label10.Text = "Item";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(440, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "Description";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Category";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(8, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(930, 352);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Expensee List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(16, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(894, 245);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(946, 700);
            this.Load += new System.EventHandler(this.ExpensesForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmb_ctgyr_el;
        private System.Windows.Forms.Button tn_clr_el;
        private System.Windows.Forms.Button tn_updt_el;
        private System.Windows.Forms.Button tn_dlt_el;
        private System.Windows.Forms.Button tn_add_el;
        private System.Windows.Forms.DateTimePicker dteTme_el;
        private System.Windows.Forms.TextBox txt_dscrptn_el;
        private System.Windows.Forms.TextBox txt_itm_el;
        private System.Windows.Forms.TextBox txt_incm_el;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
