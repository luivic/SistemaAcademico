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
using SistemaAcademico_16_05_22.View;

namespace SistemaAcademico_16_05_22.View
{
    public partial class ProfessorNota1 : Form
    {
        public ProfessorNota1()
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
                tblaluno.Rows.Add(matricula.Aluno, matricula.Turma, matricula.Noat2,matricula.Exame,matricula.Aprovado,matricula.Faltas );
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtvalor.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else if (txtvalor.Text.Length > 10)
                MessageBox.Show("O número não poder ser maior que 10");
            else
            {
                Matricula m = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                m.Nota1 = Convert.ToInt32(txtvalor.Text);
                dao.realizarMatricula(m);
                MessageBox.Show("Nota1 adicionado com sucesso!!");
            }
        }
    }
}
