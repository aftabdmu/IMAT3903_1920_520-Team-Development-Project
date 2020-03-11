<%@ Page Title="" Language="C#" MasterPageFile="~/SAMasterPage.master" AutoEventWireup="true" CodeFile="SABooking.aspx.cs" Inherits="SABooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 <p style="height: 443px; width: 1862px">
        <br />
        <asp:ListBox ID="lstAppts" runat="server" style="z-index: 1; left: 368px; top: 109px; position: relative; height: 189px; width: 198px"></asp:ListBox>
        <asp:Button ID="btnGo" runat="server" style="z-index: 1; left: 600px; top: 80px; position: absolute" Text="Go" />
        <asp:Button ID="btnBook" runat="server" OnClick="Button2_Click" style="z-index: 1; left: 382px; top: 353px; position: absolute" Text="Book" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 383px; top: 410px; position: absolute" Text="lblError"></asp:Label>
        <asp:Label ID="lblApptDate" runat="server" style="z-index: 1; left: 200px; top: 78px; position: absolute" Text="Appointment Date"></asp:Label>
        <asp:TextBox ID="txtApptDate" runat="server" style="z-index: 1; left: 381px; top: 77px; position: absolute; height: 29px; width: 189px"></asp:TextBox>
    </p>
</asp:Content>

