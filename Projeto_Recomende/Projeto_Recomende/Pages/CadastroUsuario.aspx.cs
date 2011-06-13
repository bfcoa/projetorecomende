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
        Usuario user;
        UsuarioBll userBll;
        public string path = "";
        bool cadastroNovo;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["User"] != null && !IsPostBack)
            {
                //ViewState["usuario"] = Session["User"];
                user = (Usuario)Session["usuario"];
                //Session.Remove("User");

                txtNome.Text = user.nm_usuario;
                txtEmail.Text = user.email;
                txtSenha.Text = string.Empty;
                txtConfirmaSenha.Text = string.Empty;

            }
            if (Session["usuario"] != null)
            {
                cadastroNovo = false;
            }
            else
                cadastroNovo = true;
            //if (Session["User"] != null)
            //{
            //    ViewState["usuario"] = Session["User"];
            //    Session.Remove("User");
            //}
            ////Upload de imagens para o avatar
          /*  if (Page.IsPostBack)
            {
                if (AsyncFileUpload1.HasFile)
                {
                    AsyncFileUpload1.SaveAs(Server.MapPath(@"~\Util\Imagens\ImagensUsuarios\" + AsyncFileUpload1.FileName));
                    Image1.ImageUrl = "../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;
                    Image1.Height = 70;
                    Image1.Visible = true;
                    Image1.DataBind();
                }
            }*/

        }

        protected void bntConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                if (cadastroNovo == true)
                {
                    userBll = new UsuarioBll();
                    user = new Usuario();

                    user.nm_usuario = txtNome.Text;
                    user.senha = txtSenha.Text;
                    user.email = txtEmail.Text;
                    user.end_foto = @"../Util/Imagens/ImagensUsuarios/Anonymous.png";
                    user.tipo_usuario = "usuario";
                    //bool fotoValida = userBll.verificaFoto(user);

                    //if (fotoValida)
                    //{
                    //    AsyncFileUpload1.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName));
                    //    path = @"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;

                    //    lblMensagem.Text = userBll.CadastrarUsuario(fotoValida, user);
                    //    File.Move(Server.MapPath(path), Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + user.id_usuario + userBll.Extencao));
                    //    bool fotoAtualizada = userBll.updateFoto(user);
                    //}
                    userBll.CadastrarUsuario(false, user);
                }
                else
                {
                    userBll = new UsuarioBll();
                    user = (Usuario)Session["usuario"];

                    //bool fotoValida = userBll.verificaFoto(user);
                    //if (fotoValida)
                    //{
                    //   // fuFotoPerfil.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + fuFotoPerfil.FileName));
                    //        AsyncFileUpload1.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName));
                    //   // path = @"../Util/Imagens/ImagensUsuarios/" + fuFotoPerfil.FileName;
                    //        path = @"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;

                    //    //lblMensagem.Text = userBll.CadastrarUsuario(fotoValida, user);
                    //    File.Delete(Server.MapPath(user.end_foto));
                    //    File.Move(Server.MapPath(path), Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + user.id_usuario + userBll.Extencao));
                        bool fotoAtualizada = userBll.updateFoto(user);
                    //  //  bool dadosAtualizado = userBll.updateDadosUsuario(user);
                    //}

                }

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
                Session["usuario"] = user;
                Response.Redirect("~/Pages/UpdateFoto.aspx");
            }
            catch (Exception ex)
            {
                lblMensagem.Text = "Ocorreram problemas na conclusão de seu cadastro";
            }
        }

     /*   protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (AsyncFileUpload1.HasFile)
            {
                ViewState["NewUser"] = AsyncFileUpload1.FileName;
            }
        }*/
    }
}