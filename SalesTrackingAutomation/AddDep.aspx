<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddDep.aspx.cs" Inherits="SalesTrackingAutomation.AddDep" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <form runat="server" class="form-control-static">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Department:" Font-Bold="true"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <div>
            <asp:Button ID="Button1" runat="server" Text ="CREATE" CssClass="btn btn-default" OnClick="Button1_Click"/>
        </div>
    </form>

</asp:Content>
