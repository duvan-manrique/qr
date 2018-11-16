<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/ConsultarCupoUsuario1.aspx.cs" Inherits="View_ConsultarCupoUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            text-align: center;
            width: 406px;
        }
        .auto-style13 {
            text-align: left;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style23 {
            text-align: left;
            height: 24px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
            <table class="auto-style1" border="0">
                <tr>
                    <td style="color: #009900;" colspan="2" class="auto-style23">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
                </tr>
                <tr>
                    <td style="color: #009900;" colspan="2" class="auto-style23">
                        <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td class="auto-style13">
                        <br />
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <asp:GridView ID="GV_ConsultarCupo" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False" DataKeyNames="id">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="fecha_inicio" HeaderText="fecha_inicio " />
                                            <asp:BoundField DataField="fecha_fin" HeaderText="fecha_fin" />
                                            <asp:BoundField DataField="estado" HeaderText="estado" />
                                            <asp:BoundField DataField="vehiculo_id" HeaderText="vehiculo_id" />
                                            <asp:BoundField DataField="descripcion" HeaderText="descripcion" />
                                            <asp:BoundField DataField="qr" HeaderText="qr" />
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
                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="EliminarReserva" SelectMethod="obtenereservaTodos" TypeName="DAOUsuario" UpdateMethod="UpdateReserva">
                                        <DeleteParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                        </DeleteParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                            <asp:Parameter Name="parqueadero_id" Type="Int32" />
                                            <asp:Parameter Name="fecha_inicio" Type="DateTime" />
                                            <asp:Parameter Name="fecha_fin" Type="DateTime" />
                                            <asp:Parameter Name="estado" Type="Int32" />
                                            <asp:Parameter Name="vehiculo_id" Type="Int32" />
                                            <asp:Parameter Name="descripcion" Type="String" />
                                            <asp:Parameter Name="qr" Type="Int32" />
                                        </UpdateParameters>
                                    </asp:ObjectDataSource>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    
</asp:Content>

