<%@ Page Title="Fornecedor" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroFornecedor.aspx.cs" Inherits="PSI.Cadastro_Fornecedor"  Theme="css" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Contentplaceholder1" runat="server">
    Cadastro Fornecedor
    &nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Text="Incluir" />
    <asp:DataList ID="DataList1" runat="server" DataSourceID="SqlDataSource1">
        <ItemTemplate>
            <table>
                 <tr>
                     <td>
                         Nome
                     </td>
                     <td>
                         CPF
                     </td>
                     <td>
                         EMAIL
                     </td>
                </tr>
                 <tr>
                   <td>
                        <asp:Label ID="nomeLabel" runat="server" Text='<%# Eval("nome") %>' />
                    </td>
                     <td>
                        <asp:Label ID="cpfLabel" runat="server" Text='<%# Eval("cpf") %>' />
                    </td>
                    <td>
                        <asp:Label ID="emailLabel" runat="server" Text='<%# Eval("email") %>' />
                    </td>
                     <td>
                        <asp:LinkButton ID="LinkButton1" runat="server">Editar</asp:LinkButton>
                    </td>
                    <td>
                        <asp:LinkButton ID="LinkButton2" runat="server">Excluir</asp:LinkButton>
                    </td>
                </tr>
             </table>
        </ItemTemplate>
    </asp:DataList>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PDSI_2017_IsabellyConnectionString %>" SelectCommand="SELECT [nome], [cpf], [email] FROM [Fornecedor]"></asp:SqlDataSource>
</asp:Content>