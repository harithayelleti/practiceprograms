<%@ Page Language="C#" AutoEventWireup="true" CodeFile="genraltech.aspx.cs" Inherits="genraltech" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <input type="text" name="TextBox1"/>
            <button style="width: 65px">Submit</button><br/><br/>

            <asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"/>
            <asp:Button ID="button1" runat="server" Text="SUBMIT" /><br/>
            <asp:Button ID="Button2" runat="server" Text="Button" /><br/>
            <asp:Image ID="Image1" runat="server" /><br/><br/>
            <asp:Image ID="Image2" runat="server"/><br/><br/>
            <asp:RadioButton ID="rdnred" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="Red" Height="20px" OnCheckedChanged="rdnred_CheckedChanged" Text="RED" /><br /><br/>
            <asp:RadioButton ID="rdnblue" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="Blue" Height="20px" OnCheckedChanged="rdnblue_CheckedChanged" Text="BLUE" /><br/><br/>
            <asp:RadioButton ID="rdngreen" runat="server" AutoPostBack="True" Font-Bold="True" ForeColor="#009900" Height="20px" OnCheckedChanged="rdngreen_CheckedChanged" Text="GREEN" /><br/><br/>
        </div>
    </form>
</body>
</html>
