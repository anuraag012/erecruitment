<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" Theme="Theme1" StylesheetTheme="Theme1" CodeBehind="EditEmployeeDetails.aspx.cs" Inherits="E_Recruitment.EditEmployeeDetails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            height: 364px;
            margin-top: 0px;
        margin-left: 222px;
            width: 706px;
        }
        .auto-style5 {
            height: 43px;
        width: 22%;
    }
        .auto-style6 {
            height: 47px;
        width: 22%;
    }
    .auto-style7 {
        height: 11px;
        width: 22%;
    }
    .auto-style8 {
        margin-top: 0px;
        width: 52%;
            height: 25px;
        }
    .auto-style9 {
        height: 11px;
        width: 52%;
    }
    .auto-style10 {
        height: 47px;
        width: 52%;
    }
    .auto-style11 {
        height: 43px;
        width: 52%;
    }
    .auto-style13 {
        margin-top: 0px;
        width: 22%;
            height: 25px;
        }
        .auto-style15 {
            height: 45px;
            width: 22%;
        }
        .auto-style16 {
            height: 45px;
            width: 52%;
        }
        .auto-style20 {
            height: 2px;
            width: 22%;
        }
        .auto-style21 {
            height: 2px;
            width: 52%;
        }
        .auto-style22 {
            height: 19px;
            width: 15%;
        }
        .auto-style23 {
            height: 19px;
            width: 22%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:906px; margin-left: 106px; margin-top: 10px; height:445px;">
        <legend style="width: 202px"><b>EDIT EMPLOYEE DETAILS</b></legend>

        <br />
      
       
       
    <div>
    
        <table align="CENTER" class="auto-style4">
           
            <tr>
                <td class="auto-style13">
                    <asp:Label ID="LblEmpID1" runat="server" Text="Employee ID"></asp:Label>
                </td>
                <td class="auto-style8">
                    <asp:DropDownList ID="ddlEmpID" runat="server" Height="19px" Width="117px">
                    </asp:DropDownList>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="BtnSubmit" runat="server" style="margin-left: 0px" Text="Submit" OnClick="BtnSubmit_Click" ValidationGroup="Submit" />
                    <asp:RequiredFieldValidator ID="rfvempid" runat="server" ControlToValidate="ddlEmpID" ErrorMessage="Please select Employee ID" ForeColor="#FF3300" InitialValue="--Select--" ValidationGroup="Submit"></asp:RequiredFieldValidator>
                    <br />
&nbsp;&nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="LblEmpID" runat="server" Text="Employee ID" Visible="False"></asp:Label>
                </td>
                <td class="auto-style9">
                    <asp:TextBox ID="txtEmpID" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="LblEmpName" runat="server" Text="Employee Name" Visible="False"></asp:Label>
                </td>
                <td class="auto-style10">
                    <asp:TextBox ID="txtEmpName" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="LblDesgn" runat="server" Text="Designation" Visible="False"></asp:Label>
                </td>
                <td class="auto-style11">
                    <asp:TextBox ID="txtdesignation" runat="server" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvdesignation" runat="server" ControlToValidate="txtdesignation" ErrorMessage="Please enter Designation" ForeColor="#FF3300" Display="Dynamic" Visible="False" ValidationGroup="Update"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="redesignation" runat="server" ControlToValidate="txtdesignation" ErrorMessage="Please avoid digits" ForeColor="#FF3300" ValidationExpression="^[a-z A-Z]{1,50}$" Display="Dynamic" ValidationGroup="Update"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style15">
                    <asp:Label ID="LblCTC" runat="server" Text="CTC" Visible="False"></asp:Label>
                </td>
                <td class="auto-style16">
                    <asp:TextBox ID="txtctc" runat="server" Visible="False"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvctc" runat="server" ControlToValidate="txtctc" ErrorMessage="Please enter CTC" ForeColor="#FF3300" Display="Dynamic" Visible="False" ValidationGroup="Update"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="rectc" runat="server" ControlToValidate="txtctc" ErrorMessage="Please enter only digits" ForeColor="#FF3300" ValidationExpression="^[0-9]{4,8}$" Display="Dynamic" ValidationGroup="Update"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style20">
                    <asp:Label ID="LblUnitHeadID" runat="server" Text="Unit Head ID" Visible="False"></asp:Label>
                </td>
                <td class="auto-style21">
                    <asp:TextBox ID="txtUnitHead" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style23">&nbsp;<asp:Button ID="BtnUpdate" runat="server" OnClick="BtnUpdate_Click" Text="Update" style="margin-left: 86px" Visible="False" ValidationGroup="Update" />
                    &nbsp;</td>
                <td class="auto-style22">
                    <asp:Button ID="BtnCancel" runat="server" Text="Cancel" style="margin-left: 9px" Visible="False" OnClick="BtnCancel_Click" Width="84px" />
                </td>
            </tr>
        </table>
    
    </div>
    
    </fieldset>
</asp:Content>
