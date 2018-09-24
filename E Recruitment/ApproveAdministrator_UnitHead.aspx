<%@ Page Title="" Language="C#" MasterPageFile="~/Master2_UnitHead.Master" AutoEventWireup="true" StylesheetTheme="Theme1" CodeBehind="ApproveAdministrator_UnitHead.aspx.cs" Inherits="E_Recruitment.ApproveAdministrator_UnitHead" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:834px; margin-left: 111px; margin-top: 62px; height:302px;">
        <legend style="width: 247px"><b>Approve BGC Test Administrator</b></legend>
        
        <br />
        <br />
      
        <asp:GridView ID="BGCgrdview" runat="server" AutoGenerateColumns="False" HorizontalAlign="Center" OnRowEditing="BGCgrdview_RowEditing" OnRowUpdating="BGCgrdview_RowUpdating" OnRowCancelingEdit="BGCgrdview_RowCancelingEdit" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowPaging="True" OnPageIndexChanging="BGCgrdview_PageIndexChanging" style="margin-top: 0px" Width="572px" PageSize="5">
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
            <Columns>
                
               
                <asp:TemplateField HeaderText="Administrator ID">
                    <ItemTemplate>
                        <asp:Label ID="lbladminid" runat="server" Text='<%#Eval("AdministratorID") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="lbladminid2" runat="server" Text='<%# Eval("AdministratorID") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status">
                    <ItemTemplate>
                        <asp:Label ID="lblStatus" runat="server" Text='<%#Eval("bgcStatus") %>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:DropDownList ID="ddlstatus" runat="server" >
                            <asp:ListItem Text="Rejected" Value="Rejected"></asp:ListItem>
                            <asp:ListItem Text="Approved" Value="Approved"></asp:ListItem>
                            <asp:ListItem Text="On Leave" Value="On Leave"></asp:ListItem>
                        </asp:DropDownList>
                    </EditItemTemplate>
                    
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Status change time">
                    <ItemTemplate>
                        <asp:Label ID="lblstatusChangeTime" runat="server" Text='<%#Eval("StatusChangeTime ")%>'></asp:Label>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Label ID="lblStatusChangeTime2" runat="server" Text='<%#Eval("StatusChangeTime") %>'></asp:Label>
                    </EditItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Set Status">
                    <ItemTemplate>
                        <asp:LinkButton ID="linkedit" runat="server" CommandName="edit">edit</asp:LinkButton>
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:LinkButton ID="linkupdate" runat="server" CommandName="update">update</asp:LinkButton>
                        <asp:LinkButton ID="linkcancel" runat="server" CommandName="cancel">cancel</asp:LinkButton>
                    </EditItemTemplate>
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
        <br />
        <br />
        </fieldset>
</asp:Content>
