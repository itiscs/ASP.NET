<%@ Page Language="C#" AutoEventWireup="true" Trace="true" 
    CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication11.WebForm4" %>

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
            height: 25px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="TOVAR"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtTOVAR" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="ED_IZM"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtED_IZM" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="ZENA"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_ZENA" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="COUNT_TOV"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txt_COUNT_TOV" runat="server" TextMode="Number"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" style="height: 25px" Text="Save" />
                </td>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
                </td>
            </tr>
        </table>
    <div>
    
        <asp:Label ID="lblAdd" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
