﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs" Inherits="Projeto_Recomende.Pages.Home" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="cc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--  STEP ONE: insert path to SWFObject JavaScript -->
    <script type="text/javascript" src="../Util/Scrypts/swfobject/swfobject.js"></script>
    <!--  STEP TWO: configure SWFObject JavaScript and embed CU3ER slider -->
    <script type="text/javascript">
        var flashvars = {};
        flashvars.xml = "../Util/Cuber/config.xml";
        flashvars.font = "../Util/Cuber/font.swf";
        var attributes = {};
        attributes.wmode = "transparent";
        attributes.id = "slider";
        swfobject.embedSWF("../Util/Cuber/cu3er.swf", "cu3er-container", "800", "360", "9", "", flashvars, attributes);            
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
    <div id="cu3er-container">
        <a href="http://www.adobe.com/go/getflashplayer">
            <img src="http://www.adobe.com/images/shared/download_buttons/get_flash_player.gif"
                alt="Get Adobe Flash player" />
        </a>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div id="Noticias" runat="server" style="margin-top: 20px; padding-bottom: 20px;">
    <center>
        <%--<div id="Titulo" style="width:520px; margin-left:auto; margin-right:auto; font-family:Bernard MT Condensed; font-style:italic;color:#00688B; font-size:x-large; height:30px; background-color:#D3D3D3; text-align:center; padding-top:10px">
        </div>
        <div id="CorpoNoticia" style=" width:500px; margin-left:auto; margin-right:auto; background-color:#EEEEE0; font-size:medium; padding:10px">            
        </div>--%>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
            ConnectionString="<%$ ConnectionStrings:danilos5ConnectionString %>" 
            SelectCommand="Select '&lt;div  style=&quot;width:520px; margin-left:auto; margin-right:auto; font-family:Bernard MT Condensed; font-style:italic;color:#252525; font-size:x-large; height:30px; background-color:#D3D3D3; text-align:center; padding-top:10px&quot;&gt;' + titulo + '&lt;/div&gt;&lt;div style=&quot; width:500px; margin-left:auto; margin-right:auto; margin-bottom:10px; background-color:#EEEEE0; font-size:medium; padding:10px&quot;&gt;' + noticia + '&lt;/div&gt;'
from tb_noticias;"></asp:SqlDataSource>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                    AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="5">
                    <Columns>
                        <asp:BoundField DataField="Column1" HeaderText="Noticias:" HtmlEncode="False" 
                            HtmlEncodeFormatString="False" ReadOnly="True" SortExpression="Column1" />
                    </Columns>
                </asp:GridView>
            </ContentTemplate>
        </asp:UpdatePanel>
        </center>
    </div>
</asp:Content>
