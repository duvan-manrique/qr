<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="configuracion.aspx.cs" Inherits="View_configuracion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style12 {
            width: 163px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style23 {
            width: 488px;
        }
        .auto-style24 {
            width: 159px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
        <tr>
            <td style="color: #009900" class="auto-style23">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: #009900" class="auto-style23">
                                <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong></span></td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="color: #009900" class="auto-style23"><span class="auto-style22"><strong>Fechas que desea bloquear</strong></span></td>
            <td style="color: #009900">
                <span class="auto-style22"><strong>horario de atencion</strong></span>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style22" style="color: #009900"><strong>fecha</td>
                        <td>
                            <asp:TextBox ID="tb_fecha0" runat="server" TextMode="Date" OnTextChanged="tb_fecha0_TextChanged"></asp:TextBox>
                            <strong style="font-family: 'Bahnschrift SemiBold'">
                <asp:Label ID="LB_u_n" runat="server" Text="fecha ya bloqueada" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                                    &nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                                    &nbsp;</td>
                    </tr>
                    <tr>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Button ID="b_crear_fecha_hora0" runat="server" OnClick="b_bloquear_fecha_hora_Click" Text="bloquear_fecha_hora" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style22" style="color: #009900"><strong>fecha</td>
                        <td>
                            <asp:TextBox ID="tb_fecha" runat="server" TextMode="Date" OnTextChanged="tb_fecha_TextChanged"></asp:TextBox>
                            <strong style="font-family: 'Bahnschrift SemiBold'">
                <asp:Label ID="LB_u_nn0" runat="server" Text="fecha ya creada" Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style22" style="color: #009900"><strong>hora inicio</td>
                        <td>
                                    <asp:TextBox ID="TB_hora_inicio" runat="server" TextMode="Time" Height="22px" OnTextChanged="TB_hora_inicio_TextChanged"></asp:TextBox>
                            <strong style="font-family: 'Bahnschrift SemiBold'">
                <asp:Label ID="LB_u_nn1" runat="server" Text="hora ya creada" Visible="False"></asp:Label>
                                </td>
                    </tr>
                    <tr>
                        <td class="auto-style22" style="color: #009900"><strong>hora fin</td>
                        <td>
                                    <asp:TextBox ID="Tb_hora_Fin" runat="server" TextMode="Time"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Button ID="b_crear_fecha_hora" runat="server" OnClick="b_crear_fecha_hora_Click" Text="crear_fecha_hora" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                        </td>
                    </tr>
                </table>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23">
                                <table class="auto-style1">
                                    <tr>
                                        <td class="auto-style24">&nbsp;</td>
                                        <td>
                                            <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="ObjectDataSource2" ForeColor="#333333" GridLines="None">
                                                <AlternatingRowStyle BackColor="White" />
                                                <Columns>
                                                    <asp:BoundField DataField="fecha" DataFormatString="&quot;{0:d}&quot;" HeaderText="fecha" />
                                                    <asp:CommandField ShowDeleteButton="True" />
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
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style24">&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                                <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="EliminarFecha_bloqueadas" SelectMethod="obtenerfechas_horas_bloqueadasTodos" TypeName="DAOUsuario">
                                    <DeleteParameters>
                                        <asp:Parameter Name="id" Type="Int32" />
                                    </DeleteParameters>
                                </asp:ObjectDataSource>
            </td>
            <td>
                <asp:GridView ID="GridView2" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Height="239px" Width="456px">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:TemplateField HeaderText="fecha">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("fecha", "{0:d}") %>' TextMode="Date"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("fecha", "{0:d}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="hora_inicio">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("hora_inicio", "{0:t}") %>' TextMode="Time"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("hora_inicio", "{0:t}") %>'> </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="hora_fin">
                            <EditItemTemplate>
                                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("hora_fin", "{0:t}") %>' TextMode="Time"></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label3" runat="server" Text='<%# Bind("hora_fin", "{0:t}") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />
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
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="EliminarFecha" SelectMethod="obtenerfechas_horasTodos" TypeName="DAOUsuario" UpdateMethod="Updatefechas_horas">
                    <DeleteParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                    </DeleteParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="Fecha" Type="DateTime" />
                        <asp:Parameter Name="Hora_inicio" DbType="Time" />
                        <asp:Parameter Name="Hora_fin" DbType="Time" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style23">&nbsp;</td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

