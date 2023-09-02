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
    public partial class TelaSecreProfessor : Form
    {
        public TelaSecreProfessor()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text.Equals("") ||
             txtnome.Text.Equals("") ||
             txtlogin.Text.Equals("") ||
             txtsenha.Text.Equals("") ||
             txtperfil.Text.Equals("") ||
             txtnumprof.Text.Equals("") ||
             txttitula.Text.Equals(""))
            {
                MessageBox.Show("Por favor preencha todos os campos ");
            }
            else
            {
                ProfessorDAO dao = new ProfessorDAO();
                Professor prof = new Professor();

                prof.Login = txtlogin.Text;
                prof.Senha = txtsenha.Text;
                prof.Numero = Convert.ToInt32(txtnumero.Text);
                prof.Nome = txtnome.Text;
                prof.Perfil = txtperfil.Text;
                prof.NumeroP = Convert.ToInt32(txtnumprof.Text);
                prof.Titulacao = txttitula.Text;

                dao.incluirProfessor(prof);
                MessageBox.Show("Professor adiconado com sucesso!! ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TelaConsultaProfessor prof = new TelaConsultaProfessor();
            prof.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtnumprof.Text.Equals("") )
          
            {
                MessageBox.Show("Por favor preencha o número do Professo!!");
            }
            else
            {

                ProfessorDAO dao = new ProfessorDAO();
                Professor prof = new Professor();

                prof.Login = txtlogin.Text;
                prof.Senha = txtsenha.Text;
                prof.Numero = Convert.ToInt32(txtnumero.Text);
                prof.Nome = txtnome.Text;
                prof.Perfil = txtperfil.Text;
                prof.NumeroP = Convert.ToInt32(txtnumprof.Text);
                prof.Titulacao = txttitula.Text;
                dao.excluirProfessor();
                MessageBox.Show("Professor excluido com sucesso!! ");

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaSecretaria s = new TelaSecretaria();
            s.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text.Equals("") ||
              txtnome.Text.Equals("") ||
              txtlogin.Text.Equals("") ||
              txtsenha.Text.Equals("") ||
              txtperfil.Text.Equals("") ||
              txtnumprof.Text.Equals("") ||
              txttitula.Text.Equals(""))
            {
                MessageBox.Show("Por favor preencha todos os campos!! ");
            }
            else
            {
                ProfessorDAO dao = new ProfessorDAO();
                Professor prof = new Professor();

                prof.Login = txtlogin.Text;
                prof.Senha = txtsenha.Text;
                prof.Numero = Convert.ToInt32(txtnumero.Text);
                prof.Nome = txtnome.Text;
                prof.Perfil = txtperfil.Text;
                prof.NumeroP = Convert.ToInt32(txtnumprof.Text);
                prof.Titulacao = txttitula.Text;

                MessageBox.Show("Professor alterado com sucesso!! ");
            }
        }
    }
}
