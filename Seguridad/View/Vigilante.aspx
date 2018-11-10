<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/Vigilante1.aspx.cs" Inherits="View_Vigilante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

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

        <div style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style9"/td style="color: #008000">
                        &nbsp;<td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"/td style="color: #008000">
                        <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td >
                        <asp:Button ID="B_ApartarCupoVilgilante" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Apartar Cupo Vigilante" OnClick="B_ApartarCupoVilgilante_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_LeerQR" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Leer QR" OnClick="B_LeerQR_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_VerParquedero" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Ver Parqueadero" OnClick="B_VerParquedero_Click" />
                        <br />
                        <br /></td>
                </tr>
                </table>
        </div>
   
</asp:Content>

