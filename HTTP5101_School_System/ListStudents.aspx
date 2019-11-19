<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListStudents.aspx.cs" Inherits="HTTP5101_School_System.ListStudents" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Students</h1>
       <div class="input_area">
            <asp:Label Text="First Name:" runat="server"></asp:Label>
           <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
        </div>
        <div class="input_area">
            <asp:Label Text="Last Name:" runat="server"></asp:Label>
            <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
        </div>
        <div class="input_area">
            <asp:Label Text="Student Number:" runat="server"></asp:Label>
            <asp:TextBox ID="txtStdNumber" runat="server"></asp:TextBox>
        </div>
        <div class="input_area">
            <asp:Label Text="Enrollment Date:" runat="server"></asp:Label>
            <asp:TextBox ID="txtEnrollDate" runat="server"></asp:TextBox>
        </div>
        <div class="input_area">
            <asp:Button Text="Add New Student" ID="btnAdd" runat="server" />
            <!-- <asp:Button Text="Update" ID="btnUpdate" runat="server" /> -->
            <!-- <asp:Button Text="Delete" ID="btnDelete" runat="server" /> -->
       </div>
      <br/>
    <div id="student_nav" class="searchbar">
        <asp:label for="student_search" runat="server">Search Students:</asp:label>
        <asp:TextBox ID="student_search" runat="server"></asp:TextBox>
        <asp:Button runat="server" text="Submit"/>
        <div id="sql_debugger" runat="server"></div>
        <%
        //todo: search by keyword
        //search by semester selection(?) -- calendar picker before/after? -- range?
        //order by fname lname asc desc
        %>
    </div>
    <div class="_table" runat="server">
        <div class="listitem tableheader">
            <div class="col6">FIRST NAME</div>
            <div class="col6">LAST NAME</div>
            <div class="col6">STUDENT NUMBER</div>
            <div class="col6">ENROLMENT DATE</div>
            <div class="col6">EDIT</div>
            <div class="col6last">DELETE</div>
        </div>
        <div id="students_result" runat="server">

        </div>
    </div>
</asp:Content>
