<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterVisit2.aspx.cs" Inherits="EDoctor.RegisterVisit2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h3>Nowa wizyta - info o chorobie</h3>
    <table class="table">
        <tr>
            <td>Opis</td>
            <td>
                <asp:TextBox ID="tbDescr" runat="server" Rows="10" TextMode="MultiLine" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Plik (png)</td>
            <td>
                <asp:FileUpload ID="fuImage" runat="server" Width="300px" />  
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Zapisz mnie" OnClick="Button1_Click" />
            </td>
        </tr>

    </table>
</asp:Content>
