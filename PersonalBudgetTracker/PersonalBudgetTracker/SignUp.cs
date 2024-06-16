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
    public partial class SignUp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Thathsarani Liyanage\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30");
        public SignUp()
        {
            InitializeComponent();
        }

        public bool checkConnection() { 
            return(connect.State == ConnectionState.Closed)? true:false;
        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_signInSignUp_Click(object sender, EventArgs e)
        {
            SignIn logInForm = new SignIn();
            logInForm.Show();

            this.Hide();
        }

        private void btn_SignUpSignUp_Click(object sender, EventArgs e)
        {
            if (txt_usernameSignUp.Text == "" || txt_passwordSignUp.Text == "" || txt_cnfrmPWsignUp.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                if (checkConnection()){
                    try
                    {
                        connect.Open();
                        //chech if the username you want to register is already exist
                        String selectUsername = "SELECT * FROM users WHERE username = @usern";

                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", txt_usernameSignUp.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count != 0)
                            {

                                //to put the first letter to big letter
                                String tempUsern = txt_usernameSignUp.Text.Substring(0, 1).ToUpper() + txt_usernameSignUp.Text.Substring(1);
                                MessageBox.Show(tempUsern + "is existing already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else if (txt_passwordSignUp.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else if (txt_passwordSignUp.Text != txt_cnfrmPWsignUp.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else
                            {
                                String insertDate = "INSERT INTO users (username, password, date_create) VALUES(@usern, @pass, @date)";

                                using (SqlCommand insertUser = new SqlCommand(insertDate, connect))
                                {
                                    insertUser.Parameters.AddWithValue("@usern", txt_usernameSignUp.Text.Trim());
                                    insertUser.Parameters.AddWithValue("@pass", txt_passwordSignUp.Text.Trim());

                                    DateTime today = DateTime.Today; //date now
                                    insertUser.Parameters.AddWithValue("@date", today);

                                    insertUser.ExecuteNonQuery();

                                    MessageBox.Show("Registration Successfull", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    //////////////////////////////////////
                                    SignUp registerForm = new SignUp();
                                    registerForm.Show();

                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally { 
                        connect.Close();
                    }
                } 
            }
        }

        private void chckBx_showPasswordSignUp_CheckedChanged(object sender, EventArgs e)
        {
            txt_passwordSignUp.PasswordChar = chckBx_showPasswordSignUp.Checked ? '\0' : '*';
            txt_cnfrmPWsignUp.PasswordChar = chckBx_showPasswordSignUp.Checked ? '\0' : '*';
        }
    }
}
