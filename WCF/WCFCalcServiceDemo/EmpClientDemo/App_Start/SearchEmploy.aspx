<%@ Page Title="" Language="C#" MasterPageFile="~/EmpCrud.Master" AutoEventWireup="true" CodeBehind="SearchEmploy.aspx.cs" Inherits="EmpClientDemo.App_Start.SearchEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="5" cellspacing="5" style="width: 107%; margin-left: 0px">
        <tr>
            <td>
                <asp:Label ID="LblEmployNo" runat="server" Text="EmployNo"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployNo" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblEmployName" runat="server" Text="EmployName"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtEmployName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblDepartment" runat="server" Text="Department"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblDesignation" runat="server" Text="Designation"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="LblBasic" runat="server" Text="Basic"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="BtnSearch" runat="server" OnClick="BtnSearch_Click" Text="Search" />
            </td>
        </tr>
    </table>
</asp:Content>
