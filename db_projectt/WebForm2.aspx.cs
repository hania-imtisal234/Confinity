using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using db_projectt.DAL;

namespace db_projectt
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }
        public void LoadGrid()
        {
            myDAL objMyDal = new myDAL();
            ItemGrid2.DataSource = objMyDal.SelecttItem();//seting data source for this Grid
            ItemGrid2.DataBind(); //bind the data source to this grid
        }
        protected void Save_feeback(object sender, EventArgs e)
        {

            String Name = name_t1.Text;
            bool b1 = string.IsNullOrEmpty(Name);

            if (!b1)
            {
                DataTable DT = new DataTable();

                myDAL objMyDal = new myDAL();

                int found;

                found = objMyDal.feedback_save(Name, ref DT);

                if (found > 0)
                {
                    ItemGrid.DataSource = DT;
                    ItemGrid.DataBind();
                    message_t1.InnerHtml = Convert.ToString("Feedback submitted successfully");
                }
                else
                {
                    message_t1.InnerHtml = Convert.ToString("unable to save feedback");
                    ItemGrid.DataSource = null;
                    ItemGrid.DataBind();
                }
            }
            else
            {
                message_t1.InnerHtml = Convert.ToString("Kindly enter feedback");
            }

        }

        /**/

    }
}