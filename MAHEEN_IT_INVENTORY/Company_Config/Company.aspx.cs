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
    public partial class Company : System.Web.UI.Page
    {
       private int indexOfColumn = 1;
        private int ComID = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CompanyGridView();
                //txtCName.Focus();
                btnEdit.Visible = false;
            btnSave.Visible = true;
            btnCancel.Visible = true;
            btnDeleteCom.Visible = false;
                txtComName.Focus();
                
            }
           // CompanyGridView();
           
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Company_DB cdb = new Company_DB();
            int UserID = 0;
            try
            {
                //if (txtComName.Text == "")
                //{
                //    lblMsg.Text = "You must enter company name!!!!!";
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}
                //if (txtComAdd.Text == "")
                //{
                //    lblMsg.Text = "You must enter company address!!!!!";
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}
                //if (TxtComEmail.Text == "")
                //{
                //    lblMsg.Text = "You must enter Email!!!!!";
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}
                //if (txtPhone.Text == "")
                //{
                //    lblMsg.Text = "You must enter phone number!!!!!";
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}

                //if (txtTelephone.Text == "")
                //{
                //    lblMsg.Text = "You must enter telephone number!!!!!";
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}

                //if (txtWeb.Text == "")
                //{
                //    lblMsg.Text = "You must enter website url!!!!!";
                //    lblMsg.ForeColor = System.Drawing.Color.Red;
                //    return;
                //}
                
                //int Userids = 0;
                //Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                // int Userids = 0;
                //Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                UserID = cdb.INSERT_COM_NAME(0, txtComName.Text, txtComAdd.Text, TxtComEmail.Text, txtPhone.Text, txtTelephone.Text, txtWeb.Text);
                txtComName.Text = "";
                txtComAdd.Text = "";
                TxtComEmail.Text = "";
                txtPhone.Text = "";
                txtTelephone.Text = "";
                txtWeb.Text = "";
                lblMsg.Text = "Company Inserted Successfully";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                CompanyGridView();

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

        protected void GridComView_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEdit.Visible = true;
            btnDeleteCom.Visible = true;
            btnCancel.Visible = true;
            btnSave.Visible = false;
            ComID = Convert.ToInt32(GridComView.SelectedRow.Cells[1].Text);
            txtComName.Text = GridComView.SelectedRow.Cells[2].Text;
            txtComAdd.Text = GridComView.SelectedRow.Cells[3].Text;
            TxtComEmail.Text = GridComView.SelectedRow.Cells[4].Text;
            txtPhone.Text = GridComView.SelectedRow.Cells[5].Text;
            txtTelephone.Text = GridComView.SelectedRow.Cells[6].Text;
            txtWeb.Text = GridComView.SelectedRow.Cells[7].Text;
            
        }

        private void CompanyGridView()
        {
            SqlConnection connectionforGridview = new SqlConnection(ConfigurationManager.AppSettings["connectionString"]);
            connectionforGridview.Open();
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connectionforGridview;
            cmd.CommandText = "SP_COMPANY_GRIDVIEW";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Company_ID", SqlDbType.Int).Value = 1;
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            adap.Fill(ds, "TB_Company_Name");
            connectionforGridview.Close();
            // this.GridView1.Columns[0].Visible = false;
            GridComView.DataSource = ds.Tables[0];
            GridComView.DataBind();
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Company_DB DB = new Company_DB();
            int UserID = 0;
            try
            {
                //int Userids = 0;
                //Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                //int Userids = 0;
                //Userids = Convert.ToInt32(HttpContext.Current.Session["UserID"]);
                // int Userids = 0;
                int CompID = 0;
                CompID = Convert.ToInt32(GridComView.SelectedRow.Cells[1].Text);
                UserID = DB.Update_CompanyName(CompID, txtComName.Text, txtComAdd.Text, TxtComEmail.Text, txtPhone.Text, txtTelephone.Text, txtWeb.Text);
                txtComName.Text = "";
                txtComAdd.Text = "";
                TxtComEmail.Text = "";
                txtPhone.Text = "";
                txtTelephone.Text = "";
                txtWeb.Text = "";
                lblMsg.Text = "Company Profile Successfully Modified";
                lblMsg.ForeColor = System.Drawing.Color.Green;
                CompanyGridView();
                txtComName.Text = GridComView.SelectedRow.Cells[2].Text;
                txtComAdd.Text = GridComView.SelectedRow.Cells[3].Text;
                TxtComEmail.Text = GridComView.SelectedRow.Cells[4].Text;
                txtPhone.Text = GridComView.SelectedRow.Cells[5].Text;
                txtTelephone.Text = GridComView.SelectedRow.Cells[6].Text;
                txtWeb.Text = GridComView.SelectedRow.Cells[7].Text;


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

        protected void GridComView_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //GridComView.PageIndex = e.NewPageIndex;
            // Cancel the paging operation if the user attempts to navigate
            // to another page while the GridView control is in edit mode. 

          
        }

        protected void GridComView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.Cells.Count > indexOfColumn)
            {

            } 
        }

        protected void GridComView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CompanyGridView();
        }

        protected void GridComView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridComView.PageIndex = e.NewPageIndex;
            CompanyGridView();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            btnEdit.Visible = false;
            btnDeleteCom.Visible = false;
            //btnDelete.Visible = false;
            txtComName.Text = "";
            txtComAdd.Text = "";
            TxtComEmail.Text = "";
            txtPhone.Text = "";
            txtTelephone.Text = "";
            txtWeb.Text = "";
            lblMsg.Text = "";
            txtComName.Focus();
        }

        protected void btnDeleteCom_Click(object sender, EventArgs e)
        {
            int CompID = 0;
            CompID = Convert.ToInt32(GridComView.SelectedRow.Cells[1].Text);
            Company_DB db = new Company_DB();
            db.DeleteCompany(CompID);
            txtComName.Text = "";
            txtComAdd.Text = "";
            TxtComEmail.Text = "";
            txtPhone.Text = "";
            txtTelephone.Text = "";
            txtWeb.Text = "";
            lblMsg.Text = "";
            txtComName.Focus();

            CompanyGridView();
            btnSave.Visible = true;
            lblMsg.Text = "Company Deeleted Successfully";
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }

       


    }
}