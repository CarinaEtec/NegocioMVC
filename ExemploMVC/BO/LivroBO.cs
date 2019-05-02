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
            Form1 form = new Form1();

            if ((livro.Titulo != "") && (livro.Autor.AutorId != 0))
            {
                livroDao.Insert(livro);
            }
        }
    }
}
