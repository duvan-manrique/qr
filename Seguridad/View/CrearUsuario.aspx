<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/CrearUsuario1.aspx.cs" Inherits="View_CrearUsuario" %>

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
        .auto-style23 {
            text-align: left;
            width: 533px;
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
                <br />Nombre<asp:TextBox ID="TB_Nombre" runat="server" ValidationGroup="r"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3542545214" runat="server" ControlToValidate="TB_Nombre" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="crear"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_Nombre" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*" ValidationGroup="r"></asp:RegularExpressionValidator>
                <br />
                <br />User Name<asp:TextBox ID="TB_Username" runat="server" OnTextChanged="TB_Username_TextChanged" AutoPostBack="True" ValidationGroup="r"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4040245" runat="server" ControlToValidate="TB_Username" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="r"></asp:RequiredFieldValidator>
                <asp:Label ID="LB_u_n" runat="server" Text="user name ya existente" Visible="False"></asp:Label>
                <br />
                <br />Codigo identificacion universitaria<asp:TextBox ID="TB_Codigo" runat="server" TextMode="Number" ValidationGroup="r"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator227521" runat="server" ControlToValidate="TB_Codigo" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="r"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_Codigo" ErrorMessage="no puede ser mayor a 10 digitos" ValidationExpression="^([0-9]{1,10})$" ValidationGroup="r"></asp:RegularExpressionValidator>
                <br />
                <br />Clave<asp:TextBox ID="TB_Clave" runat="server" TextMode="Password" ValidationGroup="r"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator545227" runat="server" ControlToValidate="TB_Clave" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="r"></asp:RequiredFieldValidator>
                <br />
                <br />Correo<asp:TextBox ID="TB_Correo" runat="server" TextMode="Email" ValidationGroup="r"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator775875" runat="server" ControlToValidate="TB_Correo" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="r"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Button ID="B_CrearUsuario" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear usuario" OnClick="B_CrearUsuario_Click" ValidationGroup="r" />
            </td>
        </tr>
    </table>

</asp:Content>

