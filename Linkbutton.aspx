<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Linkbutton.aspx.cs" Inherits="ASP.Net.Linkbutton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   

    <form id="form1" runat="server">
        <h3>It is Hyper Link Button</h3>

        <div>
             Name:<asp:TextBox id="TextBox1" runat="server" />
   <asp:LinkButton id="Button1" Text="Submit"
   PostBackUrl="demo_postbackurl.aspx" runat="Server" />
            <asp:LinkButton ID="linkButton1" runat="server" OnClick="Linkbutton1_Click" > Facebook </asp:LinkButton><br/><br/>
            
            <asp:LinkButton ID="linkButton2" runat="server" OnClick="Linkbutton1_Click" >Youtube</asp:LinkButton><br/><br/>
            
            <asp:LinkButton ID="linkButton3" runat="server" OnClick="Linkbutton1_Click" >Instagram</asp:LinkButton><br/><br/>
            
            <asp:LinkButton ID="linkButton4" runat="server" OnClick="Linkbutton1_Click" >Netflix</asp:LinkButton><br/><br/>
            
            <asp:LinkButton ID="linkButton5" runat="server" OnClick="Linkbutton1_Click" >Viki</asp:LinkButton><br/><br/>
        </div>
        <p>
            <asp:Label ID="Hello" runat="server"/>
            </p>
    </form>
</body>
</html>
