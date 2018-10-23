<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/VerParquedero1.aspx.cs" Inherits="View_VerParquedero" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style12 {
            width: 230px;
        }
        .auto-style11 {
            width: 357px;
            height: 104px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style8" style="background-color: #D9FFFA">
                        <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA">
                        <table class="auto-style1">
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">&nbsp;</td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td>&nbsp;</td>
                                <td class="auto-style12">
                                    <asp:GridView ID="GV_VerParquedero" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" ShowFooter="True">
                                        <AlternatingRowStyle BackColor="White" />
                                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                                        <SortedDescendingHeaderStyle BackColor="#820000" />
                                    </asp:GridView>
                                </td>
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
</asp:Content>

