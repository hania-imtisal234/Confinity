using db_projectt.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace db_projectt
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid(); // fill the grid every time page loads
            
        }

        public void LoadGrid()
        {
            myDAL objMyDal = new myDAL();
            ItemGrid.DataSource = objMyDal.SelectItem();//seting data source for this Grid
            ItemGrid.DataBind(); //bind the data source to this grid
        }

        
        protected void Save_request(object sender, EventArgs e)
        {

            int c1 = 0 , c2 =0 , c3 = 0;
            if (CheckBox1.Checked) { c1 = 1; }
            if (CheckBox2.Checked) { c2 = 2; }
            if (CheckBox3.Checked) { c3 = 3; }
            
            DataTable DT = new DataTable();

            myDAL objMyDal = new myDAL();
            
            int found;

            found = objMyDal.save_request_service(c1 , c2 ,c3);

            if (found > 0)
            {
                //ItemGrid.DataSource = DT;
                //ItemGrid.DataBind();
                message_t2.InnerHtml = Convert.ToString("Request Submitted");
            }
            else
            {
                message_t2.InnerHtml = Convert.ToString("Unable to Submit Request");
                //ItemGrid.DataSource = null;
                //ItemGrid.DataBind();
            }

        }
        
        /**/


    }
}