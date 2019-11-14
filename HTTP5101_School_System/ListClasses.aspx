<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListClasses.aspx.cs" Inherits="HTTP5101_School_System.ListClasses" %>

<asp:Content ID="classes_list" ContentPlaceHolderID="body" runat="server">
    <h1>Classes</h1>
    <div id="classes_result" class="_table" runat="server">
            <div id="class_nav" class="searchbar">
                <asp:label for="class_search" runat="server">Search Classes:</asp:label>
                <asp:TextBox ID="class_search" runat="server"></asp:TextBox>
                ]<asp:Button runat="server" text="Submit"/>
                <div id="sql_debugger" runat="server"></div>
            </div>
        <div class="listitem tableheader">
            <div class="col5">CLASS CODE</div>
            <div class="col5">CLASS NAME</div>
            <div class="col5">TEACHER</div>
            <div class="col5">START DATE</div>
            <div class="col5last">FINISH DATE</div>
        </div>
    </div>
    </asp:Content>