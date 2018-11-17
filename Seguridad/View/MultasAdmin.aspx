<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="MultasAdmin.aspx.cs" Inherits="View_MultasUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 541px;
        }
        .auto-style22 {
            font-family: Arial;
        }
        .auto-style13 {
            text-align: right;
            width: 541px;
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
                                <asp:ImageButton ID="ImageButton1" runat="server" CausesValidation="False" Height="31px" ImageUrl="~/Plantilla/images/volver.jpg" OnClick="ImageButton1_Click" Width="30px" />
                            </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style12" style="color: #008000"><span class="auto-style22"><strong>Usuario:&nbsp;
                        <asp:Label ID="L_Nombre" runat="server"></asp:Label>
                    </strong></span>&nbsp;&nbsp;&nbsp;<br />
                <span class="auto-style22"><strong>Usuario control:&nbsp; </strong></span>&nbsp;&nbsp;&nbsp;<asp:DropDownList ID="DDL_usuarios" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DDL_usuarios_SelectedIndexChanged" style="height: 25px">
                        </asp:DropDownList>
                <asp:Button ID="B_cargar" runat="server" OnClick="B_Seleccionar_Click" Text="cargar usuarios" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                    &nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style13">
                    <br />
                    <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                <td class="auto-style14">
                    <asp:GridView ID="GV_multas" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id"   ForeColor="#333333"  GridLines="None" OnRowDeleting="GV_multas_RowDeleting">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:BoundField DataField="multa" HeaderText="valor multa" />
                            <asp:BoundField DataField="estado" HeaderText="estado" />
                            <asp:TemplateField ShowHeader="False">
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Pagar"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
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

