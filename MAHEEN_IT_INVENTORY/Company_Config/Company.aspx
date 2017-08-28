<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Company.aspx.cs" Inherits="MAHEEN_IT_INVENTORY.Company_Config.Company" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <script type="text/javascript">
     function textBoxValidation() {
         var CompanyName = document.getElementById('<%=txtComName.ClientID%>').value;
         
            if (CompanyName == '') {
                alert('please enter company name');
                document.getElementById('<%=txtComName.ClientID%>').focus();
            return false;
            }
         var address = document.getElementById('<%=txtComAdd.ClientID%>').value;
         if (address == '') {
             alert('please enter company address');
             document.getElementById('<%=txtComAdd.ClientID%>').focus();
             return false;
         }

         var Email = document.getElementById('<%=TxtComEmail.ClientID%>').value;
         if (Email == '') {
             alert('please enter email address');
             document.getElementById('<%=TxtComEmail.ClientID%>').focus();
             return false;
         }
         var phone = document.getElementById('<%=txtPhone.ClientID%>').value;
         if (phone == '') {
             alert('please enter phone number');
             document.getElementById('<%=txtPhone.ClientID%>').focus();
             return false;
         }
         var telephone = document.getElementById('<%=txtTelephone.ClientID%>').value;
         if (telephone == '') {
             alert('please enter telephone phone number');
             document.getElementById('<%=txtTelephone.ClientID%>').focus();
             return false;
         }
         var telephone = document.getElementById('<%=txtTelephone.ClientID%>').value;
         if (telephone == '') {
             alert('please enter telephone phone number');
             document.getElementById('<%=txtTelephone.ClientID%>').focus();
             return false;
         }
         var web = document.getElementById('<%=txtWeb.ClientID%>').value;
         if (web == '') {
             alert('please enter a valid web address');
             document.getElementById('<%=txtWeb.ClientID%>').focus();
             return false;
         }

         

    }
</script>
        <div  class="col-md-12">
            <section class="panel">
        <header class="panel-heading">
                    <center>Company Details    </center>   
        </header>
               </section></div>
        <div class="panel-body">
            <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Company Name:</label>
            <div class="col-sm-4">
    <asp:TextBox ID="txtComName" runat="server" class="form-control" ></asp:TextBox>
                </div>
            </div>
        <div class="form-group">
    <label class="control-label col-sm-2" for="companyaddres">Company Address</label>
<div class="col-sm-4">
    <asp:TextBox ID="txtComAdd" runat="server" class="form-control"></asp:TextBox>
    </div>
            </div>
        <div class="form-group">
    <label class="control-label col-sm-2" for="emailaddres" >Email Address</label>
        <div class="col-sm-4">
    <asp:TextBox ID="TxtComEmail" runat="server" class="form-control"></asp:TextBox>
            </div>
            </div>

        <div class="form-group">
    <label class="control-label col-sm-2" for="phone">Phone Number</label>*
<div class="col-sm-4">
    <asp:TextBox ID="txtPhone" runat="server" class="form-control"></asp:TextBox>
    </div>
            </div>
        <div class="form-group">
    <label class="control-label col-sm-2" for="telephone">Telephone</label>
        <div class="col-sm-4">
    <asp:TextBox ID="txtTelephone" runat="server" class="form-control"></asp:TextBox>
            </div></div>

        <div class="form-group">
    <label class="control-label col-sm-2" for="website">Website</label>
            <div class="col-sm-4">
    <asp:TextBox ID="txtWeb" class="form-control" runat="server" ></asp:TextBox>
                </div>
            </div>
        <div class="form-group">        
      <div class="col-sm-offset-2 col-sm-4">
          <asp:Button ID="btnEdit" runat="server" CssClass="btn btn-primary" Text="Update" OnClick="btnEdit_Click" />
          <asp:Button ID="btnDeleteCom" runat="server" Text="Remove" class="btn btn-info" OnClick="btnDeleteCom_Click" />
        <asp:Button ID="btnSave" runat="server" CssClass="btn btn-success" Text="Save" OnClick="btnSave_Click" OnClientClick="return textBoxValidation();" />
          <asp:Button ID="btnCancel" runat="server" Text="Clear" CssClass="btn btn-danger" OnClick="btnCancel_Click" />
          </div>
            </div>

        <div class="table-responsive" >
              <asp:GridView ID="GridComView" runat="server" CellPadding="4"  HeaderStyle-CssClass="" 
	          FooterStyle-CssClass="GrayBackWhiteFont" 
	          ItemStyle-CssClass="Normal" 
	          ItemStyle-BackColor="#ecd1c4" 
	          AlternatingItemStyle-BackColor="white" borderwidth="1px"  BackColor="White" BorderColor="#3366CC" 
              BorderStyle="None" ShowFooter="True"  CssClass=" table  table-bordered table-striped table-hover margin-bottome-0" AutoGenerateSelectButton="false"  OnSelectedIndexChanged="GridComView_SelectedIndexChanged" OnRowDataBound="GridComView_RowDataBound" OnSelectedIndexChanging="GridComView_SelectedIndexChanging" OnRowUpdating="GridComView_RowUpdating" PageSize="3" AllowPaging="True" OnPageIndexChanging="GridComView_PageIndexChanging">
                  <Columns><asp:CommandField ShowSelectButton="true" SelectText="Edit" /></Columns>
              </asp:GridView>
             </div>
            </div>
             
    

</asp:Content>
