<%@ Page Title="" Language="C#" MasterPageFile="~/MasterMapa.Master" AutoEventWireup="true" CodeBehind="Mapa.aspx.cs" Inherits="AmiNew.Mapa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <script type="text/javascript" src="http://maps.googleapis.com/maps/api/js?sensor=false"></script>
<script type ="text/javascript">
    function InitializeMap() {
        var latlng = new google.maps.LatLng(18.461373375441447, -69.93553161621094);
        var myOptions = {
            zoom: 12,
            center: latlng,
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        var map = new google.maps.Map(document.getElementById("map"), myOptions);
    }
    window.onload = InitializeMap;

</script>
<h2>Ubicación del Doctor</h2>
<div id ="map"   style="width: 1200px; top: 68px; left: 80px; position: absolute; height: 550px">

</div>
</asp:Content>
