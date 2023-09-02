    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico_16_05_22.Model
{
    class Turma
    {
        private int identificador;
        private int semestre;
        private int ano;
        private bool ativa;
        private Professor professor;
        private  Disciplina disciplina;



        public int Identificador { get => identificador; set => identificador = value; }
        public int Semestre { get => semestre; set => semestre = value; }
        public int Ano { get => ano; set => ano = value; }
        public bool Ativa { get => ativa; set => ativa = value; }
        internal Professor Professor { get => professor; set => professor = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }

        public Turma()
        {

        }
    }
}
