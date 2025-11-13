<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="DepartmentSetup.aspx.cs" Inherits="HR.UI.DepartmentSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 60%;">
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label1" runat="server" Text="Department ID : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDepartmentID" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblDepartmentID" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label2" runat="server" Text="Department Name : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblDepartmentName" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label3" runat="server" Text="Description : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblDescription" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">&nbsp;</td>
        <td style="width: 274px">&nbsp;</td>
        <td style="width: 368px">&nbsp;</td>
    </tr>

    <tr>
    <td style="width: 156px">&nbsp;</td>
    <td>
        <asp:Button ID="Button1" runat="server" OnClick="btnShow_Click" Text="Show" />
        <asp:Button ID="Button2" runat="server" Text="Save" OnClick="btnSave_Click" />
        <asp:Button ID="Button3" runat="server" OnClick="btnUpdate_Click" Text="Update" />
        <asp:Button ID="Button4" runat="server" OnClick="btnDelete_Click" Text="Delete" />
    </td>
    <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="grdDepartment" runat="server" Width="100%">
            </asp:GridView>
        </td>
    </tr>
    <tr>
        <td style="width: 156px">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 156px">&nbsp;</td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
