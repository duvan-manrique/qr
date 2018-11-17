<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/Usuario1.aspx.cs" Inherits="View_Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style12 {
            width: 633px;
        }
        .auto-style13 {
            text-align: right;
            width: 633px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style14 {
            text-align: left;
            height: 128px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <div style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style12" style="color: #008000">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" style="color: #008000">
                        <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td class="auto-style14">
                        <asp:Label ID="LB_multa" runat="server" Text="apartar cupos bloqueados por multa pendiente" Visible="False"></asp:Label>
                        <br />
                        <asp:Button ID="B_ApartarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Apartar Cupo" OnClick="B_ApartarCupo_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_EditarPerfil" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Editar Perfil" OnClick="B_EditarPerfil_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_CancelarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Ver o Cancelar Cupo" OnClick="B_CancelarCupo_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_Multas0" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Enviar $ Multas al correo" OnClick="B_Multas_Click" Width="175px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    
</asp:Content>

