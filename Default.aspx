<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>sample asp.net website</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%Response.Write("My First Page create in IIS Express"); %>
        </div>

        <p>Web forms are the web pages in asp.net</p>
    </form>
</body>
</html>
