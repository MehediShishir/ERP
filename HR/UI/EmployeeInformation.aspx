<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="EmployeeInformation.aspx.cs" Inherits="HR.UI.EmployeeInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td style="width: 156px">
            <asp:Label ID="Label1" runat="server" Text="Employee Name : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmployeeName" runat="server" style="margin-left: 0px"></asp:TextBox>
            <asp:Label ID="lblEmployeeName" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">
            <asp:Label ID="Label3" runat="server" Text="Email : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            <asp:Label ID="lblEmail" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">
            <asp:Label ID="Label2" runat="server" Text="Mobile Number : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
            <asp:Label ID="lblMobileNumber" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">&nbsp;</td>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show" />
            <asp:Button ID="Button2" runat="server" Text="Save" />
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
