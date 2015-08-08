<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PacientesAgregados.aspx.cs" Inherits="AmiNew.PacientesAgregados" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de pacientes</title>
    <style type="text/css">
            table {
                color:white;
            }
            body {
                background-image:url("images/BackGround07.jpg")
            }
            h1 {
                text-align:center;
                color:white;
            }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
        <table style="width:100%;">
            <tr>
                <td>Datos de sus pacientes</td>
                <td>
                    <asp:Label ID="LabelUsuDoc" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>ID USUARIO</td>
                <td>NOMBRE</td>
                <td>APELLIDO</td>
                <td>TELEFONO</td>
                <td>TIPO DE SANGRE</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel1" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel2" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan2" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick3" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre3" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido3" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel3" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan3" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick4" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre4" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido4" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel4" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan4" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel5" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan5" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick6" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre6" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido6" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel6" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan6" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick7" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre7" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido7" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel7" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan7" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick8" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre8" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido8" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel8" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan8" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick9" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre9" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido9" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel9" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan9" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="LabelNick10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelNombre10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelApellido10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelTel10" runat="server"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="LabelSan10" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        
    </div>
    </form>
</body>
</html>
