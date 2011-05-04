using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.IO;
using System.Web.UI.WebControls;

namespace Projeto_Recomende.Pages
{
    public partial class CadastroUsuario : System.Web.UI.Page
    {
        recomendeEntities entities = new recomendeEntities();

        tb_usuario usuario = new tb_usuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["User"] != null)
            {
                if (!IsPostBack)
                {
                    ViewState["usuario"] = Session["User"];
                    Session.Remove("User");
                }
                usuario = (tb_usuario)ViewState["usuario"];

                if (!IsPostBack)
                    FillAllCampos();
            }


        }
        private void FillAllCampos()
        {
            txtNome.Text = usuario.nm_usuario;
            txtEmail.Text = usuario.email;
            txtSenha.Text = string.Empty;
            txtConfirmaSenha.Text = string.Empty;
        }

        protected void bntConfirma_Click(object sender, EventArgs e)
        {

            if (txtNome.Text != string.Empty && txtEmail.Text != string.Empty && txtSenha.Text != string.Empty)
            {

                if (ViewState["usuario"] != null) // tem usuario
                {
                    usuario.nm_usuario = txtNome.Text;
                    usuario.email = txtEmail.Text;
                    usuario.senha = txtSenha.Text;
                /*    string caminho = Server.MapPath(@"/Util/Images/ImagensUsuarios/" + fuFotoPerfil.FileName);
                    usuario.end_foto = (@"/Util/Images/ImagensUsuarios/" + fuFotoPerfil.FileName);
                    
                    fuFotoPerfil.SaveAs(caminho);*/
                    
                }
                else  // vai cadastra novo usuario
                {
                    var query = (from user in entities.tb_usuario
                                 where user.email == txtEmail.Text
                                 select user).ToList<tb_usuario>();

                    if (query.Count != 1)
                    {
                        usuario.nm_usuario = txtNome.Text;
                        usuario.email = txtEmail.Text;
                        usuario.senha = txtSenha.Text;
                        string caminho = Server.MapPath(@"/Util/Images/ImagensUsuarios/" + fuFotoPerfil.FileName);
                        //    string caminho = @"/Util/Images/ImagensUsuarios/" + fuFotoPerfil.FileName;
                        //if (!File.Exists(caminho))
                        //{
                        usuario.end_foto = (@"/Util/Images/ImagensUsuarios/" + fuFotoPerfil.FileName);
                        fuFotoPerfil.SaveAs(caminho);
                        //}


                        entities.tb_usuario.AddObject(usuario);

                    }
                    else
                    {
                        lblMensagem.Text = "Email já cadastrado!";
                    }

                }
                entities.SaveChanges(System.Data.Objects.SaveOptions.AcceptAllChangesAfterSave);

                Session["usuario"] = usuario;
                Response.Redirect("PerfilUsuario.aspx");

            }
            else
            {
                lblMensagem.Text = "Preecha os campos em branco!";
            }
        }
    }
}