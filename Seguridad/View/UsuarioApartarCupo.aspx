<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/UsuarioApartarCupo1.aspx.cs" Inherits="View_UsuarioApartarCupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style16 {
            text-align: right;
            width: 958px;
        }
        .auto-style17 {
            width: 958px;
        }
        .auto-style18 {
            height: 33px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style26 {
        width: 100%;
        height: 415px;
    }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
            <table class="auto-style26" border="0" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit; color: #008000; font-family: 'Bahnschrift SemiBold';">
                <tr>
                    <td colspan="2" class="auto-style18">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" class="auto-style18"><span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; codigo identificativo del vehiculo<asp:TextBox ID="TB_codigoVe" runat="server" OnTextChanged="TB_codigoVe_TextChanged"></asp:TextBox>
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
                                <td>fecha de resevacion&nbsp;&nbsp; </td>
                                <td><asp:TextBox ID="TB_Calendariocupo" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="TB_Calendariocupo_TextChanged"></asp:TextBox>
                <asp:Label ID="LB_u_n" runat="server" Text="Fecha fuera de rango" Visible="False"></asp:Label>
                                    </td>
                            </tr>
                            <tr>
                                <td>hora de inicio&nbsp;&nbsp;&nbsp;</td>
                                <td><asp:DropDownList ID="DDL_HInicio" runat="server" ForeColor="#009900">
                                  
                                    <asp:ListItem Value="1">1:00</asp:ListItem>
                                    <asp:ListItem Value="2">2:00</asp:ListItem>
                                    <asp:ListItem Value="3">3:00</asp:ListItem>
                                    <asp:ListItem Value="4">4:00</asp:ListItem>
                                    <asp:ListItem Value="5">5:00</asp:ListItem>
                                    <asp:ListItem Value="6">6:00</asp:ListItem>
                                    <asp:ListItem Value="7">7:00 </asp:ListItem>
                                    <asp:ListItem Value="8">8:00</asp:ListItem>
                                    <asp:ListItem Value="9">9:00</asp:ListItem>
                                    <asp:ListItem Value="10">10:00</asp:ListItem>
                                    <asp:ListItem Value="11">11:00</asp:ListItem>
                                    <asp:ListItem Value="12">12:00</asp:ListItem>
                                    <asp:ListItem Value="13">13:00</asp:ListItem>
                                    <asp:ListItem Value="14">14:00</asp:ListItem>
                                    <asp:ListItem Value="15">15:00</asp:ListItem>
                                    <asp:ListItem Value="16">16:00</asp:ListItem>
                                    <asp:ListItem Value="17">17:00</asp:ListItem>
                                    <asp:ListItem Value="18">18:00</asp:ListItem>
                                    <asp:ListItem Value="19">19:00</asp:ListItem>
                                    <asp:ListItem Value="20">20:00</asp:ListItem>
                                    <asp:ListItem Value="21">21:00</asp:ListItem>
                                    <asp:ListItem Value="22">22:00</asp:ListItem>
                                    <asp:ListItem Value="23">23:00</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>hora final</td>
                                <td><asp:DropDownList ID="DDL_HFinal" runat="server" ForeColor="#009900">
                          
                                    <asp:ListItem Value="1">1:00</asp:ListItem>
                                    <asp:ListItem Value="2">2:00</asp:ListItem>
                                    <asp:ListItem Value="3">3:00</asp:ListItem>
                                    <asp:ListItem Value="4">4:00</asp:ListItem>
                                    <asp:ListItem Value="5">5:00</asp:ListItem>
                                    <asp:ListItem Value="6">6:00</asp:ListItem>
                                    <asp:ListItem Value="7">7:00 </asp:ListItem>
                                    <asp:ListItem Value="8">8:00</asp:ListItem>
                                    <asp:ListItem Value="9">9:00</asp:ListItem>
                                    <asp:ListItem Value="10">10:00</asp:ListItem>
                                    <asp:ListItem Value="11">11:00</asp:ListItem>
                                    <asp:ListItem Value="12">12:00</asp:ListItem>
                                    <asp:ListItem Value="13">13:00</asp:ListItem>
                                    <asp:ListItem Value="14">14:00</asp:ListItem>
                                    <asp:ListItem Value="15">15:00</asp:ListItem>
                                    <asp:ListItem Value="16">16:00</asp:ListItem>
                                    <asp:ListItem Value="17">17:00</asp:ListItem>
                                    <asp:ListItem Value="18">18:00</asp:ListItem>
                                    <asp:ListItem Value="19">19:00</asp:ListItem>
                                    <asp:ListItem Value="20">20:00</asp:ListItem>
                                    <asp:ListItem Value="21">21:00</asp:ListItem>
                                    <asp:ListItem Value="22">22:00</asp:ListItem>
                                    <asp:ListItem Value="23">23:00</asp:ListItem>
                                    
                                    </asp:DropDownList>
                                    </td>
                            </tr>
                            <tr>
                                <td rowspan="2">vehiculo
                        </td>
                                <td>
                        <asp:DropDownList ID="DDL_Tipo" runat="server" ForeColor="#009900" OnSelectedIndexChanged="DDL_Tipo_SelectedIndexChanged" AutoPostBack="True">
                            <asp:ListItem Value="0">tipo</asp:ListItem>
                            <asp:ListItem Value="1">moto</asp:ListItem>
                            <asp:ListItem Value="2">carro</asp:ListItem>
                            <asp:ListItem Value="3">cicla</asp:ListItem>
                        </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>
                        <asp:DropDownList ID="DDL_Veicu" runat="server" Enabled="False" AutoPostBack="True" OnSelectedIndexChanged="DDL_Veicu_SelectedIndexChanged">
                            <asp:ListItem Value="0">Seleccione</asp:ListItem>
                        </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>Descripcion</td>
                                <td>
                        <asp:TextBox ID="TB_Descripcion" runat="server" Height="44px" Width="181px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Time"></asp:TextBox>
                                </td>
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
                    <td><br />
                        <asp:Button ID="B_Reservar" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Reservar" OnClick="B_Reservar_Click" />
                    </td>
                </tr>
            </table>
     
</asp:Content>

