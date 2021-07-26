<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="Esercizio_Utilizzo_Wcf.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 31px;
        }
        .auto-style3 {
            text-align: center;
        }
        .auto-style4 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            Conversione<br />
            <table class="auto-style1">
                <tr>
                    <td>Importo in km</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Importo in Miglia<br />
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txt_Miglia" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="btn_Converti" runat="server" Text="Converti" OnClick="btn_Converti_Click" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                    </td>
                </tr>
            </table>
            <br />
        </div>
    </form>
</body>
</html>
