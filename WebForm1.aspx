<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 34%;
            margin-right: 0px;
        }
        .auto-style2 {
            width: 191px;
        }
        .auto-style3 {
            width: 118px;
        }
        .auto-style4 {
            margin-left: 61px;
        }
        .auto-style5 {
            margin-left: 117px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">ID</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="285px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="285px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">City</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Width="285px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Email</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" Width="285px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save" OnClick="Button1_Click" Width="65px" />
            <asp:Button ID="Button2" runat="server" CssClass="auto-style4" OnClick="Button2_Click" Text="Update" />
            <asp:Button ID="Button3" runat="server" CssClass="auto-style5" OnClick="Button3_Click" Text="Delete" />
            <br />
            <br />
        </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Week5ConnectionString %>" SelectCommand="StudentDetails" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
    </form>
</body>
</html>
