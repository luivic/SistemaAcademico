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
    public partial class TelaCoordenadorProfessor : Form
    {
        public TelaCoordenadorProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            ProfessorDAO dao = new ProfessorDAO();

            List<Professor> professores;
            professores = dao.ConsultarPorfessor();
            foreach (Professor professor in professores)
            {
                tblprof.Rows.Add(professor.Numero, professor.Nome, professor.Login, professor.Senha, professor.Perfil, professor.NumeroP, professor.Titulacao);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtprof.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");
            else
            {
                Turma t = new Turma();
                TurmaDAO dao = new TurmaDAO();
                TelaCoordenadorTurma c = new TelaCoordenadorTurma();

                t.Professor.NumeroP = Convert.ToInt32(txtprof.Text);
                dao.abrirTurmas(t);
                MessageBox.Show("Professor adicionado a turma!! ");
                c.Show();
                this.Hide();


                


            }
        }

        private void tblprof_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCoordenador c = new TelaCoordenador();
            c.Show();
            this.Hide();
        }
    }
}
