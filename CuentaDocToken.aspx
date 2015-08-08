<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CuentaDocToken.aspx.cs" Inherits="AmiNew.CuentaDocToken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Token Ver</title>
            <style type="text/css">
            table {
                color:blue;
            }
            body {
                background-image:url("images/BackGround02.jpg")
            }
            h1 {
                text-align:center;
                color:blue;
            }
                .auto-style1 {
                    width: 583px;
                    text-align: right;
                }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Bienvenido usuario </td>
                <td>
                    <asp:Label ID="LabelUser" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Inserte el código con el ID</td>
                <td>
                    <asp:Label ID="LabelNumeroRan" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TextBoxCodigo" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="BotonEnter" runat="server" OnClick="BotonEnter_Click" Text="Enter" />
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
