<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" Theme="Theme1" StylesheetTheme="Theme1" CodeBehind="CreateBGCSchedule_HR.aspx.cs" Inherits="E_Recruitment.CreateBGCSchedule_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:815px; margin-left: 157px; margin-top: 10px; height:361px;">
        <legend><b>Create BGC Schedule</b></legend>
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" Height="89px" Width="787px" style="margin-top: 21px; margin-left: 0px;">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="LblAdminID" runat="server" Text="Administrator ID"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DdlAdminID" runat="server" OnSelectedIndexChanged="DdlAdminID_SelectedIndexChanged" AutoPostBack="true">
                  <%-- <asp:ListItem Text="--Select--" Value="0"></asp:ListItem> --%>
                </asp:DropDownList>
             </asp:TableCell>
                    <asp:TableCell> 
                <asp:RequiredFieldValidator ID="RFVAdminID" runat="server" ErrorMessage="Please select a value" ControlToValidate="DdlAdminID" ForeColor="#cc0000" InitialValue="0"></asp:RequiredFieldValidator>
            </asp:TableCell>
            </asp:TableRow>
                <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="LblVacancyID" runat="server" Text="Vacancy ID"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:DropDownList ID="DdlVacancyID" runat="server" OnSelectedIndexChanged="DdlVacancyID_SelectedIndexChanged" AutoPostBack="true" Enabled="false">
                               
                </asp:DropDownList>
             </asp:TableCell>
                    <asp:TableCell> 
             <asp:RequiredFieldValidator ID="RFVVacancyID" runat="server" ErrorMessage="Please select a value" ControlToValidate="DdlVacancyID" ForeColor="#cc0000" Enabled="false" InitialValue="0"></asp:RequiredFieldValidator>
            </asp:TableCell>
            </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="LblReqByDate" runat="server" Text="Required-By Date [MM-DD-YYYY]"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxReqByDate" runat="server" Enabled="false"></asp:TextBox>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="LblFromDate" runat="server" Text="From date"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxFromDate" runat="server" TextMode="Date" OnTextChanged="TextBoxFromDate_TextChanged"></asp:TextBox>
             </asp:TableCell>
                    <asp:TableCell> 
                <asp:RequiredFieldValidator ID="RFVFromDate" runat="server" ErrorMessage="Please enter the From Date" ControlToValidate="TextBoxFromDate" ForeColor="#cc0000" Display="Dynamic"></asp:RequiredFieldValidator><br />
                <asp:RangeValidator ID="RVFromDate" runat="server" Type="Date" ErrorMessage="Please enter a From-Date within 7 days to the Required By Date" ForeColor="#cc0000" ControlToValidate="TextBoxFromDate" Enabled="false" Display="Dynamic"></asp:RangeValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="ToDate" runat="server" Text="To Date"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TextBoxToDate" runat="server" TextMode="Date"></asp:TextBox>
             </asp:TableCell>
                    <asp:TableCell> 
            <asp:RequiredFieldValidator ID="RFVToDate" runat="server" ErrorMessage="Please enter the To Date" ControlToValidate="TextBoxToDate" ForeColor="#cc0000" Display="Dynamic"></asp:RequiredFieldValidator><br />
            <asp:RangeValidator ID="RVToDate" runat="server" Type="Date" ErrorMessage="Please enter a 'To Date' that is after the 'From Date' and before the Required By Date" ForeColor="#cc0000" Display="Dynamic" ControlToValidate="TextBoxToDate" Enabled="false"></asp:RangeValidator>
                </asp:TableCell>
        </asp:TableRow>
           </asp:Table>
     <div style="text-align:center">
           <asp:Button id="CreateBGCScheduleButton" runat="server" Text="Submit" OnClick="CreateBGCScheduleButton_Click" />
           <br />
    </div>
        </fieldset>
 
</asp:Content>
