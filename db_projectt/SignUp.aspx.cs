using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;
using db_projectt;
using System.Net;
using System.Security.Policy;


namespace db_projectt
{
    public partial class SignUp : System.Web.UI.Page
    {


        SqlConnection con = new SqlConnection("Data Source=DESKTOP-C87NKI3;Initial Catalog=confinity;Integrated Security=True");
        string cs = ConfigurationManager.ConnectionStrings["confinity"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                password.Attributes["type"] = "password";
            }
            else
            {


            }
        }



        protected void Register_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("Select count(*) from Users6__ where Account_number='" + int.Parse(accountno.Text) + "'", con);
            con.Open();
            int value = (int)cmd1.ExecuteScalar();
            if (value > 0)
            {
                Session["Error"] = "Error, You Have Already Registered Or Account Number Already Existed \n Please Try Some Other Account Number";
                Response.Redirect("Error.aspx");
            }


            SqlCommand cmd = new SqlCommand("SignupUser");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@username", username.Text);
            cmd.Parameters.AddWithValue("@password", password.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.Parameters.AddWithValue("@phno", phone.Text);
            cmd.Parameters.AddWithValue("@Account_number", int.Parse(accountno.Text));
            cmd.Parameters.AddWithValue("@Amount ", int.Parse(amount.Text));


            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            SqlDataAdapter d1 = new SqlDataAdapter(cmd);




            //SqlCommand cmd = new SqlCommand("execute  Registeration '" + username.Text + "', '" + password.Text + "'," + email.Text + ",'" + address.Text + "','" + phone.Text + "','" + accountno.Text + "','" + "','" + gen + "','" + a.ToString() + "' ", con);

            //cmd.ExecuteNonQuery();
            con.Close();

            Session["ID"] = accountno.Text;
            Response.Redirect("LoginUser.aspx");


        }
    }
}