<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="CadastroUsuario.aspx.cs" Inherits="Projeto_Recomende.Pages.CadastroUsuario" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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
            <asp:PasswordStrength ID="txtSenha_PasswordStrength" runat="server" Enabled="True"
                TargetControlID="txtSenha" DisplayPosition="BelowRight" PrefixText="Força da Senha: ">
            </asp:PasswordStrength>
            <br />
            <asp:TextBox class="txt" ID="txtConfirmaSenha" runat="server" Text="Confirme a Senha"></asp:TextBox>
            <br />
            <h3>
                Selecione uma foto para seu perfil:</h3>
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="conditional">
                <Triggers>
                    <asp:PostBackTrigger ControlID="btnUpload" />
                </Triggers>
                <ContentTemplate>
                    <asp:Image ID="Image1" runat="server" Visible="false" />
                    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                    </asp:ToolkitScriptManager>
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:Button ID="btnUpload" runat="server" Text="Upload" />
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>

            <br />
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:danilos5ConnectionString %>"
                InsertCommand="INSERT INTO tb_genero(id_genero, tp_genero) VALUES (@id_genero,@tp_genero)"
                SelectCommand="SELECT id_genero, tp_genero FROM tb_genero">
                <InsertParameters>
                    <asp:Parameter Name="id_genero" />
                    <asp:Parameter Name="tp_genero" />
                </InsertParameters>
            </asp:SqlDataSource>
            <h3>
                Marque as categorias de seu interesse:</h3>
            <asp:CheckBoxList ID="CheckBoxList1" runat="server" DataSourceID="SqlDataSource1"
                DataTextField="tp_genero" DataValueField="id_genero">
            </asp:CheckBoxList>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <!--   <input id="File1" type="file" onclick=""/></div> -->
            <asp:Button ID="bntConfirma" class="btn" runat="server" Text="Confirmar" OnClick="bntConfirma_Click" />
            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
