<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CuentaPaciente.aspx.cs" Inherits="AmiNew.CuentaPaciente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Paciente</title>
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
                width: 137px;
            }
            .auto-style2 {
                width: 609px;
            }
       </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1">Nombre de Usuario:</td>
                <td>
                    <asp:TextBox ID="Usuario" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1">Contraseña:</td>
                <td>
                    <asp:TextBox ID="Contrasena" runat="server" TextMode="Password"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2"></td>
                <td class="auto-style1">&nbsp;</td>
                <td>
                    <asp:Button ID="Enter" runat="server" Text="Enter" OnClick="Enter_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <h1>AMI te da la Bienvenida</h1>
        <h1>Usuario Paciente</h1>
    </form>
</body>
</html>
