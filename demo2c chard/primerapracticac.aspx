<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="primerapracticac.aspx.cs" Inherits="demo2c_chard.primerapracticac_" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
</head>
<body>
    <br />
    <div class="container">
        <div class="row">
            <div class="col"></div>
            <div class="col-10">
                <h1> Proceso de Formulario</h1>
                <h3><b>Nombre Completo</b> <% =mensaje %></h3>
                <br/>
                <p><b>Nombre Completo</b> <%= Nombre %> <% =apellido1 %> <% =apellido2%> %></p>
        </div>
            <div class="col"></div>
    </div>
</body>
</html>
