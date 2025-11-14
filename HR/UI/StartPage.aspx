<%@ Page Title="" Language="C#" MasterPageFile="~/HRSite.Master" AutoEventWireup="true" CodeBehind="StartPage.aspx.cs" Inherits="HR.UI.StartPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

    <div style="padding: 40px; text-align:center;">

        <asp:Button ID="btnAttendance" runat="server" Text="Attendance"
            CssClass="menuBtn" OnClick="btnAttendance_Click" />

        <asp:Button ID="btnDepartmentSetup" runat="server" Text="Department Setup"
            CssClass="menuBtn" OnClick="btnDepartmentSetup_Click" />

        <asp:Button ID="btnDesignation" runat="server" Text="Designation"
            CssClass="menuBtn" OnClick="btnDesignation_Click" />

        <asp:Button ID="btnEmployeeInformation" runat="server" Text="Employee Information"
            CssClass="menuBtn" OnClick="btnEmployeeInformation_Click" />

        <asp:Button ID="btnLeaveApplication" runat="server" Text="Leave Application"
            CssClass="menuBtn" OnClick="btnLeaveApplication_Click" />

    </div>

    <style>
        .menuBtn {
            margin: 10px;
            padding: 15px 30px;
            font-size: 18px;
            border-radius: 6px;
        }
    </style>

</asp:Content>
