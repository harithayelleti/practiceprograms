<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DropDown.aspx.cs" Inherits="WebApplication3.DropDown" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <p>Select The  your  city for variety of foods we offer </p>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" >

            <asp:ListItem value="Please select" runat="server">Please Select </asp:ListItem>
            <asp:ListItem runat="server">Banglore </asp:ListItem>
            <asp:ListItem runat="server">Hyderabad </asp:ListItem>
            <asp:ListItem runat="server">Vizag </asp:ListItem>
            <asp:ListItem runat="server">Pune </asp:ListItem>
            <asp:ListItem runat="server">Chennai </asp:ListItem>
                </asp:DropDownList><br/><br/>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

        </div>
        <p>
            <asp:Label ID="Label1" runat="server" />
            </p>
        <asp:DropDownList ID="DropDownList2" runat="server" >
            <asp:ListItem>Chicken</asp:ListItem>
            <asp:ListItem>Pulihora</asp:ListItem>
            <asp:ListItem>Paneer</asp:ListItem>
            <asp:ListItem>Chicken Tandoori</asp:ListItem>
            <asp:ListItem>Chicken Majestic</asp:ListItem>
            <asp:ListItem>Chicken Coding</asp:ListItem>
         </asp:DropDownList><br/><br/>
        <asp:Button ID="Button2" runat="server" Text="Hola" OnClick="Button2_Click" /><br/><br/>
        
    </form>
</body>
</html>
