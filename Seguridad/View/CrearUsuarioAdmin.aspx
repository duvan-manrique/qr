﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="CrearUsuarioAdmin.aspx.cs" Inherits="View_CrearUsuarioAdmin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style23 {
            text-align: left;
            width: 666px;
        }
        .auto-style13 {
            text-align: left;
        }
        .auto-style12 {
            text-align: center;
            width: 666px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" border="0" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
        <tr>
            <td class="auto-style23">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
            <td  class="auto-style13">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style12">
                <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
            <td  class="auto-style22" style="color: #009900; background-color: #FFFFFF;"><strong style="font-family: 'Bahnschrift SemiBold'">
                <br />Nombre<asp:TextBox ID="TB_Nombre" runat="server" OnTextChanged="TB_Nombre_TextChanged" ValidationGroup="t"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3545" runat="server" ControlToValidate="TB_Nombre" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="t"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*" ValidationGroup="t"></asp:RegularExpressionValidator>
                <br />
                <br />User Name<asp:TextBox ID="TB_Username" runat="server" OnTextChanged="TB_Username_TextChanged" AutoPostBack="True" ValidationGroup="t"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator41254541" runat="server" ControlToValidate="TB_Username" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="t"></asp:RequiredFieldValidator>
                <asp:Label ID="LB_u_n" runat="server" Text="user name ya existente" Visible="False"></asp:Label>
                <br />
                Tipo de&nbsp; usuario<asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
             
                    <asp:ListItem Value="3">usuario</asp:ListItem>
                    <asp:ListItem Value="2">vigilante</asp:ListItem>
                </asp:DropDownList>
                <br />Codigo identificacion universitaria<asp:TextBox ID="TB_Codigo" runat="server" TextMode="Number" ValidationGroup="t"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator21542145" runat="server" ControlToValidate="TB_Codigo" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="t"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_Codigo" ErrorMessage="no puede ser mayor a 10 digitos" ValidationExpression="^([0-9]{1,10})$" ValidationGroup="t"></asp:RegularExpressionValidator>
                <br />
                <br />Clave<asp:TextBox ID="TB_Clave" runat="server" TextMode="Password" ValidationGroup="t"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator54245245" runat="server" ControlToValidate="TB_Clave" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="t"></asp:RequiredFieldValidator>
                <br />
                <br />Correo<asp:TextBox ID="TB_Correo" runat="server" TextMode="Email" ValidationGroup="t"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator742145" runat="server" ControlToValidate="TB_Correo" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="t"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="B_CrearUsuario" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear usuario" OnClick="B_CrearUsuario_Click" ValidationGroup="t" />
            </td>
        </tr>
    </table>

</asp:Content>

