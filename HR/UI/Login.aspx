<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HR.Login" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <title>Login - ERP System</title>
    <link href="<%= ResolveUrl("~/Content/HRSite.css") %>" rel="stylesheet" />

</head>


<body class="login-page">

    <form id="form1" runat="server">

        <div class="login-container">
            <h2 class="login-title">ERP SYSTEM LOGIN</h2>

            <div class="login-card">
                <asp:Label ID="lblMsg" runat="server" Text="" CssClass="login-error"></asp:Label>

                <asp:TextBox ID="txtUserName" runat="server" CssClass="login-input" placeholder="Username"></asp:TextBox>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="login-input" TextMode="Password" placeholder="Password"></asp:TextBox>

                <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="login-btn" OnClick="btnLogin_Click" />
            </div>
        </div>

    </form>
</body>
</html>
