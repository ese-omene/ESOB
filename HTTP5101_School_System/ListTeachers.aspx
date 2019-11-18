<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>

<asp:Content ID="teachers_list" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div>
            <asp:Label Text="First Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtTeacherFName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Last Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtTeacherLName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Employee Number" runat="server"></asp:Label>
            <asp:TextBox ID="txtEmployeeNumber" runat="server"></asp:TextBox>
        </div>
    <div>
            <asp:Label Text="Salary" runat="server"></asp:Label>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Hire Date" runat="server"></asp:Label>
            <asp:TextBox ID="txtHireDate" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button Text="Add" ID="btnAdd" runat="server" />
            <asp:Button Text="Update" ID="btnUpdate" runat="server" />
            <asp:Button Text="Delete" ID="btnDelete" runat="server" />
       </div>
       <br/ . />

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