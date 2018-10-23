<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/LeerQR1.aspx.cs" Inherits="View_LeerQR" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style11 {
            margin-right: 0px;
        }
    </style>
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
                        <asp:Panel ID="Panel1" runat="server" CssClass="auto-style11" Height="216px" Width="263px">
                        </asp:Panel>
                        <br /></td>
                    <td style="background-color: #D9FFFA" class="auto-style8">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="color: #009900">Nombre</td>
                                <td>
                                    <asp:TextBox ID="TB_Nombre" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #009900">Apellido</td>
                                <td>
                                    <asp:TextBox ID="TB_Apellido" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #009900">Numero identificativo</td>
                                <td>
                                    <asp:TextBox ID="TB_NumeroIdentificativo" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #009900">celular</td>
                                <td>
                                    <asp:TextBox ID="TB_Celular" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #009900">Codigo identificativo del vehiculo</td>
                                <td>
                                    <asp:TextBox ID="TB_CodigoVehiculo" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td style="color: #009900">Codigo identificativo universitario</td>
                                <td>
                                    <asp:TextBox ID="TB_CodigoUniversidad" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td style="color: #009900">Correo</td>
                                <td>
                                    <asp:TextBox ID="TB_Correo" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
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

