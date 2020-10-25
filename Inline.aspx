<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void button1_Click(object sender, EventArgs e)
    {
        Response.Write("This is inline coding");
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="button1" runat="server" Text="Click Me" ForeColor="Salmon" Height="165px" Width="165px" OnClick="button1_Click" />
        </div>
    </form>
</body>
</html>
