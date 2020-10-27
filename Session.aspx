<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Session.aspx.cs" Inherits="WebApplication3.Session" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h3>Provide Following Details</h3>

            Email <asp:TextBox ID="Email" runat="server" TextMode="Email" OnTextChanged="TextBox1_TextChanged" Height="22px" Width="145px" /><br/><br/>
            
            Password <asp:TextBox ID="Password" runat="server" TextMode="Password" Height="22px" Width="138px" /><br/><br/>

            Mobile <asp:TextBox ID="Mobile" runat="server" TextMode="Phone" Height="22px" Width="138px" /><br/><br/>
        
            Refrence <asp:TextBox ID="Search" runat="server" TextMode="Search" Height="22px" Width="138px" /><br/><br/>
            <asp:Button ID="Button1" runat="server" Text="Login" Height="29px" Width="64px" />
        </div>
        <p>
        <asp:Label ID="Label1" runat="server" ></asp:Label>
            <asp:Label ID="Label2" runat="server" ></asp:Label>
       </p>
   </form>
</body>
</html>
