<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="IncluirCliente.aspx.cs" Inherits="PSI.Cliente.IncluirCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    Incluir Cliente
    <br>
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
                  CPF
            </td>
            <td>
                <asp:TextBox ID="TextBoxCPF" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Cidade
            </td>
            <td>
                <asp:TextBox ID="TextBoxCidade" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Estado
            </td>
            <td>
                <asp:TextBox ID="TextBoxEstado" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Email
            </td>
            <td>
                <asp:TextBox ID="TextBoxEmail" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Endereço
            </td>
            <td>
                <asp:TextBox ID="TextBoxEndereco" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                 Telefone
            </td>
            <td>
                <asp:TextBox ID="TextBoxTelefone" runat="server" BorderColor="Black" BorderStyle="Solid" BorderWidth="1px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Salvar</asp:LinkButton> 
            </td>
            <td>
                <asp:LinkButton ID="LinkButton2" runat="server" PostBackUrl="~/Cliente/CadastroCliente.aspx">Cancelar</asp:LinkButton> 
            </td>
        </tr>
    </table> 
</asp:Content>
