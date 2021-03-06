﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tooltip.aspx.cs" Inherits="ASP.Net.Tooltip" %>

<!DOCTYPE html>


<script runat="server">
 
    void SubmitBtn_Click(object sender, EventArgs e)
    {
        if (((Button)sender).CommandArgument == "1")
            Label1.Text = "Change the world!";
        else
            Label1.Text = "Save the world!";

        Label1.BorderColor = System.Drawing.Color.BurlyWood;
        Label1.BorderWidth = 4;
    }
 
 </script>
 <html xmlns="http://www.w3.org/1999/xhtml">
 <head runat="server">
    <title>WebControl.ToolTip Example</title>
 </head>
 <body>
 <form id="Form1" runat="server">
 
    <h3>ToolTip Property of a Web Control</h3>
    <p>Don't know which button to click?<br />
        Move the mouse pointer over the buttons to find out!
    </p>

    <p><asp:Button id="SubmitBtn1" OnClick="SubmitBtn_Click" 
            Text="Click Me" CommandArgument="1"
            ToolTip="Click me if you are an engineer" runat="server"/>
    </p>

    <p><asp:Button id="SubmitBtn2" OnClick="SubmitBtn_Click" 
            Text="Click Me" CommandArgument="2"
            ToolTip="Click me if you are a doctor." runat="server"/>
    </p>

    <asp:Label id="Label1" Font-size="24pt" Font-Bold="True" 
        BackColor="Yellow" runat="server"/>

 </form>
 
</body>
</html>
