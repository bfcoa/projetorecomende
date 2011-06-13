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
        Foto foto;
        Usuario user;
        UsuarioBll userBll;
        public string path = "";
        bool cadastroNovo;

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["usuario"] != null && !IsPostBack)
            {
                user = (Usuario)Session["usuario"];
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


            #region Comentado
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
            #endregion
        }

        protected void bntConfirma_Click(object sender, EventArgs e)
        {
            try
            {
                string mensagemErro = "";   

                if (cadastroNovo == true)
                {
                                     
                    user = new Usuario();
                    
                    userBll = new UsuarioBll();
                    user.nm_usuario = txtNome.Text;
                    user.senha = txtSenha.Text;
                    user.email = txtEmail.Text;
                    user.end_foto = @"../Util/Imagens/ImagensSite/semfoto.jpg";
                    user.tipo_usuario = "usuario";

                    foto = new Foto();
                    foto.NomeFoto = AsyncFileUpload1.FileName;
                    foto.FotoValida = false;

                    if (userBll.CadastrarUsuario(user, txtConfirmaSenha.Text, foto, out mensagemErro))
                    {
                        if (foto.FotoValida)
                            AsyncFileUpload1.SaveAs(Server.MapPath(user.end_foto));
                        Session["usuario"] = user;
                        Response.Redirect("~/Pages/PerfilUsuario.aspx");
                    }
                    else
                    {
                        lblMensagem.Text = mensagemErro;
                        lblMensagem.Visible = true;
                    }

                    #region Comentado
                    //bool fotoValida = userBll.verificaFoto(user);
                    //if (fotoValida)
                    //{
                    //    AsyncFileUpload1.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName));
                    //    path = @"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;

                    //    lblMensagem.Text = userBll.CadastrarUsuario(fotoValida, user);
                    //    File.Move(Server.MapPath(path), Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + user.id_usuario + userBll.Extencao));
                    //    bool fotoAtualizada = userBll.updateFoto(user);
                    //}
                    //userBll.CadastrarUsuario(false, user);
                    #endregion
                }
                else // cadastro velho
                {
                    //aqui estará a edição né?
                    
                    userBll = new UsuarioBll();
                    user = (Usuario)Session["usuario"];

                    if (userBll.updateDadosUsuario(user, txtConfirmaSenha.Text, foto, out mensagemErro))
                    {
                        if (foto.FotoValida)
                        {
                            AsyncFileUpload1.SaveAs(Server.MapPath(user.end_foto));                      
                        }
                        else if (File.Exists(Server.MapPath(user.end_foto) )&& foto.FotoValida == false )
                        {
                            File.Delete(user.end_foto);                        
                        }
                    }
                    #region Comentado
                    ////bool fotoValida = userBll.verificaFoto(user);
                    ////if (fotoValida)
                    ////{
                    ////   // fuFotoPerfil.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + fuFotoPerfil.FileName));
                    ////        AsyncFileUpload1.SaveAs(Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName));
                    ////   // path = @"../Util/Imagens/ImagensUsuarios/" + fuFotoPerfil.FileName;
                    ////        path = @"../Util/Imagens/ImagensUsuarios/" + AsyncFileUpload1.FileName;

                    ////    //lblMensagem.Text = userBll.CadastrarUsuario(fotoValida, user);
                    ////    File.Delete(Server.MapPath(user.end_foto));
                    ////    File.Move(Server.MapPath(path), Server.MapPath(@"../Util/Imagens/ImagensUsuarios/" + user.id_usuario + userBll.Extencao));
                    //    //bool fotoAtualizada = userBll.updateFoto(user);
                    ////  //  bool dadosAtualizado = userBll.updateDadosUsuario(user);
                    ////}
                    #endregion
                }

                #region Comentado
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
                //Session["usuario"] = user;
                //Response.Redirect("~/Pages/UpdateFoto.aspx");
                #endregion
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