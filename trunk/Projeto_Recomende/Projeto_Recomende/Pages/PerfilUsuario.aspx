<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="PerfilUsuario.aspx.cs" Inherits="Projeto_Recomende.Pages.PerfilUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Util/Styles/PagesStyleSheets.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div id="welcom_pan">
        <div class="rgtWrap">
            <div id="opcoes">
                <a href="PerfilUsuario.aspx#perguntasPerfil">Perguntas do perfil</a>
            </div>
            <div id="ContentDados">
                <asp:Label ID="lblBemvindo" runat="server">Bem Vindo, </asp:Label>
                <asp:Label ID="lblNome" runat="server"></asp:Label>
            </div>
            <div id="fotoPerfil">
                <asp:Image ID="imgPerfil" runat="server" Height="128px" Width="128px" />
            </div>
            <div>
                <asp:LinkButton ID="lbEditar" runat="server" OnClick="lbEditar_Click">Editar Perfil</asp:LinkButton>
            </div>
            <div class="ParteTras">
            <center>
            <h3>
                FILMES RECOMENDADOS PRA VOCÊ !!&nbsp;&nbsp;
            </h3>
            </center>
            <br /><br /><br />
            <div id="listaRecomendacoes">                
            </div>
            </div>

            <div class="ParteTras">
            <center>
            <h3>RESPONDA AS PERGUNTAS PARA FILTRARMOS SEU PERFIL !XD</h3>
            </center>
            <div id="perguntasPerfil">
               <div>
                    <asp:Label ID="lblPergunta1" runat="server" ForeColor="Red" Text="Em que nivel religioso vocês se encontra?"></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Praticante"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Não Praticante"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Agnostico"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Ateu"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Anti-Cristo"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta2" runat="server" ForeColor="Red" Text="Quais estilos de musica mais te agrada?"></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta2" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Pagode/Samba"></asp:ListItem>
                        <asp:ListItem Value="2" Text="MPB"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Pop"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Rock"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Death Metal/ Black Metal"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta3" runat="server" ForeColor="Red" Text="Quando o assunto é esporte você..."></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta3" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Acompanho/Pratico sempre que possivel"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Acompanho/Pratico eventualmente"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Acompanho/Pratico qualquer esporte"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Acompanho/Pratico muito raramente"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Não gosto de esportes"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta4" runat="server" ForeColor="Red" Text="Das areas de atuação a seguir você prefere..."></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta4" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Humanas"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Contabil"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Marketing"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Adminstrativo"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Tecnologia da Informação"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta5" runat="server" ForeColor="Red" Text="Que tipo de filme mais te agrada ?"></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta5" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Comedia/Romance"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Drama"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Ação"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Suspense"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Terror"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta6" runat="server" ForeColor="Red" Text="Em que faixa etaria vc se encontra?"></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta6" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Até 20 anos"></asp:ListItem>
                        <asp:ListItem Value="3" Text="20 a 40 anos"></asp:ListItem>
                        <asp:ListItem Value="5" Text="mais de 40 anos"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta7" runat="server" ForeColor="Red" Text="Que tipo de leitura mais lhe agrada?"></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta7" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="2" Text="Jornal"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Revista"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Livros"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Gibis/Mangas"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta8" runat="server" ForeColor="Red" Text="Dos tipos de lazer a seguir vo prefere..."></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta8" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Cinema"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Esportes"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Balada"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Teatro"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Shows"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                <div>
                    <asp:Label ID="lblPergunta9" runat="server" ForeColor="Red" Text="Que tipo de animal de estimação tem mais haver com você?"></asp:Label>
                    <asp:RadioButtonList ID="rblPergunta9" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="1" Text="Passaros"></asp:ListItem>
                        <asp:ListItem Value="2" Text="Gato"></asp:ListItem>
                        <asp:ListItem Value="3" Text="Cachorro"></asp:ListItem>
                        <asp:ListItem Value="4" Text="Hamister"></asp:ListItem>
                        <asp:ListItem Value="5" Text="Cobra"></asp:ListItem>
                    </asp:RadioButtonList>
                </div>
                
            </div>
            <div>
                    <asp:Button ID="bntConfirma" runat="server" Text="Confirmar" OnClick="bntConfirma_Click" />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
