<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IdPage.aspx.cs" Inherits="ConvertPostTitleIntoUrlLab.IdPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>URL Rewrite Demo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="text-align: center;">
        <h1>
            URL Rewrite Demo</h1>
    </div>
     
 
    <div style="width:700px;">
    <table style="width: 100%;">
       <tr>
       <td style="width:100px;"><b>Title :</b></td>
       <td style="width:500px;"><div id="divtitle" runat="server"></div></td>
       </tr>
       <tr>
       <td colspan="2">
        <div id="divmsg" runat="server" style="width:500px; height:auto; padding:10px;"></div>
       </td>
       </tr>
    </table>
    </div>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
        </asp:CheckBoxList>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>