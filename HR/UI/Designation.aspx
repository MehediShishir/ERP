<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="Designation.aspx.cs" Inherits="HR.UI.Designation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table style="width: 60%;">
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label1" runat="server" Text="Designation ID : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDesignationID" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblDesignationID" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label2" runat="server" Text="Designation Title : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDesignationTitle" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblDesignationTitle" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label3" runat="server" Text="Short Code"></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtShortCode" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblShortCode" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">&nbsp;</td>
        <td style="width: 274px">&nbsp;</td>
        <td style="width: 368px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 191px">&nbsp;</td>
        <td style="width: 274px">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
        </td>
        <td style="width: 368px">&nbsp;</td>
    </tr>
</table>
</asp:Content>
