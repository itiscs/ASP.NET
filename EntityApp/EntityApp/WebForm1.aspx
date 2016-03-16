<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="EntityApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 29px;
        }
        .auto-style3 {
            height: 29px;
            width: 241px;
        }
        .auto-style4 {
            width: 241px;
        }
        .auto-style5 {
            height: 29px;
            width: 155px;
        }
        .auto-style6 {
            width: 155px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:TextBox ID="blogName" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlBlogs" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBlogs_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 25px" Text="Add blog" />
                </td>
                <td class="auto-style6">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add Post" />
                </td>
                <td>
                    <asp:TextBox ID="txtContent" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                   
                    <asp:Label ID="Label1"  runat="server" Text="Label"></asp:Label>

                   
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
