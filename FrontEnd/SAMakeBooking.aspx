<%@ Page Title="" Language="C#" MasterPageFile="~/SAMasterPage.master" AutoEventWireup="true" CodeFile="SAMakeBooking.aspx.cs" Inherits="SAMakeBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p style="height: 500px">
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 335px; top: 376px; position: absolute; height: 32px; width: 49px" Text="OK" />
        <asp:TextBox ID="txtTime" runat="server" style="z-index: 1; left: 500px; top: 133px; position: absolute; width: 236px"></asp:TextBox>
        <asp:TextBox ID="txtDate" runat="server" style="z-index: 1; left: 503px; top: 87px; position: absolute; width: 234px"></asp:TextBox>
        <asp:Label ID="lblDate" runat="server" style="z-index: 1; left: 353px; top: 87px; position: absolute" Text="Booking Date"></asp:Label>
        <asp:Label ID="lblTime" runat="server" style="z-index: 1; left: 353px; top: 136px; position: absolute" Text="Booking Time"></asp:Label>
    </p>
    <asp:Label ID="lblReason" runat="server" style="z-index: 1; left: 351px; top: 185px; position: absolute" Text="Reason"></asp:Label>
    <asp:Button ID="btnCancel" runat="server" OnClick="btnCancel_Click" style="z-index: 1; left: 407px; top: 377px; position: absolute; height: 29px" Text="Cancel" />
    <asp:ListBox ID="txtReason" runat="server" style="z-index: 1; left: 348px; top: 223px; position: absolute; width: 395px; height: 128px"></asp:ListBox>
</asp:Content>

