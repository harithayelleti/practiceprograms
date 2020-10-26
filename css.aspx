<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="css.aspx.cs" Inherits="ASP.Net.css" %>

<!DOCTYPE html>


    <script runat="server">
    void Button1_Click(object sender, EventArgs e)
    {
        if (HyperLink1.CssClass == "CssStyle1")
            HyperLink1.CssClass = "CssStyle2";
        else
            HyperLink1.CssClass = "CssStyle1";
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head2" runat="server">
    <title>CssClass Property Example</title>
    <style type="text/css">
        .CssStyle1   
        { 
           font: 110pt Verdana; 
           font-weight:900;
           color: black;
        }

        .CssStyle2
        { 
           font: 20pt Times; 
           font-weight:20;
           color: orange;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h3>CssClass Property of a Web Control</h3>
        <asp:HyperLink id="HyperLink1" 
            NavigateUrl="http://www.microsoft.com" 
            CssClass="CssClass1" 
            Text="Click here to go to the Microsoft site" 
            Target="_new" runat="server" />
        <p><asp:Button id="Button1" 
            Text="Click to change the CSS style of the link"
            OnClick="Button1_Click" runat="server" />
         </p>
    </div>
    </form>
</body>
</html>
