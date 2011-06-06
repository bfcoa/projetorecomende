<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="SAC.aspx.cs" Inherits="Projeto_Recomende.Pages.SAC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div id="welcom_pan">
        <div class="rgtWrap">
            <h3>
                <span>RECOMENDE!</span> Entre em contato conosco!
            </h3>
            <p>Dúvidas, críticas ou sugestões? Preencha o Formulário abaixo para conversarmos à respeito!
            </p>
            <input name="name" type="text" class="txt" value="Name">
            <input name="id" type="text" class="txt" value="Email-ID">
            <input name="submit" type="submit" class="btn" value="submit">
        </div>
        <p>
            Aliquam ut ipsum non mi vehicula fringilla. Fusce ac risus eget felis mollis cursus
            eu eu mi. Ut vulputate adipiscing mauris, ac tincidunt enim tristique id. Integer
            eget turpis nunc. Ut ut diam urna. Duis gravida vehicula sem malesuada laoreet.
            In hac habitasse platea dictumst. Praesent eget dui ornare mauris auctor pellentesque.
            Vivamus non eros quis mi venenatis sollicitudin.</p>
    </div>
    <!-- 
    <div id="Noticias" runat="server" style="margin-top:20px; padding-bottom:20px">
    </div>-->
</asp:Content>
