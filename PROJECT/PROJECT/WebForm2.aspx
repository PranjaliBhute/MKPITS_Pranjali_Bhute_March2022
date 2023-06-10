<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="PROJECT.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            height: 110px;
        }
        .auto-style4 {
            text-align: right;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Product Master</strong></td>
                </tr>
                <tr>
                    <td class="auto-style4">ProductId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">ProductName&nbsp;&nbsp; :</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">CategoryName :</td>
                    <td>
                        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="CategoryName" DataValueField="CategoryId">
                        </asp:DropDownList>
                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PROJECT_MASTERConnectionString %>" SelectCommand="SELECT * FROM [Category_Master]"></asp:SqlDataSource>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"><asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Product" />
                        &nbsp;
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                        &nbsp;
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                        &nbsp;
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Status :"></asp:Label>
                        <br />
                        <br />
&nbsp;
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm1.aspx">Category Master</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebForm3.aspx">Product List</asp:HyperLink>
        </p>
    </form>
</body>
</html>
