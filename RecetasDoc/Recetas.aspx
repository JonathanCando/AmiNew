<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Recetas.aspx.cs" Inherits="AmiNew.RecetasDoc.Recetas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" > 
<head id="Head1" runat="server"> 
<title>Página sin título</title> 
</head> 
<body> 
<form id="form1" runat="server"> 
<div> 
<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True"> 
<asp:ListItem>Estella</asp:ListItem> 
<asp:ListItem>Solares</asp:ListItem> 
<asp:ListItem>Ermua</asp:ListItem> 
</asp:DropDownList> 
<asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Usuario" HeaderText="Usuario" SortExpression="Usuario" />
    </Columns>
</asp:GridView> 
</div> 
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AMIConnectionString %>" SelectCommand="SELECT [Usuario] FROM [Paciente]"></asp:SqlDataSource>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
</form> 
</body>
</html>
