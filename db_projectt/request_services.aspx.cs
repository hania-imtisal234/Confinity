using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace db_projectt
{
    public partial class request_services : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            Label1.Text = "Debit Card Requested";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label2.Text = "Credit Card Requested";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Label3.Text = "Cheque book Requested";
        }
    }
}