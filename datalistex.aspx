﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="datalistex.aspx.cs" Inherits="WebApplication3.datalistex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>The DataList shows data of the Data Table</p>
            <asp:DataList ID="DataList1" runat="server" Height="98px" Width="342px">
                <ItemTemplate>
                    <asp:Table ID="Table1" runat="server" CellPadding="2"  Cellspacing="0" Border="1" Style="width:250px;height:50px ;background-color:Navy" />

                    <tr>
                        <td>
                            <strong>FirstName</strong> <span class="City" ><%# Eval("FirstName") %></span><br/><br/>
                            <strong>LastName</strong> <span class="PostalAddress"><%# Eval ("LastName") %></span><br/><br/>
                            <strong>Designation</strong> <span class="State"><%# Eval("Designation") %></span><br/><br/>
                            <strong>Location</strong> <span class="Country"><%# Eval ("Location") %></span><br/><br/>
                            <strong>Country</strong> <span class="Continent"><%# Eval("Country") %></span><br/><br/>
                            </td>
                        </tr>


                </ItemTemplate>
            </asp:DataList>
        </div>
    </form>
</body>
</html>
