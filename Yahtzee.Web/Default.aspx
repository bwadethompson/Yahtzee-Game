<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Yahtzee.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

        <div style="align-items:center; align-content:center" >

    <h1 class="text-center">Yahtzee | Play it with just a click <br /> <br /> <asp:ImageButton class="text-center" ID="ImageButton1" runat="server" ImageUrl="Images\NewGame.gif" OnClick="NewGameButton_Click" /></h1>

    
            </div>
</asp:Content>
