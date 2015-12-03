<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConvertPostTitleIntoUrlLab.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>URL Rewrite Demo</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center;">
            <h1>URL Rewrite Demo</h1>
        </div>


        <div style="text-align: center;">
            <table>
                <tr>
                    <td>Title :</td>
                    <td>&nbsp;<asp:TextBox ID="txt_title" runat="server" Width="382px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Message :
                    </td>
                    <td>&nbsp;<asp:TextBox ID="txt_msg" runat="server" Height="175px" Width="382px"
                        TextMode="MultiLine"></asp:TextBox></td>
                </tr>

                <tr>
                    <td>
                        <asp:Button ID="Btn_submit" runat="server" Text="Submit"
                            OnClick="Btn_submit_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
