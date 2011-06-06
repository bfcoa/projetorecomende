<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true" CodeBehind="AdmSite.aspx.cs" Inherits="Projeto_Recomende.Pages.AdmSite" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    #PostarNoticia
    {
        color:Black;    
        font-weight:bold;
        background-color: #A9A9A9;
        padding: 5px;
    }    
    #titulo
    {
        margin-bottom:20px;
    }
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphBanner" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
   
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>    
    
    <asp:UpdatePanel runat="server">
    <ContentTemplate>
        <div id="PostarNoticia">
        
        <center>
        <div id="titulo">
        <label>Titulo:</label>        
        <asp:TextBox ID="txtTitulo" Width="250" runat="server"></asp:TextBox><br />
        </div>
        <cc1:Editor ID="Editor1" runat="server" />
        
        <br />
            <asp:Button ID="Button1" runat="server" CssClass="btn" Text="POSTAR" onclick="Button1_Click" /> 
        </center>
        </div>
    </ContentTemplate>    
    </asp:UpdatePanel>    

</asp:Content>


