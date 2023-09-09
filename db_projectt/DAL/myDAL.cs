using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace db_projectt.DAL
{ 
    public class myDAL
    { 
        int account = 2;
        private static readonly string connString =
        System.Configuration.ConfigurationManager.ConnectionStrings["sqlCon1"].ConnectionString;

        public DataSet SelectItem() //to get the values of all the items from table Items and return the Dataset
        {

            DataSet ds = new DataSet(); //declare and instantiate new dataset
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select * from Admin", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return ds; //return the dataset
        }

        public DataSet SelecttItem() //to get the values of all the items from table Items and return the Dataset
        {

            DataSet ds = new DataSet(); //declare and instantiate new dataset
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select * from info", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return ds; //return the dataset
        }

        public int SearchItem(String Name, ref DataTable DT)
        {

            int Found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("searchitem ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ItemName", SqlDbType.VarChar, 15);
                cmd.Parameters.Add("@Found", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@ItemName"].Value = Name;


                cmd.ExecuteNonQuery();

                // read output value 
                Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                if (Found == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }


        public int feedback_save(String Name, ref DataTable DT)
        {

            int Found = 1;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {//found acc_no , feed
                cmd = new SqlCommand("feedback_saved ", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@found", SqlDbType.Int);
                cmd.Parameters.Add("@acc_no", SqlDbType.Int);
                cmd.Parameters.Add("@feed", SqlDbType.VarChar, 15);

                // set parameter values
                cmd.Parameters["@feed"].Value = Name;
                cmd.Parameters["@acc_no"].Value = 3;
                cmd.Parameters["@found"].Value = 1;


                cmd.ExecuteNonQuery();

                // read output value 
                //Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                if (Found == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {
                        //cout<<feedback submited
                        //da.Fill(ds);

                    }

                    //DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }
        public int save_request_service(int  c1, int c2, int c3)
        {
            int Found = 1;

            if (c1 != 0)
            {

                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("service_request_save ", con); //name of your procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@found", SqlDbType.Int);
                    cmd.Parameters.Add("@acc_no", SqlDbType.Int);
                    cmd.Parameters.Add("@type", SqlDbType.Int);

                    // set parameter values
                    cmd.Parameters["@type"].Value = c1;
                    cmd.Parameters["@acc_no"].Value = 3;
                    cmd.Parameters["@found"].Value = 1;

                    cmd.ExecuteNonQuery();

                    // read output value 
                    //Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                    if (Found == 1)
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        {
                            //cout<<feedback submited
                            //da.Fill(ds);

                        }
                        //DT = ds.Tables[0];

                    }
                    con.Close();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error" + ex.Message.ToString());

                }
                finally
                {
                    con.Close();
                }

            }
            if (c2 != 0)
            {

                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("service_request_save ", con); //name of your procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@found", SqlDbType.Int);
                    cmd.Parameters.Add("@acc_no", SqlDbType.Int);
                    cmd.Parameters.Add("@type", SqlDbType.Int);

                    // set parameter values
                    cmd.Parameters["@type"].Value = c2;
                    cmd.Parameters["@acc_no"].Value = 3;
                    cmd.Parameters["@found"].Value = 1;


                    cmd.ExecuteNonQuery();

                    // read output value 
                    //Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                    if (Found == 1)
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        {
                            //cout<<feedback submited
                            //da.Fill(ds);

                        }

                        //DT = ds.Tables[0];

                    }


                    con.Close();


                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error" + ex.Message.ToString());

                }
                finally
                {
                    con.Close();
                }

            }
            if (c3 != 0)
            {

                DataSet ds = new DataSet();
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd;
                try
                {
                    cmd = new SqlCommand("service_request_save ", con); //name of your procedure
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@found", SqlDbType.Int);
                    cmd.Parameters.Add("@acc_no", SqlDbType.Int);
                    cmd.Parameters.Add("@type", SqlDbType.Int);

                    // set parameter values
                    cmd.Parameters["@type"].Value = c3;
                    cmd.Parameters["@acc_no"].Value = 3;
                    cmd.Parameters["@found"].Value = 1;


                    cmd.ExecuteNonQuery();

                    // read output value 
                    //Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                    if (Found == 1)
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                        {
                            //cout<<feedback submited
                            //da.Fill(ds);

                        }

                        //DT = ds.Tables[0];

                    }


                    con.Close();


                }
                catch (SqlException ex)
                {
                    Console.WriteLine("SQL Error" + ex.Message.ToString());

                }
                finally
                {
                    con.Close();
                }

            }
            return Found;
        }

        public DataSet bal_display() //to get the values of all the items from table Items and return the Dataset
        {

            DataSet dss = new DataSet(); //declare and instantiate new dataset
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {

                string input = "select amount from Users where Account_number = 2";
             

                cmd = new SqlCommand(input, con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command

                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dss); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return dss; //return the dataset
        }

        public DataSet SelectItemm() //to get the values of all the items from table Items and return the Dataset
        {

            DataSet ds = new DataSet(); //declare and instantiate new dataset
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("select email AS Email, admin_name AS Admin, Transaction_number AS TransactionID, Account_number AS Account, Amount AS Amount, Balance AS BalanceRem, date_ AS DateOfTran from Transactions", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return ds; //return the dataset
        }
        //for request Loan
        public int SaveLoanRequest(int accNum, int loanType, int loanAmt, ref DataTable DT)
        {

            int Found = 1, reqIDcounter = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {//found acc_no , feed
                cmd = new SqlCommand("reqLoan", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@found", SqlDbType.Int);
                cmd.Parameters.Add("@acc_no", SqlDbType.Int);
                cmd.Parameters.Add("@reqID", SqlDbType.Int);
                cmd.Parameters.Add("@type", SqlDbType.Int);
                cmd.Parameters.Add("@l_amt", SqlDbType.Int);


                // set parameter values
                cmd.Parameters["@acc_no"].Value = accNum;
                cmd.Parameters["@type"].Value = loanType;
                cmd.Parameters["@l_amt"].Value = loanAmt;
                cmd.Parameters["@reqID"].Value = reqIDcounter + 3;
                cmd.Parameters["@found"].Value = 1;

                reqIDcounter = +1;
                cmd.ExecuteNonQuery();

                // read output value 
                //Found = Convert.ToInt32(cmd.Parameters["@Found"].Value); //convert to output parameter to interger format

                if (Found == 1)
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                    {

                        da.Fill(ds);

                    }

                    DT = ds.Tables[0];

                }


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return Found;

        }

        public DataSet PayBill()
        {
            DataSet ds = new DataSet(); //declare and instantiate new dataset
            SqlConnection con = new SqlConnection(connString); //declare and instantiate new SQL connection
            con.Open(); // open sql Connection
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("Select * from Bills_", con);  //instantiate SQL command 
                cmd.CommandType = CommandType.Text; //set type of sqL Command
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(ds); //Add the result  set  returned from SQLCommand to ds
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());
            }
            finally
            {
                con.Close();
            }

            return ds; //return the dataset


        }

        public int payBillUpdate(int billID, ref DataTable DT)
        {

            int found = 0;
            DataSet ds = new DataSet();
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd;
            try
            {
                cmd = new SqlCommand("payBill", con); //name of your procedure
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@billIDP", SqlDbType.Int);
                cmd.Parameters.Add("@found", SqlDbType.Int).Direction = ParameterDirection.Output;

                // set parameter values
                cmd.Parameters["@billIDP"].Value = billID;


                cmd.ExecuteNonQuery();

                // read output value 
                found = Convert.ToInt32(cmd.Parameters["@found"].Value); //convert to output parameter to interger format

                //if (found == 1)
                //{
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))

                {
                    da.Fill(ds);

                }

                DT = ds.Tables[0];

                //}


                con.Close();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error" + ex.Message.ToString());

            }
            finally
            {
                con.Close();
            }

            return found;

        }



    }

}



