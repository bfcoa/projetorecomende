<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="BuscarFilmes.aspx.cs" Inherits="Projeto_Recomende.Pages.BuscarFilmes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<style type="text/css">
#filtroAvancado
{    
    color:Black;    
    font-weight:bold;
    background-color: #A9A9A9;
    padding: 5px;
}
#filtroAvancadoConteudo
{
    margin-left:auto;
    margin-right:auto;    
}
#filtro
{
color:White;
font-weight:bold;
background-color: #8B8989;
width: 500px;
margin-left: auto;
margin-right: auto;
text-align: center; 
padding: 5px;
}
</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div id="filtro">
                <div>
                    <label> NOME DO FILME</label>
                    <asp:TextBox ID="txtFilme" Width="120" runat="server"></asp:TextBox>
                    <asp:Button ID="bntBuscar" runat="server" CssClass="btn" Text="Buscar Filme" OnClick="bntBuscar_Click" />
                    <br /><asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
                </div>
                <br />
                <div id="filtroAvancado">                
                    <div id="filtroAvancadoConteudo">
                        <label>Ator:</label>
                        <asp:TextBox ID="txtAtor" Width="200" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        <label> Gênero:</label>
                        <asp:DropDownList ID="dplGenero" Width="200" runat="server">
                            <asp:ListItem Value="1">Nenhum</asp:ListItem>
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
                        <br />
                        <label>
                            Ordenar Por:</label>
                        <asp:DropDownList ID="dplOrdem" Width="170" runat="server">
                            <asp:ListItem Value="0">Nenhum</asp:ListItem>
                            <asp:ListItem Value="1">Mais Recomendados</asp:ListItem>
                            <asp:ListItem Value="2">Mais Comentados</asp:ListItem>
                            <asp:ListItem Value="3">Alfabéticamente (A-Z)</asp:ListItem>
                            <asp:ListItem Value="4">Alfabéticamente (Z-A)</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />                        
                    </div>
                    
                </div>
            </div>
            <center>
                <div id="divFilmesResult" runat="server" visible="true" style="padding: 5px; background-color: White;
                    margin-top: 10px; clear: both">
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:danilos5ConnectionString %>">
                    </asp:SqlDataSource>
                    <asp:GridView BackColor="White" ID="GridView1" runat="server" AllowPaging="True"
                        PageSize="5" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnPageIndexChanged="GridView1_PageIndexChanged"
                        PagerSettings-Mode="NumericFirstLast">
                        <Columns>
                            <asp:BoundField DataField="trFilme" HtmlEncode="false" HtmlEncodeFormatString="false" HeaderText="Resultados Da Sua Busca:" SortExpression="trFilme" />
                        </Columns>
                    </asp:GridView>
                </div>
            </center>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
