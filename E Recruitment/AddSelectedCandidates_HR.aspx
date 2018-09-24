<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" StylesheetTheme="Theme1" Theme="Theme1" CodeBehind="AddSelectedCandidates_HR.aspx.cs" Inherits="E_Recruitment.AddSelectedCandidates_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:991px; margin-left: 62px; margin-top: 10px; height:321px;">
        <legend><b>Add Selected candidates as Employee</b></legend>
        <asp:GridView ID="grdaddemp"  runat="server" AutoGenerateColumns="False" Height="211px"  DataKeyNames="CandidateProfileID" style="margin-left: 60px; margin-top: 35px; margin-bottom: 3px"  BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None"  OnRowEditing="grdaddemp_RowEditing1" Width="865px" AllowPaging="true"  OnPageIndexChanging="grdaddemp_PageIndexChanging" PageSize="5" >
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField HeaderText="Candidate ID">
                    
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("CandidateProfileID") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Candidate Name">
                    
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("CandidateName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="Date of Birth(mm/dd/yyyy)">
                    
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval(" DOB","{0:MM/dd/yyyy}") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Location">
                   
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Eval("Location") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <%--<asp:TemplateField HeaderText="Gender">
                   
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Eval("Gender") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Add  Employee">
                   
                    <ItemTemplate>
                        <asp:LinkButton runat="server" CommandName="Edit" Text="Add "  ></asp:LinkButton>
                    </ItemTemplate>
                    <ItemStyle ForeColor="#0033CC" />
                </asp:TemplateField>
                
                
            </Columns>

            <FooterStyle BackColor="Tan" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" HorizontalAlign="Center" />
            <RowStyle HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <SortedAscendingCellStyle BackColor="#FAFAE7" />
            <SortedAscendingHeaderStyle BackColor="#DAC09E" />
            <SortedDescendingCellStyle BackColor="#E1DB9C" />
            <SortedDescendingHeaderStyle BackColor="#C2A47B" />

        </asp:GridView>
    </fieldset>
</asp:Content>
