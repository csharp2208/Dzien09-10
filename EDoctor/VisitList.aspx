<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="VisitList.aspx.cs" Inherits="EDoctor.VisitList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Lista wizyt</h3>
    <asp:GridView ID="gridView" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="sqllDataSource" ForeColor="#333333" GridLines="None" OnRowDataBound="gridView_RowDataBound" Width="90%" OnRowCommand="gridView_RowCommand">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="fname" HeaderText="Imię" SortExpression="fname" />
            <asp:BoundField DataField="lname" HeaderText="Nazwisko" SortExpression="lname" />
            <asp:BoundField DataField="pesel" HeaderText="PESEL" SortExpression="pesel" />
            <asp:TemplateField HeaderText="Email" SortExpression="email">
                <ItemTemplate>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# Eval("email", "mailto:{0}") %>' Text='<%# Eval("email") %>'></asp:HyperLink>
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Lekarz" SortExpression="doctor">
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# GetDoctor(Convert.ToInt32(Eval("doctor"))) %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            
            <asp:BoundField DataField="card" HeaderText="Nr karty" SortExpression="card" />

            <asp:BoundField DataField="visit_date" HeaderText="Termin" SortExpression="visit_date" DataFormatString="{0:yyyy-MM-dd}" />
            <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
            <asp:BoundField DataField="descr" HeaderText="descr" SortExpression="descr" Visible="False" />
            <asp:BoundField DataField="image" HeaderText="image" SortExpression="image" Visible="False" />
            
            <asp:ImageField HeaderText="Grafika" DataImageUrlField="image" 
                DataImageUrlFormatString="~/uploads/{0}" NullDisplayText="BRAK">
                <ControlStyle Width="150px" />
            </asp:ImageField>

            <asp:TemplateField HeaderText="Usuwanie">
                <ItemTemplate>
                    <asp:Button OnClientClick="return confirm('Czy na pewno usunąć?');"
                        CommandName="DeleteRow"
                        CommandArgument='<%# Eval("id") %>'
                        ID="Button1" runat="server" Text="Usuń" />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:HyperLinkField HeaderText="" Text="Edycja" 
                DataNavigateUrlFormatString="~/EditVisit?id={0}"
                DataNavigateUrlFields="id" />

        </Columns>
        <EditRowStyle BackColor="#999999" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <asp:SqlDataSource ID="sqllDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:edoctorConnectionString %>" ProviderName="<%$ ConnectionStrings:edoctorConnectionString.ProviderName %>" SelectCommand="SELECT * FROM visits ORDER BY id desc"></asp:SqlDataSource>
</asp:Content>
