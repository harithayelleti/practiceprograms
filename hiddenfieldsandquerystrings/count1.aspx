<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="count1.aspx.cs" Inherits="HiddenFields.count1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Button ID="Button1" runat="server" Text="hit count" BackColor="Blue" Font-Bold="True" ForeColor="Black"  />

            <br />
            <asp:Button ID="Button2" runat="server" Text="open another webpage" BackColor="Blue" Font-Bold="True" ForeColor="Black"  PostBackUrl="~/pageform.aspx" />

            <br />
    </div>

        <asp:HiddenField ID="HiddenField1" runat="server" value="0"/>

        <br />
        <br />
        <asp:Button ID="Button3" runat="server"  Text="Redirect" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Label ID="lbl" runat="server" Text=""/>
        <br />
        <br />
        <asp:HiddenField ID="HiddenField" runat="server"  />
        <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
                <asp:Label ID="Label2" runat="server"></asp:Label>
    </form>
</body>
</html>
