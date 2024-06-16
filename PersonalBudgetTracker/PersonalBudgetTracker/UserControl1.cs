using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace PersonalBudgetTracker
{
    public partial class UserControl1 : UserControl
    {
        // String stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Thathsarani Liyanage\\Documents\\expense.mdf\";Integrated Security=True;Connect Timeout=30";
        string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Thathsarani Liyanage\\Documents\\expense.mdf\";Integrated Security=True;Connect Timeout=30";
        public UserControl1()
        {
            InitializeComponent();

            displayCatergoryList();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            displayCatergoryList();
        }

        public void displayCatergoryList()
        {
            CatergoryData cData = new CatergoryData();
            List<CatergoryData> listData = cData.catergoryListData();

            dataGridView1.DataSource = listData;

           // dataGridView1.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
        }

        private void btn_add_uc_Click(object sender, EventArgs e)
        {
            if (txt_catergory_uc.Text == "" || combo_type_uc.SelectedIndex == -1 || combo_status_uc.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all blank fields", "Error Messaage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    String insertData = "INSERT INTO categories(category, type, status, date_insert)" +
                        "VALUES(@cat, @type, @status, @date)";

                    using (SqlCommand command = new SqlCommand(insertData, connect))
                    {
                        command.Parameters.AddWithValue("@cat", txt_catergory_uc.Text.Trim());
                        command.Parameters.AddWithValue("@type", combo_type_uc.SelectedIndex);
                        command.Parameters.AddWithValue("@status", combo_status_uc.SelectedIndex);

                        DateTime today = DateTime.Today;
                        command.Parameters.AddWithValue("@date", today);

                        command.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added Successfully", "Information Messaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
            displayCatergoryList();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                txt_catergory_uc.Text = row.Cells[1].Value.ToString();
                combo_type_uc.SelectedItem = row.Cells[2].Value.ToString();
                combo_status_uc.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void btn_update_uc_Click(object sender, EventArgs e)
        {
            if (txt_catergory_uc.Text == "" || combo_type_uc.SelectedIndex == -1 || combo_status_uc.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Messaage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update ID : " + getID + "?", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        String updateData = "UPADTE categories SET category = @cat, type = @type, status = @status, WHERE id =@id)" +
                            "VALUES(@cat, @type, @status, @date)";

                        using (SqlCommand command = new SqlCommand(updateData, connect))
                        {
                            command.Parameters.AddWithValue("@cat", txt_catergory_uc.Text.Trim());
                            command.Parameters.AddWithValue("@type", combo_type_uc.SelectedIndex);
                            command.Parameters.AddWithValue("@status", combo_status_uc.SelectedIndex);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Updated Successfully", "Information Messaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayCatergoryList();

        }
        public void clearFields() {
            txt_catergory_uc.Text = "";
            combo_type_uc.Text = "";
            combo_status_uc.Text = "";
        }
        private void btn_clrear_uc_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btn_dlt_uc_Click(object sender, EventArgs e)
        {
            if (txt_catergory_uc.Text == "" || combo_type_uc.SelectedIndex == -1 || combo_status_uc.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Messaage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID : " + getID + "?", "Confirmation Message", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        String deleteData = "DELETE FROM categories  id =@id";

                        using (SqlCommand command = new SqlCommand(deleteData, connect))
                        {
                            command.Parameters.AddWithValue("@cat", txt_catergory_uc.Text.Trim());
                            command.Parameters.AddWithValue("@type", combo_type_uc.SelectedIndex);
                            command.Parameters.AddWithValue("@status", combo_status_uc.SelectedIndex);
                            command.ExecuteNonQuery();

                            MessageBox.Show("Deleted Successfully", "Information Messaage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayCatergoryList();
        }
    }
}
