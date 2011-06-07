<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="True"
    CodeBehind="BuscarFilmes.aspx.cs" Inherits="Projeto_Recomende.Pages.BuscarFilmes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../Util/Scrypts/jquery/extensao/themes/base/jquery.ui.all.css" rel="stylesheet"
        type="text/css" />
    <script src="../Util/Scrypts/jquery/jquery-1.5.2.js" type="text/javascript"></script>
    <script src="../Util/Scrypts/funcoes.js" type="text/javascript"></script>
    
    <%--<style type="text/css">
#filtroAvancado
{    
    color:Black;    
    font-weight:bold;
    background-color: #8B8989;
    padding: 5px;
}
#filtroAvancadoConteudo
{
    margin-left:auto;
    margin-right:auto; 
    width:270px;       
    text-align:right;
}
#filtro
{
color:Black;
font-weight:bold;
background-color: #A9A9A9;
width: 500px;
margin-left: auto;
margin-right: auto;
text-align: center; 
padding: 5px;
}
</style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="welcom_pan">
                <div id="filtro" class="rgtWrap" style="text-align: center">
                    <h3>
                        RECOMENDE!&nbsp;&nbsp;
                        <asp:Label ID="Label1" runat="server" Text="Busca De Filmes"></asp:Label>
                    </h3>
                    <p style="text-align: left; padding-left: 30px;">
                        <asp:Label ID="Label2" runat="server" Text="Aqui você pode buscar um filme que você gostou e recomendar para o pessoal!!"></asp:Label>
                    </p>
                    <%--<label> NOME DO FILME</label>--%>
                    <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label><br />
                    <asp:TextBox ID="txtFilme" CssClass="txt" Text="Titulo Do Filme" runat="server" onfocus="this.value='';"></asp:TextBox>
                    <br />
                    <%--<label>Ator:</label>--%>
                    <asp:TextBox ID="txtAtor" CssClass="txt" Text="Ator" runat="server" onfocus="this.value='';"></asp:TextBox>
                    <br />
                    <%--<label> Gênero:</label>--%>
                    <asp:DropDownList ID="dplGenero" runat="server" CssClass="txt">
                        <asp:ListItem Value="1">Gênero</asp:ListItem>
                        <asp:ListItem Value="2">Ação e Aventura</asp:ListItem>
                        <asp:ListItem Value="3">Animação</asp:ListItem>
                        <asp:ListItem Value="4">Cinema Nacional</asp:ListItem>
                        <asp:ListItem Value="5">Cinema Estrangeiro</asp:ListItem>
                        <asp:ListItem Value="6">Clássicos</asp:ListItem>
                        <asp:ListItem Value="7">Comédia</asp:ListItem>
                        <asp:ListItem Value="8">Drama</asp:ListItem>
                        <asp:ListItem Value="9">Documentário</asp:ListItem>
                        <asp:ListItem Value="10">Esporte</asp:ListItem>
                        <asp:ListItem Value="11">Faroeste</asp:ListItem>
                        <asp:ListItem Value="12">Ficção</asp:ListItem>
                        <asp:ListItem Value="13">Filmes de Época</asp:ListItem>
                        <asp:ListItem Value="14">Infantil</asp:ListItem>
                        <asp:ListItem Value="15">Musical</asp:ListItem>
                        <asp:ListItem Value="16">Policial</asp:ListItem>
                        <asp:ListItem Value="17">Religião</asp:ListItem>
                        <asp:ListItem Value="18">Romance</asp:ListItem>
                        <asp:ListItem Value="19">Show</asp:ListItem>
                        <asp:ListItem Value="20">Suspense</asp:ListItem>
                        <asp:ListItem Value="21">Terror</asp:ListItem>
                        <asp:ListItem Value="22">TV</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <%--<label>Ordenar Por:</label>--%>
                    <asp:DropDownList ID="dplOrdem" CssClass="txt" runat="server">
                        <asp:ListItem Value="0">Ordenar Por</asp:ListItem>
                        <asp:ListItem Value="1">Mais Recomendados</asp:ListItem>
                        <asp:ListItem Value="2">Mais Comentados</asp:ListItem>
                        <asp:ListItem Value="3">Alfabéticamente (A-Z)</asp:ListItem>
                        <asp:ListItem Value="4">Alfabéticamente (Z-A)</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <asp:Button ID="bntBuscar" runat="server" CssClass="btn" Text="Buscar Filme" OnClick="bntBuscar_Click" />
                </div>
            </div>
            <div id="divFilmesResult" runat="server" visible="true" style="padding: 5px; background-color: White;
                margin-top: 10px; clear: both">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:danilos5ConnectionString %>">
                </asp:SqlDataSource>
                <asp:GridView BackColor="White" ID="GridView1" runat="server" AllowPaging="True"
                    PageSize="5" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnPageIndexChanged="GridView1_PageIndexChanged"
                    PagerSettings-Mode="NumericFirstLast">
                    <Columns>
                        <asp:BoundField DataField="trFilme" HtmlEncode="false" HtmlEncodeFormatString="false"
                            HeaderText="Resultados Da Sua Busca:" SortExpression="trFilme" />
                    </Columns>
                </asp:GridView>
                <table>
                    <tbody>
                        <tr>
                            <td style="width: 120px; height: 120px;">
                                <img width="120px" src="../Util/Imagens/ImagensFilmes/2410715.gif" style="margin: 0px"
                                    alt=" Foto Não Disponível">
                                <center>
                                    <br />
                                    <div>
                                        <input runat="server" type="image" class="btnRecomendar" src="../Util/Imagens/ImagensSite/recomendar.png"
                                            title="Recomendar Este Filme" onclick="Comentar();" />
                                        <input type="image" style="margin-left: 20px" src="../Util/Imagens/ImagensSite/comentar.png"
                                            title="Fazer Comentário Sobre o Filme" />
                                    </div>
                                </center>
                            </td>
                            <td valign="top">
                                <strong>Titulo:</strong><span>'+f.nm_titulo'</span><br>
                                <strong>Titulo Original:</strong><span>'+f.nm_tituloOriginal+'</span><br>
                                <strong>Gênero:</strong><span>'+g.tp_genero+'</span><br>
                                <strong>Ano de Produção:</strong><span>'+f.ano_producao+'</span><br>
                                <strong>Duração:</strong><span>'+f.duracao+'</span><br>
                                <strong>Elenco:</strong><span>'+f.elenco+'</span><br>
                                <strong>Sinopse:</strong><span>'+CONVERT(VARCHAR(8000), f.txt_sinopse)+'</span><br>
                            </td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
