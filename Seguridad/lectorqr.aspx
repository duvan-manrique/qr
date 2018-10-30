<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lectorqr.aspx.cs" Inherits="Prestamos.lectorqr" CodeFile="~/lectorqr.aspx.cs" %>

<!DOCTYPE html>
<script runat="server">


  
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">

        .auto-style8 {
            text-align: center;
        }
        .auto-style3 {
            width: 50%;
        }
        .auto-style5 {
            width: 521px;
        }
        .auto-style1 {
            width: 95%;
            height: 356px;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style12 {
            text-align: center;
            height: 254px;
        }
        .auto-style13 {
            height: 26px;
        }
        .auto-style14 {
            width: 521px;
            height: 26px;
        }
        .auto-style15 {
            width: 521px;
            text-align: right;
        }
        </style>
</head>
<script src="js/jquery-1.9.1.min.js"></script>
<script src="js/html5-qrcode.min.js"></script>
<body>
    <form id="form1" runat="server">

    <script>
        $(document).ready(function () {
            $('#reader').html5_qrcode(function (data) {
                debugger;
                $('#<%=txtCodigo1.ClientID%>').val(data);
                document.getElementById('<%=txtCodigo.ClientID%>').innerHTML = " listo";
            },
                function (error) {
                   
                }, function (videoError) {
                    alert("No hay cámara");
                }
            );
        });
    </script>
        
        <table class="auto-style1" border="0">
      
                <tr>
                    <td colspan="2" class="auto-style8">&nbsp;
                        <img alt="" class="auto-style3" src="Imagenes/LOGO.png" /></td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA">&nbsp;</td>
                    <td class="auto-style5" style="background-color: #D9FFFA">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style12" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
                                <img alt="" class="auto-style11" src="Imagenes/article.jpg" /></td>
                    <td class="auto-style12" style="background-color: #D9FFFA; font-family: 'Arial Rounded MT Bold'; color: #800000;">
    <div id="reader" style="width:300px; height:250px">
        <p>
           Datos del Código QR:
            </p>

                        <asp:Label ID="txtCodigo" runat="server" Text="Esperando"></asp:Label>

        <br />
        </div>

                    </td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA" class="auto-style13">
                        <br />
                    </td>
                    <td class="auto-style14" style="background-color: #D9FFFA">
            <asp:TextBox ID="txtCodigo1" runat="server" Width="0px" BackColor="#D9FFFA" BorderColor="#D9FFFA" ForeColor="#D9FFFA"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="background-color: #D9FFFA">
                        &nbsp;</td>
                    <td class="auto-style15" style="background-color: #D9FFFA">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="verificar" />
                    </td>
                </tr>
            </table>
        
    </form>
    </body>
</html>
