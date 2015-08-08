<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="AmiNew.Administrador" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
                table {
                color:blue;
            }
            body {
                background-image:url('images/BackGround12.jpg');
            margin-bottom: 350px;
        }
            h1 {
                text-align:center;
                color:#FFFFFF;
            }
            .auto-style1 {
            width: 825px;
        }
            .auto-style2 {
            width: 148px;
        }
            .auto-style3 {
            width: 146px;
            height: 26px;
        }
        .auto-style4 {
            width: 825px;
            height: 26px;
        }
            .auto-style5 {
            width: 146px;
        }
            </style>
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <br />

        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style2">Datos del médico</td>
                    
                </tr>
                <tr>
                    <td class="auto-style3">
                        Usuario</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="Usuario" runat="server" Width="321px"></asp:TextBox>
                    </td>
                 </tr>
                <tr>
                    <td class="auto-style5">
                        ID de la tarjeta</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="Tarjeta_Id" runat="server" Width="321px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">                       
                        <asp:Label ID="Label2" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                <td class="auto-style5">Contraseña del administrador</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Pas" TextMode="Password" runat="server" Width="182px"></asp:TextBox>
                &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style5">
                    <asp:Button ID="Salir" runat="server" Text="Añadir" OnClick="Salir_Click" />
                &nbsp;</td>
                </tr>

                <tr>
                <td class="auto-style5">
                    <asp:Button ID="SalirNew" runat="server" OnClick="SalirNew_Click" Text="Salir" />
                    </td>
                </tr>

             </table>
            </div>
    </form>
</body>
</html>
