<%@ Page Title="Specific" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CrudPage.aspx.cs" Inherits="HTTP5101_School_System.CrudPage" %>

<asp:Content ID="students_list" ContentPlaceHolderID="body" runat="server">
    <h1>Create - Review - Update - Delete</h1>
      <div>
            <asp:Label Text="First Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtFName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Last Name" runat="server"></asp:Label>
            <asp:TextBox ID="txtLName" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Student Number" runat="server"></asp:Label>
            <asp:TextBox ID="txtStdNumber" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label Text="Enrollment Date" runat="server"></asp:Label>
            <asp:TextBox ID="txtEnrollDate" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Button Text="Save" ID="btnSave" runat="server" />
            <asp:Button Text="Delete" ID="btnDelete" runat="server" />
            <asp:Button Text="Clear" ID="btnClear" runat="server" />
       </div>
        <div>
            <asp:Label Text="" ID="lblSuccessMessage" runat="server" ForeColor="Green"></asp:Label>
        </div>
        <div>
            <asp:Label Text="" ID="lblErrorMessage" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <br/ . />
 
        
    
    <div id="students_result" class="_table" runat="server">
        <div class="listitem">
            <div class="col4">FIRST NAME</div>
            <div class="col4">LAST NAME</div>
            <div class="col4">STUDENT NUMBER</div>
            <div class="col4last">ENROLMENT DATE</div>
        </div>
    </div>

</asp:Content>
