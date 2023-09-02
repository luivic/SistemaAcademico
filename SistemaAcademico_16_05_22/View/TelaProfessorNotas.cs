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
    public partial class TelaProfessorNotas : Form
    {
        public TelaProfessorNotas()
        {
            InitializeComponent();
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtid.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else
            {
                Matricula m = new Matricula();
                MatriculaDAO dao = new MatriculaDAO();

                m.Turma.Identificador = Convert.ToInt32(txtid.Text);
                dao.realizarMatricula(m);
                MessageBox.Show("Turma adicionada com sucesso!! ");

                


            }
           
            
            

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaProfessor prof = new TelaProfessor();
            prof.Show();
            this.Hide();
        }
    }
}
