<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListStudents.aspx.cs" Inherits="HTTP5101_School_System.ListStudents" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Students</h1>
    <div id="students_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col4">FIRST NAME</div>
            <div class="col4">LAST NAME</div>
            <div class="col4">STUDENT NUMBER</div>
            <div class="col4last">ENROLMENT DATE</div>
        </div>
    </div>
</asp:Content>
