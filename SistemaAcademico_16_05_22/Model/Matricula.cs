using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico_16_05_22.Model
{
    class Matricula
    {
        private Aluno aluno;
        private Turma turma;
        private int nota1;
        private int noat2;
        private int exame;
        private int faltas;
        private bool aprovado;


        public int Nota1 { get => nota1; set => nota1 = value; }
        public int Noat2 { get => noat2; set => noat2 = value; }
        public int Exame { get => exame; set => exame = value; }
        public int Faltas { get => faltas; set => faltas = value; }
        public bool Aprovado { get => aprovado; set => aprovado = value; }
        internal Aluno Aluno { get => aluno; set => aluno = value; }
        internal Turma Turma { get => turma; set => turma = value; }

        public Matricula() { }
    }
}
