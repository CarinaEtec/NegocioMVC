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

            btnBuscar.Visible = false;
            btnGravarAutor.Enabled = false;
            btnEditarAutor.Enabled = false;
            btnExcluirAutor.Enabled = false;

            btnBuscarL.Visible = false;
            btnGravarLivro.Enabled = false;
            btnEditarLivro.Enabled = false;
            btnExcluirLivro.Enabled = false;


        }

        private void btnNovoAutor_Click(object sender, EventArgs e)
        {
            grpAutor.Enabled = true;
            btnBuscarAutor.Enabled = false;
            btnEditarAutor.Enabled = false;
            btnGravarAutor.Enabled = true;



        }

        private void btnNovoLivro_Click(object sender, EventArgs e)
        {
            grpLivro.Enabled = true;
            btnBuscarLivro.Enabled = false;
            btnEditarLivro.Enabled = false;
            btnGravarLivro.Enabled = true;

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

            btnEditarAutor.Enabled = false;
            btnExcluirAutor.Enabled = false;
            btnBuscarAutor.Enabled = true;
            btnNovoAutor.Enabled = true;
            btnGravarAutor.Enabled = false;


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

            btnEditarLivro.Enabled = false;
            btnExcluirLivro.Enabled = false;
            btnBuscarLivro.Enabled = true;
            btnNovoLivro.Enabled = true;
            btnGravarLivro.Enabled = false;
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


            btnBuscar.Visible = false;
            btnGravarAutor.Enabled = false;
            btnEditarAutor.Enabled = false;
            btnNovoAutor.Enabled = true;
            btnExcluirAutor.Enabled = false;



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

            btnBuscarL.Visible = false;
            btnGravarLivro.Enabled = false;
            btnEditarLivro.Enabled = false;
            btnNovoLivro.Enabled = true;
            btnExcluirLivro.Enabled = false;

        }

        private void btnBuscarAutor_Click(object sender, EventArgs e)
        {
            txtAutorId.Enabled = true;
            btnBuscar.Visible = true;
            grpAutor.Enabled = true;
            btnEditarAutor.Enabled = true;
            btnNovoAutor.Enabled = false;
            btnGravarAutor.Enabled = false;
            btnExcluirAutor.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            try
            {
                autor.AutorId = Convert.ToInt16(txtAutorId.Text);
                autorBO.Buscar(autor);

                if (autor.Nome == "")
                {
                    MessageBox.Show("Autor não encontrado");
                    txtAutorId.Clear();
                    txtNome.Clear();
                    txtNacionalidade.Clear();
                }
                else
                {
                    txtNome.Text = autor.Nome;
                    txtNacionalidade.Text = autor.Nacionalidade;
                }

            }

            catch
            {
                MessageBox.Show("Preencha corretamente as informações");

            }


        }

        private void btnBuscarLivro_Click(object sender, EventArgs e)
        {
            txtLivroId.Enabled = true;
            btnBuscarL.Visible = true;
            grpLivro.Enabled = true;
            btnEditarLivro.Enabled = true;
            btnNovoLivro.Enabled = false;
            btnGravarLivro.Enabled = false;
            btnExcluirLivro.Enabled = true;

        }

        private void btnBuscarL_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();

            try
            {
                livro.LivroId = Convert.ToInt16(txtLivroId.Text);
                livroBO.Buscar(livro);


                if (livro.Titulo == "")
                {
                    MessageBox.Show("Livro não encontrado");
                    txtLivroId.Clear();
                    txtTitulo.Clear();
                    txtDtPublicacao.Clear();
                    txtIdAutorLivro.Clear();
                }
                else
                {
                    txtTitulo.Text = livro.Titulo;
                    txtDtPublicacao.Text = Convert.ToString(livro.Datapublicacao);
                    //livro.Datapublicacao = Convert.ToDateTime(txtDtPublicacao.Text);
                    //livro.Autor.AutorId = Convert.ToInt16(txtIdAutorLivro.Text);
                    txtIdAutorLivro.Text = Convert.ToString(livro.Autor.AutorId);
                }
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");
            }
        }

        private void btnExcluirAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            AutorBO autorBO = new AutorBO();

            try
            {
                autor.AutorId = Convert.ToInt16(txtAutorId.Text);
                autorBO.Deletar(autor);

                MessageBox.Show("Autor excluído com sucesso");
                grpAutor.Enabled = false;
                txtAutorId.Clear();
                txtNome.Clear();
                txtNacionalidade.Clear();
                btnExcluirAutor.Enabled = false;
                btnGravarAutor.Enabled = false;
                btnNovoAutor.Enabled = true;
                btnBuscarAutor.Enabled = true;
                btnEditarAutor.Enabled = false;

            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");

            }
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {
            Livro livro = new Livro();
            LivroBO livroBO = new LivroBO();

            try
            {
                livro.LivroId = Convert.ToInt16(txtLivroId.Text);
                livroBO.Deletar(livro);

                MessageBox.Show("Livro excluído com sucesso");
                grpLivro.Enabled = false;
                txtLivroId.Clear();
                txtTitulo.Clear();
                txtDtPublicacao.Clear();
                txtIdAutorLivro.Clear();


                btnExcluirLivro.Enabled = false;
                btnGravarLivro.Enabled = false;
                btnNovoLivro.Enabled = true;
                btnBuscarLivro.Enabled = true;
                btnEditarLivro.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Preencha corretamente as informações");

            }
        }
    }
}
