<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="CompanyBranch.aspx.cs" Inherits="MAHEEN_IT_INVENTORY.Company_Config.CompanyBranch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div  class="col-md-12">
            <section class="panel">
        <header class="panel-heading">
                    <center>Company Branch Name    </center>   
        </header>
               </section></div>
        <div class="panel-body">
            
        <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Branch Name:</label><asp:Label ID="Label1" runat="server"></asp:Label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtBranchName" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="lblMsg" runat="server"></asp:Label>
                </div>
            </div>
            <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Main Company Name:</label>
            <div class="col-sm-6">
                <asp:DropDownList runat="server" class="form-control" ID="txtComName" Enabled="true" ></asp:DropDownList>
    <%--<asp:TextBox ID="txtCname" runat="server" class="form-control" ></asp:TextBox>--%>
                </div>
            </div>

            <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Branch Address:</label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtBaddress" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="Label2" runat="server"></asp:Label>
                </div>
            </div>

            <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Email Address:</label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtBEmail" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="Label3" runat="server"></asp:Label>
                </div>
            </div>

            <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Mobile Number:</label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtBMobile" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="Label4" runat="server"></asp:Label>
                </div>
            </div>
            <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Telephone Number:</label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtBTelephone" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="Label5" runat="server"></asp:Label>
                </div>
            </div>

            <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Website:</label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtWebsite" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="Label6" runat="server"></asp:Label>
                </div>
            </div>
            
            <div class="form-group">        
      <div class="col-sm-offset-2 col-sm-4">
          <asp:Button ID="btnModify" runat="server" Text="Edit" CssClass="btn btn-primary" />
          <asp:Button ID="btnDelete" runat="server" Text="Remove" class="btn btn-info"  />
         <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" />
          <asp:Button ID="btnClear" runat="server" Text="Refresh" CssClass="btn btn-danger" />
          

          </div></div>
           

        
        
            </div>
</asp:Content>
