using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico_16_05_22.DAO;
using SistemaAcademico_16_05_22.Model;

namespace SistemaAcademico_16_05_22.View
{
    public partial class ProfessorNotaExame : Form
    {
        public ProfessorNotaExame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatriculaDAO dao = new MatriculaDAO();
            List<Matricula> matriculas;

            matriculas = dao.ConsultarMatricula();
            foreach (Matricula matricula in matriculas)
            {
                tblaluno.Rows.Add(matricula.Aluno,matricula.Turma,matricula.Nota1,matricula.Noat2,matricula.Aprovado,matricula.Faltas);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else if (txtvalor.Text.Length > 10)
                MessageBox.Show("A nota não pode ultrapassar 10 ");

            else
            {
                Matricula m = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                m.Exame = Convert.ToInt32(txtvalor.Text);
                MessageBox.Show("Nota de Exame adicionada com sucesso!! ");
            }
        }

        private void tblaluno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
