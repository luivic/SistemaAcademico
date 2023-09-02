using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico_16_05_22.Model
{
    class Disciplina
    {
        private int codigo;
        private string nome;
        private int creditos;

        
        public string Nome { get => nome; set => nome = value; }
        public int Creditos { get => creditos; set => creditos = value; }
        public int Codigo { get => codigo; set => codigo = value; }
    }
}
