<%@ Page Language="C#" AutoEventWireup="true" CodeFile="text.aspx.cs" Inherits="text" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Username" runat="server" ToolTip="Enter your Name"/>
            <asp:TextBox ID="TextBox1" runat="server"/>

            <br/>
            <asp:HyperLink ID="HyperLink1" runat="server" Text="SheShore" NavigateUrl="~/Contact.aspx"/>

        </div>
        <p>
          <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click"/>    
        </p>
    </form>
    <asp:Label ID="userinput" runat="server"/>
</body>
</html>
