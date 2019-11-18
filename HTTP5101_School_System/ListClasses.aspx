<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="ListClasses.aspx.cs" Inherits="HTTP5101_School_System.ListClasses" %>

<asp:Content ID="classes_list" ContentPlaceHolderID="body" runat="server">
    <h1>Classes</h1>
 <div>
            <asp:Label Text="Class Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtClassName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Class Code" runat="server"></asp:Label>
            <asp:TextBox ID="txtClassCode" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Teacher Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtTeacherName" runat="server"></asp:TextBox>
        </div>
    <div>
            <asp:Label Text="Start Date" runat="server"></asp:Label>
            <asp:TextBox ID="txtStartDate" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Finish Date" runat="server"></asp:Label>
            <asp:TextBox ID="txtFinishDate" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button Text="Add" ID="btnAdd" runat="server" />
            <asp:Button Text="Update" ID="btnUpdate" runat="server" />
            <asp:Button Text="Delete" ID="btnDelete" runat="server" />
       </div>
       <br/ . />
    <div id="class_nav" class="searchbar">
                <asp:label for="class_search" runat="server">Search Classes:</asp:label>
                <asp:TextBox ID="class_search" runat="server"></asp:TextBox>
                <asp:Button runat="server" text="Submit"/>
                <div id="sql_debugger" runat="server"></div>
            </div>
    <div  class="_table" runat="server">
        <div class="listitem tableheader">
            <div class="col5">CLASS CODE</div>
            <div class="col5">CLASS NAME</div>
            <div class="col5">TEACHER</div> <div class="col5">START DATE</div>
            <div class="col5last">FINISH DATE</div>
        </div>
        <div id="classes_result" runat="server">
        </div>
    </div>
    </asp:Content>