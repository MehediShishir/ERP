<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="EmployeeInformation.aspx.cs" Inherits="HR.UI.EmployeeInformation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
    <tr>
        <td style="width: 156px">
            <asp:Label ID="Label1" runat="server" Text="Employee Name : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtEmployeeName" runat="server" style="margin-left: 0px"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">
            <asp:Label ID="Label2" runat="server" Text="Mobile Number : "></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="txtMobileNumber" runat="server"></asp:TextBox>
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
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
<div _designerregion="0">
</div>
</asp:Content>
