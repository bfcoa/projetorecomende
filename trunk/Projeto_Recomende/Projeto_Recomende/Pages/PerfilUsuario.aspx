<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="PerfilUsuario.aspx.cs" Inherits="Projeto_Recomende.Pages.PerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- <script type="text/javascript" src="Util/Scrypts/lightbox2.05/js/prototype.js"></script>
    <script type="text/javascript" src="Util/Scrypts/lightbox2.05/js/scriptaculous.js?load=effects,builder"></script>
    <script type="text/javascript" src="Util/Scrypts/lightbox2.05/js/lightbox.js"></script>
    <link rel="stylesheet" href="Util/Scrypts/lightbox2.05/css/lightbox.css" type="text/css" media="screen" /> -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="PerfilUsuario.aspx#perguntasPerfil">Perguntas do perfil!</a> <a href="PerfilUsuario.aspx#DadosUsuario">
        Dados do usuario!</a>
    <div id="DadosUsuario">
        <div>
            <asp:Label ID="lblBemvindo" runat="server">Bem Vindo, </asp:Label>
            <asp:Label ID="lblNome" runat="server"></asp:Label>
        </div>
        <div id="fotoPerfil">
            <asp:Image ID="imgLogo" runat="server" />
        </div>
        <div id ="listaRecomendacoes">
            LISTA DE FILMES
        </div>
    </div>
    <div id="perguntasPerfil">
        <div>
            <asp:Label ID="lblPergunta1" runat="server" Text="PERGUNTA 1 :"></asp:Label>
            <asp:RadioButtonList ID="rblPergunta1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Opção1"></asp:ListItem>
                <asp:ListItem Text="Opção2"></asp:ListItem>
                <asp:ListItem Text="Opção3"></asp:ListItem>
                <asp:ListItem Text="Opção4"></asp:ListItem>
                <asp:ListItem Text="Opção5"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="lblPergunta2" runat="server" Text="PERGUNTA 2 :"></asp:Label>
            <asp:RadioButtonList ID="rblPergunta2" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Opção1"></asp:ListItem>
                <asp:ListItem Text="Opção2"></asp:ListItem>
                <asp:ListItem Text="Opção3"></asp:ListItem>
                <asp:ListItem Text="Opção4"></asp:ListItem>
                <asp:ListItem Text="Opção5"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Label ID="lblPergunta3" runat="server" Text="PERGUNTA 3 :"></asp:Label>
            <asp:RadioButtonList ID="rblPergunta3" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Text="Opção1"></asp:ListItem>
                <asp:ListItem Text="Opção2"></asp:ListItem>
                <asp:ListItem Text="Opção3"></asp:ListItem>
                <asp:ListItem Text="Opção4"></asp:ListItem>
                <asp:ListItem Text="Opção5"></asp:ListItem>
            </asp:RadioButtonList>
        </div>
        <div>
            <asp:Button ID="bntConfirma" runat="server" Text="Confirmar" OnClick="bntConfirma_Click" />
        </div>
    </div>
</asp:Content>
