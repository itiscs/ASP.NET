<%@ Page Language="C#" AutoEventWireup="true" Trace="true"  CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication11.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataKeyNames="KOD_TOVAR" DataSourceID="SqlDataSource1" EmptyDataText="Нет записей для отображения." GridLines="Vertical" PageSize="3">
            <AlternatingRowStyle BackColor="Gainsboro" />
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="KOD_TOVAR" HeaderText="KOD_TOVAR" ReadOnly="True" SortExpression="KOD_TOVAR" />
                <asp:BoundField DataField="TOVAR" HeaderText="TOVAR" SortExpression="TOVAR" />
                <asp:BoundField DataField="ED_IZM" HeaderText="ED_IZM" SortExpression="ED_IZM" />
                <asp:BoundField DataField="ZENA" HeaderText="ZENA" SortExpression="ZENA" />
                <asp:BoundField DataField="COUNT_TOV" HeaderText="COUNT_TOV" SortExpression="COUNT_TOV" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myBaseConnectionString1 %>" DeleteCommand="DELETE FROM [TOVARY] WHERE [KOD_TOVAR] = @KOD_TOVAR" InsertCommand="INSERT INTO [TOVARY] ([TOVAR], [ED_IZM], [ZENA], [COUNT_TOV]) VALUES (@TOVAR, @ED_IZM, @ZENA, @COUNT_TOV)" ProviderName="<%$ ConnectionStrings:myBaseConnectionString1.ProviderName %>" SelectCommand="SELECT [KOD_TOVAR], [TOVAR], [ED_IZM], [ZENA], [COUNT_TOV] FROM [TOVARY]" UpdateCommand="UPDATE [TOVARY] SET [TOVAR] = @TOVAR, [ED_IZM] = @ED_IZM, [ZENA] = @ZENA, [COUNT_TOV] = @COUNT_TOV WHERE [KOD_TOVAR] = @KOD_TOVAR">
            <DeleteParameters>
                <asp:Parameter Name="KOD_TOVAR" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="TOVAR" Type="String" />
                <asp:Parameter Name="ED_IZM" Type="String" />
                <asp:Parameter Name="ZENA" Type="Int32" />
                <asp:Parameter Name="COUNT_TOV" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TOVAR" Type="String" />
                <asp:Parameter Name="ED_IZM" Type="String" />
                <asp:Parameter Name="ZENA" Type="Int32" />
                <asp:Parameter Name="COUNT_TOV" Type="Int32" />
                <asp:Parameter Name="KOD_TOVAR" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Выбрать" />
    </form>
</body>
</html>
