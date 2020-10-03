<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplicationExample.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:BulletedList ID="BulletedList1" runat="server">
                <asp:ListItem>Opcja A</asp:ListItem>
                <asp:ListItem>Opcja B</asp:ListItem>
                <asp:ListItem>Opcja C</asp:ListItem>
            </asp:BulletedList>
        </div>
        <div>
            <asp:CheckBox Checked="true" Font-Bold="true" Text="Stawka 23%" ID="CheckBox1" runat="server" />
        </div>
        <div>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" RepeatColumns="2" RepeatDirection="Horizontal" TextAlign="Left">
                <asp:ListItem Value="A">Opcja A</asp:ListItem>
                <asp:ListItem Selected="True" Value="B">Opcja B</asp:ListItem>
                <asp:ListItem Value="C">Opcja C</asp:ListItem>
                <asp:ListItem Selected="True" Value="D">Opcja D</asp:ListItem>
            </asp:CheckBoxList>
        </div>
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Value="RED">Czerwony</asp:ListItem>
                <asp:ListItem Value="GREEN">Zielony</asp:ListItem>
                <asp:ListItem Value="BLUE">Niebieski</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            <!--
            <img src="Content/kotek.jpg" width="200" />
            -->
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Content/kotek.jpg" Width="200px" />
        </div>
        <div>
            <asp:ListBox ID="ListBox1" runat="server" Rows="10">
                <asp:ListItem Value="0">Stawka 0%</asp:ListItem>
                <asp:ListItem Value="8">Stawka 8%</asp:ListItem>
                <asp:ListItem Selected="True" Value="23">Stawka 23%</asp:ListItem>
            </asp:ListBox>
        </div>
        <div>
            <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                <asp:ListItem Value="ad">Andrzej Duda</asp:ListItem>
                <asp:ListItem Value="rt">Rafał Trzaskowski</asp:ListItem>
                <asp:ListItem Value="rb">Robert Biedroń</asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="lblResult" Font-Size="X-Large" runat="server" Text="ABCDE"></asp:Label>
        </div>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Pokaż dane" />
        </div>
    </form>
</body>
</html>
