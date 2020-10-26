<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="weight.aspx.cs" Inherits="ASP.Net.weight" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head2" runat="server">
    <title>WebControl Example</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <h3>Width Property of a Web Control</h3>
    <asp:Table id="Table1" runat="server"
        CellPadding="100" GridLines="Both"
        Width="500">
 
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
