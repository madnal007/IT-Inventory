using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace MAHEEN_IT_INVENTORY.DB_Common_Connection
{
    public class DepartmentBD
    {
        public void Insert_Department(int Dept_ID, string DeptName, DateTime CreatedDate)
    {
        SqlConnection myconnection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
        SqlCommand mycommand = new SqlCommand("SP_DEPARTMENT_INSERT", myconnection);
        mycommand.CommandType = CommandType.StoredProcedure;

        SqlParameter DeptID = new SqlParameter("@Department_ID", SqlDbType.Int, 4);
        DeptID.Value = Dept_ID;
        mycommand.Parameters.Add(DeptID);

        SqlParameter DName = new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 50);
        DName.Value = DeptName;
        mycommand.Parameters.Add(DName);

        SqlParameter DCreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime, 20);
        DCreatedDate.Value = CreatedDate;
        mycommand.Parameters.Add(DCreatedDate);

        myconnection.Open();
        mycommand.ExecuteNonQuery();
        myconnection.Close();

    }

        public int Update_Department(int departId, string dept_Name, DateTime CreatedDate)
        {
            SqlConnection myconnection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            SqlCommand mycommand = new SqlCommand("SP_Depart_Grid_Upade", myconnection);
            mycommand.CommandType = CommandType.StoredProcedure;

            SqlParameter PcomID = new SqlParameter("@Department_ID", SqlDbType.Int, 4);
            PcomID.Value = departId;
            mycommand.Parameters.Add(PcomID);

            SqlParameter PCom_Name = new SqlParameter("@DepartmentName", SqlDbType.NVarChar, 50);
            PCom_Name.Value = dept_Name;
            mycommand.Parameters.Add(PCom_Name);


            SqlParameter parameterCreatedDate = new SqlParameter("@CreatedDate", SqlDbType.DateTime, 20);
            parameterCreatedDate.Value = CreatedDate;
            mycommand.Parameters.Add(parameterCreatedDate);


            myconnection.Open();
            mycommand.ExecuteNonQuery();
            myconnection.Close();


            return departId;
        }


        internal int Update_Department()
        {
            throw new NotImplementedException();
        }
    }
}