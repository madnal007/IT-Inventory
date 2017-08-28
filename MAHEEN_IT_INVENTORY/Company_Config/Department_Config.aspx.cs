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
    public partial class Department_Config : System.Web.UI.Page
    {
        private int ComID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                //CompanyGridView();
                //txtCName.Focus();
                btnEdit.Visible = false;
                btnSave.Visible = true;
                btnCancel.Visible = true;
                btnDelete.Visible = false;
                txtDeptName.Focus();
                DeptGridView();

            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DepartmentBD cdb = new DepartmentBD();
            //int UserID = 0;
            try
            {
                int Userids = 0;
                Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                cdb.Insert_Department(0, txtDeptName.Text, DateTime.Now);
                txtDeptName.Text = "";
                lblMsg.Text = "Department Added Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                //CompanyGridView();

                //lblMsg.ForeColor = System.Drawing.Color.Green;
                //if (avatarUpload.PostedFile.FileName != null && avatarUpload.PostedFile.FileName != "")
                // {
                //   string filepath = avatarUpload.PostedFile.FileName;
                //  string filename = Path.GetFileName(filepath);
                //string ext = Path.GetExtension(filename);

                //   if (ext == ".jpeg" || ext == ".jpg")
                //   {
                //  UploadFiles(txtShortName.Text, ext);
                // }

                //}
            }

            catch (Exception ex)
            {
                lblMsg.Text = "Please Enter Valid Information";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {

            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            DepartmentBD db = new DepartmentBD();
            int UserID = 0;
            try
            {
                //int Userids = 0;
                //Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                //int Userids = 0;
                //Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                // int Userids = 0;
                int CompID = 0;
                CompID = Convert.ToInt32(GridViewDept.SelectedRow.Cells[1].Text);
                UserID = db.Update_Department(CompID, txtDeptName.Text, DateTime.Now);
                txtDeptName.Text = "";
                lblMsg.Text = "Department modified uuccessfully along with created date";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                DeptGridView();
                txtDeptName.Text = GridViewDept.SelectedRow.Cells[2].Text;

                //lblMsg.ForeColor = System.Drawing.Color.Green;
                //if (avatarUpload.PostedFile.FileName != null && avatarUpload.PostedFile.FileName != "")
                // {
                //   string filepath = avatarUpload.PostedFile.FileName;
                //  string filename = Path.GetFileName(filepath);
                //string ext = Path.GetExtension(filename);

                //   if (ext == ".jpeg" || ext == ".jpg")
                //   {
                //  UploadFiles(txtShortName.Text, ext);
                // }

                //}
            }

            catch (Exception ex)
            {
                lblMsg.Text = "Please Enter Valid Information";
                lblMsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {

            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
            //btnDelete.Visible = false;
            txtDeptName.Text = "";
            lblMsg.Text = "";
            txtDeptName.Focus();
        }

        private void DeptGridView()
        {
            SqlConnection connectionforGridview = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            connectionforGridview.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionforGridview;
            cmd.CommandText = "SP_Department_Grid";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Department_ID", SqlDbType.Int).Value = 1;
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(ds, "TB_Department_Name");
            connectionforGridview.Close();
            // this.GridView1.Columns[0].Visible = false;
            GridViewDept.DataSource = ds.Tables[0];
            GridViewDept.DataBind();

        }

        protected void GridViewDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            btnCancel.Visible = true;
            btnSave.Visible = false;
            ComID = Convert.ToInt32(GridViewDept.SelectedRow.Cells[1].Text);
            txtDeptName.Text = GridViewDept.SelectedRow.Cells[2].Text;
            
        }

        protected void GridViewDept_RowEditing(object sender, GridViewEditEventArgs e)
        {
            DeptGridView();
        }

    }
}