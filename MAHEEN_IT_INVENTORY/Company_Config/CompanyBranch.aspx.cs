using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web.UI;
using System.Web.UI.WebControls;
using MAHEEN_IT_INVENTORY.DB_Common_Connection;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace MAHEEN_IT_INVENTORY.Company_Config
{
    public partial class CompanyBranch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetCompanyList(ComID);
        }

        private void GetCompanyList(int ComID)
        {
            SqlCommand command = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable ds = new DataTable();
            ds.Clear();
            SqlConnection connection = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "SP_GET_COMPANY";
            adapter = new SqlDataAdapter(command);
            //SqlParameter cID = new SqlParameter("@Company_ID", SqlDbType.Int, 4);
            //cID.Value = ComID;
            //command.Parameters.Add(cID);
            adapter.Fill(ds);
            connection.Close();
            txtComName.DataSource = ds;
            txtComName.DataTextField = "Company_Name";
            //txtComName.DataValueField = "Company_ID";
            txtComName.DataBind();
            //txtCompanyName.Items.Insert(0,"Please Select");
        }





        public int ComID { get; set; }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}