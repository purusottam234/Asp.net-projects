<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Crud.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Label ID="Label1" runat="server" Text=" Purusottam Tech"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text=" Crud operation"></asp:Label>
            <br />
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" DataKeyNames="sid" DataSourceID="SqlDataSource1" DefaultMode="Insert" ForeColor="Black" Height="50px" OnItemInserted="DetailsView1_ItemInserted" Width="326px">
                <EditRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <Fields>
                    <asp:BoundField DataField="sid" HeaderText="Roll No" ReadOnly="True" SortExpression="sid" />
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                    <asp:BoundField DataField="age" HeaderText="Age" SortExpression="age" />
                    <asp:CommandField ShowInsertButton="True" />
                </Fields>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
            </asp:DetailsView>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" DataKeyNames="sid" DataSourceID="SqlDataSource1" ForeColor="Black" GridLines="Vertical" Width="582px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <Columns>
                    <asp:BoundField DataField="sid" HeaderText="Roll No" ReadOnly="True" SortExpression="sid"></asp:BoundField>
                    <asp:BoundField DataField="name" HeaderText="Name" SortExpression="name" />
                    <asp:BoundField DataField="address" HeaderText="Address" SortExpression="address" />
                    <asp:BoundField DataField="age" HeaderText="Age" SortExpression="age" />
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                </Columns>
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:amcConnectionString %>" DeleteCommand="DELETE FROM [student] WHERE [sid] = @sid" InsertCommand="INSERT INTO [student] ([sid], [name], [address], [age]) VALUES (@sid, @name, @address, @age)" SelectCommand="SELECT * FROM [student]" UpdateCommand="UPDATE [student] SET [name] = @name, [address] = @address, [age] = @age WHERE [sid] = @sid">
                <DeleteParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="sid" Type="Int32" />
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="address" Type="String" />
                    <asp:Parameter Name="age" Type="Int32" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="name" Type="String" />
                    <asp:Parameter Name="address" Type="String" />
                    <asp:Parameter Name="age" Type="Int32" />
                    <asp:Parameter Name="sid" Type="Int32" />
                </UpdateParameters>
            </asp:SqlDataSource>

        </div>
    </form>
</body>
</html>
