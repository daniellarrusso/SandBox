<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PL.aspx.cs" Inherits="Web3Tier.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:TextBox ID="txtEmployeeId" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="search" runat="server" Text="Search Employee Id" OnClick="search_Click" />
        
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" />
                
            </Columns>
        </asp:GridView>
       
    </div>
        <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="FirstName" DataValueField="FirstName">
            
        </asp:DropDownList>

         <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="LastName" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>
