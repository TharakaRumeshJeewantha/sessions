<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mainpage.aspx.cs" Inherits="SSD.mainpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <br />
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="Red" Text="COOKIES &amp; SESSIONS"></asp:Label>
        <br />
        <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="HOME"></asp:Label>
        <br />
        <br />
        <hr />
        <br />
        <br />
    welcome&nbsp;&nbsp;&nbsp;&nbsp; :&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Delete Cookie" />
        &nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Log out" />
    </div>
    </form>
</body>
</html>
