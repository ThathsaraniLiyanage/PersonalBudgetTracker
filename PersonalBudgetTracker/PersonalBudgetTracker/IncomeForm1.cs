using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PersonalBudgetTracker
{
    public partial class IncomeForm1 : UserControl
    {
        string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Thathsarani Liyanage\\Documents\\expense.mdf\";Integrated Security=True;Connect Timeout=30";

        public IncomeForm1()
        {
            InitializeComponent();
            displayCategoryList();
            displayIncomeData();
        }

        public void displayIncomeData()
        {
            IncomeData iData = new IncomeData();
            List<IncomeData> listData = iData.IncomeListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategoryList()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    cmd.Parameters.AddWithValue("@type", "Income");
                    cmd.Parameters.AddWithValue("@status", "Active");

                    cmb_ctgry_il.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmb_ctgry_il.Items.Add(reader["category"].ToString());
                    }
                }

                conn.Close();
            }
        }

        private void btn_add_il_Click(object sender, EventArgs e)
        {
            if (cmb_ctgry_il.SelectedIndex == -1 || txt_itm_il.Text == "" || txt_incm_il.Text == "" || txt_dscrptn_il.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    string insertData = "INSERT INTO income(category, item, income, description, date_income, date)" +
                        "VALUES(@cat, @item, @income, @desc, @date_income, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, conn))
                    {
                        cmd.Parameters.AddWithValue("@cat", cmb_ctgry_il.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", txt_itm_il.Text);
                        cmd.Parameters.AddWithValue("@income", txt_incm_il.Text);
                        cmd.Parameters.AddWithValue("@desc", txt_dscrptn_il.Text);
                        cmd.Parameters.AddWithValue("@date_income", dateTime_il.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    conn.Close();
                }
            }
        }

        private void btn_clear_il_Click(object sender, EventArgs e)
        {
            cmb_ctgry_il.SelectedIndex = -1;
            txt_itm_il.Text = "";
            txt_incm_il.Text = "";
            txt_dscrptn_il.Text = "";
        }

        private void btn_update_il_Click(object sender, EventArgs e)
        {
            if (cmb_ctgry_il.SelectedIndex == -1 || txt_itm_il.Text == "" || txt_incm_il.Text == "" || txt_dscrptn_il.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(stringConnection))
                    {
                        conn.Open();

                        string updateData = "UPDATE income SET category = @cat, item = @item, income = @income, description = @desc, date_income = @date_income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@cat", cmb_ctgry_il.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", txt_itm_il.Text);
                            cmd.Parameters.AddWithValue("@income", txt_incm_il.Text);
                            cmd.Parameters.AddWithValue("@desc", txt_dscrptn_il.Text);
                            cmd.Parameters.AddWithValue("@date_income", dateTime_il.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            displayIncomeData();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                {
                    getID = (int)row.Cells[0].Value;
                    cmb_ctgry_il.SelectedItem = row.Cells[1].Value.ToString();
                    txt_itm_il.Text = row.Cells[2].Value.ToString();
                    txt_incm_il.Text = row.Cells[3].Value.ToString();
                    txt_dscrptn_il.Text = row.Cells[4].Value.ToString();
                    dateTime_il.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
                }
            }
        }

        private void btn_dlt_il_Click(object sender, EventArgs e)
        {
            if (cmb_ctgry_il.SelectedIndex == -1 || txt_itm_il.Text == "" || txt_incm_il.Text == "" || txt_dscrptn_il.Text == "")
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(stringConnection))
                    {
                        conn.Open();

                        string deleteData = "DELETE FROM income WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();

                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            displayIncomeData();
        }
    }
}
