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
            <asp:Button ID="Button1" runat="server" OnClick="btnShow_Click" Text="Show" />
            <asp:Button ID="Button2" runat="server" OnClick="btnSave_Click" Text="Save" />
            <asp:Button ID="Button3" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            <asp:Button ID="Button4" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        </td>
        <td style="width: 368px">&nbsp;</td>
    </tr>
    <tr>
        <td style="width: 191px">&nbsp;</td>
        <td style="width: 274px">
            &nbsp;</td>
        <td style="width: 368px">&nbsp;</td>
    </tr>
    <tr>
        <td colspan="3">
            <asp:GridView ID="grdDesignation" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </td>
    </tr>
</table>
</asp:Content>
