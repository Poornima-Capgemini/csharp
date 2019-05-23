<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchEmploy.aspx.cs" Inherits="ClientAPI_EmployDEMO.SearchEmploy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
     <script src="Scripts/jquery-3.3.1.js"></script>
    <script>
        function searchBook()
        {
            $.getJSON("http://localhost:64942/api/Emps/" 
                + $("#<%=txtEmpNo.ClientID%>").val(),
                function (data) {
                    
                    $("#<%=txtName.ClientID%>").val(data.nam);
                    $("#<%=txtDept.ClientID%>").val(data.dept);
                    $("#<%=txtDesig.ClientID%>").val(data.desig);
                     $("#<%=txtBasic.ClientID%>").val(data.basic)
                });

            //return false;
        }
        $(document).ready(function () {
            $("#BtnSearch").click(searchBook);
        })
    </script>

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblEmpNo" runat="server" Text="Emp No"></asp:Label>
            <br />
            <asp:TextBox ID="txtEmpNo" runat="server"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;
            <input id="BtnSearch" type="button" value="Search Employ" /><br />
            <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
            <br />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDept" runat="server" Text="Dept"></asp:Label>
            <br />
            <asp:TextBox ID="txtDept" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDesig" runat="server" Text="Desig"></asp:Label>
            <br />
            <asp:TextBox ID="txtDesig" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblBasic" runat="server" Text="Basic"></asp:Label>
            <br />
            <asp:TextBox ID="txtBasic" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
