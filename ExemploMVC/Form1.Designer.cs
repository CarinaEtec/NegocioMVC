namespace ExemploMVC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpAutor = new System.Windows.Forms.GroupBox();
            this.txtNacionalidade = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtAutorId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpLivro = new System.Windows.Forms.GroupBox();
            this.txtIdAutorLivro = new System.Windows.Forms.TextBox();
            this.txtDtPublicacao = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtLivroId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNovoAutor = new System.Windows.Forms.Button();
            this.btnGravarAutor = new System.Windows.Forms.Button();
            this.btnNovoLivro = new System.Windows.Forms.Button();
            this.btnGravarLivro = new System.Windows.Forms.Button();
            this.btnBuscarAutor = new System.Windows.Forms.Button();
            this.btnEditarAutor = new System.Windows.Forms.Button();
            this.btnEditarLivro = new System.Windows.Forms.Button();
            this.btnBuscarLivro = new System.Windows.Forms.Button();
            this.grpAutor.SuspendLayout();
            this.grpLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAutor
            // 
            this.grpAutor.Controls.Add(this.txtNacionalidade);
            this.grpAutor.Controls.Add(this.txtNome);
            this.grpAutor.Controls.Add(this.txtAutorId);
            this.grpAutor.Controls.Add(this.label3);
            this.grpAutor.Controls.Add(this.label2);
            this.grpAutor.Controls.Add(this.label1);
            this.grpAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAutor.Location = new System.Drawing.Point(23, 33);
            this.grpAutor.Name = "grpAutor";
            this.grpAutor.Size = new System.Drawing.Size(490, 142);
            this.grpAutor.TabIndex = 0;
            this.grpAutor.TabStop = false;
            this.grpAutor.Text = "Autor";
            // 
            // txtNacionalidade
            // 
            this.txtNacionalidade.Location = new System.Drawing.Point(190, 96);
            this.txtNacionalidade.Name = "txtNacionalidade";
            this.txtNacionalidade.Size = new System.Drawing.Size(262, 21);
            this.txtNacionalidade.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(190, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 21);
            this.txtNome.TabIndex = 4;
            // 
            // txtAutorId
            // 
            this.txtAutorId.Location = new System.Drawing.Point(190, 28);
            this.txtAutorId.Name = "txtAutorId";
            this.txtAutorId.Size = new System.Drawing.Size(262, 21);
            this.txtAutorId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nacionalidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Autor ID";
            // 
            // grpLivro
            // 
            this.grpLivro.Controls.Add(this.txtIdAutorLivro);
            this.grpLivro.Controls.Add(this.txtDtPublicacao);
            this.grpLivro.Controls.Add(this.txtTitulo);
            this.grpLivro.Controls.Add(this.txtLivroId);
            this.grpLivro.Controls.Add(this.label7);
            this.grpLivro.Controls.Add(this.label6);
            this.grpLivro.Controls.Add(this.label5);
            this.grpLivro.Controls.Add(this.label4);
            this.grpLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLivro.Location = new System.Drawing.Point(23, 236);
            this.grpLivro.Name = "grpLivro";
            this.grpLivro.Size = new System.Drawing.Size(490, 168);
            this.grpLivro.TabIndex = 1;
            this.grpLivro.TabStop = false;
            this.grpLivro.Text = "Livro";
            // 
            // txtIdAutorLivro
            // 
            this.txtIdAutorLivro.Location = new System.Drawing.Point(190, 134);
            this.txtIdAutorLivro.Name = "txtIdAutorLivro";
            this.txtIdAutorLivro.Size = new System.Drawing.Size(262, 21);
            this.txtIdAutorLivro.TabIndex = 6;
            // 
            // txtDtPublicacao
            // 
            this.txtDtPublicacao.Location = new System.Drawing.Point(190, 101);
            this.txtDtPublicacao.Name = "txtDtPublicacao";
            this.txtDtPublicacao.Size = new System.Drawing.Size(262, 21);
            this.txtDtPublicacao.TabIndex = 5;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(190, 68);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(262, 21);
            this.txtTitulo.TabIndex = 4;
            // 
            // txtLivroId
            // 
            this.txtLivroId.Location = new System.Drawing.Point(190, 31);
            this.txtLivroId.Name = "txtLivroId";
            this.txtLivroId.Size = new System.Drawing.Size(262, 21);
            this.txtLivroId.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "Autor ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Data Publicação";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Livro ID";
            // 
            // btnNovoAutor
            // 
            this.btnNovoAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoAutor.Location = new System.Drawing.Point(529, 33);
            this.btnNovoAutor.Name = "btnNovoAutor";
            this.btnNovoAutor.Size = new System.Drawing.Size(100, 30);
            this.btnNovoAutor.TabIndex = 2;
            this.btnNovoAutor.Text = "Novo Autor";
            this.btnNovoAutor.UseVisualStyleBackColor = true;
            this.btnNovoAutor.Click += new System.EventHandler(this.btnNovoAutor_Click);
            // 
            // btnGravarAutor
            // 
            this.btnGravarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarAutor.Location = new System.Drawing.Point(529, 71);
            this.btnGravarAutor.Name = "btnGravarAutor";
            this.btnGravarAutor.Size = new System.Drawing.Size(100, 30);
            this.btnGravarAutor.TabIndex = 3;
            this.btnGravarAutor.Text = "Gravar Autor";
            this.btnGravarAutor.UseVisualStyleBackColor = true;
            this.btnGravarAutor.Click += new System.EventHandler(this.btnGravarAutor_Click);
            // 
            // btnNovoLivro
            // 
            this.btnNovoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovoLivro.Location = new System.Drawing.Point(529, 242);
            this.btnNovoLivro.Name = "btnNovoLivro";
            this.btnNovoLivro.Size = new System.Drawing.Size(100, 30);
            this.btnNovoLivro.TabIndex = 4;
            this.btnNovoLivro.Text = "Novo Livro";
            this.btnNovoLivro.UseVisualStyleBackColor = true;
            this.btnNovoLivro.Click += new System.EventHandler(this.btnNovoLivro_Click);
            // 
            // btnGravarLivro
            // 
            this.btnGravarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravarLivro.Location = new System.Drawing.Point(529, 278);
            this.btnGravarLivro.Name = "btnGravarLivro";
            this.btnGravarLivro.Size = new System.Drawing.Size(100, 30);
            this.btnGravarLivro.TabIndex = 5;
            this.btnGravarLivro.Text = "Gravar Livro";
            this.btnGravarLivro.UseVisualStyleBackColor = true;
            this.btnGravarLivro.Click += new System.EventHandler(this.btnGravarLivro_Click);
            // 
            // btnBuscarAutor
            // 
            this.btnBuscarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarAutor.Location = new System.Drawing.Point(529, 108);
            this.btnBuscarAutor.Name = "btnBuscarAutor";
            this.btnBuscarAutor.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarAutor.TabIndex = 6;
            this.btnBuscarAutor.Text = "Buscar Autor";
            this.btnBuscarAutor.UseVisualStyleBackColor = true;
            // 
            // btnEditarAutor
            // 
            this.btnEditarAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarAutor.Location = new System.Drawing.Point(529, 144);
            this.btnEditarAutor.Name = "btnEditarAutor";
            this.btnEditarAutor.Size = new System.Drawing.Size(100, 30);
            this.btnEditarAutor.TabIndex = 7;
            this.btnEditarAutor.Text = "Editar Autor";
            this.btnEditarAutor.UseVisualStyleBackColor = true;
            this.btnEditarAutor.Click += new System.EventHandler(this.btnEditarAutor_Click);
            // 
            // btnEditarLivro
            // 
            this.btnEditarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarLivro.Location = new System.Drawing.Point(529, 365);
            this.btnEditarLivro.Name = "btnEditarLivro";
            this.btnEditarLivro.Size = new System.Drawing.Size(100, 30);
            this.btnEditarLivro.TabIndex = 9;
            this.btnEditarLivro.Text = "Editar Livro";
            this.btnEditarLivro.UseVisualStyleBackColor = true;
            this.btnEditarLivro.Click += new System.EventHandler(this.btnEditarLivro_Click);
            // 
            // btnBuscarLivro
            // 
            this.btnBuscarLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarLivro.Location = new System.Drawing.Point(529, 326);
            this.btnBuscarLivro.Name = "btnBuscarLivro";
            this.btnBuscarLivro.Size = new System.Drawing.Size(100, 30);
            this.btnBuscarLivro.TabIndex = 8;
            this.btnBuscarLivro.Text = "Buscar Livro";
            this.btnBuscarLivro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 423);
            this.Controls.Add(this.btnEditarLivro);
            this.Controls.Add(this.btnBuscarLivro);
            this.Controls.Add(this.btnEditarAutor);
            this.Controls.Add(this.btnBuscarAutor);
            this.Controls.Add(this.btnGravarLivro);
            this.Controls.Add(this.btnNovoLivro);
            this.Controls.Add(this.btnGravarAutor);
            this.Controls.Add(this.btnNovoAutor);
            this.Controls.Add(this.grpLivro);
            this.Controls.Add(this.grpAutor);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpAutor.ResumeLayout(false);
            this.grpAutor.PerformLayout();
            this.grpLivro.ResumeLayout(false);
            this.grpLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAutor;
        private System.Windows.Forms.TextBox txtNacionalidade;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtAutorId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpLivro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdAutorLivro;
        private System.Windows.Forms.TextBox txtDtPublicacao;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtLivroId;
        private System.Windows.Forms.Button btnNovoAutor;
        private System.Windows.Forms.Button btnGravarAutor;
        private System.Windows.Forms.Button btnNovoLivro;
        private System.Windows.Forms.Button btnGravarLivro;
        private System.Windows.Forms.Button btnBuscarAutor;
        private System.Windows.Forms.Button btnEditarAutor;
        private System.Windows.Forms.Button btnEditarLivro;
        private System.Windows.Forms.Button btnBuscarLivro;
    }
}

