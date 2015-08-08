<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroDoctor.aspx.cs" Inherits="AmiNew.RegistroDoctor" %>

<!DOCTYPE html>
<!--


URL del artículo: http://www.ejemplode.com/17-html/94-ejemplo_de_comentario_en_html.html
Fuente: Ejemplo de Comentario en HTML
-->

<html>
    
    <!--     esto es para habilitar el mapa falta otra parte abajo     -->

    <!--
  <head>
    <title>Remove Markers</title>
    <style>
      html, body, #map-canvas {
        height: 100%;
        margin: 0px;
        padding: 0px
      }
      #panel {
        position: absolute;
        top: 5px;
        left: 50%;
        margin-left: -180px;
        z-index: 5;
        padding: 5px;
        border: 1px solid #999;
      }
      table {
                color:blue;
            }
            body {
                background-image:url("images/BackGround05.jpg");
            }
            h1 {
                text-align:center;
                color:blue;
            }
        .auto-style1 {
            width: 145px;
        }
    </style>
    <SCRIPT type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.js"></SCRIPT> 
          <script src="https://maps.googleapis.com/maps/api/js?v=3.exp"></script>
    <script>
        // In the following example, markers appear when the user clicks on the map.
        // The markers are stored in an array.
        // The user can then click an option to hide, show or delete the markers.
        var map;
        var markers = [];

        function initialize() {
            var haightAshbury = new google.maps.LatLng(18.461373375441447, -69.93553161621094);
            var mapOptions = {
                zoom: 12,
                center: haightAshbury,
                mapTypeId: google.maps.MapTypeId.TERRAIN
            };
            map = new google.maps.Map(document.getElementById('map-canvas'),
                mapOptions);

            // This event listener will call addMarker() when the map is clicked.
            google.maps.event.addListener(map, 'click', function (event) {
                addMarker(event.latLng);
            });

            // Adds a marker at the center of the map.
            addMarker(haightAshbury);
        }

        // Add a marker to the map and push to the array.
        function addMarker(location) {
            var marker = new google.maps.Marker({
                position: location,
                map: map
            });
            markers.push(marker);
        }

        // Sets the map on all markers in the array.
        function setAllMap(map) {
            for (var i = 0; i < markers.length; i++) {
                markers[i].setMap(map);
            }
        }

        // Removes the markers from the map, but keeps them in the array.
        function clearMarkers() {
            setAllMap(null);
        }

        // Shows any markers currently in the array.
        function showMarkers() {
            setAllMap(map);
        }

        // Deletes all markers in the array by removing references to them.
        function deleteMarkers() {
            clearMarkers();
            markers = [];
        }

        google.maps.event.addDomListener(window, 'load', initialize);

    </script>
  </head>
    

    -->
    
    <head id="Head1" runat="server"> 
<title>Registro Paciente</title> 
        <style type="text/css">
            table {
                color:blue;
            }
            body {
               background-image:url("images/BackGround05.jpg");
               background-repeat: no-repeat;
            }
            h1 {
                text-align:center;
                color:blue;
                
            }
            .auto-style1 {
                width: 156px;
            }
        </style>
