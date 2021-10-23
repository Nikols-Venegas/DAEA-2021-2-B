<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="InterfazWeb.Person" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="DGVLista" runat="server" BorderColor="#004C50" BorderWidth="3px" CellPadding="5">
                <HeaderStyle BackColor="#24A1A7 " Font-Bold="True" ForeColor="White" />
                <RowStyle BackColor="#D7F7F9" ForeColor="Black" />
            </asp:GridView>
        </div>
    </form>
</body>
</html>
