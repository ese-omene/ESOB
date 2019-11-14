<%@ Page Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ShowTeacher.aspx.cs" Inherits="HTTP5101_School_System.ShowTeacher" %>

<asp:Content ID="teacher_view" ContentPlaceHolderID="body" runat="server">

    <div id="teacher" runat="server">
        <h2>Details for <span id="teacher_title_fname" runat="server"></span></h2>
        First Name: <span id="teacher_fname" runat="server"></span><br />
        Last Name: <span id="teacher_lname" runat="server"></span><br />
        Employee Number: <span id="employee_number" runat="server"></span><br />
        Salary: <span id="salary" runat="server"></span><br />
        Hire Date: <span id="hire_date" runat="server"></span><br />
    </div>
</asp:Content>