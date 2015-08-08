<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CuentaDoctor.aspx.cs" Inherits="AmiNew.CuentaDoctor" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head id="Head1" runat="server"> 
        <title>Login Doctor</title> 
        <style type="text/css">
            table {
                color:blue;
            }
            body {
                background-image:url("images/BackGround02.jpg")
            }
            .auto-style1 {
                width: 134px;
            }
            .auto-style2 {
                width: 141px;
            }
            .auto-style3 {
                width: 522px;
            }
            h1 {
                text-align:center;
                color:blue;
            }
        </style>
    </head> 

<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:104%;">
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Nombre de Usuario</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">Contraseña:</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Contrasena" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Button ID="Enter" runat="server" Text="Enter" OnClick="Enter_Click" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
        </table>   
    </div>
        <h1>AMI te da la Bienvenida</h1>
        <h1>Usuario Doctor</h1>
    </form>
</body>
</html>
