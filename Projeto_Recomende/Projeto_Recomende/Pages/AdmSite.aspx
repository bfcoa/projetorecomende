<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true" CodeBehind="AdmSite.aspx.cs" Inherits="Projeto_Recomende.Pages.AdmSite" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../Util/Scrypts/jquery-1.5.2.min.js" type="text/javascript"></script>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cphBanner" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="cphBody" runat="server">
   
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>    
    
    <asp:UpdatePanel runat="server">
    <ContentTemplate>
        <cc1:Editor ID="Editor1" runat="server" />
        <center><br />
            <asp:Button ID="Button1" runat="server" CssClass="btn" Text="POSTAR" onclick="Button1_Click" /> 
        </center>
    </ContentTemplate>    
    </asp:UpdatePanel>    

</asp:Content>


