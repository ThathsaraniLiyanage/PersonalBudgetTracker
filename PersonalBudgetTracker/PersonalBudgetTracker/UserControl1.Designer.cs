namespace PersonalBudgetTracker
{
    partial class UserControl1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_clrear_uc = new System.Windows.Forms.Button();
            this.btn_update_uc = new System.Windows.Forms.Button();
            this.btn_dlt_uc = new System.Windows.Forms.Button();
            this.btn_add_uc = new System.Windows.Forms.Button();
            this.combo_status_uc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_type_uc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_catergory_uc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_clrear_uc);
            this.panel1.Controls.Add(this.btn_update_uc);
            this.panel1.Controls.Add(this.btn_dlt_uc);
            this.panel1.Controls.Add(this.btn_add_uc);
            this.panel1.Controls.Add(this.combo_status_uc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combo_type_uc);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_catergory_uc);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(14, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 673);
            this.panel1.TabIndex = 0;
            // 
            // btn_clrear_uc
            // 
            this.btn_clrear_uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clrear_uc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clrear_uc.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clrear_uc.Location = new System.Drawing.Point(21, 492);
            this.btn_clrear_uc.Name = "btn_clrear_uc";
            this.btn_clrear_uc.Size = new System.Drawing.Size(110, 51);
            this.btn_clrear_uc.TabIndex = 9;
            this.btn_clrear_uc.Text = "CLEAR";
            this.btn_clrear_uc.UseVisualStyleBackColor = false;
            this.btn_clrear_uc.Click += new System.EventHandler(this.btn_clrear_uc_Click);
            // 
            // btn_update_uc
            // 
            this.btn_update_uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_update_uc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_uc.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_uc.Location = new System.Drawing.Point(156, 392);
            this.btn_update_uc.Name = "btn_update_uc";
            this.btn_update_uc.Size = new System.Drawing.Size(111, 51);
            this.btn_update_uc.TabIndex = 8;
            this.btn_update_uc.Text = "UPDATE";
            this.btn_update_uc.UseVisualStyleBackColor = false;
            this.btn_update_uc.Click += new System.EventHandler(this.btn_update_uc_Click);
            // 
            // btn_dlt_uc
            // 
            this.btn_dlt_uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_dlt_uc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dlt_uc.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dlt_uc.Location = new System.Drawing.Point(156, 492);
            this.btn_dlt_uc.Name = "btn_dlt_uc";
            this.btn_dlt_uc.Size = new System.Drawing.Size(111, 51);
            this.btn_dlt_uc.TabIndex = 7;
            this.btn_dlt_uc.Text = "DELETE";
            this.btn_dlt_uc.UseVisualStyleBackColor = false;
            this.btn_dlt_uc.Click += new System.EventHandler(this.btn_dlt_uc_Click);
            // 
            // btn_add_uc
            // 
            this.btn_add_uc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_add_uc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_uc.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_uc.Location = new System.Drawing.Point(21, 392);
            this.btn_add_uc.Name = "btn_add_uc";
            this.btn_add_uc.Size = new System.Drawing.Size(110, 51);
            this.btn_add_uc.TabIndex = 6;
            this.btn_add_uc.Text = "ADD";
            this.btn_add_uc.UseVisualStyleBackColor = false;
            this.btn_add_uc.Click += new System.EventHandler(this.btn_add_uc_Click);
            // 
            // combo_status_uc
            // 
            this.combo_status_uc.FormattingEnabled = true;
            this.combo_status_uc.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            ""});
            this.combo_status_uc.Location = new System.Drawing.Point(9, 304);
            this.combo_status_uc.Name = "combo_status_uc";
            this.combo_status_uc.Size = new System.Drawing.Size(269, 33);
            this.combo_status_uc.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // combo_type_uc
            // 
            this.combo_type_uc.FormattingEnabled = true;
            this.combo_type_uc.Items.AddRange(new object[] {
            "Income ",
            "Expense"});
            this.combo_type_uc.Location = new System.Drawing.Point(9, 188);
            this.combo_type_uc.Name = "combo_type_uc";
            this.combo_type_uc.Size = new System.Drawing.Size(269, 33);
            this.combo_type_uc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type";
            // 
            // txt_catergory_uc
            // 
            this.txt_catergory_uc.Location = new System.Drawing.Point(9, 76);
            this.txt_catergory_uc.Name = "txt_catergory_uc";
            this.txt_catergory_uc.Size = new System.Drawing.Size(269, 30);
            this.txt_catergory_uc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Catergory";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(319, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 673);
            this.panel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Catergory List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(14, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(548, 616);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Elephant", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(917, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(946, 700);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo_type_uc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_catergory_uc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox combo_status_uc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_add_uc;
        private System.Windows.Forms.Button btn_clrear_uc;
        private System.Windows.Forms.Button btn_update_uc;
        private System.Windows.Forms.Button btn_dlt_uc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
    }
}
