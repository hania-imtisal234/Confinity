using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;


namespace db_projectt
{
    public partial class book_appoitnment : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-VK530CB ;Initial Catalog= confinty_final ; Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["confinty_final"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void appButton_Click(object sender, EventArgs e)
        {
            //1.address of sql server and database


            //3.open connection

        }

        protected void appButton_Click1(object sender, EventArgs e)
        {
            con.Open();


            SqlCommand command;

            String sql = "";

            sql = "Insert into Appointment_ values ( ' " + TextBox2.Text + "','" + TextBox4.Text.ToString() + "' , '" + TextBox5.Text.ToString() + "' , '" + TextBox6.Text.ToString() + "')";
            command = new SqlCommand(sql, con);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dt = new DataTable();
            //adapter.SelectCommand = command;
            //adapter.Fill(dt);
            command.ExecuteNonQuery();
            //adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            con.Close();

            ////////////
            //SqlCommand cmd = new SqlCommand(Query, con);

            ////6.close connection
            //con.Close();
            Label1.Text = "Appointment booked!";
        }
    }
}