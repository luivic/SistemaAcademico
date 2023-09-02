using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademico_16_05_22.Model
{
    class Usuario
    {
        private int numero;
        private string nome;
        private string login;
        private string senha;
        private string perfil;

        public int Numero { get => numero; set => numero = value; }
        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Perfil { get => perfil; set => perfil = value; }

        public Usuario() { }

        public Usuario(int numero, string nome, string login, string senha, string perfil)
        {
            this.numero = numero;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.perfil = perfil;
        }
    }
}
