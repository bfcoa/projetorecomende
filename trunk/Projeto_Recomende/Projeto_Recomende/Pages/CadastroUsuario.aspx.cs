using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.BLL;

namespace Projeto_Recomende.Pages
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        //recomendeEntities entities = new recomendeEntities();
        //tb_usuario usuario = new tb_usuario();
        Usuario user;
        UsuarioBll userBll;
        public string path = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                ViewState["usuario"] = Session["User"];
                Session.Remove("User");
            }
            //Upload de imagens para o avatar
            if (Page.IsPostBack)
            {
                if (FileUpload1.HasFile)
                {
                    FileUpload1.SaveAs(Server.MapPath(@"~\Util\Imagens\ImagensUsuarios\" + FileUpload1.FileName));
                    Image1.ImageUrl = "../Util/Imagens/ImagensUsuarios/" + FileUpload1.FileName;
                    Image1.Height = 70;
                    Image1.Visible = true;
                    Image1.DataBind();
                }
            }
        }

        protected void bntConfirma_Click(object sender, EventArgs e)
        {

            try
            {
                //userBll = new UsuarioBll();
                //user = new Usuario();

                //user.nm_usuario = txtNome.Text;
                //user.senha = txtSenha.Text;
                //user.email = txtEmail.Text;
                //user.end_foto = @"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;
                //user.tipo_usuario = "usuario";
                //bool fotoValida = userBll.verificaFoto(user);

                //if (fotoValida)
                //{
                //    AsyncFileUpload1.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName));
                //    path = @"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;

                //    lblMensagem.Text  =  userBll.CadastrarUsuario(fotoValida, user);
                //    File.Move(Server.MapPath(path), Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + user.id_usuario + userBll.Extencao));
                //    bool fotoAtualizada = userBll.updateFoto(user);
                //}
                //throw new Exception();

            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Usuario Invalido!";
            }

            if (lblMensagem.Text != "Usuario Invalido!")
            {
                Session["usuario"] = user;
                Response.Redirect("~/Pages/PerfilUsuario.aspx");
            }
        }
    }
}