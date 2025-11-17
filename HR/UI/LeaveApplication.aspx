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
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label1" runat="server" Text="Employee ID : "></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label2" runat="server" Text="Leave Type :"></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtLeaveType" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label3" runat="server" Text="Leave Date :"></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtLeaveDate" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="btnShow_Click" Text="Show" />
                <asp:Button ID="Button2" runat="server" OnClick="btnSave_Click" Text="Save" />
                <asp:Button ID="Button3" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                <asp:Button ID="Button4" runat="server" OnClick="btnDelete_Click" Text="Delete" Visible="false" />
            </td>
        </tr>

        <tr>
            <td colspan="3">
                <asp:GridView ID="grdLeaveApplication" runat="server" Width="100%"
                    AutoGenerateColumns="False"
                    OnRowCommand="grdLeaveApplication_RowCommand"
                    OnRowDeleting="grdLeaveApplication_RowDeleting">

                    <Columns>
                        <asp:TemplateField HeaderText="Request ID">
                            <ItemTemplate>
                                <asp:Label ID="lblLeaveRequestID" runat="server" Text='<%# Eval("Leave_Request_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Employee ID">
                            <ItemTemplate>
                                <asp:Label ID="lblEmployeeID" runat="server" Text='<%# Eval("Employee_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Leave Type">
                            <ItemTemplate>
                                <asp:Label ID="lblLeaveType" runat="server" Text='<%# Eval("Leave_Type") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Leave Date">
                            <ItemTemplate>
                                <asp:Label ID="lblLeaveDate" runat="server" Text='<%# Eval("Leave_Date") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:CommandField ShowSelectButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
                    </Columns>

                </asp:GridView>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="Button5" runat="server" OnClick="btnHome_Click" Text="Home" />
            </td>
        </tr>
    </table>
</asp:Content>
