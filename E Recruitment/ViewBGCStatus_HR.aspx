<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" StylesheetTheme="Theme1" CodeBehind="ViewBGCStatus_HR.aspx.cs" Inherits="E_Recruitment.ViewBGCStatus_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:773px; margin-left: 118px; margin-top: 10px; height:372px;">
       <legend><b>Check/View BGC Status</b></legend>
   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       <br />
       <br />
        <asp:GridView ID="GridViewBGCStatusHR" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" AllowPaging="True"  OnPageIndexChanging="GridViewBGCStatusHR_PageIndexChanging" PageSize="5" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField HeaderText="Candidate ID">
                    <ItemTemplate>
                       <asp:Label ID="LblCandidateID" runat="server" Text='<%#Eval("CandidateProfileID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
             <asp:TemplateField HeaderText="HR Interview status">
                    <ItemTemplate>
                        <asp:Label ID="LblHRInterviewStatus" runat="server" Text='<%#Eval("TestStatus")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC status">
                    <ItemTemplate>
                        <asp:Label ID="LblBGCStatus" runat="server" Text='<%#Eval("BGCTestStatus")%>'></asp:Label>
                     </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remarks">
                    <ItemTemplate>
                     <asp:Label ID="LblRemarks" runat="server" Text='<%#Eval("Remarks")%>'></asp:Label>
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

<%--            <asp:TemplateField HeaderText=" Action">
                    <ItemTemplate>
                        <asp:LinkButton ID="LinkButton1" runat="server" CommandName="edit">edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>--%>

       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
   </fieldset>
</asp:Content>
