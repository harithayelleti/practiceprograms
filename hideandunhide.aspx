<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="hideandunhide.aspx.cs" Inherits="ASP.Net.hideandunhide" %>

<!DOCTYPE html>

<script runat="server">
 
    void Button1_Click(Object sender, EventArgs e)
    {
        if (Label1.Style["visibility"] == "hidden")
            Label1.Style["visibility"] = "show";
        else
            Label1.Style["visibility"] = "hidden";
    }
 
</script>
 
<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head2" runat="server">
    <title>Style Property of a Web Control</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 
        <h3>Style Property of a Web Control</h3>
 
        <asp:Label id="Label1" Text="This is a label control." 
            BorderStyle="Solid" runat="server"/>

        <p>
            <asp:Button id="Button1" 
                Text="Click to hide or unhide the label"
                OnClick="Button1_Click" runat="server"/>
        </p>

    </div>
    </form>
</body>
</html>
