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
    class ProfessorDAO
    {
        private Conexao conexao;

        public ProfessorDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (conexao)
                MessageBox.Show("Conectou");
            else MessageBox.Show("Não conectou");
        }

        public void incluirProfessor(Professor prof)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();

            string sql = "INSERT INTO Professor( numeroP, titulacao )"  +
                "VALUES" +
                "(" + prof.NumeroP + ", '" + prof.Titulacao + "' )";
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);
        }


        public void excluirProfessor()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();
            Professor prof = new Professor();

            string sql = "DELETE FROM Professor WHERE numero =  " +prof.NumeroP ;
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);

        }

        public List<Professor> ConsultarPorfessor()
        {
            Professor professor = null;
            List<Professor> professores = new List<Professor>();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Professor", Conexao.getConexao());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        professor = new Professor();

                        professor.NumeroP = reader.GetInt32("numeroP");
                        professor.Titulacao = reader.GetString("titulacao");
                        professor.Nome = reader.GetString("nome");
                        professor.Login = reader.GetString("login");
                        professor.Senha = reader.GetString("senha");
                        professores.Add(professor);


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



            return professores;
        }

        
        
    }
}
