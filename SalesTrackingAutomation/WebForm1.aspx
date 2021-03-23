<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SalesTrackingAutomation.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    Hello World!

    <table class="table table-bordered">
        <tr>
            <th>Department ID</th>
            <th>Department Name</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%#Eval("departmentid")%></td>
                    <td><%#Eval("departmentname")%></td>
                </tr>
                
            </ItemTemplate>
            </asp:Repeater>     

        </tbody>
    </table>
    <a href="AddDep.aspx" class="btn btn-block">Create New Department</a>
</asp:Content>
