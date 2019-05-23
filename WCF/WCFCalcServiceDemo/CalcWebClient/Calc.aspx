<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calc.aspx.cs" Inherits="CalcWebClient.Calc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 70%;
            border-style: solid;
            border-width: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td>
                        <asp:Label ID="LblFirstNo" runat="server" Text="First No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblSecondNo" runat="server" Text="Second No"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtSecondNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="LblResult" runat="server" Text="Result"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtResult" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="BtnSum" runat="server" OnClick="BtnSum_Click" Text="Sum" Width="56px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnSub" runat="server" OnClick="BtnSub_Click" Text="Sub" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="BtnMult" runat="server" OnClick="BtnMult_Click" Text="Mult" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
