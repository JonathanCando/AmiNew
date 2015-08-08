<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormDoctor.aspx.cs" Inherits="AmiNew.FormDoctor" %>

<!DOCTYPE HTML>
<!--
	Escape Velocity 2.5 by HTML5 UP
	html5up.net | @n33co
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
-->
<html>
	<head>
		<title>Doctor</title>
		<meta http-equiv="content-type" content="text/html; charset=utf-8" />
		<meta name="description" content="" />
		<meta name="keywords" content="" />
		<link href="http://fonts.googleapis.com/css?family=Source+Sans+Pro:400,400italic,700,900" rel="stylesheet" />
		<!--[if lte IE 8]><script src="js/html5shiv.js"></script><link rel="stylesheet" href="css/ie8.css" /><![endif]-->
		<script src="js/jquery.min.js"></script>
		<script src="js/jquery.dropotron.min.js"></script>
		<script src="js/config.js"></script>
		<script src="js/skel.min.js"></script>
		<script src="js/skel-panels.min.js"></script>
		<noscript>
			<link rel="stylesheet" href="css/skel-noscript.css" />
			<link rel="stylesheet" href="css/style.css" />
			<link rel="stylesheet" href="css/style-desktop.css" />
		</noscript>
	    <style type="text/css">
            .auto-style2 {
                width: 520px;
            }
            .auto-style3 {
                width: 177px;
                text-align: left;
            }
                        table {
                color:#FFFFFF;
            }
            body {
                background-image:url("images/BackGround07.jpg")
            }
            h1 {
                text-align:center;
                color:#FFFFFF;
            }
            .auto-style4 {
                width: 121px;
            }
            .auto-style5 {
                width: 92px;
            }
            .auto-style7 {
                width: 112px;
            }
            .auto-style8 {
                width: 84px;
            }
        </style>
	</head>
<body class="homepage">

        <form id="form1" runat="server">

    		<!-- Header Wrapper -->
			<div id="header-wrapper" class="wrapper">
				<div class="container">
					<div class="row">
						<div class="12u">
						
							<!-- Header -->
								<div id="header">
									
									<!-- Logo -->
										<div id="logo">
											<h1><a href="#">Médico</a></h1>
										<!--	<span class="byline">El paciente espera por ti</span>-->
                                            <h4>EL PACIENTE ESPERA POR TI</h4>                                         

										</div>
									<!-- /Logo -->
                                    
									
									<!-- Nav -->
										<nav id="nav">
											<ul>
												<li class="current_page_item"><a href="#">Citas</a></li>
												<li>
													<span>Paciente</span>
													<ul>
														<li><a href="PacientesAgregados.aspx">Mis Pacientes</a></li>
														<li><a href="#">Pacientes eliminados</a></li>
														<li>
															<span>Enfermo</span>
															<ul>
																<li><a href="#TextPaciente">Agregar</a></li>
																<li><a href="#TextEliminar">Eliminar</a></li>
																<li><a href="#">Inquietudes</a></li>
																<li><a href="#">Modificar Recetas</a></li>
															</ul>
														</li>
														<li><a href="#">Historial Paciente</a></li>
													</ul>
												</li>
												<li><a href="RecetasNuevas.aspx">Recetas nuevas</a></li>
												<li><a href="left-sidebar.html">Modificar Recetas</a></li>
												<li><a href="no-sidebar.html">Calendario</a></li>
											</ul>
										</nav>
									<!-- /Nav -->

								</div>
							<!-- /Header -->

						</div>
					</div>
				</div>
			</div>
		<!-- /Header Wrapper -->

    <div>    
          <table style="width: 95%; margin-left: 3px;">
              <tr>
                  <td class="auto-style4">
                      &nbsp;</td>
                  <td class="auto-style2">&nbsp;</td>
                  <td class="auto-style5">
                      <asp:Label ID="LabelUsuario" runat="server" Text="LabelUsuario"></asp:Label>
                  </td>
                  <td>
                    <asp:Button ID="BotonSalir" runat="server" OnClick="BotonSalir_Click" Text="Salir" />
                  </td>
              </tr>
          </table>
    
    </div>
    <div>

        <table style="width: 88%;">
            <tr>
                <td class="auto-style3">AGREGAR</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label1" runat="server" Text="Ingrese un paciente"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextPaciente" runat="server" style="margin-left: 0px" OnTextChanged="TextPaciente_TextChanged"></asp:TextBox>
                </td>
                <td class="auto-style7"><asp:Button ID="BotonAgregar" runat="server" OnClick="BotonAgregar_Click" Text="Agregar" Height="25px" Width="63px" />
                                                                        </td>
                <td>
                      <asp:Label ID="LabelSiUsuario" runat="server"></asp:Label>
                  </td>
            </tr>
            <tr>
                <td class="auto-style3">ELIMINAR</td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label2" runat="server" Text="Elija un paciente"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TextEliminar" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style7">
                    <asp:Button ID="BotonEliminar" runat="server" OnClick="BotonEliminar_Click" Text="Eliminar" Width="65px" />
                </td>
                <td>
                    <asp:Label ID="LabelNoUsuario" runat="server"></asp:Label>
                </td>
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
