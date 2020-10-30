﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentvalidation.aspx.cs" Inherits="Aspvalidations.studentvalidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 108%;
            height: 518px;
            margin-left: 288px;
        }
        .auto-style2 {
            width: 163px;
        }
        .auto-style3 {
            width: 252px;
        }
        .auto-style4 {
            width: 163px;
            height: 36px;
            text-align: left;
        }
        .auto-style5 {
            width: 252px;
            height: 36px;
            text-align: left;
        }
        .auto-style6 {
            height: 36px;
            text-align: left;
        }
        .auto-style7 {
            text-align: center;
        }
        .auto-style8 {
            width: 252px;
            text-align: center;
        }
        .auto-style9 {
            width: 163px;
            text-align: center;
        }
        .auto-style10 {
            text-align: left;
        }
        .auto-style11 {
            width: 252px;
            text-align: left;
        }
        .auto-style12 {
            width: 163px;
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
            <table class="auto-style1" align="left">
                <tr>
                    <td class="auto-style12">FirstName</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="TextBox1" ErrorMessage="*Give The Name " ForeColor="Red"></asp:RangeValidator>
&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style12">LastName</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Lastname Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style12">Father&#39;sName</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Father's Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style12">Mothers&#39;sName</td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Mother's Name Required" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style12">Gender</td>
                    <td class="auto-style11">
                        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" ForeColor="#0066FF" GroupName="Gender" Text="Male" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" ForeColor="#FF66CC" GroupName="Gender" Text="Female" />
                    </td>
                    <td class="auto-style10">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style2">Aggeregate</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Please select</asp:ListItem>
                            <asp:ListItem>10%</asp:ListItem>
                            <asp:ListItem>20%</asp:ListItem>
                            <asp:ListItem>30%</asp:ListItem>
                            <asp:ListItem>40%</asp:ListItem>
                            <asp:ListItem>50%</asp:ListItem>
                            <asp:ListItem>60%</asp:ListItem>
                            <asp:ListItem>70%</asp:ListItem>
                            <asp:ListItem>80%</asp:ListItem>
                            <asp:ListItem>90%</asp:ListItem>
                            <asp:ListItem>100%</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="DropDownList1" ErrorMessage="Aggregate Needed" ForeColor="Red"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="DropDownList1" ErrorMessage="*Aggregate Needed" ForeColor="Red" MaximumValue="99%" MinimumValue="60%" ></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Course</td>
                    <td class="auto-style5">
                        <asp:RadioButton ID="RadioButton3" runat="server" ForeColor="Red" GroupName="Course" Text="CSE" />
&nbsp;&nbsp;&nbsp;
                        <asp:RadioButton ID="RadioButton4" runat="server" ForeColor="Lime" GroupName="Course" Text="ECE" />
                    </td>
                    <td class="auto-style6">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">CSE:<asp:CheckBoxList ID="CheckBoxList5" runat="server" OnSelectedIndexChanged="CheckBoxList3_SelectedIndexChanged">
                            <asp:ListItem>Please Select</asp:ListItem>
                            <asp:ListItem>Computer Operating Systems</asp:ListItem>
                            <asp:ListItem>Data Structures</asp:ListItem>
                            <asp:ListItem>Computer Networks</asp:ListItem>
                            <asp:ListItem>Database Management System</asp:ListItem>
                        
                        </asp:CheckBoxList>

                        <br />

                    </td>
                    <td class="auto-style10">&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">ECE:<asp:CheckBoxList ID="CheckBoxList6" runat="server">
                            <asp:ListItem>Please Select</asp:ListItem>
                            <asp:ListItem>Computer Operating Systems</asp:ListItem>
                            <asp:ListItem>Data Structures</asp:ListItem>
                            <asp:ListItem>Computer Networks</asp:ListItem>
                            <asp:ListItem>Database Management System</asp:ListItem>
                        
                        </asp:CheckBoxList>

                    </td>
                    <td class="auto-style10">&nbsp; </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
                        &nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
            </table>
        <div class="auto-style7">
        </div>
    </form>
</body>
</html>
