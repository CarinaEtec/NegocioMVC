using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExemploMVC.BO;
using ExemploMVC.Model;

namespace ExemploMVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            grpAutor.Enabled = false;
            grpLivro.Enabled = false;
        }

        private void btnNovoAutor_Click(object sender, EventArgs e)
        {
            grpAutor.Enabled = true;
        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            grpLivro.Enabled = true;
        }

        private void btnGravarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            autor.Nome = txtNome.Text;
            autor.Nacionalidade = txtNacionalidade.Text;

            autorBO.Gravar(autor);
            MessageBox.Show("Autor cadastrado com sucesso");

            grpAutor.Enabled = false;
            txtNome.Clear();
            txtNacionalidade.Clear();
        }

        private void btnGravarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livrobo = new LivroBO();


            livro.Titulo = txtTitulo.Text;
            livro.Datapublicacao = Convert.ToDateTime(txtDtPublicacao.Text);
            livro.Autor.AutorId = Convert.ToInt16(txtIdAutorLivro.Text);

            livrobo.Gravar(livro);
            MessageBox.Show("Livro cadastrado com sucesso");

            grpLivro.Enabled = false;
            txtTitulo.Clear();
            txtDtPublicacao.Clear();
            txtIdAutorLivro.Clear();
        }



        private void btnEditarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();
            autor.AutorId = Convert.ToInt16(txtAutorId.Text);
            autor.Nome = txtNome.Text;
            autor.Nacionalidade = txtNacionalidade.Text;

            autorBO.Editar(autor);
            MessageBox.Show("Autor editado com sucesso");

            grpAutor.Enabled = false;
            txtAutorId.Clear();
            txtNome.Clear();
            txtNacionalidade.Clear();
        }

        private void btnEditarLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livrobo = new LivroBO();

            livro.LivroId = Convert.ToInt16(txtLivroId.Text);
            livro.Titulo = txtTitulo.Text;
            livro.Datapublicacao = Convert.ToDateTime(txtDtPublicacao.Text);
            livro.Autor.AutorId = Convert.ToInt16(txtIdAutorLivro.Text);

            livrobo.Editar(livro);
            MessageBox.Show("Livro editado com sucesso");

            grpLivro.Enabled = false;
            txtTitulo.Clear();
            txtDtPublicacao.Clear();
            txtIdAutorLivro.Clear();
            txtLivroId.Clear();


        }



    }
}
