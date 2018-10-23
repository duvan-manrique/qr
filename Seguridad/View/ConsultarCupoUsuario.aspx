<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/ConsultarCupoUsuario1.aspx.cs" Inherits="View_ConsultarCupoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            text-align: center;
            width: 406px;
        }
        .auto-style11 {
            width: 348px;
            height: 173px;
        }
        .auto-style13 {
            text-align: left;
        }
        .auto-style15 {
            height: 30px;
        }
        .auto-style14 {
            text-align: right;
            height: 30px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td style="background-color: #D9FFFA; color: #009900;" colspan="2" class="auto-style13">
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style15">Codigo institucional<asp:TextBox ID="TB_ConsultarCupo" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style14">
                                    <asp:Button ID="B_ConsultarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Consultar Cupo" OnClick="B_ConsultarCupo_Click" />
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
                    <td class="auto-style12" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
                        <br />
                        <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td style="background-color: #D9FFFA; color: #009900;" class="auto-style13">
                        <br />
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:GridView ID="GV_ConsultarCupo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                        <AlternatingRowStyle BackColor="White" />
                                        <EditRowStyle BackColor="#7C6F57" />
                                        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#E3EAEB" />
                                        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                        <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                        <SortedAscendingHeaderStyle BackColor="#246B61" />
                                        <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                        <SortedDescendingHeaderStyle BackColor="#15524A" />
                                    </asp:GridView>
                                </td>
                                <td>
                                    <asp:TextBox ID="TB_ResultadoConsultar" runat="server" Height="109px" Width="144px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>

