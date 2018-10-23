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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style12" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td style="background-color: #D9FFFA" class="auto-style14">
                        <asp:Button ID="B_ApartarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Apartar Cupo" OnClick="B_ApartarCupo_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_EditarPerfil" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Editar Perfil" OnClick="B_EditarPerfil_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_CancelarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Cancelar Cupo" OnClick="B_CancelarCupo_Click" />
                        <br />
                        <br />
                        <asp:Button ID="B_BuscarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Buscar Cupo" OnClick="B_BuscarCupo_Click" style="height: 26px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style12" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
            </table>
        </div>
    
</asp:Content>

