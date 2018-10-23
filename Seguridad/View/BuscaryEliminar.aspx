<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/BuscaryEliminar1.aspx.cs" Inherits="View_BuscaryEliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 555px;
        }
        .auto-style11 {
            width: 294px;
            height: 110px;
            float: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style8" style="background-color: #D9FFFA">
                        <table class="auto-style1">
                            <tr>
                                <td colspan="2">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12">
                                    <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td>
                                    <table class="auto-style1">
                                        <tr>
                                            <td>Nombre de la zona </td>
                                            <td>
                                                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                                                <asp:Button ID="B_BuscarZona" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Buscar" />
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="257px" DataKeyNames="id">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                            <asp:BoundField DataField="tipo_vehiculo" HeaderText="Tipo_vehiculo" />
                                            <asp:BoundField DataField="numero_de_campos" HeaderText="Numero_de_campos" />
                                            <asp:CommandField ShowEditButton="True" />
                                            <asp:CommandField ShowDeleteButton="True" />
                                        </Columns>
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
                                                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="EliminarZonas" SelectMethod="obtenerzonasTodos" TypeName="DAOUsuario" UpdateMethod="UpdateZonas">
                                                    <DeleteParameters>
                                                        <asp:Parameter Name="id" Type="Int32" />
                                                    </DeleteParameters>
                                                    <UpdateParameters>
                                                        <asp:Parameter Name="id" Type="Int32" />
                                                        <asp:Parameter Name="Nombre" Type="String" />
                                                        <asp:Parameter Name="Tipo_vehiculo" Type="String" />
                                                        <asp:Parameter Name="Numero_de_campos" Type="Int32" />
                                                    </UpdateParameters>
                                                </asp:ObjectDataSource>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
      
</asp:Content>

