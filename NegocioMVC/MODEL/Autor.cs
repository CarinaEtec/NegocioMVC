﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NegocioMVC.Model
{
    public class Autor //add public para q as outras classes possam enxergar
    {
        private int autorId;
        private string nome;
        private string nacionalidade;

        public int AutorId { get => autorId; set => autorId = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Nacionalidade { get => nacionalidade; set => nacionalidade = value; }
    }
}
