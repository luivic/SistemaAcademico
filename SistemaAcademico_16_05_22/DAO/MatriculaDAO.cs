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
    class MatriculaDAO
    {
        private Conexao conexao;

        public MatriculaDAO()
        {
            bool conexao = Conexao.AbrirConexao();

            if (conexao)
                MessageBox.Show("Conectou");
            else MessageBox.Show("Não conectou");
        }


        public void realizarMatricula(Matricula m)
        {
            MySqlCommand comando = new MySqlCommand();
            comando.Connection = Conexao.getConexao();

            string sql = "INSERT INTO Matricula (numaluno, idTurma, nota1, nota2, exame, faltas, aprovado)" +
                "VALUES" +
                "(" + m.Aluno + ", " + m.Turma + ", " + m.Nota1 + ", " +m.Noat2 + ", " + m.Exame + "," + m.Faltas + "," + m.Aprovado + " ) ";
            comando.CommandText = sql;
            comando.ExecuteNonQuery();
            MessageBox.Show(sql);
        }

        public List <Matricula> ConsultarMatricula()
        {
            Matricula matricula = null;
            List<Matricula> matriculas = new List<Matricula>();

            try
            {
                MySqlCommand comando = new MySqlCommand("SELECT * FROM Matricula", Conexao.getConexao());
                MySqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        matricula = new Matricula();

                        matricula.Aluno.Numero = reader.GetInt32("Aluno");
                        matricula.Nota1 = reader.GetInt32("Nota1");
                        matricula.Noat2 = reader.GetInt32("Nota2");
                        matricula.Turma.Identificador = reader.GetInt32("Turma");
                        matricula.Faltas = reader.GetInt32("Faltas");
                        matricula.Exame = reader.GetInt32("Exame");
                        matricula.Aprovado = reader.GetBoolean("Aprovado");
                        matriculas.Add(matricula);

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

            return matriculas;
        }
    }
    
}
