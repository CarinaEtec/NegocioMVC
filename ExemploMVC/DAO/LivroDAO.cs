using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExemploMVC.Model; // inserir a ref p/ model p/ poder usar o Livro
using MySql.Data; // inserir as ref p/ o mysql
using MySql.Data.MySqlClient;
using System.Data; // inserir p/ usar o CommandType

namespace ExemploMVC.DAO
{
    class LivroDAO
    {
        public void Insert(Livro livro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(); //instanciar MySqlCommand p/ poder entrar com uma string mysql de insert
                comando.CommandType = CommandType.Text; //CommandType = informa q o comando é tipo texto
                comando.CommandText = "Insert into Livro(titulo,datapublicacao, autorId) values(@titulo,@datapublicacao,@autorId)";

                comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@datapublicacao", livro.Datapublicacao);
                comando.Parameters.AddWithValue("@autorId", livro.Autor.AutorId);
                ConexaoBanco.CRUD(comando); // Está sendo enviado p/ o método CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }



        public void Update(Livro livro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(); //instanciar MySqlCommand p/ poder entrar com uma string mysql de insert
                comando.CommandType = CommandType.Text; //CommandType = informa q o comando é tipo texto
                comando.CommandText = "Update livro set titulo=@titulo, datapublicacao=@datapublicacao, autorId=@autorId where livroId=@livroId";

                comando.Parameters.AddWithValue("@titulo", livro.Titulo);
                comando.Parameters.AddWithValue("@datapublicacao", livro.Datapublicacao);
                comando.Parameters.AddWithValue("@autorId", livro.Autor.AutorId);
                comando.Parameters.AddWithValue("@livroId", livro.LivroId);

                ConexaoBanco.CRUD(comando); // Está sendo enviado p/ o método CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }





    }
}
