<%@ Page Title="Produto" Language="C#" MasterPageFile="~/MasterPage.Master"  AutoEventWireup="true" CodeBehind="IncluirProduto.aspx.cs" Inherits="PSI.Produto.IncluirProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
     Incluir Produto
    <br/>
    <table>
        <tr>
            <td>
                 Nome
            </td>
            <td>
                <asp:TextBox ID="TextBoxNome" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Salvar</asp:LinkButton> 
            </td>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Produto/CadastroProduto.aspx">Cancelar</asp:LinkButton> 
            </td>
        </tr>
    </table>
</asp:Content>