<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cookiecollection.aspx.cs" Inherits="WebApplication3.cookiecollection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <asp:Label ID="Label1" runat="server" Text="Select Brand Prefernces"/><br/><br/>
        <asp:CheckBox ID="CheckBox1" runat="server" Text="Iphone" OnCheckedChanged="CheckBox1_CheckedChanged"/><br/><br/>
        <asp:CheckBox ID="CheckBox2" runat="server" Text="Honor"/><br/><br/>
        <asp:CheckBox ID="CheckBox3" runat="server" Text="Oneplus"/><br/><br/>
        <asp:CheckBox ID="CheckBox4" runat="server" Text="Realme"/><br/><br/>
        <asp:CheckBox ID="CheckBox5" runat="server" Text="Samsung"/><br/><br/>
        <asp:CheckBox ID="CheckBox6" runat="server" Text="Vivo" /><br/><br/>
        <asp:CheckBox ID="CheckBox7" runat="server" Text="Poco"/><br/><br/>
        <asp:CheckBox ID="CheckBox8" runat="server" Text="Asus"/><br/><br/>
        <asp:CheckBox ID="CheckBox9" runat="server" Text="Lenovo"/><br/><br/>
        <asp:CheckBox ID="CheckBox10" runat="server" Text="Mi"/><br/><br/>
        <asp:Button ID="Button1" runat="server" Text="Check on" />

        
        </div>
    </form>
    <p>
        <asp:Label ID="Label2" runat="server" />
        </p>
</body>
</html>
