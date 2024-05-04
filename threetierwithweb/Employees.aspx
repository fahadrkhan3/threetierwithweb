﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="threetierwithweb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="EMPLOYEE TABLE"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
            <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="Cell"></asp:Label>
            <asp:TextBox ID="txtcell" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btninsert" runat="server" OnClick="btninsert_Click" Text="Insert" />
            <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" />
            <asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click" />
            <asp:Button ID="btnclear" runat="server" OnClick="btnclear_Click" Text="Clear" />
        </p>
        <asp:GridView ID="dataGridView1" runat="server" Width="454px">
        </asp:GridView>
        <p>
            <asp:Button ID="btnviewall" runat="server" Text="View All" OnClick="btnviewall_Click" />
        </p>
    </form>
</body>
</html>
