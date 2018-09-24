<%@ Page Title="" Language="C#" MasterPageFile="~/Master2_UnitHead.Master" AutoEventWireup="true" CodeBehind="ContactUs_UnitHead.aspx.cs" Inherits="E_Recruitment.ContactUs_UnitHead" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            height: 45px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <table align="center">
    <asp:Panel ID="Panel1" HorizontalAlign="Center" runat="server" BackColor="#CC3300" ForeColor="White">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Contact Us</asp:Panel>

</table>
    <table border = "0" style="width: 409px" align="center">
    <tr>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" Text="Name*"></asp:Label><br />
        </td>
        <td class="auto-style2">
            <asp:TextBox ID="txtName" runat="server" ValidationGroup = "contact"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*"
             ControlToValidate = "txtName" ValidationGroup="send"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label2" runat="server" Text="Subject*"></asp:Label><br />
        </td>
        <td>
            <asp:TextBox ID="txtSubject" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*"
             ControlToValidate = "txtSubject" ValidationGroup="send"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="Label3" runat="server" Text="Email*"></asp:Label><br />
        </td>
        <td>
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox><br />
            <asp:RegularExpressionValidator id="valRegEx" runat="server"
            ControlToValidate="txtEmail"
            ValidationExpression=".*@.*\..*"
            ErrorMessage="*Invalid Email address."
            display="dynamic" >
            </asp:RegularExpressionValidator>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*"
            ControlToValidate = "txtEmail" ValidationGroup="send"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td valign = "top" class="auto-style3" >
            <asp:Label ID="Label4" runat="server" Text="Body*"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:TextBox ID="txtBody" runat="server" TextMode = "MultiLine" ></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*"
            ControlToValidate = "txtBody" ValidationGroup="send"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td></td>
        <td>
            <asp:Button ID="btnSend" runat="server" Text="Send" OnClick="btnSend_Click"  ValidationGroup="send"/>
       </td>
    </tr>
    <tr>
        <td></td>
        
    </tr>
</table>
</asp:Content>
