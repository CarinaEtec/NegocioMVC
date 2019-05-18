using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using p/ BO pois ele acessa os 2 níveis, Model e DAO
using ExemploMVC.DAO;
using ExemploMVC.Model;

namespace ExemploMVC.BO
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


    }
}
