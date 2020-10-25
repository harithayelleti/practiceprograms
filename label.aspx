<%@ Page Language="C#" AutoEventWireup="true" CodeFile="label.aspx.cs" Inherits="label" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>This is an Example of document upload</title>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4>Provide the Below Information</h4>

            
               <asp:Label ID="Label1" runat="server" Text="Username" Font-Bold="True" ForeColor="#CC3300" Height="20px"/>
                    
                <asp:TextBox ID="TextBox1" runat="server" Style="margin-left:38px" BackColor="#FFFFCC" BorderColor="#FFCCFF" BorderStyle="Double"/><br/><br/>
                    
                   
                 <asp:Label ID="Label2" runat="server" Text="Upload a file" Font-Bold="True" ForeColor="#CC3300" Height="20px"/>
                    
                 <asp:FileUpload ID="FileUpload1" runat="server" Style="margin-left:24px" Width="277px" BackColor="#FFFF99" BorderColor="#FF99CC"/>
                    



            
            
            
            
           <br/>

        </div>
    </form>
</body>
</html>
