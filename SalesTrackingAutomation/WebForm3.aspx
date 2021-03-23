<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="SalesTrackingAutomation.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">

        <table class="table table-condensed">
        <tr>
            <th>Staff ID</th>
            <th>Staff Name</th>
            <th>Staff Department</th>
            <th>Staff Salary</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>                
            <tr>
                <td><%#Eval("staffid")%></td>
                <td><%#Eval("staffname")%></td>
                <td><%#Eval("staffdepartmentname")%></td>
                <td><%#Eval("staffsalary")%></td>
            </tr>
            </ItemTemplate>
            </asp:Repeater>
        </tbody>
    </table>
    <a href="AddStaff.aspx" class="btn btn-block">Add New Product</a>
</asp:Content>
