<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="PROJECT.WebForm1" %>

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
            height: 23px;
        }
    .auto-style3 {
            width: 109px;
        }
        .auto-style4 {
            width: 339px;
        }
        .auto-style5 {
            width: 109px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2"><strong>Category Master</strong></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;CategoryId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">CategoryName :</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        <br />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add Category" />
                        &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Update" />
                        &nbsp;
                        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Delete" />
                        &nbsp;
                        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Search" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Status :"></asp:Label>
                        <br />
                        <br />
&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/WebForm2.aspx">Product Master</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/WebForm3.aspx">Product List</asp:HyperLink>
        </p>
    </form>
</body>
</html>
