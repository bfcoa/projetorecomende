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

        }

        protected void bntBuscar_Click(object sender, EventArgs e)
        {

            //FilmeBll bll = new FilmeBll();
            //List<Filme> listFilmes = bll.BuscarFilmes(txtFilme.Text, txtAtor.Text, dplGenero.SelectedIndex, dplOrdem.SelectedIndex);

            //if (listFilmes != null && listFilmes.Count > 0)
            //{
            Filme item = new Filme();
            item.nm_titulo = "Titulo B";
            item.nm_tituloOriginal = "Titulo Original B";
            item.ano_producao = 2003;
            item.duracao = "Duração B";
            item.elenco = "Elencol B";
            item.txt_sinopse = "asdiuhasudhiuashdiuhuiahsudhuiashdui sadu asudh aiusdh iaus dhiuash diahsuduia sduih asdui ahsudah sid ahsd asudh ua sduias hduasiud uas hdua sduias daus duas diu asd asd  B";
            item.foto = "2623764.gif";
                string teste = "<table><tbody> ";
                //foreach (Filme item in listFilmes)
                //{
                    teste += "<tr style=\"border-style:solid;border-width:1px;border-color:red\">"+
                        "<td><img alt=\"Foto Não Disponivel\" width=\"120px\" style=\"margin:0px\" src=\"../Util/Imagens/ImagensFilmes/"+item.foto+"\"></td> " +
                        "<td valign=\"top\">";
                    if (!string.IsNullOrEmpty(item.nm_titulo))
                    {
                        teste += "<strong>Titulo:</strong><span>" + item.nm_titulo + "</span><br>";
                    }
                    if (!string.IsNullOrEmpty(item.nm_tituloOriginal))
                    {
                        teste += "<strong>Titulo Original:</strong><span>" + item.nm_tituloOriginal + "</span><br>";
                    }
                    if (item.ano_producao > 0)
                    {
                        teste += "<strong>Ano de Produção:</strong><span>" + item.ano_producao + "</span><br>";
                    }
                    if (!string.IsNullOrEmpty(item.duracao))
                    {
                        teste += "<strong>Duração:</strong><span>" + item.duracao + "</span><br>";
                    }
                    if (!string.IsNullOrEmpty(item.elenco))
                    {
                        teste += "<strong>Elenco:</strong><span>" + item.elenco + "</span><br>";
                    }
                    if (!string.IsNullOrEmpty(item.txt_sinopse))
                    {
                        teste += "<strong>Sinopse:</strong><span>" + item.txt_sinopse + "</span><br>";
                    }
                    teste += "</td></tr>";    
                    teste += "</tbody></table>";
                    divFilmesResult.Visible = true;
                    divFilmesResult.InnerHtml = teste;
                //}
            //}
        }
    }
}