<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListTeachers.aspx.cs" Inherits="HTTP5101_School_System.ListTeachers" %>

<asp:Content ID="teachers_list" ContentPlaceHolderID="body" runat="server">
    <h1>Teachers</h1>
    <div id="teachers_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col5">FIRST NAME</div>
            <div class="col5">LAST NAME</div>
            <div class="col5">EMPLOYEE NUMBER</div>
            <div class="col5">SALARY</div>
            <div class="col5last">HIRE DATE</div>
        </div>
    </div>
    </asp:Content>