using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PersonalBudgetTracker
{
    public partial class ExpensesForm : UserControl
    {
        string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Thathsarani Liyanage\\Documents\\expense.mdf\";Integrated Security=True;Connect Timeout=30";

        public ExpensesForm()
        {
            InitializeComponent();
            displayExpensesData();
            displayCategoryList();
            displayExpensesData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            displayExpensesData();
        }


        public void displayExpensesData()
        {
            // Assuming ExpensesData is a defined class and has a method expensesListData()
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.expensesListData();

            dataGridView1.DataSource = listData;
        }

        private void ExpensesForm_Load(object sender, EventArgs e)
        {
            // Typically, any form initialization code
        }

        public void displayCategoryList()
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status";

                using (SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    cmd.Parameters.AddWithValue("@type", "Expenses"); // Ensure 'type' is a string column in the DB
                    cmd.Parameters.AddWithValue("@status", "Active"); // Ensure 'status' is a string column in the DB

                    cmb_ctgyr_el.Items.Clear();

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmb_ctgyr_el.Items.Add(reader["category"].ToString());
                    }
                }

                conn.Close();
            }
        }


        private void tn_add_el_Click(object sender, EventArgs e)
        {
            if (cmb_ctgyr_el.SelectedIndex == -1 || txt_itm_el.Text == "" || txt_incm_el.Text == "" || txt_dscrptn_el.Text == "")
            {

                MessageBox.Show("Please fll all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(stringConnection))
                {
                    conn.Open();

                    string insertData = "INSERT INTO expenses(catedory, item, cost, description,date_expense, date_insert) " +
                        "date_expense = @date_ex, date_insert = @date)" +
                        "VALUES(@cat, @item, @cost, @desc, @date_ex, @date)";

                    using (SqlCommand cmd = new SqlCommand(insertData, conn))
                    {
                        cmd.Parameters.AddWithValue("@cat", cmb_ctgyr_el.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", txt_itm_el.Text);
                        cmd.Parameters.AddWithValue("@income", txt_incm_el.Text);
                        cmd.Parameters.AddWithValue("@desc", txt_dscrptn_el.Text);
                        cmd.Parameters.AddWithValue("@date_income", dteTme_el.Text);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    conn.Close();
                }
            }
            displayExpensesData();
        }

        public void clearFields() {
            cmb_ctgyr_el.SelectedIndex = -1;
            txt_itm_el.Text = "";
            txt_incm_el.Text = "";
            txt_dscrptn_el.Text = "";
        }

        private void tn_clr_el_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void tn_updt_el_Click(object sender, EventArgs e)
        {
            if (cmb_ctgyr_el.SelectedIndex == -1 || txt_itm_el.Text == "" || txt_incm_el.Text == "" || txt_dscrptn_el.Text == "")
            {

                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(stringConnection))
                    {
                        conn.Open();

                        string updateData = "UPDATE expenses SET category = @cat, item = @item, income = @income, " +
                            "description = @desc, date_ex = @date_in, WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.AddWithValue("@cat", cmb_ctgyr_el.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", txt_itm_el.Text);
                            cmd.Parameters.AddWithValue("@income", txt_incm_el.Text);
                            cmd.Parameters.AddWithValue("@desc", txt_dscrptn_el.Text);
                            cmd.Parameters.AddWithValue("@date_ex", dteTme_el.Text);
                           // cmd.Parameters.AddWithValue("@id", getID);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            displayExpensesData();
        }

        private int getID = 0;


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                cmb_ctgyr_el.SelectedItem = row.Cells[1].Value.ToString();
                txt_itm_el.Text = row.Cells[2].Value.ToString();
                txt_incm_el.Text = row.Cells[3].Value.ToString();
                txt_dscrptn_el.Text = row.Cells[4].Value.ToString();
                dteTme_el.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void tn_dlt_el_Click(object sender, EventArgs e)
        {
            if (cmb_ctgyr_el.SelectedIndex == -1 || txt_itm_el.Text == "" || txt_incm_el.Text == "" || txt_dscrptn_el.Text == "")
            {

                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(stringConnection))
                    {
                        conn.Open();

                        string deleteData = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, conn))
                        {
                            cmd.Parameters.AddWithValue("@cat", cmb_ctgyr_el.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", txt_itm_el.Text);
                            cmd.Parameters.AddWithValue("@income", txt_incm_el.Text);
                            cmd.Parameters.AddWithValue("@desc", txt_dscrptn_el.Text);
                            cmd.Parameters.AddWithValue("@date_ex", dteTme_el.Text);
                            // cmd.Parameters.AddWithValue("@id", getID);

                            DateTime today = DateTime.Today;
                            cmd.Parameters.AddWithValue("@date", today);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        conn.Close();
                    }
                }
            }
            displayExpensesData();
        }
    }
}
