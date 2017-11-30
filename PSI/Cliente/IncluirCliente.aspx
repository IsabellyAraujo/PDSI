<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IncluirCliente.aspx.cs" Inherits="PSI.Cliente.IncluirCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Incluir Cliente
    <br>
    Nome<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br>
    CPF<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    <br>
    Email<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br>
    <asp:Button ID="Button1" runat="server" Text="Salvar" />
    <asp:Button ID="Button2" runat="server" Text="Cancelar" PostBackUrl="~/Cliente/CadastroCliente.aspx" />
</asp:Content>
