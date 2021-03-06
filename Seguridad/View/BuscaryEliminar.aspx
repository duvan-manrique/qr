﻿<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/BuscaryEliminar1.aspx.cs" Inherits="View_BuscaryEliminar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 555px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style22 {
            font-family: Arial;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
          
                             
                        <table class="auto-style1">
                            <tr>
                                <td colspan="2" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;"><span class="auto-style22"><strong style="color: #009900">Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server" ForeColor="#009900"></asp:Label>
                        </strong></span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                            </tr>
                            <tr>
                                <td colspan="2" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                                <td style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                                    <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="257px" DataKeyNames="id">
                                        <AlternatingRowStyle BackColor="White" />
                                        <Columns>
                                            <asp:TemplateField HeaderText="Nombre">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("nombre") %>'></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator539" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator156844" runat="server" ControlToValidate="TextBox1" ErrorMessage="ingrese solo letras" ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ ,.]*"></asp:RegularExpressionValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label2" runat="server" Text='<%# Bind("nombre") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Tipo_vehiculo">
                                                <EditItemTemplate>
                                                    <asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("tipo") %>'>
                                                        <asp:ListItem Value="moto">moto</asp:ListItem>
                                                        <asp:ListItem Value="carro">carro</asp:ListItem>
                                                        <asp:ListItem Value="cicla">cicla</asp:ListItem>
                                                    </asp:DropDownList>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label1" runat="server" Text='<%# Bind("tipo") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                            <asp:TemplateField HeaderText="Numero_de_campos">
                                                <EditItemTemplate>
                                                    <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("numero_de_campos") %>' TextMode="Number"></asp:TextBox>
                                                    <strong style="font-family: 'Bahnschrift SemiBold'">
                                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3489611" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                                    </strong>
                                                    <strong>
                                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="no puede ser mas de 2 digitos" ValidationExpression="^([0-9]{1,2})$"></asp:RegularExpressionValidator>
                                                    </strong>
                                                </EditItemTemplate>
                                                <ItemTemplate>
                                                    <asp:Label ID="Label3" runat="server" Text='<%# Bind("numero_de_campos") %>'></asp:Label>
                                                </ItemTemplate>
                                            </asp:TemplateField>
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
                                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style12" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                                    &nbsp;</td>
                                <td style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style12" style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
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
                                <td style="background-image: url('../Imagenes/facatativa.jpg'); background-color: #FFFFFF; background-repeat: repeat; background-attachment: inherit;">
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    
                    </td>
                </tr>
            </table>
      
</asp:Content>

