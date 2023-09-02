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
    public partial class TelaSecreDisciplina : Form
    {
        public TelaSecreDisciplina()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Equals("") ||
                txtnome.Text.Equals("") ||
                txtcreditos.Text.Equals(""))
                MessageBox.Show("Por favor preencha todos os campos !!");
            else
            {
                Disciplina dis = new Disciplina();
                DisciplinaDAO dao = new DisciplinaDAO();

                dis.Codigo = Convert.ToInt32(txtcodigo.Text);
                dis.Nome = txtnome.Text;
                dis.Creditos = Convert.ToInt32(txtcreditos.Text);
                dao.incluirDisciplina(dis);
                MessageBox.Show("Disciplina adicionada com Sucesso!!");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaSecretaria secre = new TelaSecretaria();
            secre.Show();
            this.Hide();
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (txtcodigo.Text.Equals(""))
            {
                MessageBox.Show("Por favor preencha o código da disciplina a ser excluida!!");
            }
            else
            {
                Disciplina dis = new Disciplina();
                DisciplinaDAO dao = new DisciplinaDAO();

                dis.Codigo = Convert.ToInt32(txtcodigo.Text);
                dis.Nome = txtnome.Text;
                dis.Creditos = Convert.ToInt32(txtcreditos.Text);
                dao.excluirDisciplina();
                MessageBox.Show("Disciplina excluida com sucesso!! ");


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaConsultaDisciplina consu = new TelaConsultaDisciplina();
            consu.Show();
            this.Hide();
        }
    }
}
