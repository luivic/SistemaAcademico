using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico_16_05_22.Model
{
    class Aluno : Usuario
    {
        private string curso;
        private int numeroA;

        public string Curso { get => curso; set => curso = value; }
        public int NumeroA { get => numeroA; set => numeroA = value; }

        public Aluno() { }

        public Aluno(int numero, string nome, string login, string senha, string perfil, string curso, int numeroA)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.Perfil = perfil;
            this.numeroA = numeroA;
            this.curso = curso;


        }
    }
}
