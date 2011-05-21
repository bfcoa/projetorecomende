<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="BuscarFilmes.aspx.cs" Inherits="Projeto_Recomende.Pages.BuscarFilmes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div style="background-color: #D3D3D3; width: 500px; margin-left: auto; margin-right: auto;
        text-align: center; padding:5px">
        <div>
            <label>
                NOME DO FILME</label>
            <asp:TextBox ID="txtFilme" Width="120" runat="server"></asp:TextBox>
            <asp:Button ID="bntBuscar" runat="server" Text="Buscar Filme" />
            <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
        </div>
        <br />
        <div id="filtroAvancado" 
            style="border-width: 1px; background-color:#CDC9C9; padding:5px; border-style:solid">
            <div id="conteudo" style=" width: 250px; margin-right: auto; margin-left: auto; text-align: left">
                <label>Autor:</label>
                <asp:TextBox ID="TextBox1" Width="200" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>
                    Gênero:</label>
                <asp:DropDownList ID="TextBox2" Width="200" runat="server">
                    <asp:ListItem Value="0">Nenum</asp:ListItem>
                    <asp:ListItem Value="1">Ação</asp:ListItem>
                    <asp:ListItem Value="2">Suspense</asp:ListItem>
                    <asp:ListItem Value="3">Comédia</asp:ListItem>
                    <asp:ListItem Value="4">Drama</asp:ListItem>
                    <asp:ListItem Value="5">Romance</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <label>
                    Ordenar Por:</label>
                <asp:DropDownList ID="DropDownList1" Width="170" runat="server">
                    <asp:ListItem Value="0">Nenhum</asp:ListItem>
                    <asp:ListItem Value="1">Mais Recomendados</asp:ListItem>
                    <asp:ListItem Value="2">Mais Comentados</asp:ListItem>
                    <asp:ListItem Value="3">Alfabéticamente (A-Z)</asp:ListItem>
                    <asp:ListItem Value="4">Alfabéticamente (Z-A)</asp:ListItem>
                </asp:DropDownList>
                <br />
                <br />
                <asp:CheckBox ID="CheckBox1" Text=" Desabilitar Filtro De Perfil" runat="server" />
            </div>
        </div>
    </div>
</asp:Content>