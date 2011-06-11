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

        public string CadastrarUsuario(bool fotoValida, Usuario usuario)
        {
            try
            {
                userDao = new UsuarioDao();

                if (fotoValida)
                {
                    userDao.CadastrarUsuario(usuario);
                    return "Cadastro realizado com sucesso!";
                }
                throw new Exception();
            }
            catch (Exception ex)
            {
                return "Usuario Invalido!";
            }
        }

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

        }

        public bool updateFoto(Usuario usuario)
        {
            if (usuario.end_foto != @"../Util/Imagens/ImagensUsuarios/" + usuario.id_usuario + Extencao)
            {
                usuario.end_foto = userDao.UpdateFoto(usuario, Extencao);

                return true;
            }
            return false;
        }

        public bool updateDadosUsuario(Usuario usuario)
        {

            if (usuario != null)
            {
                userDao = new UsuarioDao();
                usuario = userDao.UpdateDadosUsuario(usuario);

                if (usuario != null)
                {
                    user = usuario;

                    return true;
                }
            }
            return false;
        }

        public Usuario loadUsuario(Usuario usuario)
        {
            try
            {
                userDao = new UsuarioDao();

                user = userDao.LoadUsuario(usuario.email, usuario.senha);
                if (user != null)
                {
                    return user;
                }

            }
            catch (Exception ex)
            {

            }

            return null;
        }
        public Usuario loadUsuario(string email, string senha)
        {
            try
            {
                userDao = new UsuarioDao();

                user = userDao.LoadUsuario(email, senha);
                if (user != null)
                {
                    return user;
                }

            }
            catch (Exception ex)
            {

            }

            return null;
        }
    }
}