</head> 



  <body>

      <!-- Tambien es parte del mapa       -->

      <!--
    <div id="panel">
      <input onclick="clearMarkers();" type=button value="Hide Markers">
      <input onclick="showMarkers();" type=button value="Show All Markers">
      <input onclick="deleteMarkers();" type=button value="Delete Markers">
    </div> 
    <div id="map-canvas"  style="width: 509px; top: 56px; left: 369px; position: absolute; height: 434px"></div>
    <p>Click on the map to add markers.</p> 

      -->


    <form id="form1" runat="server">
        <h1>Registro de Doctor</h1>
    <div>
    
        <table style="width:100%;">
            <tr>
                <td class="auto-style1">Nombre</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DNombre" runat="server"></asp:TextBox> <!--Style="text-transform:uppercase"></asp:TextBox>-->
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Apellido</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DApellido" runat="server"></asp:TextBox> <!--Style="text-transform:uppercase"></asp:TextBox>  convierte a mayucula pero no lo lee como tal-->
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Usuario</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DUsuario" runat="server"></asp:TextBox>
                    <asp:Label ID="ExisteUsuario" runat="server"></asp:Label>
                    <asp:Label ID="Label2" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Exequatur</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DExequatur" runat="server"></asp:TextBox>
                    <asp:Label ID="ExisteExequ" runat="server"></asp:Label>
                    <asp:Label ID="Label3" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>

            <!--  habilita la fecha de nacimiento-->

            <!--
            <tr>
                <td class="auto-style1">Fecha de nacimiento</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DDia" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                        <asp:ListItem>13</asp:ListItem>
                        <asp:ListItem>14</asp:ListItem>
                        <asp:ListItem>15</asp:ListItem>
                        <asp:ListItem>16</asp:ListItem>
                        <asp:ListItem>17</asp:ListItem>
                        <asp:ListItem>18</asp:ListItem>
                        <asp:ListItem>19</asp:ListItem>
                        <asp:ListItem>20</asp:ListItem>
                        <asp:ListItem>21</asp:ListItem>
                        <asp:ListItem>22</asp:ListItem>
                        <asp:ListItem>23</asp:ListItem>
                        <asp:ListItem>24</asp:ListItem>
                        <asp:ListItem>25</asp:ListItem>
                        <asp:ListItem>26</asp:ListItem>
                        <asp:ListItem>27</asp:ListItem>
                        <asp:ListItem>28</asp:ListItem>
                        <asp:ListItem>29</asp:ListItem>
                        <asp:ListItem>30</asp:ListItem>
                        <asp:ListItem>31</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DMes" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                        <asp:ListItem>4</asp:ListItem>
                        <asp:ListItem>5</asp:ListItem>
                        <asp:ListItem>6</asp:ListItem>
                        <asp:ListItem>7</asp:ListItem>
                        <asp:ListItem>8</asp:ListItem>
                        <asp:ListItem>9</asp:ListItem>
                        <asp:ListItem>10</asp:ListItem>
                        <asp:ListItem>11</asp:ListItem>
                        <asp:ListItem>12</asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DAno" runat="server">

                        <asp:ListItem>1980</asp:ListItem>
                        <asp:ListItem>1981</asp:ListItem>
                        <asp:ListItem>1982</asp:ListItem>
                        <asp:ListItem>1983</asp:ListItem>
                        <asp:ListItem>1984</asp:ListItem>
                        <asp:ListItem>1985</asp:ListItem>
                        <asp:ListItem>1986</asp:ListItem>
                        <asp:ListItem>1987</asp:ListItem>
                        <asp:ListItem>1988</asp:ListItem>
                        <asp:ListItem>1989</asp:ListItem>
                        <asp:ListItem>1990</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>               

            </tr>

            -->

            <!--  habilita la direccion-->

            <!--
            <tr>
                <td class="auto-style1">Direccion</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DDireccion" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>

            -->

            <tr>
                <td class="auto-style1">Telefono</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DTelefono" runat="server"></asp:TextBox>
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                    <asp:Label ID="Label4" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Contraseña</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DContrasena" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Confirmar Contraseña</td>
                <td class="auto-style2">
                    <asp:TextBox ID="DCContrasena" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>

            <!--  numero de tarjeta y puntos no creo que sirva-->

           <!--

            <tr>
                <td class="auto-style1">Numero de Tarjeta</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Token" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style3"></td>
            </tr>
            <tr>
                <td class="auto-style1">Puntos</td>
                <td class="auto-style2">
                    <asp:TextBox ID="Puntos" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>

            -->

            <tr>
                <td class="auto-style1">Sexo:</td>
                <td class="auto-style2">
                    <asp:DropDownList ID="DSexo" runat="server">
                        <asp:ListItem Value="0">Hombre</asp:ListItem>
                        <asp:ListItem Value="1">Mujer</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">&nbsp;</td>
                <td class="auto-style2">
                    <asp:LinkButton ID="Enter" runat="server" BackColor="#333333" BorderColor="Black" BorderStyle="Solid" ForeColor="Red" OnClick="Enter_Click1">ENTER</asp:LinkButton>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
        <p>
                    <asp:Label ID="Prueba" runat="server"></asp:Label>
                </p>
    </form>
</body>
</html>
