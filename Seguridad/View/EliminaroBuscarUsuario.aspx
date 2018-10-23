<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/EliminaroBuscarUsuario.aspx.cs" Inherits="View_EliminaroBuscarUsuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">


        .auto-style1 {
            width: 100%;
        }
        .auto-style8 {
            text-align: center;
        }
        .auto-style3 {
            width: 525px;
            height: 120px;
        }
        .auto-style11 {
            width: 250px;
            height: 101px;
            float: right;
        }
        .auto-style12 {
            width: 200px;
        }
        .auto-style13 {
            text-align: left;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" border="0">
      
                <tr>
                    <td class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <img alt="" class="auto-style3" src="../Imagenes/LOGO.png" /></td>
                </tr>
                <tr>
                    <td class="auto-style8" style="background-color: #D9FFFA">
                        <table class="auto-style1">
                            <tr>
                                <td>
                                    <table class="auto-style1">
                                        <tr>
                                            <td>codigo de usuario</td>
                                            <td class="auto-style13">
                                                <asp:TextBox ID="TB_Usuario" runat="server"></asp:TextBox>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                &nbsp;</td>
                                            <td class="auto-style13">
                        <asp:Button ID="B_Buscar" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Buscar" />
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                                <td>
                        <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                            </tr>
                            <tr>
                                <td class="auto-style8" colspan="2">&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">
                                    <asp:GridView ID="GV_Usuario" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ObjectDataSource2" OnSelectedIndexChanged="GV_Usuario_SelectedIndexChanged">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                            <asp:BoundField DataField="user_name" HeaderText="User_name" />
                                            <asp:BoundField DataField="clave" HeaderText="Clave" />
                                            <asp:BoundField DataField="correo" HeaderText="Correo" />
                                            <asp:BoundField DataField="rol_id" HeaderText="Rol_id" />
                                            <asp:BoundField DataField="codigo" HeaderText="Codigo" />
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
                                    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" DeleteMethod="EliminarUsuario" SelectMethod="obtenerUsuariosTodos" TypeName="DAOUsuario" UpdateMethod="UpdateUsuario">
                                        <DeleteParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                        </DeleteParameters>
                                        <UpdateParameters>
                                            <asp:Parameter Name="id" Type="Int32" />
                                            <asp:Parameter Name="Nombre" Type="String" />
                                            <asp:Parameter Name="User_name" Type="String" />
                                            <asp:Parameter Name="Clave" Type="String" />
                                            <asp:Parameter Name="Correo" Type="String" />
                                            <asp:Parameter Name="Rol_id" Type="Int32" />
                                            <asp:Parameter Name="Codigo" Type="Int64" />
                                        </UpdateParameters>
                                    </asp:ObjectDataSource>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
