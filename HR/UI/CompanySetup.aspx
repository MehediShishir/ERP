<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CompanySetup.aspx.cs" Inherits="HR.UI.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 165px;
        }
        .auto-style2 {
            width: 170px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table style="width: 100%;">
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server" Text="Comapny Name : "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyName" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label2" runat="server" Text="Addess : "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCompanyAddress" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyAddress" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label3" runat="server" Text="Phone Number : "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCompanyPhoneNumber" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyPhoneNumber" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label4" runat="server" Text="Email : "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCompanyEmail" runat="server"></asp:TextBox>
                    </td>
                <td>
                    <asp:Label ID="lblCompanyEmail" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Label ID="Label5" runat="server" Text="Type : "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtCompanyType" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="lblCompanyType" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Button ID="btnShow" runat="server" Text="Show" OnClick="btnShow_click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                
            </table>
        </div>
    </form>
</body>
</html>
