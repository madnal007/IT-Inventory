<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Department_Config.aspx.cs" Inherits="MAHEEN_IT_INVENTORY.Company_Config.Department_Config" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
     function textBoxValidation() {
         var CompanyName = document.getElementById('<%=txtDeptName.ClientID%>').value;
         
            if (CompanyName == '') {
                alert('please enter department');
                document.getElementById('<%=txtDeptName.ClientID%>').focus();
            return false;
            }

    }
</script>
 
    <div  class="col-md-12">
            <section class="panel">
        <header class="panel-heading">
                    <center>Configure Department Here    </center>   
        </header>
               </section></div>
        <div class="panel-body">
            
        <div class="form-group">
    <label class="control-label col-sm-2" for="companyname">Company Name:</label>
            <div class="col-sm-6">
    <asp:TextBox ID="txtDeptName" runat="server" class="form-control" ></asp:TextBox><asp:Label ID="lblMsg" runat="server"></asp:Label>
                </div>
            </div>
            <div class="form-group">        
      <div class="col-sm-offset-2 col-sm-4">
          <asp:Button ID="btnEdit" runat="server" Text="Update" CssClass="btn btn-primary" OnClick="btnEdit_Click" />
          <asp:Button ID="btnDelete" runat="server" Text="Remove" class="btn btn-info" OnClick="btnDelete_Click" />
            <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-success" OnClick="btnSave_Click" OnClientClick="return textBoxValidation();" />
           <asp:Button ID="btnCancel" runat="server" Text="Refresh" CssClass="btn btn-danger" OnClick="btnCancel_Click" />

          </div></div>
            <asp:GridView ID="GridViewDept" runat="server" CellPadding="4"  HeaderStyle-CssClass="" 
	          FooterStyle-CssClass="GrayBackWhiteFont" 
	          ItemStyle-CssClass="Normal" 
	          ItemStyle-BackColor="#ecd1c4" 
	          AlternatingItemStyle-BackColor="white" borderwidth="1px"  BackColor="White" BorderColor="#3366CC" 
              BorderStyle="None" ShowFooter="True"  CssClass=" table  table-bordered table-striped table-hover margin-bottome-0" AutoGenerateSelectButton="false" OnSelectedIndexChanged="GridViewDept_SelectedIndexChanged" OnRowEditing="GridViewDept_RowEditing" >
                <Columns><asp:CommandField ShowSelectButton="true" SelectText="Edit" /></Columns>
            </asp:GridView>

        
        
            </div>
        
</asp:Content>
