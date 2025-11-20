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
            <td></td>
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label2" runat="server" Text="Designation Title : "></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtDesignationTitle" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>

        <tr>
            <td style="width: 191px">
                <asp:Label ID="Label3" runat="server" Text="Short Code : "></asp:Label>
            </td>
            <td style="width: 274px">
                <asp:TextBox ID="txtShortCode" runat="server"></asp:TextBox>
            </td>
            <td></td>
        </tr>

        <tr>
            <td></td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="btnShow_Click" Text="Show" />
                <asp:Button ID="Button2" runat="server" OnClick="btnSave_Click" Text="Save" />
                <asp:Button ID="Button3" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                <asp:Button ID="Button4" runat="server" OnClick="btnDelete_Click" Text="Delete" Visible="false"/>
            </td>
            <td></td>
        </tr>

        <tr>
            <td colspan="3">
                <asp:GridView 
                    ID="grdDesignation" 
                    runat="server" 
                    Width="100%" 
                    AutoGenerateColumns="False"
                    OnRowCommand="grdDesignation_RowCommand"
                    OnRowDeleting="grdDesignation_RowDeleting">

                    <Columns>
                        <asp:TemplateField HeaderText="ID" Visible ="false">
                            <ItemTemplate>
                                <asp:Label ID="lblDesignationID" runat="server" Text='<%# Eval("Designation_ID") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Title">
                            <ItemTemplate>
                                <asp:Label ID="lblDesignationTitle" runat="server" Text='<%# Eval("Title") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="Short Code">
                            <ItemTemplate>
                                <asp:Label ID="lblShortCode" runat="server" Text='<%# Eval("Short_Code") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:CommandField ShowSelectButton="True"/>
                        <asp:CommandField ShowDeleteButton="True"/>
                    </Columns>

                </asp:GridView>
            </td>
        </tr>

        <tr>
            <td colspan="3">
                <asp:Button ID="Button5" runat="server" OnClick="btnHome_Click" Text="Home" />
            </td>
        </tr>
    </table>
</asp:Content>
