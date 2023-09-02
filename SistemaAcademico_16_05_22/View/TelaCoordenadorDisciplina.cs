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
    public partial class TelaCoordenadorDisciplina : Form
    {
        public TelaCoordenadorDisciplina()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DisciplinaDAO dao = new DisciplinaDAO();
            List<Disciplina> disciplinas;

            disciplinas = dao.ConsultarDisciplinas();
            foreach (Disciplina disciplina in disciplinas)
            {
                tbldisciplina.Rows.Add(disciplina.Codigo, disciplina.Nome, disciplina.Creditos);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtdis.Text.Equals(""))
                MessageBox.Show("Por favor preecha todos os campos!! ");

            else
            {
                Turma turma = new Turma();
                TurmaDAO dao = new TurmaDAO();
                TelaConsultaProfessor prof = new TelaConsultaProfessor();
                Disciplina d = new Disciplina();

                turma.Disciplina.Codigo = Convert.ToInt32(txtdis.Text);
                dao.abrirTurmas(turma);
                MessageBox.Show("Disciplina adicionada à turma!! ");
                prof.Show();
                this.Hide();



                


               

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCoordenador c = new TelaCoordenador();
            c.Show();
            this.Hide();

        }

        private void txtdis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
