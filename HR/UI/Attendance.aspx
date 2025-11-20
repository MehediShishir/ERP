<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="Attendance.aspx.cs" Inherits="HR.UI.Attendance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width: 60%;">
        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label1" runat="server" Text="Attendance ID : "></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtAttendanceID" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label2" runat="server" Text="Employee ID : "></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label3" runat="server" Text="Date : "></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtDate" runat="server" TextMode="Date"></asp:TextBox>
            </td>
        </tr>

        <tr><td colspan="2">&nbsp;</td></tr>

        <tr>
            <td colspan="2">
                <asp:Button ID="btnShow" runat="server" OnClick="btnShow_Click" Text="Show" />
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            </td>
        </tr>

        <tr><td colspan="2">&nbsp;</td></tr>

        <tr>
            <td colspan="2">
                <asp:GridView ID="grdAttendance" runat="server" Width="100%"
                    AutoGenerateColumns="False"
                    OnRowCommand="grdAttendance_RowCommand"
                    OnRowDeleting="grdAttendance_RowDeleting">

                    <Columns>

                        <asp:TemplateField HeaderText="Attendance ID" Visible ="false">
                            <ItemTemplate>
                                <asp:Label ID="lblAttendanceID" runat="server" Text='<%# Eval("Attendance_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Employee ID">
                            <ItemTemplate>
                                <asp:Label ID="lblEmployeeID" runat="server" Text='<%# Eval("Employee_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Date">
                            <ItemTemplate>
                                <asp:Label ID="lblDate" runat="server" Text='<%# Eval("Date", "{0:yyyy-MM-dd}") %>'></asp:Label>
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
                <asp:Button ID="btnHome" runat="server" OnClick="btnHome_Click" Text="Home" />
            </td>
        </tr>

    </table>

</asp:Content>
