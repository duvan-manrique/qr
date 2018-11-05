<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="EditarUsuario.aspx.cs" Inherits="View_EditarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 170px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style13 {
            text-align: right;
            width: 170px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style14 {
            text-align: left;
            height: 128px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
   
        <div style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style12" style="color: #008000">
                        <span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">
                        <br />
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td class="auto-style14">
                        <br />
                        <br />
                        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                            <AlternatingRowStyle BackColor="White" />
                            <Columns>
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="user_name" HeaderText="user_name" />
                                <asp:BoundField DataField="clave" HeaderText="clave" />
                                <asp:BoundField DataField="correo" HeaderText="Correo" />
                                <asp:CommandField ShowEditButton="True" />
                                <asp:BoundField DataField="id" HeaderText="id" />
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
                        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" OnSelecting="ObjectDataSource1_Selecting" SelectMethod="obteneryo" TypeName="DAOUsuario" UpdateMethod="UpdateUsuarioyo">
                            <SelectParameters>
                                <asp:SessionParameter DefaultValue="" Name="filtro" SessionField="user_id" Type="Int32" />
                            </SelectParameters>
                            <UpdateParameters>
                                <asp:Parameter Name="id" Type="Int32" />
                                <asp:Parameter Name="Nombre" Type="String" />
                                <asp:Parameter Name="User_name" Type="String" />
                                <asp:Parameter Name="Clave" Type="String" />
                                <asp:Parameter Name="Correo" Type="String" />
                            </UpdateParameters>
                        </asp:ObjectDataSource>
                        <br />
                        <br />
                        <br />
                        <br />
                    </td>
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

