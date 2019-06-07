using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using p/ BO pois ele acessa os 2 níveis, Model e DAO
using NegocioMVC.DAO;
using NegocioMVC.Model;

namespace NegocioMVC.BO
{
    public class LivroBO
    {

        public void Gravar(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();
            if ((livro.Titulo != "") && (livro.Autor.AutorId != 0))
            {
                livroDao.Insert(livro);
            }
        }


        public void Editar(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();
            if ((livro.Titulo != "") && (livro.Autor.AutorId != 0))
            {
                livroDao.Update(livro);
            }
        }


        public void Buscar(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();

            if (livro.LivroId > 0)
            {
                //Armazena o resultado buscado
                var livroTemp = livroDao.BuscaPorId(livro.LivroId);
                //preenche os dados do autor 
                livro.Titulo = livroTemp.Titulo;
                livro.Datapublicacao = livroTemp.Datapublicacao;
                livro.Autor.AutorId = livroTemp.Autor.AutorId;

            }
        }

        public void Deletar(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();
            if (livro.LivroId > 0)
            {
                livroDao.Delete(livro);
            }
        }



        public IList<Livro> BuscarPorTitulo(Livro livro)
        {
            LivroDAO livroDao = new LivroDAO();

            if (livro.Titulo != "")
            {
                IList<Livro> livroTemp = livroDao.BuscaPorLivro(livro.Titulo);
                return livroTemp;
            }
            else
            {
                return null;
            }
        }

        
        
    }
}
