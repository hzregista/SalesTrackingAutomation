<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="SalesTrackingAutomation.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

    <table class="table table-hover">
        <tr>
            <th>Sales ID</th>
            <th>Product Name</th>
            <th>Staff Name</th>
            <th>Customer Name</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>                
            <tr>
                <td><%#Eval("salesid")%></td>
                <td><%#Eval("productname")%></td>
                <td><%#Eval("staffname")%></td>
                <td><%#Eval("customername")%></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="NewSale.aspx" class="btn btn-block">New Sale</a>
</asp:Content>
