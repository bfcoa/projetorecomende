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
                <span>RECOMENDE!</span>&nbsp;&nbsp; Entre em contato conosco!
            </h3>
            <p> Dúvidas, críticas ou sugestões? <br /> Preencha o Formulário abaixo para conversarmos à respeito
            </p>
            <asp:TextBox name="name" class="txt" ID="tbxNome" runat="server" Text="Nome" onfocus="this.value='';"></asp:TextBox>
            <asp:TextBox name="email" class="txt" ID="tbxEMail" runat="server" Text="E-Mail" onfocus="this.value='';"></asp:TextBox><br />
            <asp:TextBox class="txt" ID="tbxMensagem" runat="server" Height="208px" 
                TextMode="MultiLine" Width="403px" Text="Digite aqui sua mensagem" onfocus="this.value='';"></asp:TextBox><br />
            <asp:Button name="submit" class="btn" ID="btnEnviar" runat="server" Text="Enviar!" />
        </div>
    </div>
    <!-- 
    <div id="Noticias" runat="server" style="margin-top:20px; padding-bottom:20px">
    </div>-->
</asp:Content>
