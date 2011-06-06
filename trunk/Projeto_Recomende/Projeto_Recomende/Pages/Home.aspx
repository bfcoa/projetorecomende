<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageRecomende.Master" AutoEventWireup="true"
    CodeBehind="Home.aspx.cs" Inherits="Projeto_Recomende.Pages.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cphBanner" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphBody" runat="server">
    <div id="Noticias" runat="server" style="margin-top: 20px; padding-bottom: 20px;">
        <center>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:danilos5ConnectionString %>"
                SelectCommand="Select '&lt;div  style=&quot;width:520px; margin-left:auto; margin-right:auto; font-family:Bernard MT Condensed; font-style:italic;color:#252525; font-size:x-large; height:30px; background-color:#D3D3D3; text-align:center; padding-top:10px&quot;&gt;' + titulo + '&lt;/div&gt;&lt;div style=&quot; width:500px; margin-left:auto; margin-right:auto; margin-bottom:10px; background-color:#EEEEE0; font-size:medium; padding:10px&quot;&gt;' + noticia + '&lt;/div&gt;'from tb_noticias;"
                CacheExpirationPolicy="Absolute"></asp:SqlDataSource>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:GridView BackColor="White" ID="GridView1" runat="server" AllowPaging="True"
                        AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="5">
                        <Columns>
                            <asp:BoundField DataField="Column1" HeaderText="Noticias:" HtmlEncode="False" HtmlEncodeFormatString="False"
                                ReadOnly="True" SortExpression="Column1" />
                        </Columns>
                    </asp:GridView>
                </ContentTemplate>
            </asp:UpdatePanel>
        </center>
    </div>
</asp:Content>
