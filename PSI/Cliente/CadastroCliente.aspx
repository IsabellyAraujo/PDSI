<%@ Page Title="Cliente" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="PSI.Cadastro_Cliente"  Theme="css" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
    Cadastro de Cliente
     &nbsp; &nbsp;   <asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Cliente/IncluirCliente.aspx" />
    <div class="inserircliente">
        <asp:GridView ID="GridView1" runat="server" DataSourceID="ObjectDataSource1" AutoGenerateColumns="False">
            <Columns>
               
                <asp:BoundField DataField="nome" HeaderText="nome" SortExpression="nome" />
                <asp:BoundField DataField="cpf" HeaderText="cpf" SortExpression="cpf" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="SelectAll" TypeName="PSI.DAL.DALCliente"></asp:ObjectDataSource>
    </div>
   
</asp:Content>

