<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="SAC.aspx.cs" Inherits="Projeto_Recomende.Pages.SAC" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">

function limpa() {
if(document.getElementById('email').value=="")
document.getElementById('email').value="Prrencha aqui seu e-mail";

</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div id="welcom_pan">
        <div class="rgtWrap">
            <h3>
                RECOMENDE!&nbsp;&nbsp; 
                <asp:Label ID="Label1" runat="server" Text="Entre em contato conosco!"></asp:Label>
            </h3>
            <p><asp:Label ID="Label2" runat="server" 
                    Text="Dúvidas, críticas ou sugestões? Preencha o Formulário abaixo para conversarmos à respeito"></asp:Label>
            </p>
            <asp:TextBox name="name" class="txt" ID="tbxNome" runat="server" Text="Nome"></asp:TextBox>
            <asp:TextBox name="email" class="txt" ID="tbxEMail" runat="server" Text="E-Mail"></asp:TextBox>
            <asp:DropDownList name="assunto" class="txt" ID="ddlAssunto" runat="server">
                <asp:ListItem>Dúvida</asp:ListItem>
                <asp:ListItem>Sugestão</asp:ListItem>
                <asp:ListItem>Reclamação</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:TextBox class="txt" ID="tbxMensagem" runat="server" Height="208px" 
                TextMode="MultiLine" Width="500px" Text="Digite aqui sua mensagem" onfocus="this.value='';"></asp:TextBox><br />
                <center>
            <asp:Button name="submit" class="btn" ID="btnEnviar" runat="server" 
                Text="Enviar!" onclick="btnEnviar_Click" />
                </center>
        </div>
    </div>
    <!-- 
    <div id="Noticias" runat="server" style="margin-top:20px; padding-bottom:20px">
    </div>-->
</asp:Content>
