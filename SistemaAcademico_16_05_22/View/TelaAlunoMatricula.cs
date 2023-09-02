using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico_16_05_22.View;
using SistemaAcademico_16_05_22.Model;
using SistemaAcademico_16_05_22.DAO;

namespace SistemaAcademico_16_05_22.View
{
    public partial class TelaAlunoMatricula : Form
    {
        public TelaAlunoMatricula()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else
            {
                Matricula m = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                m.Turma.Identificador = Convert.ToInt32(txtid.Text);
                MessageBox.Show("Turma adicionada com Sucesso!! ");
                TelaAlunoMatricula2 m2 = new TelaAlunoMatricula2();
                m2.Show();
                this.Hide();

            }
        }

        private void tblturma_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TurmaDAO dao = new TurmaDAO();
            List<Turma> turma;

            turma = dao.ConsultarTurma(); 
            foreach (Turma turmas in turma)
            {
                tblturma.Rows.Add(turmas.Identificador, turmas.Professor, turmas.Semestre, turmas.Disciplina, turmas.Ano, turmas.Ativa);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
