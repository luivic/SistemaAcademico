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
    class DisciplinaDAO
    {
          private Conexao conexao;

        public DisciplinaDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (conexao)
                MessageBox.Show("Conectou");
            else MessageBox.Show("Não conectou");
        }

        public void incluirDisciplina(Disciplina d)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();

            string sql = "INSERT INTO Disciplina (codigo,nome,creditos) " +
                "VALUES" +
                "(" + d.Codigo + ", '"+ d.Nome + "', " + d.Creditos+ ")";

            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);
        }

        public void excluirDisciplina()
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();
            Disciplina dis = new Disciplina();


            string sql = "DELETE FROM Disciplina WHERE codigo =  " + dis.Codigo ;
            comando.CommandText = sql;
            comando.ExecuteNonQuery();

        }

        public List<Disciplina> ConsultarDisciplinas()
        {
            Disciplina disciplina = null;
             List<Disciplina> disciplinas = new List<Disciplina>();

            try
            {
                MySqlCommand comando= new MySqlCommand("SELECT * FROM Disciplina", Conexao.getConexao());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        disciplina = new Disciplina();

                        disciplina.Codigo = reader.GetInt32("codigo");
                        disciplina.Nome = reader.GetString("nome");
                        disciplina.Creditos = reader.GetInt32("creditos");
                        disciplinas.Add(disciplina);

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

            return disciplinas;
        }
    }
}
