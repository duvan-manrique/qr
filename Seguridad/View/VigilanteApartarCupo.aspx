<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/VigilanteApartarCupo1.aspx.cs" Inherits="View_VigilanteApartarCupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

    .auto-style26 {
        width: 100%;
        height: 415px;
    }
        .auto-style18 {
            height: 33px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style16 {
            text-align: right;
            width: 945px;
        }
        .auto-style17 {
            width: 945px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style27 {
            text-align: left;
            width: 202px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
  
              
            <table class="auto-style26" border="0" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit; color: #008000; font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;">
                <tr>
                    <td colspan="2" class="auto-style18">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style18"><span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; codigo identificativo del vehiculo<asp:TextBox ID="TB_codigoVe" runat="server"></asp:TextBox>
                        marca<asp:TextBox ID="TB_marca" runat="server"></asp:TextBox>
                        tipo
                        <asp:DropDownList ID="DDL_Vehiculo" runat="server" ForeColor="#009900">
                            <asp:ListItem Value="0">tipo</asp:ListItem>
                            <asp:ListItem Value="1">moto</asp:ListItem>
                            <asp:ListItem Value="2">carro</asp:ListItem>
                            <asp:ListItem Value="3">cicla</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="B_agregar" runat="server" OnClick="B_agregar_Click" Text="Agregar" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td class="auto-style8">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style27">fecha de resevacion&nbsp;&nbsp; </td>
                                <td><asp:TextBox ID="TB_Calendariocupo" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="TB_Calendariocupo_TextChanged1"></asp:TextBox>
                <asp:Label ID="LB_u_n" runat="server" Text="Fecha fuera de rango" Visible="False"></asp:Label>
                                    </td>
                            </tr>
                            <tr>
                                <td class="auto-style27">hora de inicio&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TB_hora_inicio" runat="server" TextMode="Time" AutoPostBack="True" OnTextChanged="TB_hora_inicio_TextChanged"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style27">hora final</td>
                                <td>
                                    <asp:TextBox ID="TB_hora_fin" runat="server" TextMode="Time"></asp:TextBox>
                                    </td>
                            </tr>
                            <tr>
                                <td rowspan="2" class="auto-style27">vehiculo
                        </td>
                                <td>
                        <asp:DropDownList ID="DDL_Tipo" runat="server" ForeColor="#009900" Enabled="False">
                            <asp:ListItem Value="0">tipo</asp:ListItem>
                            <asp:ListItem Value="1">moto</asp:ListItem>
                            <asp:ListItem Value="2">carro</asp:ListItem>
                            <asp:ListItem Value="3">cicla</asp:ListItem>
                        </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        <asp:DropDownList ID="DDL_Veicu" runat="server" Enabled="False" AutoPostBack="True">
                            <asp:ListItem Value="0">Seleccione</asp:ListItem>
                        </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style27">Descripcion</td>
                                <td>
                        <asp:TextBox ID="TB_Descripcion" runat="server" Height="44px" Width="181px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style27">
                                    &nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style17">
                        <asp:TextBox ID="txtCode" runat="server" Visible="False"></asp:TextBox>
                        <br />
                        <br />
                        <asp:PlaceHolder ID="PHQRCode" runat="server"></asp:PlaceHolder>
                    </td>
                    <td>
                        <br />
                        <asp:Button ID="B_Reservar" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Reservar" OnClick="B_Reservar_Click" style="height: 29px" />
                    </td>
                </tr>
            </table>
     
        
    
</asp:Content>

