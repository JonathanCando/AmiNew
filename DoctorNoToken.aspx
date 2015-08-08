<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorNoToken.aspx.cs" Inherits="AmiNew.DoctorNoToken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
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
    <div>    
    </div>

        <div>
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style4">
                        Bienvenido&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">
                        En estos momentos su plataforma no esta activada, solicite una tarjeta de seguridad para activar su plataforma</td>
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
                    <asp:Button ID="SalirNew" runat="server" OnClick="SalirNew_Click" Text="Salir" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        &nbsp;</td>
                    <td class="auto-style1">                       
                        &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">
                &nbsp;</td>
                </tr>
                <tr>
                <td class="auto-style5">
                &nbsp;</td>
                </tr>

                <tr>
                <td class="auto-style5">
                    &nbsp;</td>
                </tr>

             </table>
            </div>

    </form>
</body>
</html>
