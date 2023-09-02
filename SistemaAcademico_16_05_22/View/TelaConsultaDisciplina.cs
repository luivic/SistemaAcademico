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
    public partial class TelaConsultaDisciplina : Form
    {
        public TelaConsultaDisciplina()
        {
            InitializeComponent();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            DisciplinaDAO dao = new DisciplinaDAO();
            List<Disciplina> disciplinas;

            disciplinas = dao.ConsultarDisciplinas();
            foreach (Disciplina disciplina in disciplinas)
            {
                tbldisciplina.Rows.Add(disciplina.Codigo, disciplina.Nome, disciplina.Creditos);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaSecreDisciplina d = new TelaSecreDisciplina();
            d.Show();
            this.Hide();
        }

        private void TelaConsultaDisciplina_Load(object sender, EventArgs e)
        {

        }
    }
}
