﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Postback.aspx.cs" Inherits="ASP.Net.Postback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl= "~/About.aspx" OnClick="LinkButton1_Click" >Click Here to see the postback</asp:LinkButton><br/><br/>
            <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl= "~/About.aspx" OnClick="LinkButton2_Click" >Click Here to see the postback for another link</asp:LinkButton>
        </div>
    </form>
</body>
</html>
