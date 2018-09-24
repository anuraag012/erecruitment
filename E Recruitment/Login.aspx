<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="E_Recruitment.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 114px;
            height: 33px;
        }
        .auto-style3 {
            width: 114px;
            height: 46px;
        }
        .auto-style4 {
            height: 46px;
        }
        .auto-style5 {
            height: 33px;
        }
        .auto-style6 {
            width: 569px;
            height: 98px;
        }
    </style>
</head>
<body style="width: 516px; height: 193px; margin-left: 218px; margin-top: 164px">
    <form id="form1" runat="server">

         <fieldset style="background-color:beige">
        <legend><b>Login Here</b></legend>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="lblUser" runat="server" Text="Username :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtUser" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvUsername" runat="server" ControlToValidate="TxtUser" ErrorMessage="Please enter Username" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="lblPass" runat="server" Text="Password :"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvPassword" runat="server" ControlToValidate="TxtPass" ErrorMessage="Please enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnLogin" runat="server" OnClick="BtnLogin_Click" Text="Login" Width="83px" />
    
    </div>
             </fieldset>
    </form>
</body>
</html>
