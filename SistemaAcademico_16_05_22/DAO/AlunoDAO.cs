using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaAcademico_16_05_22.ConexaoSQL;
using SistemaAcademico_16_05_22.Model;


namespace SistemaAcademico_16_05_22.DAO
{
    class AlunoDAO
    {
        private Conexao conexao;

        public AlunoDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (conexao)
                MessageBox.Show("Conectou");
            else MessageBox.Show("Não conectou");
        }
        public void excluirAluno()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();
            Aluno aluno = new Aluno();

            string sql = "DELETE FROM Aluno WHERE numero =  " +aluno.NumeroA ;

            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);

        }

        public void incluirAluno(Aluno a)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();

            string sql = "INSERT INTO Aluno( numero, curso) " +
                 "VALUES" +
                "( " + a.NumeroA + ", '" + a.Curso + "' )";

            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);
        }

        public List<Aluno> ConsultarAluno()
        {
            Aluno aluno = null;
            List<Aluno> alunos = new List<Aluno>();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Aluno", Conexao.getConexao());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        aluno = new Aluno();

                        aluno.Nome = reader.GetString("Nome");
                        aluno.Login = reader.GetString("Login");
                        aluno.Senha = reader.GetString("Senha");
                        aluno.Perfil = reader.GetString("Perfil");
                        aluno.NumeroA = reader.GetInt32("numeroA");
                        aluno.Curso = reader.GetString("curso");
                        alunos.Add(aluno);

                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Conexao.FecharConexao();
            }



            return alunos;
        }
    }
}
