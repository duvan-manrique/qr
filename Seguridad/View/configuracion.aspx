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
            width: 447px;
        }
        .auto-style24 {
            width: 159px;
        }
        .auto-style25 {
            width: 507px;
            height: 130px;
        }
        .auto-style26 {
            height: 130px;
            width: 569px;
        }
        .auto-style27 {
            width: 507px;
            height: 46px;
        }
        .auto-style28 {
            height: 46px;
            font-family: Arial;
            text-align: right;
        }
        .auto-style29 {
            width: 569px;
        }
        .auto-style30 {
            height: 46px;
            width: 569px;
        }
        .auto-style31 {
            width: 507px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style1" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
        <tr>
            <td style="background-color: #FFFFFF;" class="auto-style31">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
            <td class="auto-style29" style="background-color: #FFFFFF">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFFFFF;" class="auto-style31">
                                <span class="auto-style22"><strong style="color: #009900">Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</strong></span></td>
            <td class="auto-style29" style="background-color: #FFFFFF">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="background-color: #FFFFFF;" class="auto-style27"><span class="auto-style22"><strong style="color: #009900">Fechas que desea bloquear</strong></span></td>
            <td style="background-color: #FFFFFF;" class="auto-style30">
                <span class="auto-style22"><strong style="color: #009900">horario de atencion</strong></span>&nbsp;</td>
            <td class="auto-style28">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style25" style="background-color: #FFFFFF">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style22" style="color: #009900"><strong>fecha</td>
                        <td>
                            <asp:TextBox ID="tb_fecha0" runat="server" TextMode="Date" OnTextChanged="tb_fecha0_TextChanged"></asp:TextBox>
                            <strong style="font-family: 'Bahnschrift SemiBold'">
                <asp:Label ID="LB_u_n" runat="server" Text="fecha ya bloqueada" Visible="False"></asp:Label>
                        &nbsp;<asp:Label ID="LB_uk" runat="server" Text="fecha tiene horario de atencion" Visible="False"></asp:Label>
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
            <td class="auto-style26" style="background-color: #FFFFFF">
                <table class="auto-style1">
                    <tr>
                        <td class="auto-style22" style="color: #009900; background-color: #FFFFFF;"><strong>fecha</td>
                        <td>
                            <asp:TextBox ID="tb_fecha" runat="server" TextMode="Date" OnTextChanged="tb_fecha_TextChanged"></asp:TextBox>
                            <strong style="font-family: 'Bahnschrift SemiBold'">
                <asp:Label ID="LB_u_nn0" runat="server" Text="fecha ya creada" Visible="False"></asp:Label>
                <asp:Label ID="LB_u_nn1" runat="server" Text="fecha esta bloqueada " Visible="False"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style22" style="color: #009900; background-color: #FFFFFF;"><strong>hora inicio</td>
                        <td>
                                    <asp:TextBox ID="TB_hora_inicio" runat="server" TextMode="Time" Height="22px" OnTextChanged="TB_hora_inicio_TextChanged"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td class="auto-style22" style="color: #009900; background-color: #FFFFFF;"><strong>hora fin</td>
                        <td>
                                    <asp:TextBox ID="Tb_hora_Fin" runat="server" TextMode="Time"></asp:TextBox>
                                </td>
                    </tr>
                    <tr>
                        <td class="auto-style12">&nbsp;</td>
                        <td>
                            <asp:Button ID="b_crear_fecha_hora" runat="server" OnClick="b_crear_fecha_hora_Click" Text="crear_fecha_hora" BackColor="#009900" BorderColor="#009900" ForeColor="White" ValidationGroup="atencion" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="auto-style23" rowspan="2"><span class="auto-style22"><strong style="color: #009900">&nbsp;configuracion de valor de multas<br />
                <br />
                </strong></span>
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ObjectDataSource3">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="nombre" HeaderText="nombre" />
                            <asp:TemplateField HeaderText="valor_multa">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("valor_multa") %>' TextMode="Number"></asp:TextBox>
                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3682" runat="server" ControlToValidate="TextBox4" ErrorMessage="ingrese numero" ValidationExpression="^([0-9]{1,8})$"></asp:RegularExpressionValidator>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3682" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                    <strong>
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox4" ErrorMessage="no puede ser mas de 7 digitos" ValidationExpression="^([0-9]{1,7})$"></asp:RegularExpressionValidator>
                                    </strong></strong>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("valor_multa") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
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
                    <br />
                <asp:ObjectDataSource ID="ObjectDataSource3" runat="server" SelectMethod="obtenerMultasTodos" TypeName="DAOUsuario" UpdateMethod="UpdateValorMulta">
                    <UpdateParameters>
                        <asp:Parameter Name="id" Type="Int32" />
                        <asp:Parameter Name="Nombre" Type="String" />
                        <asp:Parameter Name="Valor_multa" Type="Double" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">
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
            <td class="auto-style29">
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
                                <asp:Label ID="Label2" runat="server" Text='<%# Bind("hora_inicio", "{0:t}") %>'></asp:Label>
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
                        <asp:BoundField DataField="limite_diario" HeaderText="limite en segundos" />
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
                        <asp:Parameter Name="limite_diario" Type="Int64" />
                    </UpdateParameters>
                </asp:ObjectDataSource>
            </td>
        </tr>
        <tr>
            <td class="auto-style31">&nbsp;</td>
            <td class="auto-style29">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style31">&nbsp;</td>
            <td class="auto-style29">
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

