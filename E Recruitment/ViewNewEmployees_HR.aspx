<%@ Page Title="" Language="C#" MasterPageFile="~/Master1.Master" AutoEventWireup="true" StylesheetTheme="Theme1" CodeBehind="ViewNewEmployees_HR.aspx.cs" Inherits="E_Recruitment.ViewNewEmployees_HR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <fieldset style="background-color:beige; width:1032px; margin-left: 43px; margin-top: 10px; height:328px;">
        <legend style="width: 214px"><b>View the list of Employees</b></legend>
        <br />
        <br />
        <br />
        <br />
        <br />
       
    <div style="width: 142px; height: 46px">
     <asp:GridView ID="grdEmployee" runat="server" AutoGenerateColumns="False" Width="951px" BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" AllowPaging="true" OnPageIndexChanging="grdEmployee_PageIndexChanging" PageSize="5" HorizontalAlign="Center" style="margin-left: 43px" >
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
    <Columns>
        <asp:TemplateField HeaderText="Employee ID">
            <ItemTemplate>
                <asp:Label ID="Label1" runat="server" Text='<%#Eval("EmployeeID")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        
         <asp:TemplateField HeaderText="Date Of Birth">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("DOB","{0:dd/MM/yyyy}")%>'></asp:Label>
          
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="Date Of Joining">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("DOJ","{0:dd/MM/yyyy}")%>' ></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

          <asp:TemplateField HeaderText="Designation">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("Designation")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="Location">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("Location")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Gender">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("Gender")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="CTC">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("CTC")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>

         <asp:TemplateField HeaderText="Unit Head ">
             <ItemTemplate>
                  <asp:Label ID="Label1" runat="server" Text='<%#Eval("UnitHeadID")%>'></asp:Label>
             </ItemTemplate>
        </asp:TemplateField>

        <asp:TemplateField HeaderText="Project ID">
            <ItemTemplate>
                 <asp:Label ID="Label1" runat="server" Text='<%#Eval("ProjectId")%>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
         
       
</Columns>
         <EditRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
            <EmptyDataRowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
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
    </div>
    </fieldset>
</asp:Content>
