<%@ Page Language="C#" AutoEventWireup="true" CodeFile="~/Controller/GenerarToken.aspx.cs" Inherits="View_GenerarToken" %>

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
        .auto-style9 {
            width: 589px;
        }
        .auto-style13 {
            text-align: left;
            width: 315px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style12 {
            width: 4px;
        }
        .auto-style14 {
            width: 645px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style10 {
            text-align: center;
            width: 589px;
            font-family: "Arial Rounded MT Bold";
            color: #800000;
        }
        .auto-style11 {
            width: 439px;
            height: 209px;
            float: left;
        }
        .auto-style15 {
            width: 100%;
            height: 340px;
        }
        .auto-style16 {
            height: 392px;
        }
        .auto-style17 {
            text-align: right;
            height: 23px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style15">
                <tr>
                    <td class="auto-style16">
        <div>
            <table class="auto-style1">
                <tr>
                    <td style="font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif; color: #008000">
            <table class="auto-style1" border="0">
      
                <tr>
                    <td colspan="2" class="auto-style8">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <img alt="" class="auto-style3" src="../Imagenes/LOGO.png" /></td>
                </tr>
      
                <tr>
                    <td colspan="2" class="auto-style17"></td>
                </tr>
                <tr>
                    <td class="auto-style9" style="background-color: #FFFFFF; background-image: url('../Imagenes/facatativa.jpg'); background-repeat: repeat; background-attachment: inherit;">
                        <table class="auto-style1">
                            <tr>
                    <td class="auto-style13">
                        <asp:Label ID="L_User_Name0" runat="server" Text="Digite su User Name: "></asp:Label>
                        <asp:TextBox ID="TB_User_Name" runat="server"></asp:TextBox>
                                </td>
                                <td class="auto-style12">
                                    &nbsp;</td>
                                <td>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TB_User_Name" Display="Dynamic" ErrorMessage="no puede estar vacio"></asp:RequiredFieldValidator>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                        </table>
                        <table class="auto-style1">
                            <tr>
                    <td class="auto-style14">
                        <asp:Button ID="B_Recuperar" runat="server" OnClick="B_Recuperar_Click" Text="Recuperar" BackColor="#009900" BorderColor="#009900" ForeColor="White" />
                        <br />
                        <asp:Label ID="L_Mensaje" runat="server"></asp:Label>
                                </td>
                    <td class="auto-style10">
                        &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                    <td style="background-color: #FFFFFF; background-image: url('../Imagenes/facatativa.jpg'); background-repeat: repeat; background-attachment: inherit;">
                                <img alt="" class="auto-style11" src="../Imagenes/article.jpg" /></td>
                </tr>
                </table>
                    </td>
                </tr>
                </table>
        </div>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
