<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="backcolor.aspx.cs" Inherits="ASP.Net.backcolor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <h3>BackColor Property of a Web Control</h3>
 
        <asp:Table id="Table1" runat="server"
            CellPadding = "10" 
            GridLines="Both"
            BackColor="LightBlue">
            <asp:TableRow>
                <asp:TableCell>
                    Row 0, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 0, Col 1
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    Row 1, Col 0
                </asp:TableCell>
                <asp:TableCell>
                    Row 1, Col 1
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>
    </form>
</body>
</html>
