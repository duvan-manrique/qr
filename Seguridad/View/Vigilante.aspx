<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/Vigilante1.aspx.cs" Inherits="View_Vigilante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style12 {
            text-align: left;
            height: 128px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style9" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td style="background-color: #D9FFFA" class="auto-style12">
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
   
</asp:Content>

