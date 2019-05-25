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


        public Livro BuscaPorId(int id) // o SELECT retorna um valor, que é o livro buscado
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Livro where livroId=@id";

            comando.Parameters.AddWithValue("@id", id);

            //MySqlDataReader retorna uma tabela do BD
            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Livro livro = new Livro();//instancia para poder retornar um valor
            // se dr tiver linhas preenchidas
            if (dr.HasRows)
            {
                //preenche o objeto
                dr.Read();
                livro.LivroId = (int)dr["livroId"];
                livro.Titulo = (string)dr["titulo"];
                livro.Datapublicacao = (DateTime)dr["datapublicacao"];
                livro.Autor.AutorId = (int)dr["autorId"];
            }
            else
            {
                //zera o objeto
                livro.LivroId = 0;
                livro.Titulo = "";
                //livro.Datapublicacao = '0000-00-00';
                livro.Autor.AutorId = 0;
            }
            return livro;
        }


        public void Delete(Livro livro)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "Delete from livro where livroId=@livroId";

                comando.Parameters.AddWithValue("@livroId", livro.LivroId);

                ConexaoBanco.CRUD(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }


    }
}
