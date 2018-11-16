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
        .auto-style12 {
            width: 200px;
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
            text-align: right;
            width: 871px;
        }
        .auto-style24 {
            width: 871px;
        }
        .auto-style25 {
            text-align: center;
            width: 871px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1" border="0">
      
                <tr>
                    <td class="auto-style25">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <img alt="" class="auto-style3" src="../Imagenes/LOGO.png" />&nbsp; </td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
      
                <tr>
                    <td class="auto-style23"><asp:Button ID="B_Cierre" runat="server" OnClick="B_Cierre_Click" Text="Cerrar Session" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA" class="auto-style24">
                        <table class="auto-style1" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                            <tr>
                                <td>
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                                </td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                        <span class="auto-style22" style="color: #009900"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                                <td class="auto-style12">
                                    <asp:GridView ID="GV_Usuario" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="ObjectDataSource2" OnSelectedIndexChanged="GV_Usuario_SelectedIndexChanged">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="Nombre">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("nombre") %>'></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1338888" runat="server" ControlToValidate="TextBox1" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*"></asp:RegularExpressionValidator>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator33388888" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label6" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="User_name">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("user_name") %>'></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3338" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1338" runat="server" ControlToValidate="TextBox1" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*"></asp:RegularExpressionValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("user_name") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Clave">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("clave") %>' TextMode="Password"></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3488" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label5" runat="server" Text='<%# Bind("clave") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Correo">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("correo") %>' TextMode="Email"></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3695" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label4" runat="server" Text='<%# Bind("correo") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Rol">
                                                <EditItemTemplate>
                                                    <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("rol_id") %>'>
                                                        <asp:ListItem Value="3">User</asp:ListItem>
                                                        <asp:ListItem Value="2">Vigilante</asp:ListItem>
                                                        <asp:ListItem Value="1">Admin</asp:ListItem>
                                                    </asp:DropDownList>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("rol_id") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Codigo">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("codigo") %>' TextMode="Number"></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3447" runat="server" ControlToValidate="TextBox2" ErrorMessage="no puede ser mayor a 10 digitos" ValidationExpression="^([0-9]{1,10})$"></asp:RegularExpressionValidator>
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3447" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("codigo") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
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
                                            <asp:Parameter Name="rol_id" Type="Int32" />
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
                    <td style="background-color: #D9FFFA">
                        &nbsp;</td>
                </tr>
                </table>
        </div>
    </form>
</body>
</html>
