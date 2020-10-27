<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ondisposed.aspx.cs" Inherits="ASP.Net.ondisposed" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton ID="LinkButton1" runat="server" OnDisposed="LinkButton1_Disposed">Disposed Property</asp:LinkButton><br />
			<asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
    </form>
</body>
</html>
