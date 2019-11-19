<%@ Page Title="ShowClassDetails" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowClass.aspx.cs" Inherits="HTTP5101_School_System.ShowClasses" %>

<asp:Content ID ="class_view" ContentPlaceHolderID="body" runat="server">

    <div id="class_div" runat="server">
        <h2>Details for <span id="class_title" runat="server"></span></h2>
        Class Code: <span id="class_code" runat="server"></span><br />
        Class Name: <span id="class_name" runat="server"></span><br />
        Start Date: <span id="class_start" runat="server"></span><br />
        End Date: <span id="class_finish" runat="server"></span><br />
    </div>
</asp:Content>


