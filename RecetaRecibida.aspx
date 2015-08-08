<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RecetaRecibida.aspx.cs" Inherits="AmiNew.RecetaRecibida" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
        <div>Paciente
            <asp:Label ID="LabelPacienteUsuario" runat="server"></asp:Label>
        </div>
        <div>
    
            Seleccione un médico
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
    
            <asp:Label ID="LabelUsuarioDoctor" runat="server"></asp:Label>
    
        </div>
        <div>
    
            Cantidad de recetas&nbsp;
            <asp:Label ID="LabelCantidadRecetas" runat="server"></asp:Label>
    
        </div>
        <div>
    
            Selecione el numero de receta&nbsp;
            &nbsp;<asp:TextBox ID="TextBoxReceta" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="ButtonBuscar" runat="server" OnClick="ButtonBuscar_Click" Text="Busqueda" />
    
        </div>
        <div>
    
        </div>
        <table style="width:100%;">           
           <tr>
                <td class="auto-style1">
                <asp:Label ID="LabelMedicina" runat="server">Medicamento</asp:Label>
                </td>
               <td class="auto-style2">
                <asp:Label ID="LabelTiempo" runat="server">Tiempo para ingerir</asp:Label>
                </td>
               <td class="auto-style3">
                <asp:Label ID="LabelRepeticion" runat="server">Cantidad de dosificación</asp:Label>
                </td>
           </tr>
            <tr>
                <td class="auto-style1">
                <asp:Label ID="LabelMed1" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                <asp:Label ID="LabelTime1" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                <asp:Label ID="LabelCic1" runat="server"></asp:Label>
                </td>
           </tr>
            <tr>
                <td class="auto-style1">
                <asp:Label ID="LabelMed2" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                <asp:Label ID="LabelTime2" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                <asp:Label ID="LabelCic2" runat="server"></asp:Label>
                </td>
           </tr>
            <tr>
                <td class="auto-style1">
                <asp:Label ID="LabelMed3" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                <asp:Label ID="LabelTime3" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                <asp:Label ID="LabelCic3" runat="server"></asp:Label>
                </td>
           </tr>
            <tr>
                <td class="auto-style1">
                <asp:Label ID="LabelMed4" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                <asp:Label ID="LabelTime4" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                <asp:Label ID="LabelCic4" runat="server"></asp:Label>
                </td>
           </tr>
            <tr>
                <td class="auto-style1">
                <asp:Label ID="LabelMed5" runat="server"></asp:Label>
                </td>
                <td class="auto-style2">
                <asp:Label ID="LabelTime5" runat="server"></asp:Label>
                </td>
                <td class="auto-style3">
                <asp:Label ID="LabelCic5" runat="server"></asp:Label>
                </td>
           </tr>

        </table>
        <div>
            <asp:Label ID="LabelInicio" runat="server"></asp:Label>
        &nbsp; Elaborado por el Dr&nbsp;
            <asp:Label ID="LabelDoctorNombre" runat="server"></asp:Label>
&nbsp;<asp:Label ID="LabelDoctorApellido" runat="server"></asp:Label>
&nbsp;cuya profesión es
            <asp:Label ID="LabelProfesion" runat="server"></asp:Label>
        </div>
        <div>
            Nota de la receta:<asp:Label ID="LabelNota" runat="server"></asp:Label>
        </div>
        <div>
            <asp:Button ID="ButtonVolver" runat="server" OnClick="ButtonVolver_Click" Text="Volver" />
        </div>
    </form>
</body>
</html>
