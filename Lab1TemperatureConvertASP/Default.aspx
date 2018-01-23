<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Lab1TemperatureConvertASP.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
    <style type="text/css">



    /*
        ------------------------------------
        TEMPERATURE CONVERTER (Lab1)(ASP.NET)
        Dean Jones
        Jan.12, 2017
        ------------------------------------
    */





    </style>
    <link href="Styles.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <header><h2>Temperature Converter</h2></header>
        <main>

    <p>
        <img alt="temperature.jpg" class="auto-style1" longdesc="temperature.jpg" src="images/temperature.jpg" /></p>
    <table class="auto-style2">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="From:"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="To:"></asp:Label>
            </td>
            <td></td>
        </tr>
        <tr>
            <td>
                <asp:DropDownList ID="cboTempFrom" runat="server" Height="16px" Width="142px" OnSelectedIndexChanged="cboTempFrom_SelectedIndexChanged">
                    <asp:ListItem Value="Celsius">Celsius</asp:ListItem>
                    <asp:ListItem>Farenheit</asp:ListItem>
                    <asp:ListItem>Kelvin</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="cboTempTo" runat="server" Height="16px" Width="142px" OnSelectedIndexChanged="cboTempTo_SelectedIndexChanged">
                    <asp:ListItem Value="Celsius">Celsius</asp:ListItem>
                    <asp:ListItem>Farenheit</asp:ListItem>
                    <asp:ListItem>Kelvin</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="txtTempFrom" runat="server" Width="138px" OnTextChanged="txtTempFrom_TextChanged"></asp:TextBox>
            </td>
            <td>
                <asp:TextBox ID="txtTempTo" runat="server" Width="138px" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTempFrom" Display="Dynamic" ErrorMessage="This FROM input needs to be a number" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtTempFrom" Display="Dynamic" ErrorMessage="Enter a value between -1000...1000" ForeColor="Red" MaximumValue="1000" MinimumValue="-1000" Type="Double"></asp:RangeValidator>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnConvert" runat="server" Text="Convert" Width="107px" OnClick="btnConvert_Click" />
            </td>
            <td>
                <asp:Button ID="btnClear" runat="server" Text="Clear" Width="107px" CausesValidation="False" OnClick="btnClear_Click" />
            </td>
            <td></td>
        </tr>
    </table>
            </main>
        <footer>Dean Jones - Lab1 - Jan.12, 2017</footer>
    </form>
    </body>
</html>
