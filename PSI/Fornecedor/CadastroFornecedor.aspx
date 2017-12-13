<%@ Page Title="Fornecedor" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroFornecedor.aspx.cs" Inherits="PSI.Cadastro_Fornecedor"  Theme="css" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
    Cadastro Fornecedor
    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Fornecedor/IncluirFornecedor.aspx" />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" OnPreRender="LinkButton2_PreRender" DataKeyField="codigo">
        <ItemTemplate>
            nome:
            <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />
            <br />
            cpf:
            <asp:Label ID="cpfLabel" runat="server" Text='<%# Eval("cpf") %>' />
            <br />
            email:
            <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
            <br />
            codigo:
            <asp:Label ID="codigoLabel" runat="server" Text='<%# Eval("codigo") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
   
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PDSI_2017_IsabellyConnectionString %>" SelectCommand="SELECT [nome], [cpf], [email], [codigo] FROM [Fornecedor]"></asp:SqlDataSource>
</asp:Content>