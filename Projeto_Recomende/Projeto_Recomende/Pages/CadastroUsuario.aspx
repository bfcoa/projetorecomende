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
    <div id="ContentCadastro">
        <div>
            <asp:Label ID="lblNome" runat="server" Text="Nome:"></asp:Label>
            <asp:TextBox ID ="txtNome" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
            <asp:TextBox ID ="txtEmail" runat="server" ></asp:TextBox>
        </div>
         <div>
            <asp:Label ID="lblSenha" runat="server" Text="Senha:"></asp:Label>
            <asp:TextBox ID ="txtSenha" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="lblConfirmaSenha" runat="server" Text="Confirmação de senha:"></asp:Label>
            <asp:TextBox ID ="txtConfirmaSenha" runat="server" ></asp:TextBox>
        </div>
        <div>
            <asp:FileUpload ID="fuFotoPerfil" runat="server" />
         <!--   <input id="File1" type="file" onclick=""/></div> -->
        <div>

           <asp:Button ID="bntConfirma" runat="server" Text="Confirmar" 
                onclick="bntConfirma_Click" />
                <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>

    </div>
</asp:Content>
