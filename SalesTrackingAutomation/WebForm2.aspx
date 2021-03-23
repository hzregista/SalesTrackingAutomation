<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="SalesTrackingAutomation.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    
    <table class="table table-bordered">
        <tr>
            <th>Customer ID</th>
            <th>Customer Name</th>
            <th>UPDATE</th>
            <th>DELETE</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>                
            <tr>
                <td><%#Eval("customerid")%></td>
                <td><%#Eval("customername")%></td>
                <td><asp:HyperLink NavigateUrl='<%# "~/CustomerUpdate.Aspx?customerid=" + Eval("customerid")%>' ID="HyperLink1" runat="server" CssClass="btn btn-warning">Update</asp:HyperLink></td>
                <td><asp:HyperLink NavigateUrl='<%# "~/DeleteCustomer.Aspx?customerid=" + Eval("customerid")%>' ID="HyperLink2" runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink></td>
                
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="AddCustomer.aspx" class="btn btn-block">Add New Customer</a>
</asp:Content>
