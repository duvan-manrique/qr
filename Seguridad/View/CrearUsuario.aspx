﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/CrearUsuario1.aspx.cs" Inherits="View_CrearUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        

        .auto-style1 {
            width: 100%;
        }
        .auto-style12 {
            text-align: center;
            width: 533px;
        }
        .auto-style13 {
            text-align: left;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <table class="auto-style1" border="0">
        <tr>
            <td class="auto-style12" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
                <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
            <td style="background-color: #D9FFFA; color: #009900;" class="auto-style13">
                <br />Nombre<asp:TextBox ID="TB_Nombre" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_Nombre" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*" ValidationGroup="insertar"></asp:RegularExpressionValidator>
                <br />
                <br />User Name<asp:TextBox ID="TB_Username" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TB_Username" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                <br />
                <br />Codigo identificacion universitaria<asp:TextBox ID="TB_Codigo" runat="server" TextMode="Number"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_Codigo" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_Codigo" ErrorMessage="ingrese numero" ValidationExpression="^([0-9]{1,10})$"></asp:RegularExpressionValidator>
                <br />
                <br />Clave<asp:TextBox ID="TB_Clave" runat="server" TextMode="Password"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TB_Clave" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                <br />
                <br />Correo<asp:TextBox ID="TB_Correo" runat="server" TextMode="Email"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TB_Correo" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="B_CrearUsuario" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear usuario" OnClick="B_CrearUsuario_Click" />
            </td>
        </tr>
    </table>

</asp:Content>

