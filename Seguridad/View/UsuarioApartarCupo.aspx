﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/UsuarioApartarCupo1.aspx.cs" Inherits="View_UsuarioApartarCupo" %>

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
        .auto-style27 {
            width: 161px;
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
                    <td colspan="2" class="auto-style18" style="background-color: #FFFFFF"><span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; codigo identificativo del vehiculo<asp:TextBox ID="TB_codigoVe" runat="server" ValidationGroup="m"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4547" runat="server" ControlToValidate="TB_codigoVe" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="m"></asp:RequiredFieldValidator>
                        marca<asp:TextBox ID="TB_marca" runat="server" ValidationGroup="m"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5452142" runat="server" ControlToValidate="TB_marca" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="m"></asp:RequiredFieldValidator>
                        tipo
                        <asp:DropDownList ID="DDL_Vehiculo" runat="server" ForeColor="#009900">
                            <asp:ListItem Value="0">tipo</asp:ListItem>
                            <asp:ListItem Value="1">moto</asp:ListItem>
                            <asp:ListItem Value="2">carro</asp:ListItem>
                            <asp:ListItem Value="3">cicla</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Button ID="B_agregar" runat="server" OnClick="B_agregar_Click" Text="Agregar" BackColor="#009900" BorderColor="#009900" ForeColor="White" ValidationGroup="m" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style16">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /><asp:GridView ID="GV_series" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="fecha_inicio" HeaderText="inicio" />
                                <asp:BoundField DataField="fecha_fin" HeaderText="fin" />
                                <asp:BoundField DataField="dia" HeaderText="dia" />
                            </Columns>
                            <EditRowStyle BackColor="#2461BF" />
                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                            <RowStyle BackColor="#EFF3FB" />
                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                            <SortedAscendingCellStyle BackColor="#F5F7FB" />
                            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                            <SortedDescendingCellStyle BackColor="#E9EBEF" />
                            <SortedDescendingHeaderStyle BackColor="#4870BE" />
                        </asp:GridView>
                    </td>
                    <td class="auto-style8">
                        <table class="auto-style1" style="background-color: #FFFFFF">
                            <tr>
                                <td class="auto-style27">fecha de resevacion&nbsp;&nbsp; </td>
                                <td><asp:TextBox ID="TB_Calendariocupo" runat="server" TextMode="Date" AutoPostBack="True" OnTextChanged="TB_Calendariocupo_TextChanged" ValidationGroup="x"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator642452" runat="server" ControlToValidate="TB_Calendariocupo" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="x"></asp:RequiredFieldValidator>
                <asp:Label ID="LB_u_n" runat="server" Text="Fecha fuera de rango" Visible="False"></asp:Label>
                                    </td>
                            </tr>
                            <tr>
                                <td class="auto-style27">hora de inicio&nbsp;&nbsp;&nbsp;</td>
                                <td>
                                    <asp:TextBox ID="TB_hora_inicio" runat="server" TextMode="Time" ValidationGroup="x"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator741245" runat="server" ControlToValidate="TB_hora_inicio" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="x"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style27">hora final</td>
                                <td>
                                    <asp:TextBox ID="TB_hora_fin" runat="server" TextMode="Time" ValidationGroup="x"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator841452" runat="server" ControlToValidate="TB_hora_fin" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="x"></asp:RequiredFieldValidator>
                                    </td>
                            </tr>
                            <tr>
                                <td rowspan="2" class="auto-style27">vehiculo
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
                                <td class="auto-style27">Descripcion</td>
                                <td>
                        <asp:TextBox ID="TB_Descripcion" runat="server" Height="44px" Width="181px" ValidationGroup="x"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator9452752" runat="server" ControlToValidate="TB_Descripcion" Display="Dynamic" ErrorMessage="no puede estar vacio" ValidationGroup="x"></asp:RequiredFieldValidator>
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
                    <td><br />
                        <asp:Button ID="B_Reservar" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Reservar" OnClick="B_Reservar_Click" ValidationGroup="x" />
                    </td>
                </tr>
            </table>
     
</asp:Content>

