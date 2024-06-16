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
    public partial class DashboardForm : UserControl
    {
        string stringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Thathsarani Liyanage\\Documents\\expense.mdf\";Integrated Security=True;Connect Timeout=30";
        public DashboardForm()
        {
            InitializeComponent();
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            totalIncome();

            expenseTodayIncome();
            expenseYesterdayIncome();
            expenseThisMonth();
            expenseThisYear();
            totalExpense();

        }


        public void refreshData()
        {
            if(InvokeRequired)
            {
                Invoke(new MethodInvoker(refreshData));
                return;
            }

            InitializeComponent();
            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            totalIncome();

            expenseTodayIncome();
            expenseYesterdayIncome();
            expenseThisMonth();
            expenseThisYear();
            totalExpense();

        }

        //INCOME

        public void incomeTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_in";

                using(SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_in", today);

                    Object result =  cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        incm_tdy_incm.Text = "$" + todayCost.ToString("0.00");

                    }
                    else
                    {
                        incm_tdy_incm.Text = "$0.00";
                    }
                }
            }
        }
        public void incomeYesterdayIncome()
        {
            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, 0, GETDATE()), -1)";
                using (SqlCommand cmd = new SqlCommand(query))
                {

                    //using(SqlCommand cmd = new SqlCommand(query, connect)) {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        incm_ystrdy_incm.Text = yesterdayCost.ToString("C");

                    }
                    else
                    {
                        incm_ystrdy_incm.Text = "$0.00";
                    }

                }
            }
            
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        incm_ystrdy_incm.Text = monthCost.ToString("C");

                    }
                    else
                    {
                        incm_mnth_incm.Text = "$0.00";
                    }

                }
            }
        }


        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                
                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);


                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        incm_yr_incm.Text = yearCost.ToString("C");

                    }
                    else
                    {
                        incm_yr_incm.Text = "$0.00";
                    }

                }
            }
        }


        public void totalIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses ";
                using (SqlCommand cmd = new SqlCommand(query))
                {

                    //using(SqlCommand cmd = new SqlCommand(query, connect)) {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        ttlCosr_id.Text = totalCost.ToString("C");

                    }
                    else
                    {
                        ttlCosr_id.Text = "$0.00";
                    }

                }
            }
        }

        //EXPENSES

        public void expenseTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_ex";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_ex", today);

                    Object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        expns_tdy_ex.Text = "$" + todayCost.ToString("0.00");

                    }
                    else
                    {
                        expns_tdy_ex.Text = "$0.00";
                    }
                }
            }
        }

        public void expenseYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, 0, GETDATE()), -1)";
                using (SqlCommand cmd = new SqlCommand(query))
                {

                    //using(SqlCommand cmd = new SqlCommand(query, connect)) {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);
                        expns_ystrdy_ex.Text = yesterdayCost.ToString("C");

                    }
                    else
                    {
                        expns_ystrdy_ex.Text = "$0.00";
                    }

                }
            }

        }

        public void expenseThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal monthCost = Convert.ToDecimal(result);
                        expns_mnth_ex.Text = monthCost.ToString("C");

                    }
                    else
                    {
                        expns_mnth_ex.Text = "$0.00";
                    }

                }
            }
        }

        public void expenseThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);


                string query = "SELECT SUM(cost) FROM expenses WHERE date_expensee >= @startYear AND date_expense <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        expns_yr_ex.Text = yearCost.ToString("C");

                    }
                    else
                    {
                        expns_yr_ex.Text = "$0.00";
                    }

                }
            }
        }

        public void totalExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);


                string query = "SELECT SUM(cost) FROM expenses WHERE date_expensee >= @startYear AND date_expense <= @endYear";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);
                        expns_yr_ex.Text = yearCost.ToString("C");

                    }
                    else
                    {
                        expns_yr_ex.Text = "$0.00";
                    }

                }
            }
        }



        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }
    }
}
