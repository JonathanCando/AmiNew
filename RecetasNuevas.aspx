<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecetasNuevas.aspx.cs" Inherits="AmiNew.RecetasNuevas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

            table {
                color:blue;
            }
            body {
                background-image:url("images/BackGround11.png")
            }
            h1 {
                text-align:center;
                color:blue;
            }

        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 630px;
        }
        .auto-style4 {
            width: 628px;
        }
        .auto-style5 {
            width: 628px;
            height: 23px;
        }
        .auto-style6 {
            width: 263px;
        }
        </style>

   <!-- <script Language="JavaScript">    -->
     <script type ="text/javascript">   
        var timerID = null;
        var timerRunning = false;
        function stopclock() {
            if (timerRunning)
                clearTimeout(timerID);
            timerRunning = false;
        }
        function showtime() {
            var now = new Date();
            var hours = now.getHours();
            var minutes = now.getMinutes();
            var seconds = now.getSeconds();
            var timeValue = "" + ((hours > 12) ? hours - 12 : hours)

            if (timeValue == "0") timeValue = 12;
            timeValue += ((minutes < 10) ? ":0" : ":") + minutes
            timeValue += ((seconds < 10) ? ":0" : ":") + seconds
            timeValue += (hours >= 12) ? " P.M." : " A.M."
            document.getElementById('Label1').innerText = timeValue;

            timerID = setTimeout("showtime()", 1000);
            timerRunning = true;
        }
        function startclock() {
            stopclock();
            showtime();
        }
</script>

</head>
 <body onload="startclock()">
    <form id="form1" runat="server">
    <div>
      
        <table style="width:100%;">
            <tr>
                <td>Dr.<asp:Label ID="LabelIDDoctor" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="LabelNombre" runat="server"></asp:Label>
&nbsp;<asp:Label ID="LabelApellido" runat="server"></asp:Label>
&nbsp;&nbsp;
                    <asp:Label ID="LabelPrefecion" runat="server"></asp:Label>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            </table>
    
    </div>
        <div>

            <table style="width:100%;">
                <tr>
                    <td>Seleccione un paciente&nbsp;&nbsp;&nbsp;
                        <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style6">
                        <!-- **************   -->
                        <asp:Label ID="Label12" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>Medicamento</td>
                    <td class="auto-style6">¿Cada cuánto tiempo en horas? </td>
                    <td>¿Cuantos ciclos?</td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextMed1" runat="server"></asp:TextBox>
                    </td>

                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <asp:Label ID="Label13" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <asp:Label ID="Label18" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextMed2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <asp:Label ID="Label14" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        <asp:Label ID="Label19" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextMed3" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                        <asp:Label ID="Label15" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
                        <asp:Label ID="Label20" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextMed4" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
                        <asp:Label ID="Label16" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                        <asp:Label ID="Label21" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:TextBox ID="TextMed5" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style6">
                        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <asp:Label ID="Label17" runat="server"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
                        <asp:Label ID="Label22" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>

        </div>
        <div>

            <table style="width:100%;">
                <tr>
                    <td class="auto-style4">Nota</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:TextBox ID="TextBox1" runat="server" Width="600px"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        <asp:Button ID="BotonEnviar" runat="server" Text="Enviar" OnClick="BotonEnviar_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="LabelRevisarPaciente" runat="server" style="color: red"></asp:Label>
&nbsp;&nbsp;
                        
                        </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="BotonVolver" runat="server" Text="Volver" OnClick="BotonVolver_Click" />
                    </td>
                    <td class="auto-style1"></td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
