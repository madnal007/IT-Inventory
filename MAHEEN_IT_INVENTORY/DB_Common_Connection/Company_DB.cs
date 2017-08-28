using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MAHEEN_IT_INVENTORY.DB_Common_Connection
{
    public class Company_DB
    {
        public int INSERT_COM_NAME(int Company_ID, string Company_Name, string Company_Address, string Company_Email_Address, string Company_Phone_Number, string Company_Telphone_Number, string Company_WebSite)
        {
            SqlConnection myconnection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            SqlCommand mycommand = new SqlCommand("SP_Company_Insert_Name", myconnection);
            mycommand.CommandType = CommandType.StoredProcedure;

            SqlParameter PcomID = new SqlParameter("@Company_ID", SqlDbType.NVarChar, 50);
            PcomID.Value = Company_ID;
            mycommand.Parameters.Add(PcomID);

            SqlParameter PCom_Name = new SqlParameter("@Company_Name", SqlDbType.NVarChar, 30);
            PCom_Name.Value = Company_Name;
            mycommand.Parameters.Add(PCom_Name);

            SqlParameter PAddress = new SqlParameter("@Company_Address", SqlDbType.NVarChar, 60);
            PAddress.Value = Company_Address;
            mycommand.Parameters.Add(PAddress);

            SqlParameter PEmail = new SqlParameter("@Company_Email_Address", SqlDbType.NVarChar, 20);
            PEmail.Value = Company_Email_Address;
            mycommand.Parameters.Add(PEmail);

            SqlParameter PPhone = new SqlParameter("@Company_Phone_Number", SqlDbType.NVarChar, 15);
            PPhone.Value = Company_Phone_Number;
            mycommand.Parameters.Add(PPhone);

            SqlParameter PTelePhone = new SqlParameter("@Company_Telphone_Number", SqlDbType.NVarChar, 15);
            PTelePhone.Value = Company_Telphone_Number;
            mycommand.Parameters.Add(PTelePhone);

            SqlParameter PWebsite = new SqlParameter("@Company_WebSite", SqlDbType.NVarChar, 20);
            PWebsite.Value = Company_WebSite;
            mycommand.Parameters.Add(PWebsite);


            myconnection.Open();
            mycommand.ExecuteNonQuery();
            myconnection.Close();


            return Company_ID;
        }



        public int Update_CompanyName(int Company_ID, string Company_Name, string Company_Address, string Company_Email_Address, string Company_Phone_Number, string Company_Telphone_Number, string Company_WebSite)
        {
            SqlConnection myconnection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            SqlCommand mycommand = new SqlCommand("SP_Update_Company", myconnection);
            mycommand.CommandType = CommandType.StoredProcedure;

            SqlParameter PcomID = new SqlParameter("@Company_ID", SqlDbType.Int, 4);
            PcomID.Value = Company_ID;
            mycommand.Parameters.Add(PcomID);

            SqlParameter PCom_Name = new SqlParameter("@Company_Name", SqlDbType.NVarChar, 30);
            PCom_Name.Value = Company_Name;
            mycommand.Parameters.Add(PCom_Name);

            SqlParameter PAddress = new SqlParameter("@Company_Address", SqlDbType.NVarChar, 60);
            PAddress.Value = Company_Address;
            mycommand.Parameters.Add(PAddress);

            SqlParameter PEmail = new SqlParameter("@Company_Email_Address", SqlDbType.NVarChar, 20);
            PEmail.Value = Company_Email_Address;
            mycommand.Parameters.Add(PEmail);

            SqlParameter PPhone = new SqlParameter("@Company_Phone_Number", SqlDbType.NVarChar, 15);
            PPhone.Value = Company_Phone_Number;
            mycommand.Parameters.Add(PPhone);

            SqlParameter PTelePhone = new SqlParameter("@Company_Telphone_Number", SqlDbType.NVarChar, 15);
            PTelePhone.Value = Company_Telphone_Number;
            mycommand.Parameters.Add(PTelePhone);

            SqlParameter PWebsite = new SqlParameter("@Company_WebSite", SqlDbType.NVarChar, 20);
            PWebsite.Value = Company_WebSite;
            mycommand.Parameters.Add(PWebsite);


            myconnection.Open();
            mycommand.ExecuteNonQuery();
            myconnection.Close();


            return Company_ID;
        }

        public void DeleteCompany(int datastr)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            SqlCommand myCommand = new SqlCommand("SP_COMPANY_DELETE", con);
            myCommand.CommandType = CommandType.StoredProcedure;
            SqlParameter parameterCompany = new SqlParameter("@ID", SqlDbType.Int, 4);
            parameterCompany.Value = datastr;
            myCommand.Parameters.Add(parameterCompany);
            con.Open();
            myCommand.ExecuteNonQuery();
            con.Close();
        }


        internal int Update_CompanyName(int CompID, string p, DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}