<%@ Page Title="Produto" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroProduto.aspx.cs" Inherits="PSI.Cadastro_Produto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
    Cadastro Produto
    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Incluir" PostBackUrl="~/Produto/IncluirProduto.aspx" />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1" DataKeyField="codigo">
        <ItemTemplate>
            <table>
                <tr>
                     <td>
                         Código
                     </td>
                     <td>
                         Nome
                     </td>
                </tr>
                <tr>
                    <td>
                         <asp:Label ID="codigoLabel" runat="server" Text='<%# Eval("codigo") %>' />
                    </td>
                    <td>
                       <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />                  
                    </td>
                    <td>
                      <asp:LinkButton ID="LinkButton3" runat="server">Editar</asp:LinkButton>
                    </td>
                    <td>
                     <asp:LinkButton ID="LinkButton4" runat="server">Excluir</asp:LinkButton>
                     <!-- OS BOTÕES DE EDITAR E EXCLUIR DEVEM TER UM EVENTO QUE PEGUE O ID DE CADA UM PRA PODER CHAMAR O SELECT ONE E REDIRECIONAR PRA PÁGINA DE EXCLUSÃO-->
                    </td>
                </tr>
           </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PDSI_2017_IsabellyConnectionString %>" SelectCommand="SELECT * FROM [Produto]"></asp:SqlDataSource>
</asp:Content>