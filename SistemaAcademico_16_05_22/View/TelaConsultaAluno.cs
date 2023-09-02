using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaAcademico_16_05_22.Model;
using SistemaAcademico_16_05_22.DAO;
using SistemaAcademico_16_05_22.View;

namespace SistemaAcademico_16_05_22.View
{
    public partial class TelaConsultaAluno : Form
    {
        public TelaConsultaAluno()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btncad_Click(object sender, EventArgs e)
        {
            AlunoDAO dao = new AlunoDAO();
            List<Aluno> alunos;

            alunos = dao.ConsultarAluno();
            foreach (Aluno aluno in alunos)
            {
                tblaluno.Rows.Add( aluno.NumeroA, aluno.Curso);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaSecreAluno a = new TelaSecreAluno();
            a.Show();
            this.Hide();
        }

        private void TelaConsultaAluno_Load(object sender, EventArgs e)
        {

        }
    }
}
