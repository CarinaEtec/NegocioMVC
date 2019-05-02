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
    class AutorDAO
    {
        public void Insert(Autor autor)
        {
            try
            {
                MySqlCommand comando = new MySqlCommand(); //instancias MySqlCommand p/ poder entrar com uma string mysql de insert
                comando.CommandType = CommandType.Text; //CommandType = informa q o comando é tipo texto
                comando.CommandText = "Insert into Autor(nome,nacionalidade) values(@nome,@nacionalidade)";

                comando.Parameters.AddWithValue("@nome", autor.Nome);
                comando.Parameters.AddWithValue("@nacionalidade", autor.Nacionalidade);

                ConexaoBanco.CRUD(comando); // Está sendo enviado p/ o método CRUD
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possível se conectar" + ex.Message);
            }

        }

        public Autor BuscaPorId(int id) // o SELECT retorna um valor, que é o livro buscado
        {
            MySqlCommand comando = new MySqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "Select * from Autor where autorId=@id";

              comando.Parameters.AddWithValue("@id", id);

            //MySqlDataReader retorna uma tabela do BD
            MySqlDataReader dr = ConexaoBanco.Selecionar(comando);

            Autor autor = new Autor();//instancia para poder retornar um valor
            // se dr tiver linhas preenchidas
            if (dr.HasRows)
            {
                //preenche o objeto
                dr.Read();
                autor.AutorId = (int)dr["autorId"];
                autor.Nacionalidade = (string)dr["nacionalidade"];
               autor.Nome = (string)dr["nome"];
            }
            else
            {
                //coloca null no objeto
                autor = null;
            }
            return autor;
        }


    }
}
