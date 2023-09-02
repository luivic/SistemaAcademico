using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico_16_05_22.Model
{
    class Professor : Usuario
    {
        private int numeroP;
        private string titulacao;

        public int NumeroP { get => numeroP; set => numeroP = value; }
        public string Titulacao { get => titulacao; set => titulacao = value; }

        public Professor() { }

        public Professor(int numero, string nome, string login, string senha, string perfil, int numeroP, string titulacao)
        {
            this.Numero = numero;
            this.Nome = nome;
            this.Login = login;
            this.Senha = senha;
            this.Perfil = perfil;
            this.numeroP = numeroP;
            this.titulacao = titulacao;
        }
    }
}
