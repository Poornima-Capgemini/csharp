<%@ Page Title="" Language="C#" MasterPageFile="~/BMS.Master" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="EmsWebApp.DeleteBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table align="center" cellpadding="5" cellspacing="5" style="width: 70%; background-color: #FFFFFF">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label3" runat="server" Text="Delete Book Details"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblBookID" runat="server" Text="Book ID"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtBookID" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <asp:Button ID="BtnDeleteBook" runat="server" OnClick="BtnDeleteBook_Click" Text="Delete Book" />
            </td>
        </tr>
    </table>
</asp:Content>
