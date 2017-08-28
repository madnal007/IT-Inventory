using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MAHEEN_IT_INVENTORY.DB_Common_Connection
{
    public class Company_Branch_DB
    {
        public void InsertCompanyBranch(int BranchCompany_ID, string BranchCompanyName, int CompanyID)
        {
            SqlConnection myconnection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            SqlCommand mycommand = new SqlCommand("SP_INSER_COMPANY_BRANCH", myconnection);
            mycommand.CommandType = CommandType.StoredProcedure;

            SqlParameter PBranchName = new SqlParameter("@Company_Branch_Id", SqlDbType.NVarChar, 50);
            PBranchName.Value = BranchCompany_ID;
            mycommand.Parameters.Add(PBranchName);

            SqlParameter ComName = new SqlParameter("@Company_Branch_Name", SqlDbType.NVarChar, 30);
            ComName.Value = BranchCompanyName;
            mycommand.Parameters.Add(ComName);

            SqlParameter PCom_ID = new SqlParameter("@Company_Id", SqlDbType.NVarChar, 30);
            PCom_ID.Value = CompanyID;
            mycommand.Parameters.Add(PCom_ID);





        }
    }
}