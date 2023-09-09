using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;


namespace db_projectt
{

    public partial class ServiceApproval : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VK530CB ;Initial Catalog= sqlCon1 ; Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MultiView1.ActiveViewIndex = 0;
            SqlCommand com = new SqlCommand("serviceApproval");
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@requestid", int.Parse(requestid.Text));
            com.Parameters.AddWithValue("@requesttype", requesttype.Text.ToString());
            com.Parameters.AddWithValue("@status", SqlDbType.Int).Direction = ParameterDirection.Output;
            com.Connection = con;
            int count = (int)com.ExecuteNonQuery();

            if (count < 1)
            {
                Msg.Text = "Service approved!";
            }
            else
            {
                Msg.Text = "Service Not approved!";
            }

        }




    }
}