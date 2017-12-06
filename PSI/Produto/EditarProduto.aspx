<%@ Page Title="Editar Produto" Language="C#"  MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditarProduto.aspx.cs" Inherits="PSI.Produto.EditarProduto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
    Editar Produto
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
                      <asp:LinkButton ID="LinkButton3" runat="server">Excluir</asp:LinkButton>
                    </td>
                    <td>
                     <asp:LinkButton ID="LinkButton4" runat="server">Cancelar</asp:LinkButton>
                     <!--SELECT ONE-->
                    </td>
                </tr>
           </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PDSI_2017_IsabellyConnectionString %>" SelectCommand="SELECT * FROM [Produto]"></asp:SqlDataSource>
</asp:Content>