<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="LeaveApplication.aspx.cs" Inherits="HR.UI.LeaveApplication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 60%;">
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label4" runat="server" Text="Leave Request ID : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtLeaveRequestID" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblLeaveRequestID" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label1" runat="server" Text="Employee ID : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblEmployeeID" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label2" runat="server" Text="Leave Type :  "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtLeaveType" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblLeaveType" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label3" runat="server" Text="Leave Date"></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtLeaveDate" runat="server"></asp:TextBox>
        </td>
        <td style="width: 368px">
            <asp:Label ID="lblLeaveDate" runat="server"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="width: 191px">&nbsp;</td>
        <td style="width: 274px">&nbsp;</td>
        <td style="width: 368px">&nbsp;</td>
    </tr>
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
            <asp:GridView ID="grdLeaveApplication" runat="server" Width="100%">
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
        <td style="width: 156px">
            <asp:Button ID="Button5" runat="server" OnClick="btnHome_Click" Text="Home" />
        </td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
