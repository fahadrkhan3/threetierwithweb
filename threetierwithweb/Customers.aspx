<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="threetierwithweb.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form3" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="CUSTOMER TABLE"></asp:Label>
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="ID"></asp:Label>
            <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
           <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click1" style="height: 26px" />
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="FName"></asp:Label>
            <asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="LName"></asp:Label>
            <asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="Since"></asp:Label>
            <asp:TextBox ID="txtsince" runat="server"></asp:TextBox>
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
            <asp:Button ID="btnviewall" runat="server" Text="View All" OnClick="btnviewall_Click1" />
        </p>
    </form>
    </body>
</html>
