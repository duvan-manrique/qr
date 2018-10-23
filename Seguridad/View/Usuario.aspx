<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/Usuario1.aspx.cs" Inherits="View_Usuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style9" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
                        <br />
                        <img alt="" class="auto-style9" src="../Imagenes/article.jpg" /></td>
                    <td style="background-color: #D9FFFA" class="auto-style8">
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
                    <td class="auto-style9" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>

