<%@ Page Title="Excluir Cliente" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ExcluirCliente.aspx.cs" Inherits="PSI.Cliente.ExcluirCliente" Theme="css" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
    Excluir Cliente
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" Width="172px">
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
            cidade:
            <asp:Label ID="cidadeLabel" runat="server" Text='<%# Eval("cidade") %>' />
            <br />
            estado:
            <asp:Label ID="estadoLabel" runat="server" Text='<%# Eval("estado") %>' />
            <br />
            endereco:
            <asp:Label ID="enderecoLabel" runat="server" Text='<%# Eval("endereco") %>' />
            <br />
            telefone:
            <asp:Label ID="telefoneLabel" runat="server" Text='<%# Eval("telefone") %>' />
            <br />
            <br />
        </ItemTemplate>
    </asp:DataList>
    
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PDSI_2017_IsabellyConnectionString %>" SelectCommand="SELECT [nome], [cpf], [email], [cidade], [estado], [endereco], [telefone] FROM [Cliente]"></asp:SqlDataSource>
    <div class="inserircliente">
    </div>
   
</asp:Content>

