﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/RecuperarContraseña.aspx.cs" Inherits="View_RecuperarContraseña" %>

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
        .auto-style3 {
            width: 525px;
            height: 120px;
        }
        .auto-style9 {
            width: 589px;
        }
        .auto-style13 {
            text-align: left;
            width: 315px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style12 {
            width: 4px;
        }
        .auto-style14 {
            width: 645px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style10 {
            text-align: center;
            width: 589px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style15 {
            text-align: left;
        }
        </style>
</head>
<body style="background-color: #FFFFFF">
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                <tr>
                    <td style="">
                        <br />
                        <br />
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
            <table class="auto-style1" border="0">
      
                <tr>
                    <td colspan="2" class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <img alt="" class="auto-style3" src="../Imagenes/LOGO.png" /></td>
                </tr>
      
                <tr>
                    <td colspan="2" class="auto-style15">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9" style="">
                        <table class="auto-style1">
                            <tr>
                    <td class="auto-style13" style="background-color: #FFFFFF">&nbsp;</td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                    <td class="auto-style13" style="background-color: #FFFFFF">digite su nueva contraseña</td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td>
                        <asp:TextBox ID="Tb_Contraseña" runat="server" TextMode="Password" ValidationGroup="i"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator34124527" runat="server" ControlToValidate="Tb_Contraseña" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="i"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                        <table class="auto-style1">
                            <tr>
                    <td class="auto-style14" style="background-color: #FFFFFF">repite su nueva contraseña</td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TB_Repetir" runat="server" TextMode="Password" ValidationGroup="i"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4745217" runat="server" ControlToValidate="TB_Repetir" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="i"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td style="">
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Button ID="B_Cambiar" runat="server" OnClick="B_Cambiar_Click" Text="Cambiar" BackColor="#009900" BorderColor="#009900" ForeColor="White" ValidationGroup="i" />
                    </td>
                    <td class="auto-style10">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        &nbsp;</td>
                </tr>
                </table>
                    </td>
                </tr>
                </table>
        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
