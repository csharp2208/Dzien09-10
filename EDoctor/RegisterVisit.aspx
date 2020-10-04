<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterVisit.aspx.cs" Inherits="EDoctor.RegisterVisit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Nowa wizyta</h3>

    <table class="table">
        <tr>
            <td>Imię</td>
            <td>
                <asp:TextBox ID="tbFName" Width="300px" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" 
                    runat="server" ControlToValidate="tbFName" 
                    Display="Dynamic"
                    ErrorMessage="Podaj imię" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>Nazwisko</td>
            <td>
                <asp:TextBox ID="tbLName"  Width="300px" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" 
                    runat="server" ControlToValidate="tbLName" 
                    Display="Dynamic"
                    ErrorMessage="Podaj nazwisko" ForeColor="Red">*</asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>PESEL</td>
            <td>
                <asp:TextBox ID="tbPESEL" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" 
                    runat="server" ControlToValidate="tbPESEL" 
                    Display="Dynamic"
                    ErrorMessage="Podaj PESEL" ForeColor="Red">*</asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>E-mail</td>
            <td>
                <asp:TextBox ID="tbEmail"  Width="300px" runat="server"></asp:TextBox>
                
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" 
                    runat="server" ControlToValidate="tbEmail" 
                    Display="Dynamic"
                    ForeColor="Red" ErrorMessage="Podaj adres e-mail" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
          
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" 
                    runat="server" ControlToValidate="tbEmail" 
                    Display="Dynamic"
                    ErrorMessage="Podaj adres e-mail" ForeColor="Red">*</asp:RequiredFieldValidator>

            </td>
        </tr>
        <tr>
            <td>Lekarz</td>
            <td>
                <asp:DropDownList ID="ddDoctor" runat="server">
                    <asp:ListItem Value="-1">-</asp:ListItem>
                    <asp:ListItem Value="1">Jan Kowalski - pediatra</asp:ListItem>
                    <asp:ListItem Value="2">Janina Ziętek - dermatolog</asp:ListItem>
                    <asp:ListItem Value="3">Mirosław Nowak - kardiolog</asp:ListItem>
                </asp:DropDownList>
                <asp:RangeValidator ID="RangeValidator1" 
                    ForeColor="Red" Display="Dynamic"
                    runat="server" ControlToValidate="ddDoctor"
                    Type="Integer" MinimumValue="1" MaximumValue="999999"
                    ErrorMessage="Wybierz lekarza">*</asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>Data wizyty</td>
            <td>
                <asp:Calendar ID="calVisitDate" runat="server" Height="200px" Width="300px"></asp:Calendar>
            </td>
        </tr>
        <tr>
            <td>Klient VIP</td>
            <td>
                <asp:CheckBox ID="cbVIP" runat="server" AutoPostBack="True" OnCheckedChanged="cbVIP_CheckedChanged" />
                <br/>
                <asp:TextBox ID="tbVIPNumber" Visible="false" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:ValidationSummary ForeColor="Red" ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Dalej" />
            </td>
        </tr>


    </table>
</asp:Content>
