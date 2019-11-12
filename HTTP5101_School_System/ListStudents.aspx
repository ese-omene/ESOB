<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListStudents.aspx.cs" Inherits="HTTP5101_School_System.ListStudents" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Students</h1>
    <div id="student_nav">
        <asp:label for="student_search" runat="server">Search:</asp:label>
        <asp:TextBox ID="student_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="submit"/>
        <div id="sql_debugger" runat="server"></div>
        <%
        //todod: search by keyword
        //search by semester selection(?) -- calendar picker before/after? -- range?
        //order by fname lname asc desc
        %>
    </div>
    <div class="_table" runat="server">
        <div class="listitem">
            <div class="col4">FIRST NAME</div>
            <div class="col4">LAST NAME</div>
            <div class="col4">STUDENT NUMBER</div>
            <div class="col4last">ENROLMENT DATE</div>
        </div>
        <div id="students_result" runat="server">

        </div>
    </div>
</asp:Content>
