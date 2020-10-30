<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="electionvalidation.aspx.cs" Inherits="Aspvalidations.electionvalidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 102px;
        }
        .auto-style2 {
            width: 102px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 143px;
        }
        .auto-style4 {
            width: 102px;
            height: 25px;
            text-align: center;
        }
        .auto-style5 {
            height: 25px;
            width: 143px;
        }
        .auto-style6 {
            width: 543px;
        }
        .auto-style7 {
            height: 25px;
            width: 543px;
            text-align: center;
        }
        .auto-style8 {
            height: 23px;
            width: 543px;
        }
        .auto-style9 {
            width: 62%;
            margin-left: 196px;
        }
        .auto-style10 {
            text-align: center;
            width: 143px;
        }
        .auto-style11 {
            width: 543px;
            text-align: center;
        }
        .auto-style12 {
            width: 102px;
            text-align: center;
        }
        .auto-style13 {
            width: 143px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" class="auto-style9">
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">Candidate</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox1" runat="server" Width="181px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Give your valid Name " ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">House</td>
                    <td class="auto-style7">
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" ForeColor="Red" Text="Red" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" ForeColor="#3333CC" Text="Blue" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton3" runat="server" AutoPostBack="True" ForeColor="#66FF66" Text="Green" />
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton4" runat="server" AutoPostBack="True" ForeColor="#FFFF66" Text="Yellow" />
                    </td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style12">Education</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox3" runat="server" Width="195px"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Specified Education" ForeColor="Red" MaximumValue="12" MinimumValue="6" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">Email</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox2" runat="server" Width="204px" AutoPostBack="True" TextMode="Email"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Valid Email Address" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" Text="Submit" />
                        &nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                        &nbsp;</td>
                    <td class="auto-style10">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
