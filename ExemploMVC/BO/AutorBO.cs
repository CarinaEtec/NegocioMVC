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
    public class AutorBO
    {
        public void Gravar(Autor autor)
        {
            AutorDAO autorDao = new AutorDAO();
            if ((autor.Nome != "") && (autor.Nacionalidade != ""))
            {
                autorDao.Insert(autor);
            }
        }


        public void Editar(Autor autor)
        {
            AutorDAO autorDao = new AutorDAO();
            if ((autor.Nome != "") && (autor.Nacionalidade != ""))
            {
                autorDao.Update(autor);
            }
        }


        public void Buscar(Autor autor)
        {
            AutorDAO autorDao = new AutorDAO();
            
            if (autor.AutorId > 0)
            {
                //Armazena o resultado buscado
                var autorTemp = autorDao.BuscaPorId(autor.AutorId);
                //preenche os dados do autor 
                autor.Nome = autorTemp.Nome;
                autor.Nacionalidade = autorTemp.Nacionalidade;
            }
        }




    }
}
