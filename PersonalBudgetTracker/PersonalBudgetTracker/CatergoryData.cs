using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PersonalBudgetTracker
{
    internal class CatergoryData
    {
        //string StringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Thathsarani Liyanage\Documents\expense.mdf"";Integrated Security=True;Connect Timeout=30";
        string StringConnection = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\Thathsarani Liyanage\\Documents\\expense.mdf\";Integrated Security=True;Connect Timeout=30";

        public int ID { set; get; } //0
        public String Catergory { set; get; } //1
        public String Type{ set; get; } //2
        public String Status { set; get; } //3
        public string Date { set; get; } //4

        public List<CatergoryData> catergoryListData()
        {
            List<CatergoryData> listData = new List<CatergoryData>();

            using(SqlConnection connect = new SqlConnection(StringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM catergories";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        CatergoryData cData = new CatergoryData();
                        cData.ID = (int)reader["id"];
                        cData.Catergory = reader["category"].ToString();
                        cData.Type = reader["type"].ToString();
                        cData.Status = reader["status"].ToString();
                        cData.Date = ((DateTime)reader["date_insert"]).ToString("MM-dd-yyyy");

                        listData.Add(cData);    
                    }
                }
            }
            return listData;
        }
    }
}
