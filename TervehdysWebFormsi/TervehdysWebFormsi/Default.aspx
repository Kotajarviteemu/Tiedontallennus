<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TervehdysWebFormsi._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Kerro Nimesi?</h1>

    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Paina" />

    <h2>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </h2>
</asp:Content>
