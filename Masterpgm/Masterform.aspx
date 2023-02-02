<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Masterform.aspx.cs" Inherits="Masterpgm.Masterform" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>
        <title>Master Page </title>
<asp:ContentPlaceHolder ID="head" runat="server">
        This is Master Page Header
</asp:ContentPlaceHolder>
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" Height="25px" style="margin-left: 49px" Width="294px"></asp:TextBox>
&nbsp;<br />
        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="23px" style="margin-left: 58px" Width="298px"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email ID"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox4" runat="server" Height="26px" OnTextChanged="TextBox4_TextChanged" style="margin-left: 28px" Width="301px"></asp:TextBox>
        <p>
            <asp:Label ID="Label4" runat="server" Text="PWD"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged" style="margin-left: 73px" Width="304px"></asp:TextBox>
        </p>
        <p>
            Confirm Password<asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox5_TextChanged" style="margin-left: 25px" Width="305px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
