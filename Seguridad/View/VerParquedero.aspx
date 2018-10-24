<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/VerParquedero1.aspx.cs" Inherits="View_VerParquedero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 230px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td style="background-color: #D9FFFA">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                                <td class="auto-style12">
                                    <asp:GridView ID="GV_VerParquedero" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="numero" HeaderText="numero" />
                                            <asp:BoundField DataField="zona_id" HeaderText="zona_id" />
                                            <asp:BoundField DataField="estado" HeaderText="estado" />
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
                                    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="obtenerParqueaderoTodos" TypeName="DAOUsuario"></asp:ObjectDataSource>
                                </td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
   
</asp:Content>

