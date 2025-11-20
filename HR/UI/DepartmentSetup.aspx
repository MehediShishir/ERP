<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="DepartmentSetup.aspx.cs" Inherits="HR.UI.DepartmentSetup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table style="width: 60%;">

    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label1" runat="server" Text="Department ID : " Visible ="false"></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDepartmentID" runat="server" Visible ="false"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label2" runat="server" Text="Department Name : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDepartmentName" runat="server"></asp:TextBox>
        </td>
    </tr>

    <tr>
        <td style="width: 191px">
            <asp:Label ID="Label3" runat="server" Text="Description : "></asp:Label>
        </td>
        <td style="width: 274px">
            <asp:TextBox ID="txtDescription" runat="server"></asp:TextBox>
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
        <td colspan="2">
            <asp:GridView ID="grdDepartment" runat="server" Width="100%" AutoGenerateColumns="False"
                OnRowCommand="grdDepartment_RowCommand"
                OnRowDeleting="grdDepartment_RowDeleting">

                <Columns>

                    <asp:TemplateField HeaderText="Dept ID" Visible ="false">
                        <ItemTemplate>
                            <asp:Label ID="lblDeptID" runat="server" Text='<%# Eval("Department_ID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:Label ID="lblDeptName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
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
            <asp:Button ID="Button5" runat="server" Text="Home" OnClick="btnHome_Click" />
        </td>
    </tr>

</table>

</asp:Content>
