<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="CadastroUsuario.aspx.cs" Inherits="Projeto_Recomende.Pages.CadastroUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #ContentCadastro
        {
            margin-bottom: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
    <div id="welcom_pan">
        <div class="rgtWrap">
            <h3>
                RECOMENDE!&nbsp;&nbsp; 
                <asp:Label ID="Label1" runat="server" Text="Complete seu Cadastro!"></asp:Label>
            </h3>
            <asp:TextBox class="txt" ID="txtNome" runat="server" onfocus="this.value='';" Text="Nome"></asp:TextBox>
            <br />
            <asp:TextBox class="txt" ID="txtEmail" runat="server" Text="E-Mail"></asp:TextBox>
            <br />
            <asp:TextBox class="txt" ID="txtSenha" runat="server" Text="Senha"></asp:TextBox>
            <br />
            <asp:TextBox class="txt" ID="txtConfirmaSenha" runat="server" Text="Confirme a Senha"></asp:TextBox>
            <br />
            <h3>
                Selecione uma foto para seu perfil:</h3>
            <asp:FileUpload ID="fuFotoPerfil" runat="server" class="txt" Style="text-color: black" />
            <br />
            <!--   <input id="File1" type="file" onclick=""/></div> -->
            <asp:Button ID="bntConfirma" class="btn" runat="server" Text="Confirmar" OnClick="bntConfirma_Click" />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
