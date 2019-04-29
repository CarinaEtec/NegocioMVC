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
    }
}
