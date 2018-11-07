﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/MenuAdmin.aspx.cs" Inherits="View_MenuAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">




        .auto-style1 {
            width: 100%;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style9 {
            width: 589px;
        }
        .auto-style10 {
            text-align: center;
            width: 589px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style3 {
            width: 525px;
            height: 120px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style12 {
            text-align: left;
        }
        .auto-style13 {
            text-align: center;
            height: 128px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style23 {
            text-align: right;
            height: 4px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
            <table class="auto-style1" border="0" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
      
                <tr>
                    <td colspan="2" class="auto-style13">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <img alt="" class="auto-style3" src="../Imagenes/LOGO.png" /></td>
                </tr>
      
                <tr>
                    <td colspan="2" class="auto-style23"><asp:Button ID="B_Cierre" runat="server" OnClick="B_Cierre_Click" Text="Cerrar Session" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="color: #008000" >
                        <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td >
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"  >administrativo</td>
                    <td class="auto-style8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10" >
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style12">zona </td>
                                <td class="auto-style12">reservacion </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                        <asp:Button ID="B_CrearZona" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear zona" OnClick="B_CrearZona_Click" />
                                </td>
                                <td class="auto-style12">
                        <asp:Button ID="B_CreaReservacion" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear reservacion" OnClick="B_CreaReservacion_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                        <asp:Button ID="B_BuscarZona" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Buscar  editar eliminar zona" OnClick="B_BuscarZona_Click" />
                                </td>
                                <td>
                        <asp:Button ID="B_BuscarReservacion" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Buscar  editar eliminar reservacion" OnClick="B_BuscarReservacion_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12">usuario</td>
                                <td>
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style12">
                                    parqueadero</td>
                            </tr>
                        </table>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                        <asp:Button ID="B_CrearUsuario" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear Usuario" OnClick="B_CrearUsuario_Click" />
                                </td>
                                <td class="auto-style12">
                        <asp:Button ID="B_Verparquedero" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Ver parquedero" OnClick="B_Verparquedero_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                        <asp:Button ID="B_BuscarUsuario" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Buscar editar eliminar  Usuario" OnClick="B_BuscarUsuario_Click" />
                                </td>
                                <td class="auto-style12">
                        <asp:Button ID="B_AdministrarParquedero" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="configuracion" OnClick="B_AdministrarParquedero_Click" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                                    multas de usuarios&nbsp;</td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                        <asp:Button ID="B_Multas0" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Multas" OnClick="B_Multas_Click" />
                                </td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td >
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                </table>
        <div>
        </div>
    
    
        <div>
            <br />
        </div>
   </form>
</body>
</html>
