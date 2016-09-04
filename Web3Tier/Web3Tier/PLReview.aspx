<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PLReview.aspx.cs" Inherits="Web3Tier.PLReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>Cow</div>
    <form id="form1" runat="server">
        <asp:GridView ID="searched" runat="server" AutoGenerateColumns="true">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
            </Columns>
        </asp:GridView>
    <div>
    
    </div>
    </form>
</body>
</html>
