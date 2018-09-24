<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePwd.aspx.cs" Inherits="E_Recruitment.ChangePwd" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 95%;
        }
        .auto-style2 {
            width: 143px;
        }
        .auto-style3 {
            width: 143px;
            height: 40px;
        }
        .auto-style4 {
            height: 40px;
        }
        .auto-style5 {
            width: 143px;
            height: 42px;
        }
        .auto-style6 {
            height: 42px;
        }
        .auto-style7 {
            width: 143px;
            height: 36px;
        }
        .auto-style8 {
            height: 36px;
        }
        #form1 {
            width: 773px;
        }
    </style>
</head>
<body style="margin-left: 190px; margin-top: 103px">
    <form id="form1" runat="server">
    <div>
    
    </div>
         <fieldset style="background-color:beige; width: 574px; height: 199px;">
        <legend style="width: 135px"><b>Change Password</b></legend>
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="LblOldPass" runat="server" Text="Old Password :"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TxtOldPass" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="RfvOldPass" runat="server" ControlToValidate="TxtOldPass" ErrorMessage="Please enter Old Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="LblNewPass" runat="server" Text="New Password :"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="TxtNewPass" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvNewPass" runat="server" ControlToValidate="TxtNewPass" ErrorMessage="Please enter New Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="LblConfirmPass" runat="server" Text="Confirm Password :"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:TextBox ID="TxtConfirmPass" runat="server" TextMode="Password"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:RequiredFieldValidator ID="rfvConfirmPass" runat="server" ControlToValidate="TxtConfirmPass" ErrorMessage="Please enter Confirm Password" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;&nbsp; &nbsp;</td>
                <td>
                    <asp:Button ID="BtnChange" runat="server" OnClick="BtnChange_Click" style="margin-left: 0px" Text="Change" Width="75px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnReset" runat="server" OnClick="BtnReset_Click" style="margin-left: 0px" Text="Reset" Width="75px" />
                </td>
            </tr>
        </table>
    
     </fieldset>
        </form>
</body>
</html>
