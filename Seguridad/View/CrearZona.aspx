<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/CrearZona1.aspx.cs" Inherits="View_CrearZona" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 555px;
        }
        .auto-style11 {
            width: 294px;
            height: 110px;
            float: right;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
        <table class="auto-style1" border="0">
            <tr>
                <td class="auto-style8" style="background-color: #D9FFFA">
                    <table class="auto-style1">
                        <tr>
                            <td colspan="2">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style12">
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td style="background-color: #D9FFFA">
                    <table class="auto-style1">
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>
                                <table class="auto-style1">
                                    <tr>
                                        <td>Nombre de la zona </td>
                                        <td>
                                            <asp:TextBox ID="TB_NombreZona" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TB_NombreZona" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>numero de campos</td>
                                        <td>
                                            <asp:TextBox ID="TB_NumerodeCampos" runat="server"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TB_NumerodeCampos" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TB_NumerodeCampos" ErrorMessage="ingrese numero" ValidationExpression="^([0-9]{1,90})$"></asp:RegularExpressionValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>tipos de vehiculo</td>
                                        <td>
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
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                            <td>&nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
   
</asp:Content>

