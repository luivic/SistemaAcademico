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
    class TurmaDAO
    {
        private Conexao conexao;
        public TurmaDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (conexao)
                MessageBox.Show("Conectou");
            else MessageBox.Show("Não conectou");
        }

        public void abrirTurmas(Turma c)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();

            string sql = "INSERT INTO Turma (identificador, semestre, ano, ativa, codDisciplina, numprof)"  +
                "VALUES" +
                  "(" + c.Identificador + ", " + c.Semestre + ", " + c.Ano + ", " + c.Ativa + ", " + c.Disciplina.Codigo + "," + c.Professor.NumeroP + ")";
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);
        }
        public List<Turma> ConsultarTurma()
        {
            Turma turma = null;
            List<Turma> turmas = new List<Turma>();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Turma", Conexao.getConexao());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        turma = new Turma();

                        turma.Identificador = reader.GetInt32("Identificador");
                        turma.Professor.NumeroP = reader.GetInt32("Professor");
                        turma.Semestre = reader.GetInt32("Semestre");
                        turma.Ano = reader.GetInt32("Ano");
                        turma.Ativa = reader.GetBoolean("Ativa");
                        turma.Disciplina.Codigo = reader.GetInt32("Disciplina");
                        turmas.Add(turma);
                        

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



            return turmas;
        }

    }
}
