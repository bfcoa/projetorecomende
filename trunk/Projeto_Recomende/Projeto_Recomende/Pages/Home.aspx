<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Projeto_Recomende.Pages.Home" %>
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
    cphBody
</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="cphBodyDown" runat="server">
    cphBodyDown
</asp:Content>
