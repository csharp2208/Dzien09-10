<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditVisit.aspx.cs" Inherits="EDoctor.EditVisit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Zmiana status</h3>
    <table class="table">
        <tr>
            <td>Zmiana stanu</td>
            <td>
                <asp:DropDownList ID="ddStatus" runat="server">
                    <asp:ListItem Value="0">NOWA</asp:ListItem>
                    <asp:ListItem Value="1">POTWIERDZONA</asp:ListItem>
                    <asp:ListItem Value="-1">ANULOWANA</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <asp:HiddenField ID="tbHiddenId" runat="server" />
            <td>
                <asp:Button ID="btnOK" runat="server" Text="Zmień status" OnClick="btnOK_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
