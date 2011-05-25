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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                ViewState["usuario"] = Session["User"];
                Session.Remove("User");
            }
        }


        protected void bntConfirma_Click(object sender, EventArgs e)
        {

            try
            {
                userBll = new UsuarioBll();
                user = new Usuario();
                user.nm_usuario = txtNome.Text;
                user.senha = txtSenha.Text;
                user.email = txtEmail.Text;
                user.end_foto = Server.MapPath(@"../Util/ImagensUsuarios/" + fuFotoPerfil.FileName);
                bool fotoValida = userBll.verificaFoto(user);

                if (fotoValida)
                {
                    fuFotoPerfil.SaveAs(Server.MapPath(@"../Util/ImagensUsuarios/" + fuFotoPerfil.FileName));
                    string path = Server.MapPath(@"../Util/ImagensUsuarios/" + fuFotoPerfil.FileName);

                    userBll.CadastrarUsuario(fotoValida, user);
                    File.Move(path, Server.MapPath(@"../Util/ImagensUsuarios/" + user.id_usuario));
                    Response.Redirect("PerfilUsuario.aspx");
                }
                throw new Exception();

            }
            catch (Exception)
            {
                lblMensagem.Text = "Usuario Invalido!";
            }
        }
    }
}