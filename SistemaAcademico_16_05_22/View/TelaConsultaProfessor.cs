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
    public partial class TelaConsultaProfessor : Form
    {
        public TelaConsultaProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProfessorDAO dao = new ProfessorDAO();
            List<Professor> professores;

            professores = dao.ConsultarPorfessor();
            foreach (Professor professor in professores)
            {
                tblprof.Rows.Add(professor.NumeroP, professor.Titulacao, professor.Nome,professor.Login,professor.Senha,professor.Perfil);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaSecreProfessor s = new TelaSecreProfessor();
            s.Show();
            this.Hide();

        }

        private void tblprof_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
