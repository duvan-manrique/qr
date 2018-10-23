<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="configuracion.aspx.cs" Inherits="View_configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style11 {
            width: 398px;
            height: 189px;
        }
        .auto-style12 {
            width: 163px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1">
        <tr>
            <td>&nbsp;</td>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style12">fecha</td>
                        <td>
                            <asp:TextBox ID="tb_fecha" runat="server" TextMode="Date"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">hora inicio</td>
                        <td>
                                    <asp:DropDownList ID="DDL_HInicio" runat="server" ForeColor="#009900">
                                        <asp:ListItem Value="1">1:00</asp:ListItem>
                                        <asp:ListItem Value="2">2:00</asp:ListItem>
                                        <asp:ListItem Value="3">3:00</asp:ListItem>
                                        <asp:ListItem Value="4">4:00</asp:ListItem>
                                        <asp:ListItem Value="5">5:00</asp:ListItem>
                                        <asp:ListItem Value="6">6:00</asp:ListItem>
                                        <asp:ListItem Value="7">7:00 </asp:ListItem>
                                        <asp:ListItem Value="8">8:00</asp:ListItem>
                                        <asp:ListItem Value="9">9:00</asp:ListItem>
                                        <asp:ListItem Value="10">10:00</asp:ListItem>
                                        <asp:ListItem Value="11">11:00</asp:ListItem>
                                        <asp:ListItem Value="12">12:00</asp:ListItem>
                                        <asp:ListItem Value="13">13:00</asp:ListItem>
                                        <asp:ListItem Value="14">14:00</asp:ListItem>
                                        <asp:ListItem Value="15">15:00</asp:ListItem>
                                        <asp:ListItem Value="16">16:00</asp:ListItem>
                                        <asp:ListItem Value="17">17:00</asp:ListItem>
                                        <asp:ListItem Value="18">18:00</asp:ListItem>
                                        <asp:ListItem Value="19">19:00</asp:ListItem>
                                        <asp:ListItem Value="20">20:00</asp:ListItem>
                                        <asp:ListItem Value="21">21:00</asp:ListItem>
                                        <asp:ListItem Value="22">22:00</asp:ListItem>
                                        <asp:ListItem Value="23">23:00</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">hora fin</td>
                        <td>
                                    <asp:DropDownList ID="DDL_HFinal" runat="server" ForeColor="#009900">
                                        <asp:ListItem Value="1">1:00</asp:ListItem>
                                        <asp:ListItem Value="2">2:00</asp:ListItem>
                                        <asp:ListItem Value="3">3:00</asp:ListItem>
                                        <asp:ListItem Value="4">4:00</asp:ListItem>
                                        <asp:ListItem Value="5">5:00</asp:ListItem>
                                        <asp:ListItem Value="6">6:00</asp:ListItem>
                                        <asp:ListItem Value="7">7:00 </asp:ListItem>
                                        <asp:ListItem Value="8">8:00</asp:ListItem>
                                        <asp:ListItem Value="9">9:00</asp:ListItem>
                                        <asp:ListItem Value="10">10:00</asp:ListItem>
                                        <asp:ListItem Value="11">11:00</asp:ListItem>
                                        <asp:ListItem Value="12">12:00</asp:ListItem>
                                        <asp:ListItem Value="13">13:00</asp:ListItem>
                                        <asp:ListItem Value="14">14:00</asp:ListItem>
                                        <asp:ListItem Value="15">15:00</asp:ListItem>
                                        <asp:ListItem Value="16">16:00</asp:ListItem>
                                        <asp:ListItem Value="17">17:00</asp:ListItem>
                                        <asp:ListItem Value="18">18:00</asp:ListItem>
                                        <asp:ListItem Value="19">19:00</asp:ListItem>
                                        <asp:ListItem Value="20">20:00</asp:ListItem>
                                        <asp:ListItem Value="21">21:00</asp:ListItem>
                                        <asp:ListItem Value="22">22:00</asp:ListItem>
                                        <asp:ListItem Value="23">23:00</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Button ID="b_crear_fecha_hora" runat="server" OnClick="b_crear_fecha_hora_Click" Text="crear_fecha_hora" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
            <td>
                <asp:GridView ID="GridView1" runat="server" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="fecha" HeaderText="fecha" />
                        <asp:BoundField DataField="hora_inicio" HeaderText="hora_inicio" />
                        <asp:BoundField DataField="hora_fin" HeaderText="hora_fin" />
                        <asp:CommandField ShowEditButton="True" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="obtenerfechas_horasTodos" TypeName="DAOUsuario" UpdateMethod="Updatefechas_horas">
                    <UpdateParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="Fecha" Type="DateTime" />
                        <asp:Parameter Name="Hora_inicio" Type="Int32" />
                        <asp:Parameter Name="Hora_fin" Type="Int32" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

