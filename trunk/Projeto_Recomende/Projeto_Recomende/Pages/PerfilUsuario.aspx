<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true" CodeBehind="PerfilUsuario.aspx.cs" Inherits="Projeto_Recomende.Pages.PerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Util/Styles/PagesStyleSheets.css" rel="stylesheet" type="text/css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div id="Content">
    <div id="opcoes">
            <a href="PerfilUsuario.aspx#perguntasPerfil">Perguntas do perfil</a>
             <a href="PerfilUsuario.aspx#DadosUsuario">Dados do usuario</a>
        </div>
        <div id="DadosUsuario">
            <div id="ContentDados">
                <asp:Label ID="lblBemvindo" runat="server">Bem Vindo, </asp:Label>
                <asp:Label ID="lblNome" runat="server"></asp:Label>
            </div>
            <div id="fotoPerfil">
                <asp:Image ID="imgPerfil" runat="server" Height="128px" Width="128px" />
            </div>
            <div>
                <asp:LinkButton ID ="lbEditar" runat="server" onclick="lbEditar_Click" >Editar Perfil</asp:LinkButton>
            </div>
            <div id="listaRecomendacoes">
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
    
    </div>
</asp:Content>
