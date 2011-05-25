using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projeto_Recomende.Codes.OBJ;
using Projeto_Recomende.Codes.DAO;
using System.IO;

namespace Projeto_Recomende.Codes.BLL
{
    public class UsuarioBll
    {
        Usuario user;
        UsuarioDao userDao;

        public string CadastrarUsuario(bool fotoValida, Usuario usuario)
        {
            try
            {
                if (fotoValida)
                {
                    userDao.CadastrarUsuario(user);
                    return "Cadastro realizado com sucesso!";
                }
                throw new Exception();
            }
            catch (Exception)
            {
                return "Usuario Invalido!";
            }
        }

        public bool verificaFoto(Usuario usuario)
        {
            char[] ext = usuario.end_foto.ToCharArray();
            Array.Reverse(ext);
            string extencao = "";

            foreach (var item in ext)
            {
                extencao += item;
                if (item == '.')
                {
                    break;
                }
            }

            ext = extencao.ToCharArray();
            Array.Reverse(ext);
            extencao = ext.ToString();

            if (extencao == ".jpeg" || extencao == ".jpg" || extencao == ".bmp" || extencao == ".gif" || extencao == ".png")
            {
                return true;
            }
            else
            {
                extencao = "Imagem invalida!";
                return false;
            }

        }

    }
}