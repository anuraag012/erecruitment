<%@ Page Title="" Language="C#" MasterPageFile="~/Master3_Administrator.Master" AutoEventWireup="true" StylesheetTheme="Theme1" CodeBehind="ViewBGCStatus_Administrator.aspx.cs" Inherits="E_Recruitment.ViewBGCStatus_Administrator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:905px; margin-left: 105px; margin-top: 10px; height: 383px;">
        <legend style="width: 230px"><b>View candidate's BGC Status</b></legend>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" EmptyDataText="Database empty" HorizontalAlign="Center" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowPaging="true" OnPageIndexChanging="GridView2_PageIndexChanging" PageSize="5" style="margin-left: 91px" Width="824px">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                <asp:TemplateField HeaderText="Candidate ID">
                    <ItemTemplate>
                        <asp:Label ID="LblCandidateID_BGC" runat="server" Text='<%#Eval("CandidateProfileID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Vacancy ID">
                    <ItemTemplate>
                        <asp:Label ID="LblVacancyID_BGC" runat="server" Text='<%#Eval("VacancyID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC ID">
                    <ItemTemplate>
                        <asp:Label ID="LblBGCTestID_BGC" runat="server" Text='<%#Eval("BGCTestID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="HR Interview status">
                    <ItemTemplate>
                        <asp:Label ID="LblHRStatus_BGC" runat="server" Text='<%#Eval("TestStatus")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BGC status">
                    <ItemTemplate>
                        <asp:Label ID="LblBGCStatus_BGC" runat="server" Text='<%#Eval("BGCTestStatus")%>'></asp:Label>
                    </ItemTemplate>
<%--                    <EditItemTemplate>
                        <asp:DropDownList ID="DDlBGCStatus" runat="server">
                            <asp:ListItem Text="Pending" ></asp:ListItem>
                            <asp:ListItem Text="Cleared" ></asp:ListItem>
                            <asp:ListItem Text="Rejected" ></asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>--%>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Remarks">
                    <ItemTemplate>
                        <asp:Label ID="LblRemarks_BGC" runat="server" Text='<%#Eval("Remarks")%>'></asp:Label>
                    </ItemTemplate>
<%--                    <EditItemTemplate>
                        <asp:TextBox ID="TextBoxRemarks" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </EditItemTemplate>--%>
                </asp:TemplateField>
<%--              <asp:TemplateField HeaderText="Action">
                    <ItemTemplate>
                        
                        <asp:LinkButton ID="EditLinkButton_BGC" runat="server" CommandName="edit">Edit</asp:LinkButton>
                    </ItemTemplate>--%>
<%--                  <EditItemTemplate>
                      <asp:LinkButton ID="UpdateLinkButton" runat="server" CommandName="update">Done</asp:LinkButton>
                      <asp:HiddenField ID="hdnField" runat="server" Value='<%#Eval("CandidateProfileID")%>' />
                  </EditItemTemplate>
                </asp:TemplateField>--%>
            
            </Columns>
<%--           <Columns>
                <asp:TemplateField HeaderText="Candidate ID"></asp:TemplateField>
                <asp:TemplateField HeaderText="HR interview status"></asp:TemplateField>
                <asp:TemplateField HeaderText="BGC status"></asp:TemplateField>
            </Columns>--%>
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
        <br />
        <br />
        <br />
    </fieldset>
</asp:Content>
