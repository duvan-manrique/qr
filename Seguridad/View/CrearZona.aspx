<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/CrearZona1.aspx.cs" Inherits="View_CrearZona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 555px;
        }
        .auto-style13 {
            text-align: left;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style22 {
            font-family: Arial;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <table class="auto-style1" border="0" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
            <tr>
                <td class="auto-style8" >
                    <table class="auto-style1">
                        <tr>
                            <td colspan="2" class="auto-style13">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
                        </tr>
                        <tr>
                            <td colspan="2" class="auto-style13">
                        <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style12">
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                            <td>
                                <table class="auto-style22" style="color: #009900; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;"><strong>
                                    <tr>
                                        <td>Nombre de la zona </td>
                                        <td class="auto-style13">
                                            <asp:TextBox ID="TB_NombreZona" runat="server" Height="22px" Width="128px" OnTextChanged="TB_NombreZona_TextChanged"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_NombreZona" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                            <strong style="font-family: 'Bahnschrift SemiBold'">
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TB_NombreZona" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*"></asp:RegularExpressionValidator>
                <asp:Label ID="LB_u_n" runat="server" Text="zona  ya existente" Visible="False"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>numero de campos</td>
                                        <td class="auto-style13">
                                            <asp:TextBox ID="TB_NumerodeCampos" runat="server" TextMode="Number"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_NumerodeCampos" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_NumerodeCampos" ErrorMessage="no puede ser mas de 2 digitos" ValidationExpression="^([0-9]{1,2})$"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>tipos de vehiculo</td>
                                        <td class="auto-style13">
                                            <asp:DropDownList ID="DDL_TipodeVehiculo" runat="server">
                                                <asp:ListItem Value="2">carro</asp:ListItem>
                                                <asp:ListItem Value="1">moto</asp:ListItem>
                                                <asp:ListItem Value="3">cicla</asp:ListItem>
                                            </asp:DropDownList>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td>
                                            <asp:Button ID="B_ApartarCupo1" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Crear" OnClick="B_ApartarCupo1_Click" />
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            </table>
   
</asp:Content>

