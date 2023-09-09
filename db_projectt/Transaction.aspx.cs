using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using db_projectt;
using System.Reflection.Emit;

namespace db_projectt
{
    public partial class Transaction : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VK530CB ;Initial Catalog= sqlCon1 ; Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitbutton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("do_transaction");
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.Parameters.AddWithValue("@acc_no_sender", int.Parse(senderaccnumber.Text));
            cmd1.Parameters.AddWithValue("@acc_no ", int.Parse(receiverammount.Text));
            cmd1.Parameters.AddWithValue("@amount ", int.Parse(amount.Text));
            cmd1.Parameters.AddWithValue("@balance ", int.Parse(balance.Text));
            cmd1.Parameters.AddWithValue("@date ", date.Text.ToString());
            cmd1.Connection = con;
            cmd1.ExecuteNonQuery();

            Label1.Text = "Transaction Successfull!";
            con.Close();
        }
    }
}