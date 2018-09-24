<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" StylesheetTheme="Theme1" CodeBehind="ViewAdministrators_HR.aspx.cs" Inherits="E_Recruitment.ViewAdministrators_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:870px; margin-left: 124px; margin-top: 10px; height:299px;">
        <legend><b>View BGC Test Administrators Status</b></legend>
        <br />
        
        <asp:GridView ID="viewgrdapproved" runat="server" AutoGenerateColumns="False" EmptyDataText="Database empty" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowPaging="true"  OnPageIndexChanging="viewgrdapproved_PageIndexChanging" PageSize="5">
<%--        <asp:GridView ID="viewgrdapproved" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowPaging="true"  OnPageIndexChanging="viewgrdapproved_PageIndexChanging" PageSize="5" Width="493px">--%>
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField HeaderText="Administrator ID">
                    <ItemTemplate>
                        <asp:Label ID="lbladminid" runat="server" Text='<%# Eval("AdministratorID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Employee name">
                        <ItemTemplate>
                            <asp:Label ID="lblname" runat="server" Text='<%#Eval("EmployeeName") %>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblstatus" runat="server" Text='<%#Eval("bgcStatus")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status change time">
                    <ItemTemplate>
                        <asp:Label ID="lblstatuschangetime" runat="server" Text='<%#Eval("StatusChangeTime")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />
        </asp:GridView>
        <br />
        <br />
        <br />
        <br />
        <br />
    </fieldset>
</asp:Content>
