<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="WebApplication4.registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>User Form</h2>


            <asp:Label ID="Label1" runat="server" Text="Username" />
            <asp:TextBox ID="Username" runat="server" required="true" Height="16px" Width="223px" style="margin-left: 77px"/><br/><br/>
 
            <asp:Label ID="Label2" runat="server" Text="Emailaddress" />
            <asp:TextBox ID="Emailaddress" runat="server" required="true" Height="16px" Width="223px" style="margin-left: 57px"/><br/><br/>

            <asp:Label ID="Label3" runat="server" Text="Password" />
            <asp:TextBox ID="password" runat="server" Textmode="Password" Height="16px" Width="219px" style="margin-left: 87px" /><br/><br/>

            <asp:Label ID="Label4" runat="server" Text="ConfirmPassword" />
            <asp:TextBox ID="confirmpassword" runat="server" Textmode="Password" Height="21px" Width="218px" style="margin-left: 35px" /><br/><br/>


            <asp:Label ID="Label5" runat="server" Text="Gender" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" Text="Female"/><br /><br/>
            

            <asp:Label ID="Label6" runat="server" Text="Courses Available" />&nbsp;&nbsp;  <br/><br/>    
            <asp:CheckBox ID="CheckBox1" runat="server" Text="Java"  /><br/><br/>
            <asp:CheckBox ID="CheckBox2" runat="server" Text="Python"  /><br/><br/>
            <asp:CheckBox ID="CheckBox3" runat="server" Text="Asp.Net" /><br/><br/>
            <asp:CheckBox ID="CheckBox4" runat="server" Text="SpringBoot" /><br/><br/>
            <asp:CheckBox ID="CheckBox5" runat="server" Text="Csharp" /><br/><br/>
            <asp:CheckBox ID="CheckBox6" runat="server" Text="Mysql" /><br/><br/>

            <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /><br/><br/>      
            
            <asp:Label ID="message" runat="server" />
            

            

            <asp:Label ID="ShowUserName" runat="server" />

            
            <asp:LAbel ID="ShowEmailAddress" runat="server" />
            

            

            <asp:Label ID="ShowGender" runat="server" />

            <asp:Label ID="ShowCourses" runat="server" />
        
           <asp:Label ID="ShowUsernameLabel" runat="server" />
            <asp:Label ID="ShowEmailAddressLabel" runat="server" />
            <asp:Label ID="ShowGenderLabel" runat="server" />
            <asp:Label ID="ShowCoursesLabel" runat="server" />
        
        </div>
        
            
    </form>
</body>
</html>
