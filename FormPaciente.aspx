<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormPaciente.aspx.cs" Inherits="AmiNew.FormPaciente" %>

<!DOCTYPE HTML>
<!--
	Escape Velocity 2.5 by HTML5 UP
	html5up.net | @n33co
	Free for personal and commercial use under the CCA 3.0 license (html5up.net/license)
-->
<html>
	<head>
		<title>Paciente</title>
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
	</head>
<body class="homepage">

    		<!-- Header Wrapper -->
			<div id="header-wrapper" class="wrapper">
				<div class="container">
					<div class="row">
						<div class="12u">
						
							<!-- Header -->
								<div id="header">
									
									<!-- Logo -->
										<div id="logo">
											<h1><a href="#">Paciente</a></h1>
											<span class="byline">Siga al pie dela letra las recetas</span>
										</div>
									<!-- /Logo -->
									
									<!-- Nav -->
										<nav id="nav">
											<ul>
												<li class="current_page_item"><a href="RecetaRecibida.aspx">Recetas</a></li>
												<li>
													<span>Médico</span>
													<ul>
														<li><a href="#">Mis Doctores</a></li>
														<li><a href="#">Doctores eliminados</a></li>
														<li>
															<span>Medicos</span>
															<ul>
																<li><a href="#">Agregar</a></li>
																<li><a href="#">Eliminar</a></li>
																<li><a href="#">Buscar Mapa</a></li>
																<li><a href="#">Calificar</a></li>
															</ul>
														</li>
														<li><a href="#">Favoritos</a></li>
													</ul>
												</li>
												<li><a href="#">Cita medica</a></li>
												<li><a href="#">Solicitudes</a></li>
												<li><a href="#">Farmacias</a></li>
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
    <form id="form1" runat="server">
        <div>   
        <table style="width: 95%; margin-left: 3px;">
              <tr>
                   <td class="auto-style1"> <asp:Label ID="LabelUsuario" runat="server"></asp:Label></td>
                   <td class="auto-style2">  <asp:Label ID="LabelPaciente" runat="server"></asp:Label> </td>
             <td class="auto-style3"> 
                 <asp:Button ID="ButtonSalir" runat="server" OnClick="ButtonSalir_Click" Text="Salir" />
                   </td>
              </tr>
        </table>    
    </div>
    </form>     
</body>
</html>
