<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Przykładowe komponenty</h1>
        </div>
        <div>
            <asp:Label ID="lblText" runat="server" Font-Size="XX-Large"
                Text="Kontrolka z ASP.NET" ForeColor="#0000ff"></asp:Label>
        </div>
        <div>
            <p>Parametry request'a</p>
            <asp:Label ID="lblRequest" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
