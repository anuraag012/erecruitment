<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" StylesheetTheme="Theme1" Theme="Theme1" CodeBehind="AddBGCAdministrator_HR.aspx.cs" Inherits="E_Recruitment.Add_BGC_Administrator_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <fieldset style="background-color:beige; width:897px; margin-left: 126px; margin-top: 10px; height:358px;">
        <legend style="height: 18px; width:299px"> <b>ADD BGC ADMINISTRATOR </b> </legend>
    <asp:Table ID="Table2" runat="server" HorizontalAlign="Center" Width="240px">
        <asp:TableRow>
            <asp:TableCell >
                <asp:Label ID="Label2" runat="server" Text="Administrator" Font-Size="Large"></asp:Label>
            </asp:TableCell>
            <asp:TableCell >
                <asp:DropDownList ID="ddlAdmin" runat="server">
                    <asp:ListItem>--Select--</asp:ListItem>
                </asp:DropDownList><br/><br />
            </asp:TableCell>
            </asp:TableRow>
      </asp:Table>
        <div style="text-align:center">
                <asp:Button ID="submit_button" runat="server" Text="Submit" style="margin-left: 88px" OnClick="submit_button_Click"/>
            <br /><br /><br /><br />
          </div>
        <div>
            <asp:GridView ID="addBGCview" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" ShowHeaderWhenEmpty="True" Height="82px" Visible="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowPaging="true" OnPageIndexChanging="addBGCview_PageIndexChanging" PageSize="5">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:TemplateField HeaderText="Administrator ID">
                        <ItemTemplate>
                            <asp:Label ID="adminid" runat="server" Text='<%# Eval("AdministratorID") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Employee name">
                        <ItemTemplate>
                            <asp:Label ID="lblname" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status">
                        <ItemTemplate>
                            <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("bgcStatus") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Status change time">
                        <ItemTemplate>
                            <asp:Label ID="lblstatustime" runat="server" Text='<%#Eval("StatusChangeTime") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </div>
        </fieldset>
</asp:Content>
