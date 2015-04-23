<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assignment2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Show Selection</title>
    <link rel="stylesheet" type="text/css" href="StyleSheet.css" />
    
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
       <h2><em>Assignment 2</em> Artist and Show Selection</h2>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>

    <!-- beginning footer -->

    <div id="footer">
    <ul>
        <li>Copyright, &copy</li>
        <li>Rights Reserved</li>
        <li><a href="http://edison.seattlecentral.edu/~bzimme02/index.html">Brandon Designs</a></li>
    </ul>
        </div> 

    <!-- end footer -->

</body>
</html>
