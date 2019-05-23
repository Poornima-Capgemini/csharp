<%@ Page Title="" Language="C#" MasterPageFile="~/EmpCrud.Master" AutoEventWireup="true" CodeBehind="UpdateEmploy.aspx.cs" Inherits="EmpClientDemo.UpdateEmploy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="6" cellspacing="6" style="width: 70%; border-style: solid; border-width: 3px">
    <tr>
        <td style="width: 73px">
            <asp:Label ID="LblEmpNo" runat="server" Text="Emp No"></asp:Label>
        </td>
        <td style="width: 148px">
            <asp:TextBox ID="txtEmpNo" runat="server" AutoPostBack="True" OnTextChanged="txtEmpNo_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 73px">
            <asp:Label ID="LblEmployName" runat="server" Text="Employ Name"></asp:Label>
        </td>
        <td style="width: 148px">
            <asp:TextBox ID="txtEmployName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 73px">
            <asp:Label ID="LblDepartment" runat="server" Text="Department"></asp:Label>
        </td>
        <td style="width: 148px">
            <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 73px">
            <asp:Label ID="LblDesignation" runat="server" Text="Designation"></asp:Label>
        </td>
        <td style="width: 148px">
            <asp:TextBox ID="txtDesignation" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 73px">
            <asp:Label ID="LblBasic" runat="server" Text="Basic"></asp:Label>
        </td>
        <td style="width: 148px">
            <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" />
        </td>
    </tr>
</table>
</asp:Content>
