<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="UpdateFoto.aspx.cs" Inherits="Projeto_Recomende.Pages.UpdateFoto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div id="welcom_pan">
        <div class="rgtWrap">
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Image ID="Image1" runat="server" /><br />
                    <asp:FileUpload ID="FileUpload1" runat="server" /><br />
                    <asp:Button ID="btnAtualizaFoto" class="btn" runat="server" Text="Atualizar Foto"
                        OnClick="btnAtualizaFoto_Click" />
                    <asp:Button ID="btnContinuar" class="btn" runat="server" Text="Continuar" />
                    &nbsp;
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </div>
</asp:Content>
