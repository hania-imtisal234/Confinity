using db_projectt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace db_projectt
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        //int acc = 2;//account no
        protected void Page_Load(object sender, EventArgs e)
        {
            displaybal();
        }
        public void displaybal()
        {
            myDAL objMyDal = new myDAL();
            objMyDal.bal_display();
            //mydiv.InnerText = "asd" ;
            mytable.DataSource = objMyDal.bal_display();//seting data source for this Grid
            mytable.DataBind(); //bind the data source to this grid

        }

    }
}