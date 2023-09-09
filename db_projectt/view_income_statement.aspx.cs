using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Reflection.Emit;

namespace db_projectt
{

    public partial class view_income_statement : System.Web.UI.Page
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VK530CB ;Initial Catalog= sqlCon1 ; Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {


        }
        protected void display_Click2(object sender, EventArgs e)
        {
            con.Open();
            //SqlCommand cmd = new SqlCommand("viewIncomeStatement", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@acc_no", int.Parse(accno_.Text));
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            MultiView1.ActiveViewIndex = 0;
            SqlCommand cmd1 = new SqlCommand("viewIncomeStatement");
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@acc_no", int.Parse(accno_.Text));
            cmd1.Connection = con;
            cmd1.ExecuteNonQuery();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd1);
            DataTable dt1 = new DataTable();
            d1.Fill(dt1);
            Label1.Text = dt1.Rows[0][0].ToString();
            Label2.Text = dt1.Rows[0][1].ToString();
            Label3.Text = dt1.Rows[0][2].ToString();
            Label4.Text = dt1.Rows[0][3].ToString();




            //cmd1.ExecuteNonQuery();

            //cmd1.Dispose();
            con.Close();


        }

    }


}