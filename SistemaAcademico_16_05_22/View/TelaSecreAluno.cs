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
    public partial class TelaSecreAluno : Form
    {
        public TelaSecreAluno()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TelaConsultaAluno consu = new TelaConsultaAluno();
            consu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnum.Text.Equals("") ||
                txtnome.Text.Equals("") ||
                txtlogin.Text.Equals("") ||
                txtsenha.Text.Equals("") ||
                txtperfil.Text.Equals("") ||
                txtnuma.Text.Equals("") ||
                txtcurso.Text.Equals(""))
                MessageBox.Show("Por favor, preencha todos os campos!! ");

            else
            {
                Aluno aluno = new Aluno();
                AlunoDAO dao = new AlunoDAO();

                aluno.Numero = Convert.ToInt32(txtnum.Text);
                aluno.Nome = txtnome.Text;
                aluno.Login = txtlogin.Text;
                aluno.Senha = txtsenha.Text;
                aluno.Perfil = txtperfil.Text;
                aluno.NumeroA = Convert.ToInt32(txtnuma.Text);
                dao.incluirAluno(aluno);
                MessageBox.Show("Aluno adicionado com sucesso!! ");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaSecretaria s = new TelaSecretaria();
            s.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtnuma.Text.Equals(""))
                MessageBox.Show("Informe um número de aluno para ser excluido!! ");
            else
            {
                Aluno aluno = new Aluno();
                AlunoDAO dao = new AlunoDAO();

                aluno.Numero = Convert.ToInt32(txtnum.Text);
                aluno.Nome = txtnome.Text;
                aluno.Login = txtlogin.Text;
                aluno.Senha = txtsenha.Text;
                aluno.Perfil = txtperfil.Text;
                aluno.NumeroA = Convert.ToInt32(txtnuma.Text);
                dao.excluirAluno();
            }
        }
    }
}
