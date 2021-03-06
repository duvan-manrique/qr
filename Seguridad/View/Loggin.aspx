﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/Loggin.aspx.cs" Inherits="View_Loggin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 50%;
        }
        .auto-style4 {
            height: 14px;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style5 {
            width: 286px;
        }
        .auto-style9 {
            width: 95%;
            height: 314px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style12 {
            text-align: right;
        }
        .auto-style13 {
            height: 23px;
        }
        .auto-style14 {
            width: 375%;
            height: 163px;
        }
        .auto-style15 {
            height: 23px;
            width: 784px;
        }
        .auto-style16 {
            width: 784px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                <tr>
                    <td><table class="auto-style9" border="0">
      
                <tr>
                    <td colspan="2" class="auto-style8">&nbsp;
                        <table class="auto-style1">
                            <tr>
                                <td>
                        <img alt="" class="auto-style3" src="../Imagenes/LOGO.png" /></td>
                                <td>
                        <asp:Button ID="B_registrarse" runat="server" Text="regitrarse" BackColor="#006600" BorderColor="#009933" ForeColor="White" OnClick="B_registrarse_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" ">
                                <table class="auto-style14">
                                    <tr>
                                        <td class="auto-style15"></td>
                                        <td class="auto-style13"></td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style16">
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                                        <td class="auto-style12">
                        <asp:Login ID="L_Autenticate" runat="server" BackColor="#F7F6F3" BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333" OnAuthenticate="L_Autenticate_Authenticate" Height="141px" Width="246px">
                            <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
                            <LayoutTemplate>
                                <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
                                    <tr>
                                        <td>
                                            <table cellpadding="0">
                                                <tr>
                                                    <td align="center" colspan="2" style="color:White;background-color:#5D7B9D;font-size:0.9em;font-weight:bold;">Iniciar sesión</td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">Nombre de usuario:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="UserName" runat="server" Font-Size="0.8em"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="El nombre de usuario es obligatorio." ToolTip="El nombre de usuario es obligatorio." ValidationGroup="L_Autenticate">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right">
                                                        <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Contraseña:</asp:Label>
                                                    </td>
                                                    <td>
                                                        <asp:TextBox ID="Password" runat="server" Font-Size="0.8em" TextMode="Password"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="La contraseña es obligatoria." ToolTip="La contraseña es obligatoria." ValidationGroup="L_Autenticate">*</asp:RequiredFieldValidator>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td colspan="2" class="auto-style12">
                                                        <asp:CheckBox ID="RememberMe" runat="server" Text="Recordármelo la próxima vez." />
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="center" colspan="2" style="color:Red;" class="auto-style4">
                                                        <asp:LinkButton ID="LB_Recuperar" runat="server" OnClick="LB_Recuperar_Click">Recuperar Contraseña</asp:LinkButton>
                                                    </td>
                                                </tr>
                                                <tr>
                                                    <td align="right" colspan="2">
                                                        <asp:Button ID="LoginButton" runat="server" BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" CommandName="Login" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" Text="Inicio de sesión" ValidationGroup="L_Autenticate" OnClick="L_Autenticate_Authenticate" style="height: 18px" />
                                                    </td>
                                                </tr>
                                            </table>
                                        </td>
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="0.8em" ForeColor="#284775" />
                            <TextBoxStyle Font-Size="0.8em" />
                            <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True" Font-Size="0.9em" ForeColor="White" />
                        </asp:Login>
                                        </td>
                                    </tr>
                                </table>
                    </td>
                    <td   class="auto-style12">
                        &nbsp;</td>
                </tr>
                </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
