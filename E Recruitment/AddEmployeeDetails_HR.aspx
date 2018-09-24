<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" StylesheetTheme="Theme1" theme="Theme1" CodeBehind="AddEmployeeDetails_HR.aspx.cs" Inherits="E_Recruitment.AddEmployeeDetails_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:965px; margin-left: 32px; margin-top: 10px; height:536px;">
        <legend><b>Add New Employee Details</b></legend>
        <asp:Table ID="Table1" runat="server" Width="723px" HorizontalAlign="Center" style="margin-left: 204px" Height="460px" >
            <asp:TableRow runat="server">
        <asp:TableCell runat="server">
              </asp:TableCell>
                <asp:TableCell>
            <asp:Label ID="Label2" runat="server" Text="All" ></asp:Label>
                  <asp:Label ID="lbl1" runat="server" Text="*" ForeColor="Red"></asp:Label>
                 <asp:Label ID="Label1" runat="server" Text="indicated fields are mandatory" ></asp:Label>
            </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            <asp:HiddenField ID="hdnCandID" runat="server" />
                <asp:Label ID="lblempname" runat="server" Text="Employee Name:"></asp:Label>
               <%-- <asp:Label ID="lbl1" runat="server" Text="*" ForeColor="Red"></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox runat="server" ID="txtempname" ReadOnly="true"></asp:TextBox>
           <%--<asp:Label ID="lblempname1" runat="server" ></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
            
               
            </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                 <asp:Label ID="lbldob" runat="server" Text="Date Of Birth:"></asp:Label>
               
            </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox runat="server" ID="txtdob" ReadOnly="true"></asp:TextBox>
                <%--<asp:Label ID="lbldob1" runat="server" ></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
                 </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lbllocation" runat="server" Text="Location:"></asp:Label>
              <%--  <asp:Label ID="lbl3" runat="server" Text="*" ForeColor="Red"></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
             <asp:TextBox runat="server" ID="txtloc" ReadOnly="true"></asp:TextBox>
               <%-- <asp:Label ID="lbllocation1" runat="server" ></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
                   </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lblgender" runat="server" Text="Gender" ></asp:Label>
              <%--  <asp:Label ID="lbl5" runat="server" Text="*" ForeColor="Red"></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell ID="TableCell1" runat="server">
            <asp:TextBox runat="server" ID="txtgend" ReadOnly="true"></asp:TextBox>
            <%--<asp:Label ID="lblgender1" runat="server" ></asp:Label>--%>
        </asp:TableCell>
        <asp:TableCell runat="server">
                    </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lbldoj" runat="server" Text="Date Of Joining:"></asp:Label>
               <%-- <asp:Label ID="lbl6" runat="server" Text="*" ForeColor="Red"></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
            <asp:TextBox ID="txtdoj" runat="server" ReadOnly="true"></asp:TextBox>
               
            </asp:TableCell>
        <asp:TableCell runat="server">
                 </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lblctc" runat="server" Text="CTC:"></asp:Label>
                <asp:Label ID="lbl7" runat="server" Text="*" ForeColor="Red"></asp:Label>
            </asp:TableCell>
        <asp:TableCell runat="server">
                <asp:TextBox ID="txtctc" runat="server"></asp:TextBox>
            </asp:TableCell>
        <asp:TableCell runat="server">
                <asp:RequiredFieldValidator ID="rfvctc" runat="server" ErrorMessage="Please enter CTC" ForeColor="Red" ValidationGroup="Submit" ControlToValidate="txtctc" Display="Dynamic"></asp:RequiredFieldValidator>
                 <asp:RangeValidator ID="rvctc" runat="server" ErrorMessage="Please enter CTC between 1.5 lakhs and 3 lakhs"  ValidationGroup="Submit" ForeColor="Red" ControlToValidate="txtctc" MaximumValue="300000" MinimumValue="150000" Type="Currency" Display="Dynamic"></asp:RangeValidator>
            </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lbldesignation" runat="server" Text="Designation:"></asp:Label>
                <asp:Label ID="lbl8" runat="server" Text="*" ForeColor="Red"></asp:Label>
            </asp:TableCell>
        <asp:TableCell runat="server">
                <asp:TextBox ID="txtdesignation" runat="server"></asp:TextBox>
            </asp:TableCell>
        <asp:TableCell runat="server">
               
             <asp:RequiredFieldValidator ID="rfvdesignation" runat="server" ErrorMessage="Please enter Designation"  ForeColor="Red" ValidationGroup="Submit" ControlToValidate="txtDesignation"></asp:RequiredFieldValidator>
            
        </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lblunithead" runat="server" Text="Unit Head:"></asp:Label>
                <asp:Label ID="lbl9" runat="server" Text="*" ForeColor="Red"></asp:Label>
            </asp:TableCell>
        <asp:TableCell runat="server">
                <asp:DropDownList ID="ddlunithead" runat="server">
                  
                    <asp:ListItem Text="500001" Value="1"></asp:ListItem>
                     <asp:ListItem Text="500009" Value="2"></asp:ListItem>
                    <asp:ListItem Text="500004" Value="3"></asp:ListItem>
                </asp:DropDownList>
            </asp:TableCell>
        <asp:TableCell runat="server">
                 <asp:RequiredFieldValidator ID="rfvunithead" runat="server" ErrorMessage="Please select Unit Head" ForeColor="Red" ValidationGroup="Submit" ControlToValidate="ddlunithead" Display="Dynamic"  InitialValue="--Select--"></asp:RequiredFieldValidator>
            </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
                <asp:Label ID="lblprojectid" runat="server" Text="Project Id:"></asp:Label>
               <%-- <asp:Label ID="lbl10" runat="server" Text="*" ForeColor="Red"></asp:Label>--%>
            </asp:TableCell>
        <asp:TableCell runat="server">
                  <asp:TextBox ID="txtPid" runat="server" ReadOnly="true"></asp:TextBox>
            </asp:TableCell>
        <asp:TableCell runat="server">
            
             </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow runat="server">
        <asp:TableCell runat="server">
            
             </asp:TableCell>
        <asp:TableCell runat="server">
                <asp:Button ID="Button1" runat="server" Text="Submit" CausesValidation="true" OnClick="Button1_Click"  ValidationGroup="Submit"/>
             <asp:Button ID="BtnCancel" runat="server" Text="Cancel" CausesValidation="true" OnClick="BtnCancel_Click"/>
            </asp:TableCell>
    </asp:TableRow>
</asp:Table>
    </fieldset>
</asp:Content>
