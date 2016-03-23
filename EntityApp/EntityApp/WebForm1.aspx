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
                <td class="auto-style4">
                    <asp:ListView ID="lvPosts" runat="server" SelectMethod="lvPosts_GetData" 
                        DataKeyNames="PostId" DeleteMethod="lvPosts_DeleteItem"
                         OnItemUpdating="lvPosts_ItemUpdating" UpdateMethod="lvPosts_UpdateItem">
                        <AlternatingItemTemplate>
                            <span style="background-color: #FFF8DC;">PostId:
                            <asp:Label ID="PostIdLabel" runat="server" Text='<%# Eval("PostId") %>' />
                            <br />
                            Title:
                            <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                            <br />
                            Content:
                            <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                            <br />
                            Blog:
                            <asp:Label ID="BlogLabel" runat="server" Text='<%# Eval("Blog.Name") %>' />
                            <br />
                            <br /></span>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <span style="background-color: #008A8C;color: #FFFFFF;">PostId:
                            <asp:TextBox ID="PostIdTextBox" runat="server" Text='<%# Bind("PostId") %>' />
                            <br />
                            Title:
                            <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                            <br />
                            Content:
                            <asp:TextBox ID="ContentTextBox" runat="server" Text='<%# Bind("Content") %>' />
                            <br />
                            Blog:
                            <asp:TextBox ID="BlogTextBox" runat="server" Text='<%# Bind("Blog") %>' />
                            <br />
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Обновить" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Отмена" />
                            <br /><br /></span>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <span>Нет данных.</span>
                        </EmptyDataTemplate>
                        <InsertItemTemplate>
                            <span style="">PostId:
                            <asp:TextBox ID="PostIdTextBox" runat="server" Text='<%# Bind("PostId") %>' />
                            <br />Title:
                            <asp:TextBox ID="TitleTextBox" runat="server" Text='<%# Bind("Title") %>' />
                            <br />Content:
                            <asp:TextBox ID="ContentTextBox" runat="server" Text='<%# Bind("Content") %>' />
                            <br />Blog:
                            <asp:TextBox ID="BlogTextBox" runat="server" Text='<%# Bind("Blog") %>' />
                            <br />
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Вставить" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Очистить" />
                            <br /><br /></span>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <span style="background-color: #DCDCDC;color: #000000;">PostId:
                            <asp:Label ID="PostIdLabel" runat="server" Text='<%# Eval("PostId") %>' />
                            <br />
                            Title:
                            <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                            <br />
                            Content:
                            <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                            <br />
                            Blog:
                            <asp:Label ID="BlogLabel" runat="server" Text='<%# Eval("Blog.Name") %>' />
                            <br />
                            <br /></span>
                        </ItemTemplate>
                        <LayoutTemplate>
                            <div id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                                <span runat="server" id="itemPlaceholder" />
                            </div>
                            <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                            </div>
                        </LayoutTemplate>
                        <SelectedItemTemplate>
                            <span style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">PostId:
                            <asp:Label ID="PostIdLabel" runat="server" Text='<%# Eval("PostId") %>' />
                            <br />
                            Title:
                            <asp:Label ID="TitleLabel" runat="server" Text='<%# Eval("Title") %>' />
                            <br />
                            Content:
                            <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                            <br />
                            Blog:
                            <asp:Label ID="BlogLabel" runat="server" Text='<%# Eval("Blog") %>' />
                            <br />
                            <br /></span>
                        </SelectedItemTemplate>
                   
                    </asp:ListView>
                   
                    <asp:LinqDataSource ID="BlogsContextDataSource" runat="server" 
                       EnableUpdate="true" ContextTypeName="EntityApp.BlogsContext" EntityTypeName="" TableName="Posts">
                    </asp:LinqDataSource>
                   
                </td>
                <td class="auto-style6">&nbsp;</td>
                <td>
                   
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
