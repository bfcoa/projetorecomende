using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Projeto_Recomende.Codes.BLL;
using Projeto_Recomende.Codes.OBJ;

namespace Projeto_Recomende.Pages
{
    public partial class BuscarFilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("~/Pages/SessaoExpirou.aspx");
            }
        }

        protected void GridView1_PageIndexChanged(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                Usuario ususario = (Usuario)Session["usuario"];
                FilmeBll bll = new FilmeBll();
                string query = bll.BuscarFilmes(ususario.id_usuario, txtFilme.Text, txtAtor.Text, int.Parse(dplGenero.SelectedItem.Value), dplOrdem.SelectedIndex);
                if (!string.IsNullOrEmpty(query))
                {
                    SqlDataSource1.SelectCommand = query;
                    SqlDataSource1.DataBind();
                    GridView1.DataBind();
                    divFilmesResult.Visible = true;
                    lblMensagem.Text = "";
                    lblMensagem.Visible = false;
                }
                else
                {
                    lblMensagem.Text = "Por favor, insira o titulo do filme que deseja buscar";
                    lblMensagem.Visible = true;
                }
            }
        }

        protected void bntBuscar_Click(object sender, EventArgs e)
        {
            #region
            //FilmeBll bll = new FilmeBll();
            //List<Filme> listFilmes = bll.BuscarFilmes(txtFilme.Text, txtAtor.Text, dplGenero.SelectedIndex, dplOrdem.SelectedIndex);
            //List<string> listFilmes = new List<string>();
            //if (listFilmes != null && listFilmes.Count > 0)
            //{
            //Filme item = new Filme();
            //item.nm_titulo = "Titulo B";
            //item.nm_tituloOriginal = "Titulo Original B";
            //item.ano_producao = 2003;
            //item.duracao = "Duração B";
            //item.elenco = "Elencol B";
            //item.txt_sinopse = "asdiuhasudhiuashdiuhuiahsudhuiashdui sadu asudh aiusdh iaus dhiuash diahsuduia sduih asdui ahsudah sid ahsd asudh ua sduias hduasiud uas hdua sduias daus duas diu asd asd  B";
            //item.foto = "2623764.gif";
            //string filmeRegistro = "<table><tbody> ";
            ////foreach (Filme item in listFilmes)
            ////{
            //    filmeRegistro += "<tr style=\"border-style:solid;border-width:1px;border-color:red\">"+
            //        "<td><img alt=\"Foto Não Disponivel\" width=\"120px\" style=\"margin:0px\" src=\"../Util/Imagens/ImagensFilmes/"+item.foto+"\"></td> " +
            //        "<td valign=\"top\">";
            //    if (!string.IsNullOrEmpty(item.nm_titulo))
            //    {
            //        filmeRegistro += "<strong>Titulo:</strong><span>" + item.nm_titulo + "</span><br>";
            //    }
            //    if (!string.IsNullOrEmpty(item.nm_tituloOriginal))
            //    {
            //        filmeRegistro += "<strong>Titulo Original:</strong><span>" + item.nm_tituloOriginal + "</span><br>";
            //    }
            //    if (item.ano_producao > 0)
            //    {
            //        filmeRegistro += "<strong>Ano de Produção:</strong><span>" + item.ano_producao + "</span><br>";
            //    }
            //    if (!string.IsNullOrEmpty(item.duracao))
            //    {
            //        filmeRegistro += "<strong>Duração:</strong><span>" + item.duracao + "</span><br>";
            //    }
            //    if (!string.IsNullOrEmpty(item.elenco))
            //    {
            //        filmeRegistro += "<strong>Elenco:</strong><span>" + item.elenco + "</span><br>";
            //    }
            //    if (!string.IsNullOrEmpty(item.txt_sinopse))
            //    {
            //        filmeRegistro += "<strong>Sinopse:</strong><span>" + item.txt_sinopse + "</span><br>";
            //    }
            //    filmeRegistro += "</td></tr>";    
            //    filmeRegistro += "</tbody></table>";
            //    divFilmesResult.Visible = true;
            //    listFilmes.Add(filmeRegistro);
            //    SqlDataSource1.SelectCommand = "SELECT titulo AS teste1 FROM tb_noticias";
            //    SqlDataSource1.DataBind();
            //    GridView1.DataBind();
            //    divFilmesResult.InnerHtml = filmeRegistro;
            //    divFilmesResult.Visible = true;
            //}
            //}
            #endregion
            if (Session["usuario"] != null)
            {
                Usuario ususario = (Usuario)Session["usuario"];
                FilmeBll bll = new FilmeBll();
                string query = bll.BuscarFilmes(ususario.id_usuario, txtFilme.Text, txtAtor.Text, int.Parse(dplGenero.SelectedItem.Value), dplOrdem.SelectedIndex);
                if (!string.IsNullOrEmpty(query))
                {
                    SqlDataSource1.SelectCommand = query;
                    SqlDataSource1.DataBind();
                    GridView1.DataBind();
                    divFilmesResult.Visible = true;
                    lblMensagem.Text = "";
                    lblMensagem.Visible = false;
                }
                else
                {
                    lblMensagem.Text = "Por favor, insira o titulo do filme que deseja buscar (ou o nome de algum ator/atriz que faça parte do elenco)";
                    lblMensagem.Visible = true;
                }
            }
        }
    }
}