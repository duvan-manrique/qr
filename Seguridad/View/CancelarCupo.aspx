<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="CancelarCupo.aspx.cs" Inherits="View_CancelarCupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 194px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style13 {
            text-align: right;
            width: 194px;
        }
        .auto-style11 {
            width: 337px;
            height: 190px;
            float: left;
        }
        .auto-style14 {
            text-align: left;
            height: 128px;
        }
        .auto-style23 {
            margin-left: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
        <table class="auto-style1" border="0">
            <tr>
                <td class="auto-style12" style="color: #008000">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12" style="color: #008000"><span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                    </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <br />
                    <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                <td class="auto-style14">
                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" CssClass="auto-style23" ForeColor="#333333" GridLines="None" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" DataKeyNames="id">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="fecha_inicio" HeaderText="fecha_inicio" />
                            <asp:BoundField DataField="fecha_fin" HeaderText="fecha_fin" />
                            <asp:BoundField DataField="descripcion" HeaderText="descripcion" />
                            <asp:BoundField DataField="marca" HeaderText="marca" />
                            <asp:BoundField DataField="placa" HeaderText="placa" />
                            <asp:BoundField DataField="tipo" HeaderText="tipo" />
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
                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="EliminarReserva" SelectMethod="obtenereservacionyo" TypeName="DAOUsuario">
                        <DeleteParameters>
                            <asp:Parameter Name="id" Type="Int32" />
                        </DeleteParameters>
                        <SelectParameters>
                            <asp:SessionParameter Name="id" SessionField="user_id" Type="Int32" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br /></td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </div>
</asp:Content>

