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
    public partial class SignIn : Form
    {
        String stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Thathsarani Liyanage\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        //SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Thathsarani Liyanage\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignIn()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(stringConnection))
            {
                conn.Open();

                String selectData = "SELECT * FROM users WHERE username =  @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(selectData, conn))
                {
                    cmd.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txt_password.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    if(table.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information );

                        MainForm mform = new MainForm();
                        mform.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect username/password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void lbl_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_signupSignIn_Click(object sender, EventArgs e)
        {
            SignUp registerForm = new SignUp();
            registerForm.Show();

            this.Hide();
        }

        private void chckBx_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = chckBx_showPassword.Checked ? '\0' : '*';
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }
    }
}
