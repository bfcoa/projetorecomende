using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.DAO;
using System.IO;

namespace Projeto_Recomende.Codes.BLL
{
    [Serializable]
    public class UsuarioBll
    {
        Usuario user;
        UsuarioDao userDao;
        public string Extencao { get; set; }


        public bool CadastrarUsuario(Usuario usuario, string confSenha, Foto foto, out string mensagemResposta)
        {
            mensagemResposta = "";
            try
            {
                if (string.IsNullOrEmpty(usuario.nm_usuario))
                    throw new Exception("Nome não pode ser vazio!");

                if (string.IsNullOrEmpty(usuario.email) || !usuario.email.Contains("@"))
                    throw new Exception("Email inválido!");

                if (string.IsNullOrEmpty(usuario.senha))
                    throw new Exception("Senha não pode ser vazia");

                if (!usuario.senha.Equals(confSenha))
                    throw new Exception("As senhas não conferem");


                UsuarioDao dao = new UsuarioDao();

                if (VerificaFoto(foto))
                {
                    if (dao.CadastrarUsuario(usuario))
                    {
                        usuario.end_foto = @"../Util/Imagens/ImagensUsuarios/" + usuario.id_usuario + "." + foto.NomeFoto.Split('.')[foto.NomeFoto.Split('.').Length - 1];
                        dao.UpdateFoto(usuario);
                    }
                }
                else
                {
                    dao.CadastrarUsuario(usuario);
                }

                return true;

            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                mensagemResposta = "Houve um erro ao inserir o usuário no Banco de dados. <br>\n Número do erro: " + sqlEx.Number;
                return false;
            }
            catch (Exception ex)
            {
                mensagemResposta = ex.Message;
                return false;
            }
        }

        public bool updateDadosUsuario(Usuario usuario, string senha, string confSenha, Foto foto, out string mensagemResposta)
        {
            mensagemResposta = "";
            try
            {
                if (string.IsNullOrEmpty(usuario.nm_usuario))
                    throw new Exception("Nome não pode ser vazio!");

                if (string.IsNullOrEmpty(usuario.email) || !usuario.email.Contains("@"))
                    throw new Exception("Email inválido!");

                if (string.IsNullOrEmpty(usuario.senha))
                    throw new Exception("Senha não pode ser vazia");

                if (!senha.Equals(confSenha))
                    throw new Exception("As senhas não conferem");


                UsuarioDao dao = new UsuarioDao();

                if (VerificaFoto(foto))
                {
                    if (dao.UpdateDadosUsuario(usuario) != null)
                    {
                        usuario.end_foto = @"../Util/Imagens/ImagensUsuarios/" + usuario.id_usuario + "." + foto.NomeFoto.Split('.')[foto.NomeFoto.Split('.').Length - 1];
                        dao.UpdateFoto(usuario);
                    }
                }
                else
                {
                    dao.UpdateFoto(usuario);
                    dao.UpdateDadosUsuario(usuario);
                }
                return true;
            }
            catch (System.Data.SqlClient.SqlException sqlEx)
            {
                mensagemResposta = "Houve um erro ao inserir o usuário no Banco de dados. <br>\n Número do erro: " + sqlEx.Number;
                return false;
            }
            catch (Exception ex)
            {
                mensagemResposta = ex.Message;
                return false;
            }
        }

        #region Comentario
        /*if (usuario != null)
            {
                userDao = new UsuarioDao();
                usuario = userDao.UpdateDadosUsuario(usuario);

                if (usuario != null)
                {
                    user = usuario;

                    return true;
                } */

        #endregion



        private bool VerificaFoto(Foto foto)
        {
            if (!string.IsNullOrEmpty(foto.NomeFoto))
            {
                string extensao = foto.NomeFoto.Split('.')[foto.NomeFoto.Split('.').Length - 1];
                if (extensao.ToLower().Equals("jpeg") || extensao.ToLower().Equals("jpg") || extensao.ToLower().Equals("bmp") || extensao.ToLower().Equals("gif") || extensao.ToLower().Equals("png"))
                    foto.FotoValida = true;
                else
                    throw new Exception("Formato de foto inválido");
            }
            return foto.FotoValida;
        }


        //public string CadastrarUsuario(bool fotoValida, Usuario usuario)
        //{
        //    try
        //    {
        //        userDao = new UsuarioDao();

        //        //if (fotoValida)
        //        //{
        //            userDao.CadastrarUsuario(usuario);
        //            return "Cadastro realizado com sucesso!";
        //        //}
        //        //throw new Exception();
        //    }
        //    catch (Exception ex)
        //    {
        //        return "Usuario Invalido!";
        //    }
        //}


        /*
        public bool verificaFoto(Usuario usuario)
        {
            char[] ext = usuario.end_foto.ToCharArray();
            Array.Reverse(ext);
            Extencao = "";

            foreach (var item in ext)
            {
                Extencao += item;
                if (item == '.')
                {
                    break;
                }
            }

            ext = Extencao.ToCharArray();
            Array.Reverse(ext);
            Extencao = "";
            foreach (var item in ext)
            {
                Extencao += item;
            }


            if (Extencao == ".jpeg" || Extencao == ".jpg" || Extencao == ".bmp" || Extencao == ".gif" || Extencao == ".png")
            {
                return true;
            }
            else
            {
                Extencao = "Imagem invalida!";
                return false;
            }
            
        }*/

        //public bool UpdateFoto(Usuario usuario)
        //{
        //    if (usuario.end_foto != @"../Util/Imagens/ImagensUsuarios/" + usuario.id_usuario + Extencao)
        //    {
        //        usuario.end_foto = userDao.UpdateFoto(usuario);
        //        return true;
        //    }
        //    return false;
        //}



        public Usuario loadUsuario(Usuario usuario)
        {
            try
            {
                userDao = new UsuarioDao();
                user = userDao.LoadUsuario(usuario.email, usuario.senha);
                if (user != null)
                    return user;

            }
            catch (Exception ex)
            {

            }
            return user;
        }
        public Usuario loadUsuario(string email, string senha, out string mensagemErro)
        {
            mensagemErro = "";
            try
            {
                userDao = new UsuarioDao();
                user = userDao.LoadUsuario(email, senha);
                if (user != null)
                    return user;
                else
                {
                    mensagemErro = "Usuário Inválido!!";
                    return user;
                }
                    
            }
            catch (Exception ex)
            {
                mensagemErro = "Erro ao carregar usuário! <br> Mensagem do erro: "+ex.Message;
                return null;
            }
            
        }
    }
}