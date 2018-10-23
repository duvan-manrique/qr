<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="~/Controller/VigilanteApartarCupo1.aspx.cs" Inherits="View_VigilanteApartarCupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">

        .auto-style11 {
            width: 361px;
            height: 181px;
        }
        .auto-style14 {
            text-align: left;
            width: 571px;
        }
        .auto-style13 {
            text-align: left;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <form id="form2" runat="server">
        <div>
            <table class="auto-style1" border="0">
                <tr>
                    <td class="auto-style9" style="background-color: #D9FFFA">
                        <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                    <td style="background-color: #D9FFFA">
                        <!-- clock widget start -->
<script type="text/javascript"> var css_file=document.createElement("link"); css_file.setAttribute("rel","stylesheet"); css_file.setAttribute("type","text/css"); css_file.setAttribute("href","//s.bookcdn.com//css/cl/bw-cl-126el.css"); document.getElementsByTagName("head")[0].appendChild(css_file); </script> 
                        <div id="tw_7_592195774">
                            <div style="width:126px; height:82px; margin: 0 auto;">
                                <a href="http://hotelmix.es/time/bogota-18970">Bogotá</a><br/>
                            </div>
                        </div>
                        <script type="text/javascript"> function setWidgetData_592195774(data){ if(typeof(data) != 'undefined' && data.results.length > 0) { for(var i = 0; i < data.results.length; ++i) { var objMainBlock = ''; var params = data.results[i]; objMainBlock = document.getElementById('tw_'+params.widget_type+'_'+params.widget_id); if(objMainBlock !== null) objMainBlock.innerHTML = params.html_code; } } } var clock_timer_592195774 = -1; </script> <script type="text/javascript" charset="UTF-8" src="https://widgets.booked.net/time/info?ver=2&domid=582&type=7&id=592195774&scode=124&city_id=18970&wlangid=4&mode=1&details=0&background=ffffff&color=08488d&add_background=ffffff&add_color=00faff&head_color=333333&border=0&transparent=0"></script>
<!-- clock widget end -->

                    </td>
            <table class="auto-style1" border="0">
                <tr>
                    <td style="background-color: #D9FFFA; color: #009900;" class="auto-style14">
                        <br />Nombre<asp:TextBox ID="TB_Nombre" runat="server"></asp:TextBox>
                        <br />
                        <br />Apellido<asp:TextBox ID="TB_Apellido" runat="server"></asp:TextBox>
                        <br />
                        <br />Codigo identificacion universitaria<asp:TextBox ID="TB_CodigoUniversitario" runat="server"></asp:TextBox>
                        <br />
                        <br />Celular<asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
                        <br />
                        <br />Correo<asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
                        <br />
                        <br />Codigo de identificacion<asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                        <br />
                        <br /></td>
                    <td style="background-color: #D9FFFA; color: #009900;" class="auto-style13">
                        <table class="auto-style1">
                            <tr>
                                <td>Tipo de vehiculo</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList1" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td>hora final</td>
                                <td>
                                    <asp:DropDownList ID="DropDownList2" runat="server">
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td colspan="2">
                                    <asp:Button ID="B_ApartarCupo" runat="server" BackColor="#009900" BorderColor="#009900" ForeColor="White" Text="Asignar cupo e imprimir QR" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
                        &nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #D9FFFA">&nbsp;</td>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</asp:Content>

