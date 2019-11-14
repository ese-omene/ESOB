<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>

<asp:Content ID="teachers_list" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div id="teacher_nav" class="searchbar">
        <asp:label for="teacher_search" runat="server">Search Teachers:</asp:label>
        <asp:TextBox ID="teacher_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="Submit"/>
        <div id="sql_debugger" runat="server"></div>
    </div>
    <div class="_table" runat="server">
        <div class="listitem tableheader">
            <div class="col5">FIRST NAME</div>
            <div class="col5">LAST NAME</div>
            <div class="col5">EMPLOYEE NUMBER</div>
            <div class="col5">SALARY</div>
            <div class="col5last">HIRE DATE</div>
        </div>
        <div id="teachers_result" runat="server">

        </div>
    </div>
</asp:Content>